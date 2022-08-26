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
    /// Defines EmploymentTypeEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EmploymentTypeEnum
    {
        /// <summary>
        /// Enum FULLTIME for value: FULL_TIME
        /// </summary>
        [EnumMember(Value = "FULL_TIME")]
        FULLTIME = 1,

        /// <summary>
        /// Enum PARTTIME for value: PART_TIME
        /// </summary>
        [EnumMember(Value = "PART_TIME")]
        PARTTIME = 2,

        /// <summary>
        /// Enum INTERN for value: INTERN
        /// </summary>
        [EnumMember(Value = "INTERN")]
        INTERN = 3,

        /// <summary>
        /// Enum CONTRACTOR for value: CONTRACTOR
        /// </summary>
        [EnumMember(Value = "CONTRACTOR")]
        CONTRACTOR = 4,

        /// <summary>
        /// Enum FREELANCE for value: FREELANCE
        /// </summary>
        [EnumMember(Value = "FREELANCE")]
        FREELANCE = 5

    }

}