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
    /// StatementResponse
    /// </summary>
    [DataContract]
    public partial class StatementResponse :  IEquatable<StatementResponse>, IValidatableObject
    {
        
        /// <summary>
        /// Xero Identifier of statement
        /// </summary>
        /// <value>Xero Identifier of statement</value>
        [DataMember(Name="statementId", EmitDefaultValue=false)]
        public Guid? StatementId { get; set; }

        /// <summary>
        /// Start date of statement
        /// </summary>
        /// <value>Start date of statement</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End date of statement
        /// </summary>
        /// <value>End date of statement</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Utc date time of when the statement was imported in Xero
        /// </summary>
        /// <value>Utc date time of when the statement was imported in Xero</value>
        [DataMember(Name="importedDateTimeUtc", EmitDefaultValue=false)]
        public DateTime? ImportedDateTimeUtc { get; set; }

        /// <summary>
        /// Identifies where the statement data in Xero was sourced, 1) direct bank feed, automatically loaded from the bank (eg STMTIMPORTSRC/CBAFEED); 2) indirect bank feed, automatically loaded from a 3rd party provider (eg STMTIMPORTSRC/YODLEE); 3) manually uploaded bank feed (eg STMTIMPORTSRC/CSV) or 4) manually entered statement data (STMTIMPORTSRC/MANUAL).
        /// </summary>
        /// <value>Identifies where the statement data in Xero was sourced, 1) direct bank feed, automatically loaded from the bank (eg STMTIMPORTSRC/CBAFEED); 2) indirect bank feed, automatically loaded from a 3rd party provider (eg STMTIMPORTSRC/YODLEE); 3) manually uploaded bank feed (eg STMTIMPORTSRC/CSV) or 4) manually entered statement data (STMTIMPORTSRC/MANUAL).</value>
        [DataMember(Name="importSource", EmitDefaultValue=false)]
        public string ImportSource { get; set; }

        /// <summary>
        /// Opening balance sourced from imported bank statements (if supplied). Note, for manually uploaded statements, this balance is also manual and usually not supplied. Where not supplied, the value will be 0.
        /// </summary>
        /// <value>Opening balance sourced from imported bank statements (if supplied). Note, for manually uploaded statements, this balance is also manual and usually not supplied. Where not supplied, the value will be 0.</value>
        [DataMember(Name="startBalance", EmitDefaultValue=false)]
        public decimal? StartBalance { get; set; }

        /// <summary>
        /// Closing balance sourced from imported bank statements (if supplied). Note, for manually uploaded statements, this balance is also manual and usually not supplied. Where not supplied, the value will be 0.
        /// </summary>
        /// <value>Closing balance sourced from imported bank statements (if supplied). Note, for manually uploaded statements, this balance is also manual and usually not supplied. Where not supplied, the value will be 0.</value>
        [DataMember(Name="endBalance", EmitDefaultValue=false)]
        public decimal? EndBalance { get; set; }

        /// <summary>
        /// Opening statement balance calculated in Xero (&#x3D; bank account conversion balance plus sum of imported bank statement lines). Note: If indicative statement balance doesn&#39;t match imported statement balance for the same date, either the conversion (opening at inception) balance in Xero is wrong or there&#39;s an error in the bank statement lines in Xero. Ref: https://central.xero.com/s/article/Compare-the-statement-balance-in-Xero-to-your-actual-bank-balance?userregion&#x3D;true 
        /// </summary>
        /// <value>Opening statement balance calculated in Xero (&#x3D; bank account conversion balance plus sum of imported bank statement lines). Note: If indicative statement balance doesn&#39;t match imported statement balance for the same date, either the conversion (opening at inception) balance in Xero is wrong or there&#39;s an error in the bank statement lines in Xero. Ref: https://central.xero.com/s/article/Compare-the-statement-balance-in-Xero-to-your-actual-bank-balance?userregion&#x3D;true </value>
        [DataMember(Name="indicativeStartBalance", EmitDefaultValue=false)]
        public decimal? IndicativeStartBalance { get; set; }

        /// <summary>
        /// Closing statement balance calculated in Xero (&#x3D; bank account conversion balance plus sum of imported bank statement lines). Note: If indicative statement balance doesn&#39;t match imported statement balance for the same date, either the conversion (opening at inception) balance in Xero is wrong or there&#39;s an error in the bank statement lines in Xero. Ref: https://central.xero.com/s/article/Compare-the-statement-balance-in-Xero-to-your-actual-bank-balance?userregion&#x3D;true  
        /// </summary>
        /// <value>Closing statement balance calculated in Xero (&#x3D; bank account conversion balance plus sum of imported bank statement lines). Note: If indicative statement balance doesn&#39;t match imported statement balance for the same date, either the conversion (opening at inception) balance in Xero is wrong or there&#39;s an error in the bank statement lines in Xero. Ref: https://central.xero.com/s/article/Compare-the-statement-balance-in-Xero-to-your-actual-bank-balance?userregion&#x3D;true  </value>
        [DataMember(Name="indicativeEndBalance", EmitDefaultValue=false)]
        public decimal? IndicativeEndBalance { get; set; }

        /// <summary>
        /// List of statement lines
        /// </summary>
        /// <value>List of statement lines</value>
        [DataMember(Name="statementLines", EmitDefaultValue=false)]
        public List<StatementLineResponse> StatementLines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatementResponse {\n");
            sb.Append("  StatementId: ").Append(StatementId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ImportedDateTimeUtc: ").Append(ImportedDateTimeUtc).Append("\n");
            sb.Append("  ImportSource: ").Append(ImportSource).Append("\n");
            sb.Append("  StartBalance: ").Append(StartBalance).Append("\n");
            sb.Append("  EndBalance: ").Append(EndBalance).Append("\n");
            sb.Append("  IndicativeStartBalance: ").Append(IndicativeStartBalance).Append("\n");
            sb.Append("  IndicativeEndBalance: ").Append(IndicativeEndBalance).Append("\n");
            sb.Append("  StatementLines: ").Append(StatementLines).Append("\n");
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
            return this.Equals(input as StatementResponse);
        }

        /// <summary>
        /// Returns true if StatementResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of StatementResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatementResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatementId == input.StatementId ||
                    (this.StatementId != null &&
                    this.StatementId.Equals(input.StatementId))
                ) && 
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
                    this.ImportedDateTimeUtc == input.ImportedDateTimeUtc ||
                    (this.ImportedDateTimeUtc != null &&
                    this.ImportedDateTimeUtc.Equals(input.ImportedDateTimeUtc))
                ) && 
                (
                    this.ImportSource == input.ImportSource ||
                    (this.ImportSource != null &&
                    this.ImportSource.Equals(input.ImportSource))
                ) && 
                (
                    this.StartBalance == input.StartBalance ||
                    (this.StartBalance != null &&
                    this.StartBalance.Equals(input.StartBalance))
                ) && 
                (
                    this.EndBalance == input.EndBalance ||
                    (this.EndBalance != null &&
                    this.EndBalance.Equals(input.EndBalance))
                ) && 
                (
                    this.IndicativeStartBalance == input.IndicativeStartBalance ||
                    (this.IndicativeStartBalance != null &&
                    this.IndicativeStartBalance.Equals(input.IndicativeStartBalance))
                ) && 
                (
                    this.IndicativeEndBalance == input.IndicativeEndBalance ||
                    (this.IndicativeEndBalance != null &&
                    this.IndicativeEndBalance.Equals(input.IndicativeEndBalance))
                ) && 
                (
                    this.StatementLines == input.StatementLines ||
                    this.StatementLines != null &&
                    input.StatementLines != null &&
                    this.StatementLines.SequenceEqual(input.StatementLines)
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
                if (this.StatementId != null)
                    hashCode = hashCode * 59 + this.StatementId.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.ImportedDateTimeUtc != null)
                    hashCode = hashCode * 59 + this.ImportedDateTimeUtc.GetHashCode();
                if (this.ImportSource != null)
                    hashCode = hashCode * 59 + this.ImportSource.GetHashCode();
                if (this.StartBalance != null)
                    hashCode = hashCode * 59 + this.StartBalance.GetHashCode();
                if (this.EndBalance != null)
                    hashCode = hashCode * 59 + this.EndBalance.GetHashCode();
                if (this.IndicativeStartBalance != null)
                    hashCode = hashCode * 59 + this.IndicativeStartBalance.GetHashCode();
                if (this.IndicativeEndBalance != null)
                    hashCode = hashCode * 59 + this.IndicativeEndBalance.GetHashCode();
                if (this.StatementLines != null)
                    hashCode = hashCode * 59 + this.StatementLines.GetHashCode();
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
