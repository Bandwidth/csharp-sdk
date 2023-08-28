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
    /// The recording state. Possible values:  &#x60;paused&#x60; to pause an active recording  &#x60;recording&#x60; to resume a paused recording
    /// </summary>
    /// <value>The recording state. Possible values:  &#x60;paused&#x60; to pause an active recording  &#x60;recording&#x60; to resume a paused recording</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecordingStateEnum
    {
        /// <summary>
        /// Enum Paused for value: paused
        /// </summary>
        [EnumMember(Value = "paused")]
        Paused = 1,

        /// <summary>
        /// Enum Recording for value: recording
        /// </summary>
        [EnumMember(Value = "recording")]
        Recording = 2
    }

}
