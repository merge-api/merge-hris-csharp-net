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
    /// Defines EthnicityEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EthnicityEnum
    {
        /// <summary>
        /// Enum AMERICANINDIANORALASKANATIVE for value: AMERICAN_INDIAN_OR_ALASKA_NATIVE
        /// </summary>
        [EnumMember(Value = "AMERICAN_INDIAN_OR_ALASKA_NATIVE")]
        AMERICANINDIANORALASKANATIVE = 1,

        /// <summary>
        /// Enum ASIANORINDIANSUBCONTINENT for value: ASIAN_OR_INDIAN_SUBCONTINENT
        /// </summary>
        [EnumMember(Value = "ASIAN_OR_INDIAN_SUBCONTINENT")]
        ASIANORINDIANSUBCONTINENT = 2,

        /// <summary>
        /// Enum BLACKORAFRICANAMERICAN for value: BLACK_OR_AFRICAN_AMERICAN
        /// </summary>
        [EnumMember(Value = "BLACK_OR_AFRICAN_AMERICAN")]
        BLACKORAFRICANAMERICAN = 3,

        /// <summary>
        /// Enum HISPANICORLATINO for value: HISPANIC_OR_LATINO
        /// </summary>
        [EnumMember(Value = "HISPANIC_OR_LATINO")]
        HISPANICORLATINO = 4,

        /// <summary>
        /// Enum NATIVEHAWAIIANOROTHERPACIFICISLANDER for value: NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER
        /// </summary>
        [EnumMember(Value = "NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER")]
        NATIVEHAWAIIANOROTHERPACIFICISLANDER = 5,

        /// <summary>
        /// Enum TWOORMORERACES for value: TWO_OR_MORE_RACES
        /// </summary>
        [EnumMember(Value = "TWO_OR_MORE_RACES")]
        TWOORMORERACES = 6,

        /// <summary>
        /// Enum WHITE for value: WHITE
        /// </summary>
        [EnumMember(Value = "WHITE")]
        WHITE = 7,

        /// <summary>
        /// Enum PREFERNOTTODISCLOSE for value: PREFER_NOT_TO_DISCLOSE
        /// </summary>
        [EnumMember(Value = "PREFER_NOT_TO_DISCLOSE")]
        PREFERNOTTODISCLOSE = 8

    }

}