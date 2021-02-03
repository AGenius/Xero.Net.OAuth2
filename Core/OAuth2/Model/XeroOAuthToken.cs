using System;
using System.Collections.Generic;

namespace Xero.Net.Core.OAuth2.Model
{
    /// <summary>
    /// Hold the Auth token
    /// </summary>
    public class XeroTokenSet
    {
        /// <summary>
        /// List of authorised tenants
        /// </summary>
        public List<Tenant> Tenants { get; set; }
        /// <summary>
        /// The AccessToken used for API calls
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// The Refresh token required to refresh the AccessToken
        /// </summary>
        public string RefreshToken { get; set; }
        /// <summary>
        /// User ID
        /// </summary>
        public string IdToken { get; set; }
        /// <summary>
        /// When the Access Token will expire
        /// </summary>
        public DateTime ExpiresAtUtc { get; set; }
        /// <summary>
        /// Record the Scope used. If the scope is changed on a refresh then force a re-authentication
        /// </summary>
        public string RequestedScopes { get; set; }
        /// <summary>
        /// JWT Decoded object holding the Access Token record
        /// </summary>
        public JWTAccessToken AccessTokenRecord { get; set; }
        /// <summary>
        /// JWT Decoded object holding the ID Token record
        /// </summary>
        public JWTIDToken IDTokenRecord { get; set; }

    }
}
