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
    /// V1OrderHistoryEntry
    /// </summary>
    [DataContract]
    public partial class V1OrderHistoryEntry :  IEquatable<V1OrderHistoryEntry>, IValidatableObject
    {
        /// <summary>
        /// The type of action performed on the order. See [V1OrderHistoryEntryAction](#type-v1orderhistoryentryaction) for possible values
        /// </summary>
        /// <value>The type of action performed on the order. See [V1OrderHistoryEntryAction](#type-v1orderhistoryentryaction) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum ORDERPLACED for "ORDER_PLACED"
            /// </summary>
            [EnumMember(Value = "ORDER_PLACED")]
            ORDERPLACED,
            
            /// <summary>
            /// Enum DECLINED for "DECLINED"
            /// </summary>
            [EnumMember(Value = "DECLINED")]
            DECLINED,
            
            /// <summary>
            /// Enum PAYMENTRECEIVED for "PAYMENT_RECEIVED"
            /// </summary>
            [EnumMember(Value = "PAYMENT_RECEIVED")]
            PAYMENTRECEIVED,
            
            /// <summary>
            /// Enum CANCELED for "CANCELED"
            /// </summary>
            [EnumMember(Value = "CANCELED")]
            CANCELED,
            
            /// <summary>
            /// Enum COMPLETED for "COMPLETED"
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED,
            
            /// <summary>
            /// Enum REFUNDED for "REFUNDED"
            /// </summary>
            [EnumMember(Value = "REFUNDED")]
            REFUNDED,
            
            /// <summary>
            /// Enum EXPIRED for "EXPIRED"
            /// </summary>
            [EnumMember(Value = "EXPIRED")]
            EXPIRED
        }

        /// <summary>
        /// The type of action performed on the order. See [V1OrderHistoryEntryAction](#type-v1orderhistoryentryaction) for possible values
        /// </summary>
        /// <value>The type of action performed on the order. See [V1OrderHistoryEntryAction](#type-v1orderhistoryentryaction) for possible values</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1OrderHistoryEntry" /> class.
        /// </summary>
        /// <param name="Action">The type of action performed on the order. See [V1OrderHistoryEntryAction](#type-v1orderhistoryentryaction) for possible values.</param>
        /// <param name="CreatedAt">The time when the action was performed, in ISO 8601 format..</param>
        public V1OrderHistoryEntry(ActionEnum? Action = default(ActionEnum?), string CreatedAt = default(string))
        {
            this.Action = Action;
            this.CreatedAt = CreatedAt;
        }
        
        /// <summary>
        /// The time when the action was performed, in ISO 8601 format.
        /// </summary>
        /// <value>The time when the action was performed, in ISO 8601 format.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1OrderHistoryEntry {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(obj as V1OrderHistoryEntry);
        }

        /// <summary>
        /// Returns true if V1OrderHistoryEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of V1OrderHistoryEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1OrderHistoryEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
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
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
