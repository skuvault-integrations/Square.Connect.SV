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
    /// A response to a request to update a &#x60;BreakType&#x60;. Contains the requested &#x60;BreakType&#x60; objects. May contain a set of &#x60;Error&#x60; objects if the request resulted in errors.
    /// </summary>
    [DataContract]
    public partial class UpdateBreakTypeResponse :  IEquatable<UpdateBreakTypeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBreakTypeResponse" /> class.
        /// </summary>
        /// <param name="BreakType">The response object..</param>
        /// <param name="Errors">Any errors that occurred during the request..</param>
        public UpdateBreakTypeResponse(BreakType BreakType = default(BreakType), List<Error> Errors = default(List<Error>))
        {
            this.BreakType = BreakType;
            this.Errors = Errors;
        }
        
        /// <summary>
        /// The response object.
        /// </summary>
        /// <value>The response object.</value>
        [DataMember(Name="break_type", EmitDefaultValue=false)]
        public BreakType BreakType { get; set; }
        /// <summary>
        /// Any errors that occurred during the request.
        /// </summary>
        /// <value>Any errors that occurred during the request.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<Error> Errors { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateBreakTypeResponse {\n");
            sb.Append("  BreakType: ").Append(BreakType).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(obj as UpdateBreakTypeResponse);
        }

        /// <summary>
        /// Returns true if UpdateBreakTypeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateBreakTypeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateBreakTypeResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BreakType == other.BreakType ||
                    this.BreakType != null &&
                    this.BreakType.Equals(other.BreakType)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
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
                if (this.BreakType != null)
                    hash = hash * 59 + this.BreakType.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
