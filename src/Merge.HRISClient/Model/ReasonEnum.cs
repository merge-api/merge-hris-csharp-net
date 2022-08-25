/*
 * Merge HRIS API
 *
 * The unified API for building rich integrations with multiple HR Information System platforms.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: hello@merge.dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Merge.HRISClient.Client.OpenAPIDateConverter;

namespace Merge.HRISClient.Model
{
    /// <summary>
    /// Defines ReasonEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReasonEnum
    {
        /// <summary>
        /// Enum GENERALCUSTOMERREQUEST for value: GENERAL_CUSTOMER_REQUEST
        /// </summary>
        [EnumMember(Value = "GENERAL_CUSTOMER_REQUEST")]
        GENERALCUSTOMERREQUEST = 1,

        /// <summary>
        /// Enum GDPR for value: GDPR
        /// </summary>
        [EnumMember(Value = "GDPR")]
        GDPR = 2,

        /// <summary>
        /// Enum OTHER for value: OTHER
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER = 3

    }

}
