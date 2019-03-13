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
    /// <value></value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum V1PageCellObjectType
    {
        
        /// <summary>
        /// Enum ITEM for "ITEM"
        /// </summary>
        [EnumMember(Value = "ITEM")]
        ITEM,
        
        /// <summary>
        /// Enum DISCOUNT for "DISCOUNT"
        /// </summary>
        [EnumMember(Value = "DISCOUNT")]
        DISCOUNT,
        
        /// <summary>
        /// Enum CATEGORY for "CATEGORY"
        /// </summary>
        [EnumMember(Value = "CATEGORY")]
        CATEGORY,
        
        /// <summary>
        /// Enum PLACEHOLDER for "PLACEHOLDER"
        /// </summary>
        [EnumMember(Value = "PLACEHOLDER")]
        PLACEHOLDER
    }

}
