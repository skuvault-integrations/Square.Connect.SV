/* 
 * Square Connect API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0
 * 
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
    /// Indicates the Square product used to process a transaction.
    /// </summary>
    /// <value>Indicates the Square product used to process a transaction.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionProduct
    {
        
        /// <summary>
        /// Enum REGISTER for "REGISTER"
        /// </summary>
        [EnumMember(Value = "REGISTER")]
        REGISTER,
        
        /// <summary>
        /// Enum EXTERNALAPI for "EXTERNAL_API"
        /// </summary>
        [EnumMember(Value = "EXTERNAL_API")]
        EXTERNALAPI,
        
        /// <summary>
        /// Enum BILLING for "BILLING"
        /// </summary>
        [EnumMember(Value = "BILLING")]
        BILLING,
        
        /// <summary>
        /// Enum APPOINTMENTS for "APPOINTMENTS"
        /// </summary>
        [EnumMember(Value = "APPOINTMENTS")]
        APPOINTMENTS,
        
        /// <summary>
        /// Enum INVOICES for "INVOICES"
        /// </summary>
        [EnumMember(Value = "INVOICES")]
        INVOICES,
        
        /// <summary>
        /// Enum ONLINESTORE for "ONLINE_STORE"
        /// </summary>
        [EnumMember(Value = "ONLINE_STORE")]
        ONLINESTORE,
        
        /// <summary>
        /// Enum PAYROLL for "PAYROLL"
        /// </summary>
        [EnumMember(Value = "PAYROLL")]
        PAYROLL,
        
        /// <summary>
        /// Enum OTHER for "OTHER"
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER
    }

}
