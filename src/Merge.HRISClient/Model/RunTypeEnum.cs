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
    /// * &#x60;REGULAR&#x60; - REGULAR * &#x60;OFF_CYCLE&#x60; - OFF_CYCLE * &#x60;CORRECTION&#x60; - CORRECTION * &#x60;TERMINATION&#x60; - TERMINATION * &#x60;SIGN_ON_BONUS&#x60; - SIGN_ON_BONUS
    /// </summary>
    /// <value>* &#x60;REGULAR&#x60; - REGULAR * &#x60;OFF_CYCLE&#x60; - OFF_CYCLE * &#x60;CORRECTION&#x60; - CORRECTION * &#x60;TERMINATION&#x60; - TERMINATION * &#x60;SIGN_ON_BONUS&#x60; - SIGN_ON_BONUS</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RunTypeEnum
    {
        /// <summary>
        /// Enum REGULAR for value: REGULAR
        /// </summary>
        [EnumMember(Value = "REGULAR")]
        REGULAR = 1,

        /// <summary>
        /// Enum OFFCYCLE for value: OFF_CYCLE
        /// </summary>
        [EnumMember(Value = "OFF_CYCLE")]
        OFFCYCLE = 2,

        /// <summary>
        /// Enum CORRECTION for value: CORRECTION
        /// </summary>
        [EnumMember(Value = "CORRECTION")]
        CORRECTION = 3,

        /// <summary>
        /// Enum TERMINATION for value: TERMINATION
        /// </summary>
        [EnumMember(Value = "TERMINATION")]
        TERMINATION = 4,

        /// <summary>
        /// Enum SIGNONBONUS for value: SIGN_ON_BONUS
        /// </summary>
        [EnumMember(Value = "SIGN_ON_BONUS")]
        SIGNONBONUS = 5

    }

}
