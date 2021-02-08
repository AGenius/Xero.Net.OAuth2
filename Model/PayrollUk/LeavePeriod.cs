/* 
 * Xero Payroll UK
 *
 * This is the Xero Payroll API for orgs in the UK region.
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

namespace Xero.Net.Api.Model.PayrollUk
{
    /// <summary>
    /// LeavePeriod
    /// </summary>
    [DataContract]
    public partial class LeavePeriod :  IEquatable<LeavePeriod>, IValidatableObject
    {
        /// <summary>
        /// Period Status
        /// </summary>
        /// <value>Period Status</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum PeriodStatusEnum
        {
            /// <summary>
            /// Enum Approved for value: Approved
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved = 1,

            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 2

        }

        /// <summary>
        /// Period Status
        /// </summary>
        /// <value>Period Status</value>
        [DataMember(Name="periodStatus", EmitDefaultValue=false)]
        public PeriodStatusEnum PeriodStatus { get; set; }
        
        /// <summary>
        /// The Pay Period Start Date (YYYY-MM-DD)
        /// </summary>
        /// <value>The Pay Period Start Date (YYYY-MM-DD)</value>
        [DataMember(Name="periodStartDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? PeriodStartDate { get; set; }

        /// <summary>
        /// The Pay Period End Date (YYYY-MM-DD)
        /// </summary>
        /// <value>The Pay Period End Date (YYYY-MM-DD)</value>
        [DataMember(Name="periodEndDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? PeriodEndDate { get; set; }

        /// <summary>
        /// The Number of Units for the leave
        /// </summary>
        /// <value>The Number of Units for the leave</value>
        [DataMember(Name="numberOfUnits", EmitDefaultValue=false)]
        public double? NumberOfUnits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeavePeriod {\n");
            sb.Append("  PeriodStartDate: ").Append(PeriodStartDate).Append("\n");
            sb.Append("  PeriodEndDate: ").Append(PeriodEndDate).Append("\n");
            sb.Append("  NumberOfUnits: ").Append(NumberOfUnits).Append("\n");
            sb.Append("  PeriodStatus: ").Append(PeriodStatus).Append("\n");
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
            return this.Equals(input as LeavePeriod);
        }

        /// <summary>
        /// Returns true if LeavePeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of LeavePeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeavePeriod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PeriodStartDate == input.PeriodStartDate ||
                    (this.PeriodStartDate != null &&
                    this.PeriodStartDate.Equals(input.PeriodStartDate))
                ) && 
                (
                    this.PeriodEndDate == input.PeriodEndDate ||
                    (this.PeriodEndDate != null &&
                    this.PeriodEndDate.Equals(input.PeriodEndDate))
                ) && 
                (
                    this.NumberOfUnits == input.NumberOfUnits ||
                    (this.NumberOfUnits != null &&
                    this.NumberOfUnits.Equals(input.NumberOfUnits))
                ) && 
                (
                    this.PeriodStatus == input.PeriodStatus ||
                    this.PeriodStatus.Equals(input.PeriodStatus)
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
                if (this.PeriodStartDate != null)
                    hashCode = hashCode * 59 + this.PeriodStartDate.GetHashCode();
                if (this.PeriodEndDate != null)
                    hashCode = hashCode * 59 + this.PeriodEndDate.GetHashCode();
                if (this.NumberOfUnits != null)
                    hashCode = hashCode * 59 + this.NumberOfUnits.GetHashCode();
                hashCode = hashCode * 59 + this.PeriodStatus.GetHashCode();
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
