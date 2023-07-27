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
    /// The machine detection mode. If set to &#39;async&#39;, the detection result will be sent in a &#39;machineDetectionComplete&#39; callback. If set to &#39;sync&#39;, the &#39;answer&#39; callback will wait for the machine detection to complete and will include its result.
    /// </summary>
    /// <value>The machine detection mode. If set to &#39;async&#39;, the detection result will be sent in a &#39;machineDetectionComplete&#39; callback. If set to &#39;sync&#39;, the &#39;answer&#39; callback will wait for the machine detection to complete and will include its result.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MachineDetectionModeEnum
    {
        /// <summary>
        /// Enum Sync for value: sync
        /// </summary>
        [EnumMember(Value = "sync")]
        Sync = 1,

        /// <summary>
        /// Enum Async for value: async
        /// </summary>
        [EnumMember(Value = "async")]
        Async = 2

    }

}
