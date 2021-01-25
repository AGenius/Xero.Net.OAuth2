using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xero.Net.Core.Api
{
    /// <summary>
    /// Collection of wrapper functions to interact with the Project API endpoints
    /// </summary>
    public class PayrolAU
    {
        Xero.Net.Api.Api.ProjectApi APIClient = new Xero.Net.Api.Api.ProjectApi();
        internal API APICore { get; set; }
   
    }
}
