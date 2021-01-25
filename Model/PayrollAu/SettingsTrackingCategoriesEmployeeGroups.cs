/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.8.0
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
    /// The tracking category used for employees
    /// </summary>
    [DataContract]
    public partial class SettingsTrackingCategoriesEmployeeGroups :  IEquatable<SettingsTrackingCategoriesEmployeeGroups>, IValidatableObject
    {
        
        /// <summary>
        /// The identifier for the tracking category
        /// </summary>
        /// <value>The identifier for the tracking category</value>
        [DataMember(Name="TrackingCategoryID", EmitDefaultValue=false)]
        public Guid? TrackingCategoryID { get; set; }

        /// <summary>
        /// Name of the tracking category
        /// </summary>
        /// <value>Name of the tracking category</value>
        [DataMember(Name="TrackingCategoryName", EmitDefaultValue=false)]
        public string TrackingCategoryName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettingsTrackingCategoriesEmployeeGroups {\n");
            sb.Append("  TrackingCategoryID: ").Append(TrackingCategoryID).Append("\n");
            sb.Append("  TrackingCategoryName: ").Append(TrackingCategoryName).Append("\n");
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
            return this.Equals(input as SettingsTrackingCategoriesEmployeeGroups);
        }

        /// <summary>
        /// Returns true if SettingsTrackingCategoriesEmployeeGroups instances are equal
        /// </summary>
        /// <param name="input">Instance of SettingsTrackingCategoriesEmployeeGroups to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettingsTrackingCategoriesEmployeeGroups input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrackingCategoryID == input.TrackingCategoryID ||
                    (this.TrackingCategoryID != null &&
                    this.TrackingCategoryID.Equals(input.TrackingCategoryID))
                ) && 
                (
                    this.TrackingCategoryName == input.TrackingCategoryName ||
                    (this.TrackingCategoryName != null &&
                    this.TrackingCategoryName.Equals(input.TrackingCategoryName))
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
                if (this.TrackingCategoryID != null)
                    hashCode = hashCode * 59 + this.TrackingCategoryID.GetHashCode();
                if (this.TrackingCategoryName != null)
                    hashCode = hashCode * 59 + this.TrackingCategoryName.GetHashCode();
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
