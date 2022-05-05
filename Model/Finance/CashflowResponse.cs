/* 
 * Xero Finance API
 *
 * The Finance API is a collection of endpoints which customers can use in the course of a loan application, which may assist lenders to gain the confidence they need to provide capital.
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

namespace Xero.Net.Api.Model.Finance
{
    /// <summary>
    /// CashflowResponse
    /// </summary>
    [DataContract]
    public partial class CashflowResponse :  IEquatable<CashflowResponse>, IValidatableObject
    {
        
        /// <summary>
        /// Start date of the report
        /// </summary>
        /// <value>Start date of the report</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End date of the report
        /// </summary>
        /// <value>End date of the report</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets CashBalance
        /// </summary>
        [DataMember(Name="cashBalance", EmitDefaultValue=false)]
        public CashBalance CashBalance { get; set; }

        /// <summary>
        /// Break down of cash and cash equivalents for the period
        /// </summary>
        /// <value>Break down of cash and cash equivalents for the period</value>
        [DataMember(Name="cashflowActivities", EmitDefaultValue=false)]
        public List<CashflowActivity> CashflowActivities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CashflowResponse {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  CashBalance: ").Append(CashBalance).Append("\n");
            sb.Append("  CashflowActivities: ").Append(CashflowActivities).Append("\n");
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
            return this.Equals(input as CashflowResponse);
        }

        /// <summary>
        /// Returns true if CashflowResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CashflowResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashflowResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.CashBalance == input.CashBalance ||
                    (this.CashBalance != null &&
                    this.CashBalance.Equals(input.CashBalance))
                ) && 
                (
                    this.CashflowActivities == input.CashflowActivities ||
                    this.CashflowActivities != null &&
                    input.CashflowActivities != null &&
                    this.CashflowActivities.SequenceEqual(input.CashflowActivities)
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.CashBalance != null)
                    hashCode = hashCode * 59 + this.CashBalance.GetHashCode();
                if (this.CashflowActivities != null)
                    hashCode = hashCode * 59 + this.CashflowActivities.GetHashCode();
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
