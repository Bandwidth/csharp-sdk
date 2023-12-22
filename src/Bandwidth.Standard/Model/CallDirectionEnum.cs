/*
 * Bandwidth
 *
 * Bandwidth's Communication APIs
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: letstalk@bandwidth.com
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
using OpenAPIDateConverter = Bandwidth.Standard.Client.OpenAPIDateConverter;

namespace Bandwidth.Standard.Model
{
    /// <summary>
    /// The direction of the call.
    /// </summary>
    /// <value>The direction of the call.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CallDirectionEnum
    {
        /// <summary>
        /// Enum Inbound for value: inbound
        /// </summary>
        [EnumMember(Value = "inbound")]
        Inbound = 1,

        /// <summary>
        /// Enum Outbound for value: outbound
        /// </summary>
        [EnumMember(Value = "outbound")]
        Outbound = 2
    }

}
