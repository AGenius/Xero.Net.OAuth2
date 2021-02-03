using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Xero.Net.Core.OAuth2.Model
{
    /// <summary>
    /// Holds the Decoded IdToken JWT set
    /// </summary>
    public class JWTIDToken
    {
        public string nbf { get; set; }
        public string exp { get; set; }
        public string iss { get; set; }
        public string aud { get; set; }
        public string iat { get; set; }
        public string at_hash { get; set; }
        public string sub { get; set; }
        public string auth_time { get; set; }
        /// <summary>
        /// The Xero User ID
        /// </summary>
        public Guid? xero_userid { get; set; }
        /// <summary>
        /// Global Session ID
        /// </summary>
        public string global_session_id { get; set; }
        /// <summary>
        /// The Xero Username used
        /// </summary>
        [JsonProperty("preferred_username")]
        public string Username { get; set; }
        /// <summary>
        /// The users Email Address
        /// </summary>
        [JsonProperty("Email")]
        public string EmailAddress { get; set; }
        /// <summary>
        /// The users First Name
        /// </summary>
        [JsonProperty("given_name")]
        public string FirstName { get; set; }
        /// <summary>
        /// The users Surname
        /// </summary>
        [JsonProperty("family_name")]
        public string Surname { get; set; }
    }
}
