using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xero.Net.Core.Api
{
    /// <summary>
    /// Collection of wrapper functions to interact with the BankFeeds API endpoints
    /// </summary>
    public class BankFeeds
    {
        Xero.Net.Api.Api.BankFeedsApi APIClient = new Xero.Net.Api.Api.BankFeedsApi();
        internal API APICore { get; set; }
 
    }
}
