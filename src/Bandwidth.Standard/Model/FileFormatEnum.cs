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
    /// The format that the recording is stored in.
    /// </summary>
    /// <value>The format that the recording is stored in.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FileFormatEnum
    {
        /// <summary>
        /// Enum Mp3 for value: mp3
        /// </summary>
        [EnumMember(Value = "mp3")]
        Mp3 = 1,

        /// <summary>
        /// Enum Wav for value: wav
        /// </summary>
        [EnumMember(Value = "wav")]
        Wav = 2
    }

}