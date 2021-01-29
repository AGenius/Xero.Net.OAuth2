using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xero.Net.Core.Api
{
    /// <summary>
    /// API Core Interface 
    /// </summary>
    public interface ICoreAPI
    {
        /// <summary>
        /// Suppress errors in some places where no data is found
        /// </summary>
        bool? RaiseNotFoundErrors { get; set; }
        /// <summary>
        /// Return the Rate Limit info collected on last call
        /// </summary>
        Xero.Net.Api.Model.RateLimitInfo RateInfo { get; }
    }
}
