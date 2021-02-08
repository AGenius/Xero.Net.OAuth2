/* 
 * Xero Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
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

namespace Xero.Net.Api.Model.Accounting
{
    /// <summary>
    /// TaxRates
    /// </summary>
    [DataContract]
    public partial class TaxRates :  IEquatable<TaxRates>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets _TaxRates
        /// </summary>
        [DataMember(Name="TaxRates", EmitDefaultValue=false)]
        public List<TaxRate> _TaxRates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxRates {\n");
            sb.Append("  _TaxRates: ").Append(_TaxRates).Append("\n");
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
            return this.Equals(input as TaxRates);
        }

        /// <summary>
        /// Returns true if TaxRates instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxRates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxRates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._TaxRates == input._TaxRates ||
                    this._TaxRates != null &&
                    input._TaxRates != null &&
                    this._TaxRates.SequenceEqual(input._TaxRates)
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
                if (this._TaxRates != null)
                    hashCode = hashCode * 59 + this._TaxRates.GetHashCode();
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
