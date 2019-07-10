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
    public partial class V1ListTimecardsRequest :  IEquatable<V1ListTimecardsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListTimecardsRequest" /> class.
        /// </summary>
        /// <param name="Order">The order in which timecards are listed in the response, based on their created_at field. See [SortOrder](#type-sortorder) for possible values.</param>
        /// <param name="EmployeeId">If provided, the endpoint returns only timecards for the employee with the specified ID..</param>
        /// <param name="BeginClockinTime">If filtering results by their clockin_time field, the beginning of the requested reporting period, in ISO 8601 format..</param>
        /// <param name="EndClockinTime">If filtering results by their clockin_time field, the end of the requested reporting period, in ISO 8601 format..</param>
        /// <param name="BeginClockoutTime">If filtering results by their clockout_time field, the beginning of the requested reporting period, in ISO 8601 format..</param>
        /// <param name="EndClockoutTime">If filtering results by their clockout_time field, the end of the requested reporting period, in ISO 8601 format..</param>
        /// <param name="BeginUpdatedAt">If filtering results by their updated_at field, the beginning of the requested reporting period, in ISO 8601 format..</param>
        /// <param name="EndUpdatedAt">If filtering results by their updated_at field, the end of the requested reporting period, in ISO 8601 format..</param>
        /// <param name="Deleted">If true, only deleted timecards are returned. If false, only valid timecards are returned.If you don&#39;t provide this parameter, both valid and deleted timecards are returned..</param>
        /// <param name="Limit">The maximum integer number of employee entities to return in a single response. Default 100, maximum 200..</param>
        /// <param name="BatchToken">A pagination cursor to retrieve the next set of results for your original query to the endpoint..</param>
        public V1ListTimecardsRequest(string Order = default(string), string EmployeeId = default(string), string BeginClockinTime = default(string), string EndClockinTime = default(string), string BeginClockoutTime = default(string), string EndClockoutTime = default(string), string BeginUpdatedAt = default(string), string EndUpdatedAt = default(string), bool? Deleted = default(bool?), int? Limit = default(int?), string BatchToken = default(string))
        {
            this.Order = Order;
            this.EmployeeId = EmployeeId;
            this.BeginClockinTime = BeginClockinTime;
            this.EndClockinTime = EndClockinTime;
            this.BeginClockoutTime = BeginClockoutTime;
            this.EndClockoutTime = EndClockoutTime;
            this.BeginUpdatedAt = BeginUpdatedAt;
            this.EndUpdatedAt = EndUpdatedAt;
            this.Deleted = Deleted;
            this.Limit = Limit;
            this.BatchToken = BatchToken;
        }
        
        /// <summary>
        /// The order in which timecards are listed in the response, based on their created_at field. See [SortOrder](#type-sortorder) for possible values
        /// </summary>
        /// <value>The order in which timecards are listed in the response, based on their created_at field. See [SortOrder](#type-sortorder) for possible values</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
        /// <summary>
        /// If provided, the endpoint returns only timecards for the employee with the specified ID.
        /// </summary>
        /// <value>If provided, the endpoint returns only timecards for the employee with the specified ID.</value>
        [DataMember(Name="employee_id", EmitDefaultValue=false)]
        public string EmployeeId { get; set; }
        /// <summary>
        /// If filtering results by their clockin_time field, the beginning of the requested reporting period, in ISO 8601 format.
        /// </summary>
        /// <value>If filtering results by their clockin_time field, the beginning of the requested reporting period, in ISO 8601 format.</value>
        [DataMember(Name="begin_clockin_time", EmitDefaultValue=false)]
        public string BeginClockinTime { get; set; }
        /// <summary>
        /// If filtering results by their clockin_time field, the end of the requested reporting period, in ISO 8601 format.
        /// </summary>
        /// <value>If filtering results by their clockin_time field, the end of the requested reporting period, in ISO 8601 format.</value>
        [DataMember(Name="end_clockin_time", EmitDefaultValue=false)]
        public string EndClockinTime { get; set; }
        /// <summary>
        /// If filtering results by their clockout_time field, the beginning of the requested reporting period, in ISO 8601 format.
        /// </summary>
        /// <value>If filtering results by their clockout_time field, the beginning of the requested reporting period, in ISO 8601 format.</value>
        [DataMember(Name="begin_clockout_time", EmitDefaultValue=false)]
        public string BeginClockoutTime { get; set; }
        /// <summary>
        /// If filtering results by their clockout_time field, the end of the requested reporting period, in ISO 8601 format.
        /// </summary>
        /// <value>If filtering results by their clockout_time field, the end of the requested reporting period, in ISO 8601 format.</value>
        [DataMember(Name="end_clockout_time", EmitDefaultValue=false)]
        public string EndClockoutTime { get; set; }
        /// <summary>
        /// If filtering results by their updated_at field, the beginning of the requested reporting period, in ISO 8601 format.
        /// </summary>
        /// <value>If filtering results by their updated_at field, the beginning of the requested reporting period, in ISO 8601 format.</value>
        [DataMember(Name="begin_updated_at", EmitDefaultValue=false)]
        public string BeginUpdatedAt { get; set; }
        /// <summary>
        /// If filtering results by their updated_at field, the end of the requested reporting period, in ISO 8601 format.
        /// </summary>
        /// <value>If filtering results by their updated_at field, the end of the requested reporting period, in ISO 8601 format.</value>
        [DataMember(Name="end_updated_at", EmitDefaultValue=false)]
        public string EndUpdatedAt { get; set; }
        /// <summary>
        /// If true, only deleted timecards are returned. If false, only valid timecards are returned.If you don&#39;t provide this parameter, both valid and deleted timecards are returned.
        /// </summary>
        /// <value>If true, only deleted timecards are returned. If false, only valid timecards are returned.If you don&#39;t provide this parameter, both valid and deleted timecards are returned.</value>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }
        /// <summary>
        /// The maximum integer number of employee entities to return in a single response. Default 100, maximum 200.
        /// </summary>
        /// <value>The maximum integer number of employee entities to return in a single response. Default 100, maximum 200.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }
        /// <summary>
        /// A pagination cursor to retrieve the next set of results for your original query to the endpoint.
        /// </summary>
        /// <value>A pagination cursor to retrieve the next set of results for your original query to the endpoint.</value>
        [DataMember(Name="batch_token", EmitDefaultValue=false)]
        public string BatchToken { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1ListTimecardsRequest {\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  BeginClockinTime: ").Append(BeginClockinTime).Append("\n");
            sb.Append("  EndClockinTime: ").Append(EndClockinTime).Append("\n");
            sb.Append("  BeginClockoutTime: ").Append(BeginClockoutTime).Append("\n");
            sb.Append("  EndClockoutTime: ").Append(EndClockoutTime).Append("\n");
            sb.Append("  BeginUpdatedAt: ").Append(BeginUpdatedAt).Append("\n");
            sb.Append("  EndUpdatedAt: ").Append(EndUpdatedAt).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  BatchToken: ").Append(BatchToken).Append("\n");
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
            return this.Equals(obj as V1ListTimecardsRequest);
        }

        /// <summary>
        /// Returns true if V1ListTimecardsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of V1ListTimecardsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1ListTimecardsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.EmployeeId == other.EmployeeId ||
                    this.EmployeeId != null &&
                    this.EmployeeId.Equals(other.EmployeeId)
                ) && 
                (
                    this.BeginClockinTime == other.BeginClockinTime ||
                    this.BeginClockinTime != null &&
                    this.BeginClockinTime.Equals(other.BeginClockinTime)
                ) && 
                (
                    this.EndClockinTime == other.EndClockinTime ||
                    this.EndClockinTime != null &&
                    this.EndClockinTime.Equals(other.EndClockinTime)
                ) && 
                (
                    this.BeginClockoutTime == other.BeginClockoutTime ||
                    this.BeginClockoutTime != null &&
                    this.BeginClockoutTime.Equals(other.BeginClockoutTime)
                ) && 
                (
                    this.EndClockoutTime == other.EndClockoutTime ||
                    this.EndClockoutTime != null &&
                    this.EndClockoutTime.Equals(other.EndClockoutTime)
                ) && 
                (
                    this.BeginUpdatedAt == other.BeginUpdatedAt ||
                    this.BeginUpdatedAt != null &&
                    this.BeginUpdatedAt.Equals(other.BeginUpdatedAt)
                ) && 
                (
                    this.EndUpdatedAt == other.EndUpdatedAt ||
                    this.EndUpdatedAt != null &&
                    this.EndUpdatedAt.Equals(other.EndUpdatedAt)
                ) && 
                (
                    this.Deleted == other.Deleted ||
                    this.Deleted != null &&
                    this.Deleted.Equals(other.Deleted)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.BatchToken == other.BatchToken ||
                    this.BatchToken != null &&
                    this.BatchToken.Equals(other.BatchToken)
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
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                if (this.EmployeeId != null)
                    hash = hash * 59 + this.EmployeeId.GetHashCode();
                if (this.BeginClockinTime != null)
                    hash = hash * 59 + this.BeginClockinTime.GetHashCode();
                if (this.EndClockinTime != null)
                    hash = hash * 59 + this.EndClockinTime.GetHashCode();
                if (this.BeginClockoutTime != null)
                    hash = hash * 59 + this.BeginClockoutTime.GetHashCode();
                if (this.EndClockoutTime != null)
                    hash = hash * 59 + this.EndClockoutTime.GetHashCode();
                if (this.BeginUpdatedAt != null)
                    hash = hash * 59 + this.BeginUpdatedAt.GetHashCode();
                if (this.EndUpdatedAt != null)
                    hash = hash * 59 + this.EndUpdatedAt.GetHashCode();
                if (this.Deleted != null)
                    hash = hash * 59 + this.Deleted.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.BatchToken != null)
                    hash = hash * 59 + this.BatchToken.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
