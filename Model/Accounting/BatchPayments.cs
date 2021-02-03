/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.8.4
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
    /// BatchPayments
    /// </summary>
    [DataContract]
    public partial class BatchPayments :  IEquatable<BatchPayments>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets _BatchPayments
        /// </summary>
        [DataMember(Name="BatchPayments", EmitDefaultValue=false)]
        public List<BatchPayment> _BatchPayments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchPayments {\n");
            sb.Append("  _BatchPayments: ").Append(_BatchPayments).Append("\n");
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
            return this.Equals(input as BatchPayments);
        }

        /// <summary>
        /// Returns true if BatchPayments instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchPayments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchPayments input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._BatchPayments == input._BatchPayments ||
                    this._BatchPayments != null &&
                    input._BatchPayments != null &&
                    this._BatchPayments.SequenceEqual(input._BatchPayments)
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
                if (this._BatchPayments != null)
                    hashCode = hashCode * 59 + this._BatchPayments.GetHashCode();
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
