using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xero.Net.Api.Model
{
    /// <summary>
    /// Returned Rate Limit Information
    /// </summary>
    public class RateLimitInfo
    {
        /// <summary>
        /// App Minute Limit: 10,000 calls per minute for the Connected App (ClientID)
        /// </summary>
        public int AppMinuteLimitRemaining { get; set; }
        /// <summary>
        /// Daily Limit: 5000 calls per day
        /// </summary>
        public int DayLimitRemaining { get; set; }
        /// <summary>
        /// Minute Limit: 60 calls per minute
        /// </summary>
        public int MinuteLimitRemaining { get; set; }
        /// <summary>
        /// DateTime stamp of when this information was last updated
        /// </summary>
        public DateTime WhenUpdated { get; set; }
        /// <summary>
        /// If you have exceed the minute or daily limit, this will have how many seconds to wait before making another request. 
        /// It is important to use the Retry-After to know when you can start making calls again.
        /// </summary>
        public int RetryAfter { get; set; }
    }
}
