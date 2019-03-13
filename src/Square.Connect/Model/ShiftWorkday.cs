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
    /// A &#x60;Shift&#x60; search query filter parameter that sets a range of days that  a &#x60;Shift&#x60; must start or end in before passing the filter condition.
    /// </summary>
    [DataContract]
    public partial class ShiftWorkday :  IEquatable<ShiftWorkday>, IValidatableObject
    {
        /// <summary>
        /// The strategy on which the dates are applied.
        /// </summary>
        /// <value>The strategy on which the dates are applied.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MatchShiftsByEnum
        {
            
            /// <summary>
            /// Enum STARTAT for "START_AT"
            /// </summary>
            [EnumMember(Value = "START_AT")]
            STARTAT,
            
            /// <summary>
            /// Enum ENDAT for "END_AT"
            /// </summary>
            [EnumMember(Value = "END_AT")]
            ENDAT,
            
            /// <summary>
            /// Enum INTERSECTION for "INTERSECTION"
            /// </summary>
            [EnumMember(Value = "INTERSECTION")]
            INTERSECTION
        }

        /// <summary>
        /// The strategy on which the dates are applied.
        /// </summary>
        /// <value>The strategy on which the dates are applied.</value>
        [DataMember(Name="match_shifts_by", EmitDefaultValue=false)]
        public MatchShiftsByEnum? MatchShiftsBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftWorkday" /> class.
        /// </summary>
        /// <param name="DateRange">Dates for fetching the shifts.</param>
        /// <param name="MatchShiftsBy">The strategy on which the dates are applied..</param>
        /// <param name="DefaultTimezone">Location-specific timezones convert workdays to datetime filters. Every location included in the query must have a timezone, or this field must be provided as a fallback. Format: the IANA timezone database identifier for the relevant timezone..</param>
        public ShiftWorkday(DateRange DateRange = default(DateRange), MatchShiftsByEnum? MatchShiftsBy = default(MatchShiftsByEnum?), string DefaultTimezone = default(string))
        {
            this.DateRange = DateRange;
            this.MatchShiftsBy = MatchShiftsBy;
            this.DefaultTimezone = DefaultTimezone;
        }
        
        /// <summary>
        /// Dates for fetching the shifts
        /// </summary>
        /// <value>Dates for fetching the shifts</value>
        [DataMember(Name="date_range", EmitDefaultValue=false)]
        public DateRange DateRange { get; set; }
        /// <summary>
        /// Location-specific timezones convert workdays to datetime filters. Every location included in the query must have a timezone, or this field must be provided as a fallback. Format: the IANA timezone database identifier for the relevant timezone.
        /// </summary>
        /// <value>Location-specific timezones convert workdays to datetime filters. Every location included in the query must have a timezone, or this field must be provided as a fallback. Format: the IANA timezone database identifier for the relevant timezone.</value>
        [DataMember(Name="default_timezone", EmitDefaultValue=false)]
        public string DefaultTimezone { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftWorkday {\n");
            sb.Append("  DateRange: ").Append(DateRange).Append("\n");
            sb.Append("  MatchShiftsBy: ").Append(MatchShiftsBy).Append("\n");
            sb.Append("  DefaultTimezone: ").Append(DefaultTimezone).Append("\n");
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
            return this.Equals(obj as ShiftWorkday);
        }

        /// <summary>
        /// Returns true if ShiftWorkday instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftWorkday to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftWorkday other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DateRange == other.DateRange ||
                    this.DateRange != null &&
                    this.DateRange.Equals(other.DateRange)
                ) && 
                (
                    this.MatchShiftsBy == other.MatchShiftsBy ||
                    this.MatchShiftsBy != null &&
                    this.MatchShiftsBy.Equals(other.MatchShiftsBy)
                ) && 
                (
                    this.DefaultTimezone == other.DefaultTimezone ||
                    this.DefaultTimezone != null &&
                    this.DefaultTimezone.Equals(other.DefaultTimezone)
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
                if (this.DateRange != null)
                    hash = hash * 59 + this.DateRange.GetHashCode();
                if (this.MatchShiftsBy != null)
                    hash = hash * 59 + this.MatchShiftsBy.GetHashCode();
                if (this.DefaultTimezone != null)
                    hash = hash * 59 + this.DefaultTimezone.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
