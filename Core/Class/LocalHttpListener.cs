﻿using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Xero.Net.Core.OAuth2.Model;


namespace Xero.Net.Core
{
    /// <summary>
    /// thanks for code found at http://www.gabescode.com/dotnet/2018/11/01/basic-HttpListener-web-service.html 
    /// </summary>
    class LocalHttpListener
    {
        public Uri CallBackUri { get; set; } // The Call Back Uri - the port and path will be extracted 

        private HttpListener Listener = null; // Holder for the main listener

        private bool _keepGoing = true; //A flag to specify when we need to stop

        private System.Threading.Tasks.Task _mainLoop; //Keep the task in a variable to keep it alive
        public XeroConfiguration config { get; set; } // Hold the configuration object 
        
        #region Event
        public class LocalHttpListenerEventArgs : EventArgs
        {
            public string MessageText { get; set; }
        }
        public virtual void OnMessageReceived(LocalHttpListenerEventArgs e)
        {
            EventHandler<LocalHttpListenerEventArgs> handler = Message;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<LocalHttpListenerEventArgs> Message;

        #endregion
        /// <summary>
        /// Call this to start the listener
        /// </summary>
        public void StartWebServer()
        {
            if (_mainLoop != null && !_mainLoop.IsCompleted) return; //Already started
            {
                _mainLoop = MainLoop();
            }
        }
        /// <summary>
        /// Call this to stop the listener. It will not kill any requests currently being processed.
        /// </summary>
        public void StopWebServer()
        {
            _keepGoing = false;
            lock (Listener)
            {
                //Use a lock so we don't kill a request that's currently being processed
                Listener.Stop();
            }
            try
            {
                _mainLoop.Wait();
            }
            catch { }
        }
        /// <summary>
        /// The main loop to handle requests into the Listener
        /// </summary>        
        private async System.Threading.Tasks.Task MainLoop()
        {
            // Prefixes = { $"http://localhost:{Port}/" } };

            Listener = new HttpListener { Prefixes = { $"{CallBackUri.GetComponents(UriComponents.SchemeAndServer, UriFormat.UriEscaped)}/" } };

            Listener.Start();

            while (_keepGoing)
            {
                try
                {
                    //GetContextAsync() returns when a new request comes in
                    var context = await Listener.GetContextAsync();
                    lock (Listener)
                    {
                        if (_keepGoing) ProcessRequest(context);
                    }
                }
                catch (Exception e)
                {
                    //this gets thrown when the listener is stopped
                    if (e is HttpListenerException)
                    {
                        return;
                    }

                    //TODO: Log the exception
                }
            }
        }
        /// <summary>
        /// Handle an incoming request
        /// </summary>        
        /// <param name="context">The context of the incoming request</param>
        private void ProcessRequest(HttpListenerContext context)
        {
            using (var response = context.Response)
            {
                try
                {
                    var handled = false;

                    if (context.Request.Url.AbsolutePath == CallBackUri.GetComponents(UriComponents.PathAndQuery, UriFormat.UriEscaped))
                    {
                        handled = HandleCallbackRequest(context, response);
                    }

                    if (!handled)
                    {
                        response.StatusCode = 404;
                    }
                }
                catch (Exception e)
                {
                    //Return the exception details the client - you may or may not want to do this
                    response.StatusCode = 500;
                    response.ContentType = "application/json";

                    var buffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(e));
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);

                    //TODO: Log the exception
                }
            }
        }
        /// <summary>
        /// Handle the returned date and extract the code
        /// </summary>
        /// <param name="context"></param>        
        /// <param name="response"></param>
        /// <returns>true/false</returns>
        private bool HandleCallbackRequest(HttpListenerContext context, HttpListenerResponse response)
        {
            response.ContentType = "text/html";

            //Write it to the response stream
            var query = context.Request.Url.Query;
            var code = "";
            var state = "";

            // Deal with access denied/cancel
            if (query.Contains("error"))
            {
                var buffer = Encoding.UTF8.GetBytes(config.AccessDeniedHTML);
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                // Raise the event so the oAuth2 class can process the receipt of the 
                LocalHttpListenerEventArgs args = new LocalHttpListenerEventArgs() { MessageText = XeroConstants.XERO_AUTH_ACCESS_DENIED };
                OnMessageReceived(args);
                config.ReturnedAccessCode = XeroConstants.XERO_AUTH_ACCESS_DENIED;// Asigning this will stop the wait timeout loop
            }
            else
            {
                if (query.Contains("?"))
                {
                    // Break down the query string by the ? 
                    query = query.Substring(query.IndexOf('?') + 1);
                }

                foreach (var vp in Regex.Split(query, "&"))
                {
                    var singlePair = Regex.Split(vp, "=");

                    if (singlePair.Length == 2)
                    {
                        if (singlePair[0] == "code")
                        {
                            code = singlePair[1];
                            config.ReturnedAccessCode = code; // Asigning this will stop the wait timeout loop
                        }

                        if (singlePair[0] == "state")
                        {
                            state = singlePair[1];
                            config.ReturnedState = state;
                        }
                    }
                }

                var buffer = Encoding.UTF8.GetBytes(config.AccessGrantedHTML);
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                // Raise the event so the oAuth2 class can process the receipt of the 
                LocalHttpListenerEventArgs args = new LocalHttpListenerEventArgs() { MessageText = XeroConstants.XERO_AUTH_ACCESS_GRANTED };
                OnMessageReceived(args);

                return true;
            }
            return false;
        }
    }
}