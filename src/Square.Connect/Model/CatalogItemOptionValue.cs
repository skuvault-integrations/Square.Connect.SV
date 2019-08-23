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
    /// An enumerated value that can link a [CatalogItemVariation(#type-catalogitemvariation) to an item option as one of its item option values.
    /// </summary>
    [DataContract]
    public partial class CatalogItemOptionValue :  IEquatable<CatalogItemOptionValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogItemOptionValue" /> class.
        /// </summary>
        /// <param name="ItemOptionId">Unique ID of the associated item option..</param>
        /// <param name="Name">Name of this item option value. Searchable..</param>
        /// <param name="Description">The option value&#39;s human-readable description..</param>
        /// <param name="Color">The HTML color for this value in the format #FFRRGGBB or #RRGGBB (e.g., \&quot;#ff8d4e85\&quot;). Only displayed if parent Item Option&#39;s &#x60;show_colors&#x60; flag is enabled. value..</param>
        /// <param name="Ordinal">Determines where this option value appears in a list of option values..</param>
        /// <param name="ItemVariationCount">The number of [CatalogItemVariation(#type-catalogitemvariation)s that currently make use of this Item Option value. Present only if &#x60;retrieve_counts&#x60; was specified on the request used to retrieve the parent Item Option of this value.  Maximum: 100 counts..</param>
        public CatalogItemOptionValue(string ItemOptionId = default(string), string Name = default(string), string Description = default(string), string Color = default(string), int? Ordinal = default(int?), long? ItemVariationCount = default(long?))
        {
            this.ItemOptionId = ItemOptionId;
            this.Name = Name;
            this.Description = Description;
            this.Color = Color;
            this.Ordinal = Ordinal;
            this.ItemVariationCount = ItemVariationCount;
        }
        
        /// <summary>
        /// Unique ID of the associated item option.
        /// </summary>
        /// <value>Unique ID of the associated item option.</value>
        [DataMember(Name="item_option_id", EmitDefaultValue=false)]
        public string ItemOptionId { get; set; }
        /// <summary>
        /// Name of this item option value. Searchable.
        /// </summary>
        /// <value>Name of this item option value. Searchable.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The option value&#39;s human-readable description.
        /// </summary>
        /// <value>The option value&#39;s human-readable description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The HTML color for this value in the format #FFRRGGBB or #RRGGBB (e.g., \&quot;#ff8d4e85\&quot;). Only displayed if parent Item Option&#39;s &#x60;show_colors&#x60; flag is enabled. value.
        /// </summary>
        /// <value>The HTML color for this value in the format #FFRRGGBB or #RRGGBB (e.g., \&quot;#ff8d4e85\&quot;). Only displayed if parent Item Option&#39;s &#x60;show_colors&#x60; flag is enabled. value.</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }
        /// <summary>
        /// Determines where this option value appears in a list of option values.
        /// </summary>
        /// <value>Determines where this option value appears in a list of option values.</value>
        [DataMember(Name="ordinal", EmitDefaultValue=false)]
        public int? Ordinal { get; set; }
        /// <summary>
        /// The number of [CatalogItemVariation(#type-catalogitemvariation)s that currently make use of this Item Option value. Present only if &#x60;retrieve_counts&#x60; was specified on the request used to retrieve the parent Item Option of this value.  Maximum: 100 counts.
        /// </summary>
        /// <value>The number of [CatalogItemVariation(#type-catalogitemvariation)s that currently make use of this Item Option value. Present only if &#x60;retrieve_counts&#x60; was specified on the request used to retrieve the parent Item Option of this value.  Maximum: 100 counts.</value>
        [DataMember(Name="item_variation_count", EmitDefaultValue=false)]
        public long? ItemVariationCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogItemOptionValue {\n");
            sb.Append("  ItemOptionId: ").Append(ItemOptionId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Ordinal: ").Append(Ordinal).Append("\n");
            sb.Append("  ItemVariationCount: ").Append(ItemVariationCount).Append("\n");
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
            return this.Equals(obj as CatalogItemOptionValue);
        }

        /// <summary>
        /// Returns true if CatalogItemOptionValue instances are equal
        /// </summary>
        /// <param name="other">Instance of CatalogItemOptionValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogItemOptionValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ItemOptionId == other.ItemOptionId ||
                    this.ItemOptionId != null &&
                    this.ItemOptionId.Equals(other.ItemOptionId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.Ordinal == other.Ordinal ||
                    this.Ordinal != null &&
                    this.Ordinal.Equals(other.Ordinal)
                ) && 
                (
                    this.ItemVariationCount == other.ItemVariationCount ||
                    this.ItemVariationCount != null &&
                    this.ItemVariationCount.Equals(other.ItemVariationCount)
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
                if (this.ItemOptionId != null)
                    hash = hash * 59 + this.ItemOptionId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.Ordinal != null)
                    hash = hash * 59 + this.Ordinal.GetHashCode();
                if (this.ItemVariationCount != null)
                    hash = hash * 59 + this.ItemVariationCount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}