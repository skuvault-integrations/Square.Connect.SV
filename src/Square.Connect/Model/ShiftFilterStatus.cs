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
    /// Specifies the `status` of `Shift` records to be returned.
    /// </summary>
    /// <value>Specifies the `status` of `Shift` records to be returned.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShiftFilterStatus
    {
        
        /// <summary>
        /// Enum OPEN for "OPEN"
        /// </summary>
        [EnumMember(Value = "OPEN")]
        OPEN,
        
        /// <summary>
        /// Enum CLOSED for "CLOSED"
        /// </summary>
        [EnumMember(Value = "CLOSED")]
        CLOSED
    }

}
