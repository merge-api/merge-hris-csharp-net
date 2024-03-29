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
    /// * &#x60;PAID&#x60; - PAID * &#x60;DRAFT&#x60; - DRAFT * &#x60;APPROVED&#x60; - APPROVED * &#x60;FAILED&#x60; - FAILED * &#x60;CLOSED&#x60; - CLOSED
    /// </summary>
    /// <value>* &#x60;PAID&#x60; - PAID * &#x60;DRAFT&#x60; - DRAFT * &#x60;APPROVED&#x60; - APPROVED * &#x60;FAILED&#x60; - FAILED * &#x60;CLOSED&#x60; - CLOSED</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RunStateEnum
    {
        /// <summary>
        /// Enum PAID for value: PAID
        /// </summary>
        [EnumMember(Value = "PAID")]
        PAID = 1,

        /// <summary>
        /// Enum DRAFT for value: DRAFT
        /// </summary>
        [EnumMember(Value = "DRAFT")]
        DRAFT = 2,

        /// <summary>
        /// Enum APPROVED for value: APPROVED
        /// </summary>
        [EnumMember(Value = "APPROVED")]
        APPROVED = 3,

        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED = 4,

        /// <summary>
        /// Enum CLOSED for value: CLOSED
        /// </summary>
        [EnumMember(Value = "CLOSED")]
        CLOSED = 5

    }

}
