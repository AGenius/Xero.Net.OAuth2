using System;
using System.Collections.Generic;

namespace Xero.Net.Core.OAuth2.Model
{
    /// <summary>
    /// Holds the Decoded AccessToken JWT set
    /// </summary>
    public class JWTAccessToken
    {
        public string nbf { get; set; }
        public string exp { get; set; }
        public string iss { get; set; }
        public string aud { get; set; }
        public string client_id { get; set; }
        public string sub { get; set; }
        public string auth_time { get; set; }
        public Guid? xero_userid { get; set; }
        public string global_session_id { get; set; }
        public string jti { get; set; }
        public Guid authentication_event_id { get; set; }
        public List<string> scope { get; set; }
    }
}
