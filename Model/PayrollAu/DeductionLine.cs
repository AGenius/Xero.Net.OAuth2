/* 
 * Xero Payroll AU API
 *
 * This is the Xero Payroll API for orgs in Australia region.
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

namespace Xero.Net.Api.Model.PayrollAu
{
    /// <summary>
    /// DeductionLine
    /// </summary>
    [DataContract]
    public partial class DeductionLine :  IEquatable<DeductionLine>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets CalculationType
        /// </summary>
        [DataMember(Name="CalculationType", EmitDefaultValue=false)]
        public DeductionTypeCalculationType CalculationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeductionLine" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DeductionLine() 
        { 
        }
        
        /// <summary>
        /// Xero deduction type identifier
        /// </summary>
        /// <value>Xero deduction type identifier</value>
        [DataMember(Name="DeductionTypeID", EmitDefaultValue=false)]
        public Guid? DeductionTypeID { get; set; }

        /// <summary>
        /// Deduction type amount
        /// </summary>
        /// <value>Deduction type amount</value>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The Percentage of the Deduction
        /// </summary>
        /// <value>The Percentage of the Deduction</value>
        [DataMember(Name="Percentage", EmitDefaultValue=false)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Deduction number of units
        /// </summary>
        /// <value>Deduction number of units</value>
        [DataMember(Name="NumberOfUnits", EmitDefaultValue=false)]
        public decimal? NumberOfUnits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeductionLine {\n");
            sb.Append("  DeductionTypeID: ").Append(DeductionTypeID).Append("\n");
            sb.Append("  CalculationType: ").Append(CalculationType).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  NumberOfUnits: ").Append(NumberOfUnits).Append("\n");
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
            return this.Equals(input as DeductionLine);
        }

        /// <summary>
        /// Returns true if DeductionLine instances are equal
        /// </summary>
        /// <param name="input">Instance of DeductionLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeductionLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeductionTypeID == input.DeductionTypeID ||
                    (this.DeductionTypeID != null &&
                    this.DeductionTypeID.Equals(input.DeductionTypeID))
                ) && 
                (
                    this.CalculationType == input.CalculationType ||
                    this.CalculationType.Equals(input.CalculationType)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    (this.Percentage != null &&
                    this.Percentage.Equals(input.Percentage))
                ) && 
                (
                    this.NumberOfUnits == input.NumberOfUnits ||
                    (this.NumberOfUnits != null &&
                    this.NumberOfUnits.Equals(input.NumberOfUnits))
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
                if (this.DeductionTypeID != null)
                    hashCode = hashCode * 59 + this.DeductionTypeID.GetHashCode();
                hashCode = hashCode * 59 + this.CalculationType.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Percentage != null)
                    hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                if (this.NumberOfUnits != null)
                    hashCode = hashCode * 59 + this.NumberOfUnits.GetHashCode();
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
