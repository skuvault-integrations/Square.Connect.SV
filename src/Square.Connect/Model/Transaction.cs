/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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

namespace Square.Connect.Model
{
    /// <summary>
    /// Represents a transaction processed with Square, either with the Connect API or with Square Point of Sale.  The &#x60;tenders&#x60; field of this object lists all methods of payment used to pay in the transaction.
    /// </summary>
    [DataContract]
    public partial class Transaction :  IEquatable<Transaction>, IValidatableObject
    {
        /// <summary>
        /// The Square product that processed the transaction.
        /// </summary>
        /// <value>The Square product that processed the transaction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProductEnum
        {
            
            /// <summary>
            /// Enum REGISTER for "REGISTER"
            /// </summary>
            [EnumMember(Value = "REGISTER")]
            REGISTER,
            
            /// <summary>
            /// Enum EXTERNALAPI for "EXTERNAL_API"
            /// </summary>
            [EnumMember(Value = "EXTERNAL_API")]
            EXTERNALAPI,
            
            /// <summary>
            /// Enum BILLING for "BILLING"
            /// </summary>
            [EnumMember(Value = "BILLING")]
            BILLING,
            
            /// <summary>
            /// Enum APPOINTMENTS for "APPOINTMENTS"
            /// </summary>
            [EnumMember(Value = "APPOINTMENTS")]
            APPOINTMENTS,
            
            /// <summary>
            /// Enum INVOICES for "INVOICES"
            /// </summary>
            [EnumMember(Value = "INVOICES")]
            INVOICES,
            
            /// <summary>
            /// Enum ONLINESTORE for "ONLINE_STORE"
            /// </summary>
            [EnumMember(Value = "ONLINE_STORE")]
            ONLINESTORE,
            
            /// <summary>
            /// Enum PAYROLL for "PAYROLL"
            /// </summary>
            [EnumMember(Value = "PAYROLL")]
            PAYROLL,
            
            /// <summary>
            /// Enum OTHER for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER
        }

        /// <summary>
        /// The Square product that processed the transaction.
        /// </summary>
        /// <value>The Square product that processed the transaction.</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public ProductEnum? Product { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        /// <param name="Id">The transaction&#39;s unique ID, issued by Square payments servers..</param>
        /// <param name="LocationId">The ID of the transaction&#39;s associated location..</param>
        /// <param name="CreatedAt">The time when the transaction was created, in RFC 3339 format..</param>
        /// <param name="Tenders">The tenders used to pay in the transaction..</param>
        /// <param name="Refunds">Refunds that have been applied to any tender in the transaction..</param>
        /// <param name="ReferenceId">If the transaction was created with the [Charge](#endpoint-charge) endpoint, this value is the same as the value provided for the &#x60;reference_id&#x60; parameter in the request to that endpoint. Otherwise, it is not set..</param>
        /// <param name="Product">The Square product that processed the transaction..</param>
        /// <param name="ClientId">If the transaction was created in the Square Point of Sale app, this value is the ID generated for the transaction by Square Point of Sale.  This ID has no relationship to the transaction&#39;s canonical &#x60;id&#x60;, which is generated by Square&#39;s backend servers. This value is generated for bookkeeping purposes, in case the transaction cannot immediately be completed (for example, if the transaction is processed in offline mode).  It is not currently possible with the Connect API to perform a transaction lookup by this value..</param>
        /// <param name="ShippingAddress">The shipping address provided in the request, if any..</param>
        /// <param name="OrderId">The order_id is an identifier for the order associated with this transaction, if any..</param>
        public Transaction(string Id = default(string), string LocationId = default(string), string CreatedAt = default(string), List<Tender> Tenders = default(List<Tender>), List<Refund> Refunds = default(List<Refund>), string ReferenceId = default(string), ProductEnum? Product = default(ProductEnum?), string ClientId = default(string), Address ShippingAddress = default(Address), string OrderId = default(string))
        {
            this.Id = Id;
            this.LocationId = LocationId;
            this.CreatedAt = CreatedAt;
            this.Tenders = Tenders;
            this.Refunds = Refunds;
            this.ReferenceId = ReferenceId;
            this.Product = Product;
            this.ClientId = ClientId;
            this.ShippingAddress = ShippingAddress;
            this.OrderId = OrderId;
        }
        
        /// <summary>
        /// The transaction&#39;s unique ID, issued by Square payments servers.
        /// </summary>
        /// <value>The transaction&#39;s unique ID, issued by Square payments servers.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The ID of the transaction&#39;s associated location.
        /// </summary>
        /// <value>The ID of the transaction&#39;s associated location.</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public string LocationId { get; set; }
        /// <summary>
        /// The time when the transaction was created, in RFC 3339 format.
        /// </summary>
        /// <value>The time when the transaction was created, in RFC 3339 format.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// The tenders used to pay in the transaction.
        /// </summary>
        /// <value>The tenders used to pay in the transaction.</value>
        [DataMember(Name="tenders", EmitDefaultValue=false)]
        public List<Tender> Tenders { get; set; }
        /// <summary>
        /// Refunds that have been applied to any tender in the transaction.
        /// </summary>
        /// <value>Refunds that have been applied to any tender in the transaction.</value>
        [DataMember(Name="refunds", EmitDefaultValue=false)]
        public List<Refund> Refunds { get; set; }
        /// <summary>
        /// If the transaction was created with the [Charge](#endpoint-charge) endpoint, this value is the same as the value provided for the &#x60;reference_id&#x60; parameter in the request to that endpoint. Otherwise, it is not set.
        /// </summary>
        /// <value>If the transaction was created with the [Charge](#endpoint-charge) endpoint, this value is the same as the value provided for the &#x60;reference_id&#x60; parameter in the request to that endpoint. Otherwise, it is not set.</value>
        [DataMember(Name="reference_id", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }
        /// <summary>
        /// If the transaction was created in the Square Point of Sale app, this value is the ID generated for the transaction by Square Point of Sale.  This ID has no relationship to the transaction&#39;s canonical &#x60;id&#x60;, which is generated by Square&#39;s backend servers. This value is generated for bookkeeping purposes, in case the transaction cannot immediately be completed (for example, if the transaction is processed in offline mode).  It is not currently possible with the Connect API to perform a transaction lookup by this value.
        /// </summary>
        /// <value>If the transaction was created in the Square Point of Sale app, this value is the ID generated for the transaction by Square Point of Sale.  This ID has no relationship to the transaction&#39;s canonical &#x60;id&#x60;, which is generated by Square&#39;s backend servers. This value is generated for bookkeeping purposes, in case the transaction cannot immediately be completed (for example, if the transaction is processed in offline mode).  It is not currently possible with the Connect API to perform a transaction lookup by this value.</value>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public string ClientId { get; set; }
        /// <summary>
        /// The shipping address provided in the request, if any.
        /// </summary>
        /// <value>The shipping address provided in the request, if any.</value>
        [DataMember(Name="shipping_address", EmitDefaultValue=false)]
        public Address ShippingAddress { get; set; }
        /// <summary>
        /// The order_id is an identifier for the order associated with this transaction, if any.
        /// </summary>
        /// <value>The order_id is an identifier for the order associated with this transaction, if any.</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Tenders: ").Append(Tenders).Append("\n");
            sb.Append("  Refunds: ").Append(Refunds).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Transaction);
        }

        /// <summary>
        /// Returns true if Transaction instances are equal
        /// </summary>
        /// <param name="other">Instance of Transaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transaction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Tenders == other.Tenders ||
                    this.Tenders != null &&
                    this.Tenders.SequenceEqual(other.Tenders)
                ) && 
                (
                    this.Refunds == other.Refunds ||
                    this.Refunds != null &&
                    this.Refunds.SequenceEqual(other.Refunds)
                ) && 
                (
                    this.ReferenceId == other.ReferenceId ||
                    this.ReferenceId != null &&
                    this.ReferenceId.Equals(other.ReferenceId)
                ) && 
                (
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
                ) && 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.ShippingAddress == other.ShippingAddress ||
                    this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(other.ShippingAddress)
                ) && 
                (
                    this.OrderId == other.OrderId ||
                    this.OrderId != null &&
                    this.OrderId.Equals(other.OrderId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Tenders != null)
                    hash = hash * 59 + this.Tenders.GetHashCode();
                if (this.Refunds != null)
                    hash = hash * 59 + this.Refunds.GetHashCode();
                if (this.ReferenceId != null)
                    hash = hash * 59 + this.ReferenceId.GetHashCode();
                if (this.Product != null)
                    hash = hash * 59 + this.Product.GetHashCode();
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                if (this.ShippingAddress != null)
                    hash = hash * 59 + this.ShippingAddress.GetHashCode();
                if (this.OrderId != null)
                    hash = hash * 59 + this.OrderId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
