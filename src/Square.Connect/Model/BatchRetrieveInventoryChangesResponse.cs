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
    /// 
    /// </summary>
    [DataContract]
    public partial class BatchRetrieveInventoryChangesResponse :  IEquatable<BatchRetrieveInventoryChangesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRetrieveInventoryChangesResponse" /> class.
        /// </summary>
        /// <param name="Errors">Any errors that occurred during the request..</param>
        /// <param name="Changes">The current calculated inventory changes for the requested objects and locations..</param>
        /// <param name="Cursor">The pagination cursor to be used in a subsequent request. If unset, this is the final response. See [Pagination](/basics/api101/pagination) for more information..</param>
        public BatchRetrieveInventoryChangesResponse(List<Error> Errors = default(List<Error>), List<InventoryChange> Changes = default(List<InventoryChange>), string Cursor = default(string))
        {
            this.Errors = Errors;
            this.Changes = Changes;
            this.Cursor = Cursor;
        }
        
        /// <summary>
        /// Any errors that occurred during the request.
        /// </summary>
        /// <value>Any errors that occurred during the request.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<Error> Errors { get; set; }
        /// <summary>
        /// The current calculated inventory changes for the requested objects and locations.
        /// </summary>
        /// <value>The current calculated inventory changes for the requested objects and locations.</value>
        [DataMember(Name="changes", EmitDefaultValue=false)]
        public List<InventoryChange> Changes { get; set; }
        /// <summary>
        /// The pagination cursor to be used in a subsequent request. If unset, this is the final response. See [Pagination](/basics/api101/pagination) for more information.
        /// </summary>
        /// <value>The pagination cursor to be used in a subsequent request. If unset, this is the final response. See [Pagination](/basics/api101/pagination) for more information.</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchRetrieveInventoryChangesResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
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
            return this.Equals(obj as BatchRetrieveInventoryChangesResponse);
        }

        /// <summary>
        /// Returns true if BatchRetrieveInventoryChangesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchRetrieveInventoryChangesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchRetrieveInventoryChangesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    this.Changes == other.Changes ||
                    this.Changes != null &&
                    this.Changes.SequenceEqual(other.Changes)
                ) && 
                (
                    this.Cursor == other.Cursor ||
                    this.Cursor != null &&
                    this.Cursor.Equals(other.Cursor)
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
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                if (this.Changes != null)
                    hash = hash * 59 + this.Changes.GetHashCode();
                if (this.Cursor != null)
                    hash = hash * 59 + this.Cursor.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
