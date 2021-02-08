/* 
 * Xero Bank Feeds API
 *
 * The Bank Feeds API is a closed API that is only available to financial institutions that have an established financial services partnership with Xero. If you're an existing financial services partner that wants access, contact your local Partner Manager. If you're a financial institution who wants to provide bank feeds to your business customers, contact us to become a financial services partner.
 *
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.Net.Api.Client.OpenAPIDateConverter;

namespace Xero.Net.Api.Model.Bankfeeds
{
    /// <summary>
    /// Pagination
    /// </summary>
    [DataContract]
    public partial class Pagination :  IEquatable<Pagination>, IValidatableObject
    {
        
        /// <summary>
        /// Page number which specifies the set of records to retrieve. Example - https://api.xero.com/bankfeeds.xro/1.0/Statements?page&#x3D;2 to get the second set of the records. When page value is not a number or a negative number, by default, the first set of records is returned.
        /// </summary>
        /// <value>Page number which specifies the set of records to retrieve. Example - https://api.xero.com/bankfeeds.xro/1.0/Statements?page&#x3D;2 to get the second set of the records. When page value is not a number or a negative number, by default, the first set of records is returned.</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }

        /// <summary>
        /// Page size which specifies how many records per page will be returned (default 50). Example - https://api.xero.com/bankfeeds.xro/1.0/Statements?pageSize&#x3D;100 to specify page size of 100.
        /// </summary>
        /// <value>Page size which specifies how many records per page will be returned (default 50). Example - https://api.xero.com/bankfeeds.xro/1.0/Statements?pageSize&#x3D;100 to specify page size of 100.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Number of pages available
        /// </summary>
        /// <value>Number of pages available</value>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// Number of items returned
        /// </summary>
        /// <value>Number of items returned</value>
        [DataMember(Name="itemCount", EmitDefaultValue=false)]
        public int? ItemCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pagination {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  ItemCount: ").Append(ItemCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Pagination);
        }

        /// <summary>
        /// Returns true if Pagination instances are equal
        /// </summary>
        /// <param name="input">Instance of Pagination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pagination input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.PageCount == input.PageCount ||
                    (this.PageCount != null &&
                    this.PageCount.Equals(input.PageCount))
                ) && 
                (
                    this.ItemCount == input.ItemCount ||
                    (this.ItemCount != null &&
                    this.ItemCount.Equals(input.ItemCount))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.PageCount != null)
                    hashCode = hashCode * 59 + this.PageCount.GetHashCode();
                if (this.ItemCount != null)
                    hashCode = hashCode * 59 + this.ItemCount.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
