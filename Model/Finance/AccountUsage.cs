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
    /// AccountUsage
    /// </summary>
    [DataContract]
    public partial class AccountUsage :  IEquatable<AccountUsage>, IValidatableObject
    {
        
        /// <summary>
        /// The month this usage item contains data for
        /// </summary>
        /// <value>The month this usage item contains data for</value>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public string Month { get; set; }

        /// <summary>
        /// The account this usage item contains data for
        /// </summary>
        /// <value>The account this usage item contains data for</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public Guid? AccountId { get; set; }

        /// <summary>
        /// The currency code this usage item contains data for
        /// </summary>
        /// <value>The currency code this usage item contains data for</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Total received
        /// </summary>
        /// <value>Total received</value>
        [DataMember(Name="totalReceived", EmitDefaultValue=false)]
        public decimal? TotalReceived { get; set; }

        /// <summary>
        /// Count of received
        /// </summary>
        /// <value>Count of received</value>
        [DataMember(Name="countReceived", EmitDefaultValue=false)]
        public int? CountReceived { get; set; }

        /// <summary>
        /// Total paid
        /// </summary>
        /// <value>Total paid</value>
        [DataMember(Name="totalPaid", EmitDefaultValue=false)]
        public decimal? TotalPaid { get; set; }

        /// <summary>
        /// Count of paid
        /// </summary>
        /// <value>Count of paid</value>
        [DataMember(Name="countPaid", EmitDefaultValue=false)]
        public int? CountPaid { get; set; }

        /// <summary>
        /// Total value of manual journals
        /// </summary>
        /// <value>Total value of manual journals</value>
        [DataMember(Name="totalManualJournal", EmitDefaultValue=false)]
        public decimal? TotalManualJournal { get; set; }

        /// <summary>
        /// Count of manual journals
        /// </summary>
        /// <value>Count of manual journals</value>
        [DataMember(Name="countManualJournal", EmitDefaultValue=false)]
        public int? CountManualJournal { get; set; }

        /// <summary>
        /// The name of the account
        /// </summary>
        /// <value>The name of the account</value>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Shown if set
        /// </summary>
        /// <value>Shown if set</value>
        [DataMember(Name="reportingCode", EmitDefaultValue=false)]
        public string ReportingCode { get; set; }

        /// <summary>
        /// Shown if set
        /// </summary>
        /// <value>Shown if set</value>
        [DataMember(Name="reportingCodeName", EmitDefaultValue=false)]
        public string ReportingCodeName { get; set; }

        /// <summary>
        /// Last modified date UTC format
        /// </summary>
        /// <value>Last modified date UTC format</value>
        [DataMember(Name="reportCodeUpdatedDateUtc", EmitDefaultValue=false)]
        public DateTime? ReportCodeUpdatedDateUtc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountUsage {\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  TotalReceived: ").Append(TotalReceived).Append("\n");
            sb.Append("  CountReceived: ").Append(CountReceived).Append("\n");
            sb.Append("  TotalPaid: ").Append(TotalPaid).Append("\n");
            sb.Append("  CountPaid: ").Append(CountPaid).Append("\n");
            sb.Append("  TotalManualJournal: ").Append(TotalManualJournal).Append("\n");
            sb.Append("  CountManualJournal: ").Append(CountManualJournal).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  ReportingCode: ").Append(ReportingCode).Append("\n");
            sb.Append("  ReportingCodeName: ").Append(ReportingCodeName).Append("\n");
            sb.Append("  ReportCodeUpdatedDateUtc: ").Append(ReportCodeUpdatedDateUtc).Append("\n");
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
            return this.Equals(input as AccountUsage);
        }

        /// <summary>
        /// Returns true if AccountUsage instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountUsage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Month == input.Month ||
                    (this.Month != null &&
                    this.Month.Equals(input.Month))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.TotalReceived == input.TotalReceived ||
                    (this.TotalReceived != null &&
                    this.TotalReceived.Equals(input.TotalReceived))
                ) && 
                (
                    this.CountReceived == input.CountReceived ||
                    (this.CountReceived != null &&
                    this.CountReceived.Equals(input.CountReceived))
                ) && 
                (
                    this.TotalPaid == input.TotalPaid ||
                    (this.TotalPaid != null &&
                    this.TotalPaid.Equals(input.TotalPaid))
                ) && 
                (
                    this.CountPaid == input.CountPaid ||
                    (this.CountPaid != null &&
                    this.CountPaid.Equals(input.CountPaid))
                ) && 
                (
                    this.TotalManualJournal == input.TotalManualJournal ||
                    (this.TotalManualJournal != null &&
                    this.TotalManualJournal.Equals(input.TotalManualJournal))
                ) && 
                (
                    this.CountManualJournal == input.CountManualJournal ||
                    (this.CountManualJournal != null &&
                    this.CountManualJournal.Equals(input.CountManualJournal))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.ReportingCode == input.ReportingCode ||
                    (this.ReportingCode != null &&
                    this.ReportingCode.Equals(input.ReportingCode))
                ) && 
                (
                    this.ReportingCodeName == input.ReportingCodeName ||
                    (this.ReportingCodeName != null &&
                    this.ReportingCodeName.Equals(input.ReportingCodeName))
                ) && 
                (
                    this.ReportCodeUpdatedDateUtc == input.ReportCodeUpdatedDateUtc ||
                    (this.ReportCodeUpdatedDateUtc != null &&
                    this.ReportCodeUpdatedDateUtc.Equals(input.ReportCodeUpdatedDateUtc))
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
                if (this.Month != null)
                    hashCode = hashCode * 59 + this.Month.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.TotalReceived != null)
                    hashCode = hashCode * 59 + this.TotalReceived.GetHashCode();
                if (this.CountReceived != null)
                    hashCode = hashCode * 59 + this.CountReceived.GetHashCode();
                if (this.TotalPaid != null)
                    hashCode = hashCode * 59 + this.TotalPaid.GetHashCode();
                if (this.CountPaid != null)
                    hashCode = hashCode * 59 + this.CountPaid.GetHashCode();
                if (this.TotalManualJournal != null)
                    hashCode = hashCode * 59 + this.TotalManualJournal.GetHashCode();
                if (this.CountManualJournal != null)
                    hashCode = hashCode * 59 + this.CountManualJournal.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.ReportingCode != null)
                    hashCode = hashCode * 59 + this.ReportingCode.GetHashCode();
                if (this.ReportingCodeName != null)
                    hashCode = hashCode * 59 + this.ReportingCodeName.GetHashCode();
                if (this.ReportCodeUpdatedDateUtc != null)
                    hashCode = hashCode * 59 + this.ReportCodeUpdatedDateUtc.GetHashCode();
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