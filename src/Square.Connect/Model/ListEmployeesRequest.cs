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
    /// Retrieve a paged-list of employees for a Square account
    /// </summary>
    [DataContract]
    public partial class ListEmployeesRequest :  IEquatable<ListEmployeesRequest>, IValidatableObject
    {
        /// <summary>
        /// Specifies the EmployeeStatus to filter the employee by.
        /// </summary>
        /// <value>Specifies the EmployeeStatus to filter the employee by.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum ACTIVE for "ACTIVE"
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE,
            
            /// <summary>
            /// Enum INACTIVE for "INACTIVE"
            /// </summary>
            [EnumMember(Value = "INACTIVE")]
            INACTIVE
        }

        /// <summary>
        /// Specifies the EmployeeStatus to filter the employee by.
        /// </summary>
        /// <value>Specifies the EmployeeStatus to filter the employee by.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListEmployeesRequest" /> class.
        /// </summary>
        /// <param name="LocationId">Filter employees returned to only those that are associated with the specified location..</param>
        /// <param name="Status">Specifies the EmployeeStatus to filter the employee by..</param>
        /// <param name="Limit">The number of employees to be returned on each page..</param>
        /// <param name="Cursor">The token required to retrieve the specified page of results..</param>
        public ListEmployeesRequest(string LocationId = default(string), StatusEnum? Status = default(StatusEnum?), int? Limit = default(int?), string Cursor = default(string))
        {
            this.LocationId = LocationId;
            this.Status = Status;
            this.Limit = Limit;
            this.Cursor = Cursor;
        }
        
        /// <summary>
        /// Filter employees returned to only those that are associated with the specified location.
        /// </summary>
        /// <value>Filter employees returned to only those that are associated with the specified location.</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public string LocationId { get; set; }
        /// <summary>
        /// The number of employees to be returned on each page.
        /// </summary>
        /// <value>The number of employees to be returned on each page.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }
        /// <summary>
        /// The token required to retrieve the specified page of results.
        /// </summary>
        /// <value>The token required to retrieve the specified page of results.</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEmployeesRequest {\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(obj as ListEmployeesRequest);
        }

        /// <summary>
        /// Returns true if ListEmployeesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ListEmployeesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListEmployeesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
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
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
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
