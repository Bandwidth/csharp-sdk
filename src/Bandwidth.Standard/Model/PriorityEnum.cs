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
using OpenAPIDateConverter = Bandwidth.Standard.Client.OpenAPIDateConverter;

namespace Bandwidth.Standard.Model
{
    /// <summary>
    /// The priority specified by the user.  Not supported on MMS.
    /// </summary>
    /// <value>The priority specified by the user.  Not supported on MMS.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PriorityEnum
    {
        /// <summary>
        /// Enum Default for value: default
        /// </summary>
        [EnumMember(Value = "default")]
        Default = 1,

        /// <summary>
        /// Enum High for value: high
        /// </summary>
        [EnumMember(Value = "high")]
        High = 2

    }

}
