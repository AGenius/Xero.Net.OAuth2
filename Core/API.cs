﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Xero.Net.Core.OAuth2.Model;

namespace Xero.Net.Core
{
    /// <summary>
    /// This is the Core of the API Wrapper. this class holds the configurations, the sub Api endpoints and events
    /// </summary>
    public class API
    {
        /// <summary>
        /// The API Wrapper version
        /// </summary>
        public string Version
        {
            get
            {
                return "This API Version : 1.2021.0129 - Compatible with Xero-Standard API : 3.13.0";
            }
        }
        oAuth2 _authClient = null;
        
        /// <summary>
        /// The Configuration object that holds all the magic info needed!
        /// </summary>
        public XeroConfiguration XeroConfig { get; set; }
        /// <summary>
        /// When the API is initialized and the Token is refreshed or the API is authenticated 
        /// this will be set to true.
        /// Use this property to determine if the auth/refresh is all ok
        /// </summary>
        public bool isConnected { get; set; }
        /// <summary>
        /// If provided, the API setup will try and match the name with the correct tenant otherwise the first tenant will be selected
        /// </summary>
        public string TenantName
        {
            get
            {
                if (XeroConfig != null)
                {
                    return XeroConfig.SelectedTenantName;
                }
                return null;
            }
        }
        /// <summary>
        /// Provides access to the available tenants authorized
        /// </summary>
        public List<Tenant> Tenants
        {
            get
            {
                if (XeroConfig != null && XeroConfig.XeroAPIToken != null)
                {
                    return XeroConfig.XeroAPIToken.Tenants;
                }
                return null;
            }
        }

        /// <summary>
        /// Provide access to the currently selected Tenant , selected by TenantID
        /// </summary>
        public Tenant SelectedTenant
        {
            get
            {
                return XeroConfig.SelectedTenant;
            }
            set
            {
                XeroConfig.SelectedTenant = value;
            }
        }



        // Setup the sub API objects
        internal Api.AccountingApi AccountingApi = new Api.AccountingApi();
        internal Api.AssetApi AssetApi = new Api.AssetApi();
        internal Api.ProjectApi ProjectApi = new Api.ProjectApi();


        #region Event
        /// <summary>
        /// Loggin message Event
        /// </summary>
        public class LogMessage
        {
            public string MessageText { get; set; }
            public XeroEventStatus Status { get; set; }
        }
        public event EventHandler<StatusEventArgs> StatusUpdates;
        public class StatusEventArgs : EventArgs
        {
            public string MessageText { get; set; }
            public XeroEventStatus Status { get; set; }
        }
        /// <summary>Fire the Status update Event</summary>
        internal void onStatusUpdates(string message, XeroEventStatus status)
        {
            StatusEventArgs args = new StatusEventArgs() { MessageText = message, Status = status };
            StatusUpdates.SafeInvoke(this, args);
        }

        #endregion
        /// <summary>Default constructor, will setup the defaults required.</summary>
        public API()
        {
            _authClient = new oAuth2();
            _authClient.ParentAPI = this;
            // Setup the reference to the core wrapper
            AccountingApi.APICore = this;
            AssetApi.APICore = this;
            ProjectApi.APICore = this;
            isConnected = false;

        }
        /// <summary>Instantiate the API with a Configuration record already setup</summary>
        /// <param name="config">The configuration record to use <see cref="XeroConfiguration"/></param>
        public API(XeroConfiguration config = null)
        {
            if (config == null)
            {
                throw new ArgumentNullException("Missing XeroConfig");
            }
            if (config != null)
            {
                XeroConfig = config;
            }
            if (XeroConfig.AutoSelectTenant == null)
            {
                XeroConfig.AutoSelectTenant = true;
            }
            if (XeroConfig.codeVerifier == null)
            {
                XeroConfig.codeVerifier = GenerateCodeVerifier();
            }
            _authClient = new oAuth2();
            _authClient.ParentAPI = this;
            _authClient.XeroConfig = XeroConfig;
            // Setup the reference to the core wrapper
            AccountingApi.APICore = this;
            AssetApi.APICore = this;
            ProjectApi.APICore = this;
            isConnected = false;

        }
        /// <summary>
        /// Setup the API and refresh token or re-authorise if needed/requested
        /// </summary>
        /// <param name="timeout">set a timeout to wait for authentication (default is 60 seconds)</param>
        /// <param name="ForceReAuth">This will force the Auth login again-Needed if you want to add a new tenant</param>
        /// <exception cref="TimeoutException">If the Auth process times out an exception will be raised.</exception>
        public void InitializeAPI(int? timeout = 60, bool ForceReAuth = false)
        {
            isConnected = false;
            if (timeout == null)
            {
                // Ensure if null passed then default to 60 seconds
                timeout = 60;
            }
            if (XeroConfig == null)
            {
                throw new ArgumentNullException("Missing XeroConfig");
            }
            _authClient.XeroConfig = XeroConfig; // Always ensure the auth client has the XeroConfig             
            try
            {
                var task = Task.Run(() => _authClient.InitializeoAuth2(timeout, ForceReAuth));
                task.Wait();
                if (_authClient.HasTimedout)
                {
                    onStatusUpdates("Timed Out Waiting for Authentication", XeroEventStatus.Timeout);
                    throw new TimeoutException("Timed Out Waiting for Authentication");
                }
                onStatusUpdates("Checking Token", XeroEventStatus.Success);

                if (XeroConfig.SelectedTenant == null)
                {
                    if ((XeroConfig.AutoSelectTenant.HasValue && XeroConfig.AutoSelectTenant.Value == true) || !XeroConfig.AutoSelectTenant.HasValue)
                    {
                        XeroConfig.SelectedTenant = XeroConfig.XeroAPIToken.Tenants[0];
                    }
                }
                onStatusUpdates("Ready", XeroEventStatus.Success);
                isConnected = true;
            }
            catch (Exception ex)
            {
                var er = ex.InnerException as Xero.Net.Api.Client.ApiException;
                if (er != null)
                {
                    throw new Xero.Net.Api.Client.ApiException(er.ErrorCode, er.Message, er.ErrorContent);
                }
                if (er == null && ex.InnerException != null)
                {
                    throw new Exception(ex.InnerException.Message);
                }
                throw;
            }
        }
        /// <summary>
        /// Revoke the Access Token to invalidate the token used 
        /// </summary>
        public void RevokeAuth()
        {
            _authClient.RevokeToken();
        }
        private string GenerateCodeVerifier()
        {
            //Generate a random string for our code verifier
            var rng = RandomNumberGenerator.Create();
            var bytes = new byte[32];
            rng.GetBytes(bytes);

            var codeVerifier = Convert.ToBase64String(bytes)
                .TrimEnd('=')
                .Replace('+', '-')
                .Replace('/', '_');
            return codeVerifier;
        }

    }
}
