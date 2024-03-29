﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xero.Net.Api.Model.Asset;

namespace Xero.Net.Core.Api
{
    /// <summary>
    /// Collection of wrapper functions to interact with the Asset API endpoints
    /// </summary>
    public class AssetApi : Xero.Net.Api.Api.AssetApi, ICoreAPI
    {
        Xero.Net.Api.Api.AssetApi APIClient;
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
        public AssetApi()
        {          
            APIClient = new Xero.Net.Api.Api.AssetApi();
        }
        /// <summary>
        /// 'ctor - pass Parent API class
        /// </summary>
        /// <param name="parentAPI">ref to the parent API object</param>
        public AssetApi(API parentAPI)
        {
            this.APICore = parentAPI;
            Xero.Net.Api.Client.Configuration confg = new Net.Api.Client.Configuration();
            confg.UserAgent = "Xero.Net.Api-" + APICore.APIVersion;
            APIClient = new Xero.Net.Api.Api.AssetApi(confg);
        }
        #region Assets
        /// <summary>
        /// Return a list of fixed assets
        /// </summary>
        /// <param name="status">Required when retrieving a collection of assets. See Asset Status Codes</param>
        /// <param name="onlypage">Up to 100 records will be returned in a single API call with line items details (optional)</param>
        /// <param name="orderBy">Requests can be ordered by AssetType, AssetName, AssetNumber, PurchaseDate and PurchasePrice. If the asset status is DISPOSED it also allows DisposalDate and DisposalPrice. (optional)</param>
        /// <param name="sortDirection">ASC or DESC (optional)</param>
        /// <param name="filterBy">A string that can be used to filter the list to only return assets containing the text. Checks it against the AssetName, AssetNumber, Description and AssetTypeName fields. (optional)</param>
        /// <param name="pageSize">The number of records returned per page. By default the number of records returned is 10. (optional)</param>
        /// <returns>List of Assets</returns>
        public List<Asset> Assets(AssetStatusQueryParam status, int? onlypage = null,
            string orderBy = null, string sortDirection = null, string filterBy = null, int pageSize = 50)
        {
            int? page = 1;
            if (onlypage.HasValue)
            {
                page = onlypage.Value;
            }
            try
            {
                var records = new List<Asset>(); // Hold the records
                int count = pageSize; // This is how many per page - setting this will ensure we check for the first page is a full 100 and loop until all returned  
                while (count == pageSize)
                {
                    if (page == -1) page = null; // This allows a quick first page of records
                    var results = Task.Run(() => APIClient.GetAssetsAsync(APICore.XeroConfig.AccessTokenSet.AccessToken, APICore.XeroConfig.SelectedTenantID, status, page, pageSize, orderBy, sortDirection, filterBy)).ConfigureAwait(false).GetAwaiter().GetResult(); ;
                    if (results != null && results.Items != null && results.Items.Count > 0)
                    {
                        records.AddRange(results.Items); // Add the next page records returned
                        count = results.Items.Count; // Record the number of records returned in this page. if less than 100 then the loop will exit otherwise get the next page full
                    }
                    else
                    {
                        count = 0;
                    }
                    if (page != null) page++;
                    if (onlypage.HasValue) count = -1;
                }

                if (records != null && records.Count > 0)
                {
                    return records;
                }
            }
            catch (Exception ex)
            {
                var er = ex.InnerException as Xero.Net.Api.Client.ApiException;
                if (er != null)
                {
                    throw new Xero.Net.Api.Client.ApiException(er.ErrorCode, er.Message, er.ErrorContent);
                }                
            }

            return null;
        }
        public List<AssetType> AssetTypes()
        {
            try
            {
                var results = Task.Run(() => APIClient.GetAssetTypesAsync(APICore.XeroConfig.AccessTokenSet.AccessToken, APICore.XeroConfig.SelectedTenantID)).ConfigureAwait(false).GetAwaiter().GetResult(); ;

                if (results != null && results.Count > 0)
                {
                    return results;
                }
            }
            catch (Exception ex)
            {
                var er = ex.InnerException as Xero.Net.Api.Client.ApiException;
                if (er != null)
                {
                    throw new Xero.Net.Api.Client.ApiException(er.ErrorCode, er.Message, er.ErrorContent);
                }                
            }
            return null;
        }
        #endregion

    }
}
