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
    /// Represents a set of [&#x60;CustomerQuery&#x60;](#type-customerquery) filters used to limit the set of Customers returned by [&#x60;SearchCustomers&#x60;](#endpoint-seachcustomers).
    /// </summary>
    [DataContract]
    public partial class CustomerFilter :  IEquatable<CustomerFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerFilter" /> class.
        /// </summary>
        /// <param name="CreationSource">A filter to select customers based on their creation source..</param>
        /// <param name="CreatedAt">A filter to select customers based on when they were created..</param>
        /// <param name="UpdatedAt">A filter to select customers based on when they were updated..</param>
        public CustomerFilter(CustomerCreationSourceFilter CreationSource = default(CustomerCreationSourceFilter), TimeRange CreatedAt = default(TimeRange), TimeRange UpdatedAt = default(TimeRange))
        {
            this.CreationSource = CreationSource;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// A filter to select customers based on their creation source.
        /// </summary>
        /// <value>A filter to select customers based on their creation source.</value>
        [DataMember(Name="creation_source", EmitDefaultValue=false)]
        public CustomerCreationSourceFilter CreationSource { get; set; }
        /// <summary>
        /// A filter to select customers based on when they were created.
        /// </summary>
        /// <value>A filter to select customers based on when they were created.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public TimeRange CreatedAt { get; set; }
        /// <summary>
        /// A filter to select customers based on when they were updated.
        /// </summary>
        /// <value>A filter to select customers based on when they were updated.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public TimeRange UpdatedAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerFilter {\n");
            sb.Append("  CreationSource: ").Append(CreationSource).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(obj as CustomerFilter);
        }

        /// <summary>
        /// Returns true if CustomerFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CreationSource == other.CreationSource ||
                    this.CreationSource != null &&
                    this.CreationSource.Equals(other.CreationSource)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
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
                if (this.CreationSource != null)
                    hash = hash * 59 + this.CreationSource.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}