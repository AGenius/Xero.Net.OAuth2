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
    /// ReportWithRows
    /// </summary>
    [DataContract]
    public partial class ReportWithRows :  IEquatable<ReportWithRows>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets Reports
        /// </summary>
        [DataMember(Name="Reports", EmitDefaultValue=false)]
        public List<ReportWithRow> Reports { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportWithRows {\n");
            sb.Append("  Reports: ").Append(Reports).Append("\n");
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
            return this.Equals(input as ReportWithRows);
        }

        /// <summary>
        /// Returns true if ReportWithRows instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportWithRows to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportWithRows input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reports == input.Reports ||
                    this.Reports != null &&
                    input.Reports != null &&
                    this.Reports.SequenceEqual(input.Reports)
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
                if (this.Reports != null)
                    hashCode = hashCode * 59 + this.Reports.GetHashCode();
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
