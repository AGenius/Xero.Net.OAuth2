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
    /// StatementLinesResponse
    /// </summary>
    [DataContract]
    public partial class StatementLinesResponse :  IEquatable<StatementLinesResponse>, IValidatableObject
    {
        
        /// <summary>
        /// Sum of the amounts of all statement lines where both the reconciled flag is set to FALSE, and the amount is positive.
        /// </summary>
        /// <value>Sum of the amounts of all statement lines where both the reconciled flag is set to FALSE, and the amount is positive.</value>
        [DataMember(Name="unreconciledAmountPos", EmitDefaultValue=false)]
        public decimal? UnreconciledAmountPos { get; set; }

        /// <summary>
        /// Sum of the amounts of all statement lines where both the reconciled flag is set to FALSE, and the amount is negative.
        /// </summary>
        /// <value>Sum of the amounts of all statement lines where both the reconciled flag is set to FALSE, and the amount is negative.</value>
        [DataMember(Name="unreconciledAmountNeg", EmitDefaultValue=false)]
        public decimal? UnreconciledAmountNeg { get; set; }

        /// <summary>
        /// Count of all statement lines where the reconciled flag is set to FALSE.
        /// </summary>
        /// <value>Count of all statement lines where the reconciled flag is set to FALSE.</value>
        [DataMember(Name="unreconciledLines", EmitDefaultValue=false)]
        public int? UnreconciledLines { get; set; }

        /// <summary>
        /// Sum-product of age of statement line in days multiplied by transaction amount, divided by the sum of transaction amount - in for those statement lines in which the reconciled flag is set to FALSE, and the amount is positive. Provides an indication of the age of unreconciled transactions.
        /// </summary>
        /// <value>Sum-product of age of statement line in days multiplied by transaction amount, divided by the sum of transaction amount - in for those statement lines in which the reconciled flag is set to FALSE, and the amount is positive. Provides an indication of the age of unreconciled transactions.</value>
        [DataMember(Name="avgDaysUnreconciledPos", EmitDefaultValue=false)]
        public decimal? AvgDaysUnreconciledPos { get; set; }

        /// <summary>
        /// Sum-product of age of statement line in days multiplied by transaction amount, divided by the sum of transaction amount - in for those statement lines in which the reconciled flag is set to FALSE, and the amount is negative. Provides an indication of the age of unreconciled transactions.
        /// </summary>
        /// <value>Sum-product of age of statement line in days multiplied by transaction amount, divided by the sum of transaction amount - in for those statement lines in which the reconciled flag is set to FALSE, and the amount is negative. Provides an indication of the age of unreconciled transactions.</value>
        [DataMember(Name="avgDaysUnreconciledNeg", EmitDefaultValue=false)]
        public decimal? AvgDaysUnreconciledNeg { get; set; }

        /// <summary>
        /// UTC Date which is the earliest transaction date of a statement line for which the reconciled flag is set to FALSE.  This date is represented in ISO 8601 format.
        /// </summary>
        /// <value>UTC Date which is the earliest transaction date of a statement line for which the reconciled flag is set to FALSE.  This date is represented in ISO 8601 format.</value>
        [DataMember(Name="earliestUnreconciledTransaction", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EarliestUnreconciledTransaction { get; set; }

        /// <summary>
        /// UTC Date which is the latest transaction date of a statement line for which the reconciled flag is set to FALSE.  This date is represented in ISO 8601 format.
        /// </summary>
        /// <value>UTC Date which is the latest transaction date of a statement line for which the reconciled flag is set to FALSE.  This date is represented in ISO 8601 format.</value>
        [DataMember(Name="latestUnreconciledTransaction", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? LatestUnreconciledTransaction { get; set; }

        /// <summary>
        /// Sum of the amounts of all deleted statement lines.  Transactions may be deleted due to duplication or otherwise.
        /// </summary>
        /// <value>Sum of the amounts of all deleted statement lines.  Transactions may be deleted due to duplication or otherwise.</value>
        [DataMember(Name="deletedAmount", EmitDefaultValue=false)]
        public decimal? DeletedAmount { get; set; }

        /// <summary>
        /// Sum of the amounts of all statement lines.  This is used as a metric of comparison to the unreconciled figures above.
        /// </summary>
        /// <value>Sum of the amounts of all statement lines.  This is used as a metric of comparison to the unreconciled figures above.</value>
        [DataMember(Name="totalAmount", EmitDefaultValue=false)]
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets DataSource
        /// </summary>
        [DataMember(Name="dataSource", EmitDefaultValue=false)]
        public DataSourceResponse DataSource { get; set; }

        /// <summary>
        /// UTC Date which is the earliest transaction date of a statement line for which the reconciled flag is set to TRUE.  This date is represented in ISO 8601 format.
        /// </summary>
        /// <value>UTC Date which is the earliest transaction date of a statement line for which the reconciled flag is set to TRUE.  This date is represented in ISO 8601 format.</value>
        [DataMember(Name="earliestReconciledTransaction", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EarliestReconciledTransaction { get; set; }

        /// <summary>
        /// UTC Date which is the latest transaction date of a statement line for which the reconciled flag is set to TRUE.  This date is represented in ISO 8601 format.
        /// </summary>
        /// <value>UTC Date which is the latest transaction date of a statement line for which the reconciled flag is set to TRUE.  This date is represented in ISO 8601 format.</value>
        [DataMember(Name="latestReconciledTransaction", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? LatestReconciledTransaction { get; set; }

        /// <summary>
        /// Sum of the amounts of all statement lines where both the reconciled flag is set to TRUE, and the amount is positive.
        /// </summary>
        /// <value>Sum of the amounts of all statement lines where both the reconciled flag is set to TRUE, and the amount is positive.</value>
        [DataMember(Name="reconciledAmountPos", EmitDefaultValue=false)]
        public decimal? ReconciledAmountPos { get; set; }

        /// <summary>
        /// Sum of the amounts of all statement lines where both the reconciled flag is set to TRUE, and the amount is negative.
        /// </summary>
        /// <value>Sum of the amounts of all statement lines where both the reconciled flag is set to TRUE, and the amount is negative.</value>
        [DataMember(Name="reconciledAmountNeg", EmitDefaultValue=false)]
        public decimal? ReconciledAmountNeg { get; set; }

        /// <summary>
        /// Count of all statement lines where the reconciled flag is set to TRUE
        /// </summary>
        /// <value>Count of all statement lines where the reconciled flag is set to TRUE</value>
        [DataMember(Name="reconciledLines", EmitDefaultValue=false)]
        public int? ReconciledLines { get; set; }

        /// <summary>
        /// Sum of the amounts of all statement lines where the amount is positive
        /// </summary>
        /// <value>Sum of the amounts of all statement lines where the amount is positive</value>
        [DataMember(Name="totalAmountPos", EmitDefaultValue=false)]
        public decimal? TotalAmountPos { get; set; }

        /// <summary>
        /// Sum of the amounts of all statement lines where the amount is negative.
        /// </summary>
        /// <value>Sum of the amounts of all statement lines where the amount is negative.</value>
        [DataMember(Name="totalAmountNeg", EmitDefaultValue=false)]
        public decimal? TotalAmountNeg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatementLinesResponse {\n");
            sb.Append("  UnreconciledAmountPos: ").Append(UnreconciledAmountPos).Append("\n");
            sb.Append("  UnreconciledAmountNeg: ").Append(UnreconciledAmountNeg).Append("\n");
            sb.Append("  UnreconciledLines: ").Append(UnreconciledLines).Append("\n");
            sb.Append("  AvgDaysUnreconciledPos: ").Append(AvgDaysUnreconciledPos).Append("\n");
            sb.Append("  AvgDaysUnreconciledNeg: ").Append(AvgDaysUnreconciledNeg).Append("\n");
            sb.Append("  EarliestUnreconciledTransaction: ").Append(EarliestUnreconciledTransaction).Append("\n");
            sb.Append("  LatestUnreconciledTransaction: ").Append(LatestUnreconciledTransaction).Append("\n");
            sb.Append("  DeletedAmount: ").Append(DeletedAmount).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  EarliestReconciledTransaction: ").Append(EarliestReconciledTransaction).Append("\n");
            sb.Append("  LatestReconciledTransaction: ").Append(LatestReconciledTransaction).Append("\n");
            sb.Append("  ReconciledAmountPos: ").Append(ReconciledAmountPos).Append("\n");
            sb.Append("  ReconciledAmountNeg: ").Append(ReconciledAmountNeg).Append("\n");
            sb.Append("  ReconciledLines: ").Append(ReconciledLines).Append("\n");
            sb.Append("  TotalAmountPos: ").Append(TotalAmountPos).Append("\n");
            sb.Append("  TotalAmountNeg: ").Append(TotalAmountNeg).Append("\n");
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
            return this.Equals(input as StatementLinesResponse);
        }

        /// <summary>
        /// Returns true if StatementLinesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of StatementLinesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatementLinesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UnreconciledAmountPos == input.UnreconciledAmountPos ||
                    (this.UnreconciledAmountPos != null &&
                    this.UnreconciledAmountPos.Equals(input.UnreconciledAmountPos))
                ) && 
                (
                    this.UnreconciledAmountNeg == input.UnreconciledAmountNeg ||
                    (this.UnreconciledAmountNeg != null &&
                    this.UnreconciledAmountNeg.Equals(input.UnreconciledAmountNeg))
                ) && 
                (
                    this.UnreconciledLines == input.UnreconciledLines ||
                    (this.UnreconciledLines != null &&
                    this.UnreconciledLines.Equals(input.UnreconciledLines))
                ) && 
                (
                    this.AvgDaysUnreconciledPos == input.AvgDaysUnreconciledPos ||
                    (this.AvgDaysUnreconciledPos != null &&
                    this.AvgDaysUnreconciledPos.Equals(input.AvgDaysUnreconciledPos))
                ) && 
                (
                    this.AvgDaysUnreconciledNeg == input.AvgDaysUnreconciledNeg ||
                    (this.AvgDaysUnreconciledNeg != null &&
                    this.AvgDaysUnreconciledNeg.Equals(input.AvgDaysUnreconciledNeg))
                ) && 
                (
                    this.EarliestUnreconciledTransaction == input.EarliestUnreconciledTransaction ||
                    (this.EarliestUnreconciledTransaction != null &&
                    this.EarliestUnreconciledTransaction.Equals(input.EarliestUnreconciledTransaction))
                ) && 
                (
                    this.LatestUnreconciledTransaction == input.LatestUnreconciledTransaction ||
                    (this.LatestUnreconciledTransaction != null &&
                    this.LatestUnreconciledTransaction.Equals(input.LatestUnreconciledTransaction))
                ) && 
                (
                    this.DeletedAmount == input.DeletedAmount ||
                    (this.DeletedAmount != null &&
                    this.DeletedAmount.Equals(input.DeletedAmount))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.DataSource == input.DataSource ||
                    (this.DataSource != null &&
                    this.DataSource.Equals(input.DataSource))
                ) && 
                (
                    this.EarliestReconciledTransaction == input.EarliestReconciledTransaction ||
                    (this.EarliestReconciledTransaction != null &&
                    this.EarliestReconciledTransaction.Equals(input.EarliestReconciledTransaction))
                ) && 
                (
                    this.LatestReconciledTransaction == input.LatestReconciledTransaction ||
                    (this.LatestReconciledTransaction != null &&
                    this.LatestReconciledTransaction.Equals(input.LatestReconciledTransaction))
                ) && 
                (
                    this.ReconciledAmountPos == input.ReconciledAmountPos ||
                    (this.ReconciledAmountPos != null &&
                    this.ReconciledAmountPos.Equals(input.ReconciledAmountPos))
                ) && 
                (
                    this.ReconciledAmountNeg == input.ReconciledAmountNeg ||
                    (this.ReconciledAmountNeg != null &&
                    this.ReconciledAmountNeg.Equals(input.ReconciledAmountNeg))
                ) && 
                (
                    this.ReconciledLines == input.ReconciledLines ||
                    (this.ReconciledLines != null &&
                    this.ReconciledLines.Equals(input.ReconciledLines))
                ) && 
                (
                    this.TotalAmountPos == input.TotalAmountPos ||
                    (this.TotalAmountPos != null &&
                    this.TotalAmountPos.Equals(input.TotalAmountPos))
                ) && 
                (
                    this.TotalAmountNeg == input.TotalAmountNeg ||
                    (this.TotalAmountNeg != null &&
                    this.TotalAmountNeg.Equals(input.TotalAmountNeg))
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
                if (this.UnreconciledAmountPos != null)
                    hashCode = hashCode * 59 + this.UnreconciledAmountPos.GetHashCode();
                if (this.UnreconciledAmountNeg != null)
                    hashCode = hashCode * 59 + this.UnreconciledAmountNeg.GetHashCode();
                if (this.UnreconciledLines != null)
                    hashCode = hashCode * 59 + this.UnreconciledLines.GetHashCode();
                if (this.AvgDaysUnreconciledPos != null)
                    hashCode = hashCode * 59 + this.AvgDaysUnreconciledPos.GetHashCode();
                if (this.AvgDaysUnreconciledNeg != null)
                    hashCode = hashCode * 59 + this.AvgDaysUnreconciledNeg.GetHashCode();
                if (this.EarliestUnreconciledTransaction != null)
                    hashCode = hashCode * 59 + this.EarliestUnreconciledTransaction.GetHashCode();
                if (this.LatestUnreconciledTransaction != null)
                    hashCode = hashCode * 59 + this.LatestUnreconciledTransaction.GetHashCode();
                if (this.DeletedAmount != null)
                    hashCode = hashCode * 59 + this.DeletedAmount.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
                if (this.DataSource != null)
                    hashCode = hashCode * 59 + this.DataSource.GetHashCode();
                if (this.EarliestReconciledTransaction != null)
                    hashCode = hashCode * 59 + this.EarliestReconciledTransaction.GetHashCode();
                if (this.LatestReconciledTransaction != null)
                    hashCode = hashCode * 59 + this.LatestReconciledTransaction.GetHashCode();
                if (this.ReconciledAmountPos != null)
                    hashCode = hashCode * 59 + this.ReconciledAmountPos.GetHashCode();
                if (this.ReconciledAmountNeg != null)
                    hashCode = hashCode * 59 + this.ReconciledAmountNeg.GetHashCode();
                if (this.ReconciledLines != null)
                    hashCode = hashCode * 59 + this.ReconciledLines.GetHashCode();
                if (this.TotalAmountPos != null)
                    hashCode = hashCode * 59 + this.TotalAmountPos.GetHashCode();
                if (this.TotalAmountNeg != null)
                    hashCode = hashCode * 59 + this.TotalAmountNeg.GetHashCode();
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
