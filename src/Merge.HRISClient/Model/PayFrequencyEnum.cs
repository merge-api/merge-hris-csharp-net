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
    /// Defines PayFrequencyEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PayFrequencyEnum
    {
        /// <summary>
        /// Enum WEEKLY for value: WEEKLY
        /// </summary>
        [EnumMember(Value = "WEEKLY")]
        WEEKLY = 1,

        /// <summary>
        /// Enum BIWEEKLY for value: BIWEEKLY
        /// </summary>
        [EnumMember(Value = "BIWEEKLY")]
        BIWEEKLY = 2,

        /// <summary>
        /// Enum MONTHLY for value: MONTHLY
        /// </summary>
        [EnumMember(Value = "MONTHLY")]
        MONTHLY = 3,

        /// <summary>
        /// Enum QUARTERLY for value: QUARTERLY
        /// </summary>
        [EnumMember(Value = "QUARTERLY")]
        QUARTERLY = 4,

        /// <summary>
        /// Enum SEMIANNUALLY for value: SEMIANNUALLY
        /// </summary>
        [EnumMember(Value = "SEMIANNUALLY")]
        SEMIANNUALLY = 5,

        /// <summary>
        /// Enum ANNUALLY for value: ANNUALLY
        /// </summary>
        [EnumMember(Value = "ANNUALLY")]
        ANNUALLY = 6,

        /// <summary>
        /// Enum THIRTEENMONTHLY for value: THIRTEEN-MONTHLY
        /// </summary>
        [EnumMember(Value = "THIRTEEN-MONTHLY")]
        THIRTEENMONTHLY = 7,

        /// <summary>
        /// Enum PRORATA for value: PRO_RATA
        /// </summary>
        [EnumMember(Value = "PRO_RATA")]
        PRORATA = 8

    }

}