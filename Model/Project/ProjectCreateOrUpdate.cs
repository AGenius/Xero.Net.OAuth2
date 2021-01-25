/* 
 * Xero Projects API
 *
 * This is the Xero Projects API
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

namespace Xero.Net.Api.Model.Project
{
    /// <summary>
    /// ProjectCreateOrUpdate
    /// </summary>
    [DataContract]
    public partial class ProjectCreateOrUpdate :  IEquatable<ProjectCreateOrUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreateOrUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ProjectCreateOrUpdate() 
        { 
        }
        
        /// <summary>
        /// Identifier of the contact this project was created for.
        /// </summary>
        /// <value>Identifier of the contact this project was created for.</value>
        [DataMember(Name="contactId", EmitDefaultValue=false)]
        public Guid? ContactId { get; set; }

        /// <summary>
        /// Name of the project.
        /// </summary>
        /// <value>Name of the project.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets EstimateAmount
        /// </summary>
        [DataMember(Name="estimateAmount", EmitDefaultValue=false)]
        public decimal? EstimateAmount { get; set; }

        /// <summary>
        /// Deadline for the project. UTC Date Time in ISO-8601 format.
        /// </summary>
        /// <value>Deadline for the project. UTC Date Time in ISO-8601 format.</value>
        [DataMember(Name="deadlineUtc", EmitDefaultValue=false)]
        public DateTime? DeadlineUtc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectCreateOrUpdate {\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EstimateAmount: ").Append(EstimateAmount).Append("\n");
            sb.Append("  DeadlineUtc: ").Append(DeadlineUtc).Append("\n");
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
            return this.Equals(input as ProjectCreateOrUpdate);
        }

        /// <summary>
        /// Returns true if ProjectCreateOrUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectCreateOrUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectCreateOrUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EstimateAmount == input.EstimateAmount ||
                    this.EstimateAmount.Equals(input.EstimateAmount)
                ) && 
                (
                    this.DeadlineUtc == input.DeadlineUtc ||
                    (this.DeadlineUtc != null &&
                    this.DeadlineUtc.Equals(input.DeadlineUtc))
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
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.EstimateAmount.GetHashCode();
                if (this.DeadlineUtc != null)
                    hashCode = hashCode * 59 + this.DeadlineUtc.GetHashCode();
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
