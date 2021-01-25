/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
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

namespace Xero.Net.Api.Model.Accounting
{
    /// <summary>
    /// Item
    /// </summary>
    [DataContract]
    public partial class Item :  IEquatable<Item>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Item() 
        {  
          ValidationErrors = new List<ValidationError>(); 
        }
        
        /// <summary>
        /// User defined item code (max length &#x3D; 30)
        /// </summary>
        /// <value>User defined item code (max length &#x3D; 30)</value>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The inventory asset account for the item. The account must be of type INVENTORY. The  COGSAccountCode in PurchaseDetails is also required to create a tracked item
        /// </summary>
        /// <value>The inventory asset account for the item. The account must be of type INVENTORY. The  COGSAccountCode in PurchaseDetails is also required to create a tracked item</value>
        [DataMember(Name="InventoryAssetAccountCode", EmitDefaultValue=false)]
        public string InventoryAssetAccountCode { get; set; }

        /// <summary>
        /// The name of the item (max length &#x3D; 50)
        /// </summary>
        /// <value>The name of the item (max length &#x3D; 50)</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Boolean value, defaults to true. When IsSold is true the item will be available on sales transactions in the Xero UI. If IsSold is updated to false then Description and SalesDetails values will be nulled.
        /// </summary>
        /// <value>Boolean value, defaults to true. When IsSold is true the item will be available on sales transactions in the Xero UI. If IsSold is updated to false then Description and SalesDetails values will be nulled.</value>
        [DataMember(Name="IsSold", EmitDefaultValue=false)]
        public bool? IsSold { get; set; }

        /// <summary>
        /// Boolean value, defaults to true. When IsPurchased is true the item is available for purchase transactions in the Xero UI. If IsPurchased is updated to false then PurchaseDescription and PurchaseDetails values will be nulled.
        /// </summary>
        /// <value>Boolean value, defaults to true. When IsPurchased is true the item is available for purchase transactions in the Xero UI. If IsPurchased is updated to false then PurchaseDescription and PurchaseDetails values will be nulled.</value>
        [DataMember(Name="IsPurchased", EmitDefaultValue=false)]
        public bool? IsPurchased { get; set; }

        /// <summary>
        /// The sales description of the item (max length &#x3D; 4000)
        /// </summary>
        /// <value>The sales description of the item (max length &#x3D; 4000)</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The purchase description of the item (max length &#x3D; 4000)
        /// </summary>
        /// <value>The purchase description of the item (max length &#x3D; 4000)</value>
        [DataMember(Name="PurchaseDescription", EmitDefaultValue=false)]
        public string PurchaseDescription { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseDetails
        /// </summary>
        [DataMember(Name="PurchaseDetails", EmitDefaultValue=false)]
        public Purchase PurchaseDetails { get; set; }

        /// <summary>
        /// Gets or Sets SalesDetails
        /// </summary>
        [DataMember(Name="SalesDetails", EmitDefaultValue=false)]
        public Purchase SalesDetails { get; set; }

        /// <summary>
        /// True for items that are tracked as inventory. An item will be tracked as inventory if the InventoryAssetAccountCode and COGSAccountCode are set.
        /// </summary>
        /// <value>True for items that are tracked as inventory. An item will be tracked as inventory if the InventoryAssetAccountCode and COGSAccountCode are set.</value>
        [DataMember(Name="IsTrackedAsInventory", EmitDefaultValue=false)]
        public bool? IsTrackedAsInventory { get; set; }

        /// <summary>
        /// The value of the item on hand. Calculated using average cost accounting.
        /// </summary>
        /// <value>The value of the item on hand. Calculated using average cost accounting.</value>
        [DataMember(Name="TotalCostPool", EmitDefaultValue=false)]
        public decimal? TotalCostPool { get; set; }

        /// <summary>
        /// The quantity of the item on hand
        /// </summary>
        /// <value>The quantity of the item on hand</value>
        [DataMember(Name="QuantityOnHand", EmitDefaultValue=false)]
        public decimal? QuantityOnHand { get; set; }

        /// <summary>
        /// Last modified date in UTC format
        /// </summary>
        /// <value>Last modified date in UTC format</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// The Xero identifier for an Item
        /// </summary>
        /// <value>The Xero identifier for an Item</value>
        [DataMember(Name="ItemID", EmitDefaultValue=false)]
        public Guid? ItemID { get; set; }

        /// <summary>
        /// Status of object
        /// </summary>
        /// <value>Status of object</value>
        [DataMember(Name="StatusAttributeString", EmitDefaultValue=false)]
        public string StatusAttributeString { get; set; }

        /// <summary>
        /// Displays array of validation error messages from the API
        /// </summary>
        /// <value>Displays array of validation error messages from the API</value>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=false)]
        public List<ValidationError> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  InventoryAssetAccountCode: ").Append(InventoryAssetAccountCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsSold: ").Append(IsSold).Append("\n");
            sb.Append("  IsPurchased: ").Append(IsPurchased).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PurchaseDescription: ").Append(PurchaseDescription).Append("\n");
            sb.Append("  PurchaseDetails: ").Append(PurchaseDetails).Append("\n");
            sb.Append("  SalesDetails: ").Append(SalesDetails).Append("\n");
            sb.Append("  IsTrackedAsInventory: ").Append(IsTrackedAsInventory).Append("\n");
            sb.Append("  TotalCostPool: ").Append(TotalCostPool).Append("\n");
            sb.Append("  QuantityOnHand: ").Append(QuantityOnHand).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  ItemID: ").Append(ItemID).Append("\n");
            sb.Append("  StatusAttributeString: ").Append(StatusAttributeString).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
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
            return this.Equals(input as Item);
        }

        /// <summary>
        /// Returns true if Item instances are equal
        /// </summary>
        /// <param name="input">Instance of Item to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.InventoryAssetAccountCode == input.InventoryAssetAccountCode ||
                    (this.InventoryAssetAccountCode != null &&
                    this.InventoryAssetAccountCode.Equals(input.InventoryAssetAccountCode))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsSold == input.IsSold ||
                    this.IsSold.Equals(input.IsSold)
                ) && 
                (
                    this.IsPurchased == input.IsPurchased ||
                    this.IsPurchased.Equals(input.IsPurchased)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PurchaseDescription == input.PurchaseDescription ||
                    (this.PurchaseDescription != null &&
                    this.PurchaseDescription.Equals(input.PurchaseDescription))
                ) && 
                (
                    this.PurchaseDetails == input.PurchaseDetails ||
                    (this.PurchaseDetails != null &&
                    this.PurchaseDetails.Equals(input.PurchaseDetails))
                ) && 
                (
                    this.SalesDetails == input.SalesDetails ||
                    (this.SalesDetails != null &&
                    this.SalesDetails.Equals(input.SalesDetails))
                ) && 
                (
                    this.IsTrackedAsInventory == input.IsTrackedAsInventory ||
                    this.IsTrackedAsInventory.Equals(input.IsTrackedAsInventory)
                ) && 
                (
                    this.TotalCostPool == input.TotalCostPool ||
                    this.TotalCostPool.Equals(input.TotalCostPool)
                ) && 
                (
                    this.QuantityOnHand == input.QuantityOnHand ||
                    this.QuantityOnHand.Equals(input.QuantityOnHand)
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.ItemID == input.ItemID ||
                    (this.ItemID != null &&
                    this.ItemID.Equals(input.ItemID))
                ) && 
                (
                    this.StatusAttributeString == input.StatusAttributeString ||
                    (this.StatusAttributeString != null &&
                    this.StatusAttributeString.Equals(input.StatusAttributeString))
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.InventoryAssetAccountCode != null)
                    hashCode = hashCode * 59 + this.InventoryAssetAccountCode.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.IsSold.GetHashCode();
                hashCode = hashCode * 59 + this.IsPurchased.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PurchaseDescription != null)
                    hashCode = hashCode * 59 + this.PurchaseDescription.GetHashCode();
                if (this.PurchaseDetails != null)
                    hashCode = hashCode * 59 + this.PurchaseDetails.GetHashCode();
                if (this.SalesDetails != null)
                    hashCode = hashCode * 59 + this.SalesDetails.GetHashCode();
                hashCode = hashCode * 59 + this.IsTrackedAsInventory.GetHashCode();
                hashCode = hashCode * 59 + this.TotalCostPool.GetHashCode();
                hashCode = hashCode * 59 + this.QuantityOnHand.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.ItemID != null)
                    hashCode = hashCode * 59 + this.ItemID.GetHashCode();
                if (this.StatusAttributeString != null)
                    hashCode = hashCode * 59 + this.StatusAttributeString.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
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
            // Code (string) maxLength
            if(this.Code != null && this.Code.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 30.", new [] { "Code" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 50.", new [] { "Name" });
            }

            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 4000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 4000.", new [] { "Description" });
            }

            // PurchaseDescription (string) maxLength
            if(this.PurchaseDescription != null && this.PurchaseDescription.Length > 4000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PurchaseDescription, length must be less than 4000.", new [] { "PurchaseDescription" });
            }

            yield break;
        }
    }

}
