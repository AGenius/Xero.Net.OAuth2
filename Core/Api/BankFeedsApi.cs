﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xero.Net.Core.Api
{
    /// <summary>
    /// Collection of wrapper functions to interact with the BankFeeds API endpoints
    /// </summary>
    public class BankFeedsApi : Xero.Net.Api.Api.BankFeedsApi, ICoreAPI
    {
        Xero.Net.Api.Api.BankFeedsApi APIClient;
        internal API APICore { get; set; }
        /// <summary>
        /// Return the Rate Limit info collected on last call
        /// </summary>
        public Xero.Net.Api.Model.RateLimitInfo RateInfo
        {
            get
            {
                return APIClient.AsynchronousClient.RateInfo;
            }
        }
        /// <summary>
        /// Throw errors for Items not found
        /// </summary>
        public bool? RaiseNotFoundErrors { get; set; }
        /// <summary>
        /// Default 'ctor
        /// </summary>
        public BankFeedsApi()
        {      
            APIClient = new Xero.Net.Api.Api.BankFeedsApi();
        }
        /// <summary>
        /// 'ctor - pass Parent API class
        /// </summary>
        /// <param name="parentAPI">ref to the parent API object</param>
        public BankFeedsApi(API parentAPI)
        {
            this.APICore = parentAPI;
            Xero.Net.Api.Client.Configuration confg = new Net.Api.Client.Configuration();
            confg.UserAgent = "Xero.Net.Api-" + APICore.APIVersion;
            APIClient = new Xero.Net.Api.Api.BankFeedsApi(confg);
        }
    }
}
