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
    /// The direction of the message. One of INBOUND OUTBOUND.
    /// </summary>
    /// <value>The direction of the message. One of INBOUND OUTBOUND.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ListMessageDirectionEnum
    {
        /// <summary>
        /// Enum INBOUND for value: INBOUND
        /// </summary>
        [EnumMember(Value = "INBOUND")]
        INBOUND = 1,

        /// <summary>
        /// Enum OUTBOUND for value: OUTBOUND
        /// </summary>
        [EnumMember(Value = "OUTBOUND")]
        OUTBOUND = 2

    }

}
