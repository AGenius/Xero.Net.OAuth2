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
    /// BatchPaymentDelete
    /// </summary>
    [DataContract]
    public partial class BatchPaymentDelete :  IEquatable<BatchPaymentDelete>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchPaymentDelete" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public BatchPaymentDelete() 
        { 
        }
        
        /// <summary>
        /// The Xero generated unique identifier for the bank transaction (read-only)
        /// </summary>
        /// <value>The Xero generated unique identifier for the bank transaction (read-only)</value>
        [DataMember(Name="BatchPaymentID", EmitDefaultValue=false)]
        public Guid? BatchPaymentID { get; set; }

        /// <summary>
        /// The status of the batch payment.
        /// </summary>
        /// <value>The status of the batch payment.</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchPaymentDelete {\n");
            sb.Append("  BatchPaymentID: ").Append(BatchPaymentID).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as BatchPaymentDelete);
        }

        /// <summary>
        /// Returns true if BatchPaymentDelete instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchPaymentDelete to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchPaymentDelete input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BatchPaymentID == input.BatchPaymentID ||
                    (this.BatchPaymentID != null &&
                    this.BatchPaymentID.Equals(input.BatchPaymentID))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.BatchPaymentID != null)
                    hashCode = hashCode * 59 + this.BatchPaymentID.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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