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
    /// Defines GenderEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GenderEnum
    {
        /// <summary>
        /// Enum MALE for value: MALE
        /// </summary>
        [EnumMember(Value = "MALE")]
        MALE = 1,

        /// <summary>
        /// Enum FEMALE for value: FEMALE
        /// </summary>
        [EnumMember(Value = "FEMALE")]
        FEMALE = 2,

        /// <summary>
        /// Enum NONBINARY for value: NON-BINARY
        /// </summary>
        [EnumMember(Value = "NON-BINARY")]
        NONBINARY = 3,

        /// <summary>
        /// Enum OTHER for value: OTHER
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER = 4,

        /// <summary>
        /// Enum PREFERNOTTODISCLOSE for value: PREFER_NOT_TO_DISCLOSE
        /// </summary>
        [EnumMember(Value = "PREFER_NOT_TO_DISCLOSE")]
        PREFERNOTTODISCLOSE = 5

    }

}