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
    /// PaymentServices
    /// </summary>
    [DataContract]
    public partial class PaymentServices :  IEquatable<PaymentServices>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets _PaymentServices
        /// </summary>
        [DataMember(Name="PaymentServices", EmitDefaultValue=false)]
        public List<PaymentService> _PaymentServices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentServices {\n");
            sb.Append("  _PaymentServices: ").Append(_PaymentServices).Append("\n");
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
            return this.Equals(input as PaymentServices);
        }

        /// <summary>
        /// Returns true if PaymentServices instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentServices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentServices input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._PaymentServices == input._PaymentServices ||
                    this._PaymentServices != null &&
                    input._PaymentServices != null &&
                    this._PaymentServices.SequenceEqual(input._PaymentServices)
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
                if (this._PaymentServices != null)
                    hashCode = hashCode * 59 + this._PaymentServices.GetHashCode();
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
