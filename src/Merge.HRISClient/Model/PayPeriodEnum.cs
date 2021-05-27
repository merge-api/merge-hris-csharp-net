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
    /// Defines PayPeriodEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PayPeriodEnum
    {
        /// <summary>
        /// Enum HOUR for value: HOUR
        /// </summary>
        [EnumMember(Value = "HOUR")]
        HOUR = 1,

        /// <summary>
        /// Enum DAY for value: DAY
        /// </summary>
        [EnumMember(Value = "DAY")]
        DAY = 2,

        /// <summary>
        /// Enum WEEK for value: WEEK
        /// </summary>
        [EnumMember(Value = "WEEK")]
        WEEK = 3,

        /// <summary>
        /// Enum EVERYTWOWEEKS for value: EVERY_TWO_WEEKS
        /// </summary>
        [EnumMember(Value = "EVERY_TWO_WEEKS")]
        EVERYTWOWEEKS = 4,

        /// <summary>
        /// Enum MONTH for value: MONTH
        /// </summary>
        [EnumMember(Value = "MONTH")]
        MONTH = 5,

        /// <summary>
        /// Enum QUARTER for value: QUARTER
        /// </summary>
        [EnumMember(Value = "QUARTER")]
        QUARTER = 6,

        /// <summary>
        /// Enum EVERYSIXMONTHS for value: EVERY_SIX_MONTHS
        /// </summary>
        [EnumMember(Value = "EVERY_SIX_MONTHS")]
        EVERYSIXMONTHS = 7,

        /// <summary>
        /// Enum YEAR for value: YEAR
        /// </summary>
        [EnumMember(Value = "YEAR")]
        YEAR = 8

    }

}
