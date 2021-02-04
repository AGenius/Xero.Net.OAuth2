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
        public long nbf { get; set; }
        public DateTime? nbf_DateTime
        {
            get
            {
                return Common.DateTimeFromUnixTime(nbf);
            }
        }
        public long exp { get; set; }
        public DateTime exp_DateTime
        {
            get
            {
                return Common.DateTimeFromUnixTime(exp);
            }
        }
        public string iss { get; set; }
        public string aud { get; set; }
        public long iat { get; set; }
        public string at_hash { get; set; }
        public string sub { get; set; }
        public long auth_time { get; set; }
        public DateTime auth_time_DateTime
        {
            get
            {
                return Common.DateTimeFromUnixTime(auth_time);
            }
        }
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
