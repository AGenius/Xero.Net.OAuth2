﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using System.IO;

namespace Xero.Net.Core.OAuth2.Model
{
    /// <summary>
    /// The Configuration object that holds all the magic info needed!
    /// </summary>
    public class XeroConfiguration
    {
        /// <summary>
        /// default ctor
        /// </summary>
        public XeroConfiguration() { }
        /// <summary>
        /// Provide ability to create the config from a loaded Json string
        /// </summary>
        /// <param name="jsonStringOrFilePath">The string containing the Configuration record or a valid file path to a saved Configuration </param>
        /// <returns>XeroConfiguration object <see cref="XeroConfiguration"/></returns>        
        public XeroConfiguration(string jsonStringOrFilePath)
        {
            try
            {
                if (System.IO.File.Exists(jsonStringOrFilePath))
                {
                    // Thi parameter passed is a valid file so load it and Deserialize
                    string content = Common.ReadTextFile(jsonStringOrFilePath);
                    XeroConfiguration newConfig = Common.DeSerializeObject<XeroConfiguration>(content);
                    Clone(newConfig);
                }
                else
                {
                    XeroConfiguration newConfig = Common.DeSerializeObject<XeroConfiguration>(jsonStringOrFilePath);
                    Clone(newConfig);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Serialize the Config to a json string
        /// </summary>
        /// <returns></returns>
        public string ToJson()
        {
            return Common.SerializeObject(this);
        }
        /// <summary>
        /// Save the Config to a file as a json string
        /// </summary>
        public string SaveToFile(string filePath, bool CreateFolders = false)
        {
            try
            {
                string content = Common.SerializeObject(this);
                string path = Path.GetPathRoot(filePath);

                if (!string.IsNullOrEmpty(path))
                {
                    if (!Directory.Exists(path))
                    {
                        if (CreateFolders)
                        {
                            Directory.CreateDirectory(path);
                        }
                        else
                        {
                            return null;
                        }
                    }                   
                }

                return Common.WriteTextFile(filePath, content);
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// Holds the Returned Access Code from the Authentication step that the AccessToken exchange needs
        /// </summary>
        public string ReturnedAccessCode { get; set; }
        /// <summary>
        /// Holds the Returned state value provided when Authenticating. this should match the State sctring provided
        /// Not needed for local desktop application
        /// </summary>
        public string ReturnedState { get; set; }
        /// <summary>
        /// Holds the Live AccessToken returned from the Auth process
        /// </summary>
        [JsonProperty]
        public XeroTokenSet AccessTokenSet { get; internal set; }
        /// <summary>
        /// The random generated code verification hash
        /// </summary>
        public string codeVerifier { get; set; }
        /// <summary>
        /// Issued when you create your Zero app
        /// </summary>
        public string ClientID { get; set; }
        /// <summary>
        /// The URL on your server to redirect back to - should be http://localhost:port/name
        /// where "port" is any valid port e.g. 8888 and "name" is something like "callback" - http://localhost:8888/callback
        /// </summary>
        public Uri CallbackUri { get; set; }
        private List<XeroScope> _scopes { get; set; } // Hold the list
        /// <summary>
        /// List of Scopes the API would like to use
        /// If a call to any API method does not have the required scope at time of authentication
        /// an APIAception will be thrown
        /// </summary>
        public List<XeroScope> Scopes
        {
            get
            {
                if (_scopes == null)
                {
                    _scopes = new List<XeroScope>();
                }

                return _scopes;
            }
            set
            {
                _scopes = value;
                if (_scopes != null && _scopes.Count == 0)
                {
                    if (!_scopes.Contains(XeroScope.openid))
                    {
                        AddScope(XeroScope.openid); // Ensure its in there
                    }
                    if (!_scopes.Contains(XeroScope.profile))
                    {
                        AddScope(XeroScope.profile); // Ensure its in there
                    }
                    if (!_scopes.Contains(XeroScope.offline_access))
                    {
                        AddScope(XeroScope.offline_access); // Ensure its in there                   
                    }
                }
            }
        }
        /// <summary>
        /// Add a scope to the required scopes when authenticating
        /// </summary>
        /// <param name="scope">The Scope to add <see cref="XeroScope"/></param>
        /// <param name="reset">Force a reset of the Scopes List</param>
        public void AddScope(XeroScope scope, bool reset = false)
        {
            if (reset)
            {
                Scopes = new List<XeroScope>(); // Reset the list as requested
            }
            switch (scope)
            {
                case XeroScope.all:
                    foreach (XeroScope item in (XeroScope[])Enum.GetValues(typeof(XeroScope)))
                    {
                        string name = Enum.GetName(typeof(XeroScope), item);
                        if (!name.EndsWith("_read") && !name.Contains("all"))
                        {
                            AddScope(item);
                        }
                    }
                    break;
                case XeroScope.all_read:
                    foreach (XeroScope item in (XeroScope[])Enum.GetValues(typeof(XeroScope)))
                    {
                        string name = Enum.GetName(typeof(XeroScope), item);
                        if (item != XeroScope.all_read && name.EndsWith("_read") && !name.Contains("all"))
                        {
                            AddScope(item);
                        }
                    }
                    break;

                case XeroScope.accounting_all:

                    foreach (XeroScope item in (XeroScope[])Enum.GetValues(typeof(XeroScope)))
                    {
                        string name = Enum.GetName(typeof(XeroScope), item);
                        if (name.StartsWith("accounting") && !name.EndsWith("_read") && !name.Contains("all"))
                        {
                            AddScope(item);
                        }
                    }
                    break;
                case XeroScope.accounting_all_read:
                    foreach (XeroScope item in (XeroScope[])Enum.GetValues(typeof(XeroScope)))
                    {
                        string name = Enum.GetName(typeof(XeroScope), item);
                        if (name.StartsWith("accounting") && name.EndsWith("_read") && !name.Contains("all"))
                        {
                            AddScope(item);
                        }
                    }
                    break;



                default:
                    // Add any not already in list
                    if (!Scopes.Contains(scope))
                    {
                        _scopes.Add(scope);
                    }
                    break;
            }


        }
        /// <summary>
        /// String representation of the list of scopes selected
        /// </summary>
        public string Scope
        {
            get
            {
                if (!_scopes.Contains(XeroScope.openid))
                {
                    AddScope(XeroScope.openid); // Ensure its in there
                }
                if (!_scopes.Contains(XeroScope.profile))
                {
                    AddScope(XeroScope.profile); // Ensure its in there
                }
                if (!_scopes.Contains(XeroScope.offline_access))
                {
                    AddScope(XeroScope.offline_access); // Ensure its in there                   
                }

                string scopelist = string.Empty;
                // Always sort the list of scopes in Alphabetical order to ensure match when testing for changes
                foreach (var item in Scopes.OrderBy(x => x.ToString()))
                {
                    // Must be a named Enum (fixes any added enums that where then removed (bankfeeds test)
                    if (!int.TryParse(item.ToString(), out int num))
                    {
                        if (!string.IsNullOrEmpty(scopelist))
                        {
                            scopelist += " ";
                        }
                        if (item == XeroScope.offline_access)
                        {
                            scopelist += item.ToString();
                        }
                        else
                        {
                            scopelist += item.ToString().Replace("_", ".");
                        }
                    }
                }

                return scopelist;
            }

        }

        /// <summary>
        /// a unique string to be passed back on completion (optional) 
        /// The state parameter should be used to avoid forgery attacks. Pass in a value that's unique to the user you're sending through authorisation. It will be passed back after the user completes authorisation.
        /// Generally not required for a Desktop application
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Returns the URL to authenticate with Xero
        /// </summary>
        public string AuthURL
        {
            get
            {
                if (!string.IsNullOrEmpty(codeVerifier))
                {
                    string codeChallenge;
                    using (var sha256 = SHA256.Create())
                    {
                        var challengeBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(codeVerifier));
                        codeChallenge = Convert.ToBase64String(challengeBytes)
                            .TrimEnd('=')
                            .Replace('+', '-')
                            .Replace('/', '_');
                    }
                    string url = $"{XeroConstants.XERO_AUTH_URL}response_type=code&client_id={ClientID}&redirect_uri={CallbackUri.AbsoluteUri}&scope={Scope.Replace(" ", "%20")}&code_challenge={codeChallenge}&code_challenge_method=S256";
                    if (!string.IsNullOrEmpty(State))
                    {
                        return $"{url}&state={State}";
                    }

                    return url;

                }
                return string.Empty;
            }
        }

        /// <summary>
        /// If provided, the API setup will try and match the name with the correct tenant otherwise the first tenant will be selected
        /// </summary>
        public string SelectedTenantName
        {
            get
            {
                if (SelectedTenant != null)
                {
                    return SelectedTenant.TenantName;
                }
                return null;
            }
        }
        /// <summary>
        /// The Tenant ID used for API calls
        /// </summary>
        public string SelectedTenantID
        {
            get
            {
                if (SelectedTenant != null)
                {
                    return SelectedTenant.TenantId.ToString();
                }
                return null;
            }
        }
        /// <summary>
        /// The Selected Tenant record
        /// </summary>
        public Tenant SelectedTenant { get; set; }
        /// <summary>
        /// Choose to store the Received scope list and sync it with the internal list
        /// </summary>
        public bool StoreReceivedScope { get; set; }
        /// <summary>
        /// Auto select will ensure the first tenant is the selected tenant
        /// Useful for single tenant connections
        /// </summary>
        public bool? AutoSelectTenant { get; set; }
        private string _AccessGrantedHTML { get; set; }
        /// <summary>
        /// Override the default Access Granted message
        /// </summary>
        public string AccessGrantedHTML
        {
            get
            {
                if (_AccessGrantedHTML == null)
                {
                    _AccessGrantedHTML = XeroConstants.XERO_AUTH_ACCESS_GRANTED_HTML;
                }
                return _AccessGrantedHTML;
            }
            set
            {
                _AccessGrantedHTML = value;
            }
        }
        private string _AccessDeniedHTML { get; set; }
        /// <summary>
        /// Override the default Access Denied message
        /// </summary>
        public string AccessDeniedHTML
        {
            get
            {
                if (_AccessDeniedHTML == null)
                {
                    _AccessDeniedHTML = XeroConstants.XERO_AUTH_ACCESS_DENIED_HTML;
                }
                return _AccessDeniedHTML;
            }
            set
            {
                _AccessDeniedHTML = value;
            }
        }

        void Clone(XeroConfiguration configObj)
        {
            this.AccessDeniedHTML = configObj.AccessDeniedHTML;
            this.AccessGrantedHTML = configObj.AccessGrantedHTML;
            this.AccessTokenSet = configObj.AccessTokenSet;
            this.AutoSelectTenant = configObj.AutoSelectTenant;
            this.CallbackUri = configObj.CallbackUri;
            this.ClientID = configObj.ClientID;
            this.codeVerifier = configObj.codeVerifier;
            this.ReturnedAccessCode = configObj.ReturnedAccessCode;
            this.ReturnedState = configObj.ReturnedState;
            this.Scopes = configObj.Scopes;
            this.SelectedTenant = configObj.SelectedTenant;
            this.State = configObj.State;
            this.StoreReceivedScope = configObj.StoreReceivedScope;

        }
    }
}
