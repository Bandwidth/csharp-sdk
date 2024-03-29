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
    /// The type of message. Either SMS or MMS.
    /// </summary>
    /// <value>The type of message. Either SMS or MMS.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessageTypeEnum
    {
        /// <summary>
        /// Enum Sms for value: sms
        /// </summary>
        [EnumMember(Value = "sms")]
        Sms = 1,

        /// <summary>
        /// Enum Mms for value: mms
        /// </summary>
        [EnumMember(Value = "mms")]
        Mms = 2
    }

}
