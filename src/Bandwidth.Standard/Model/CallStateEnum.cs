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
    /// The call state. Possible values:&lt;br&gt;&#x60;active&#x60; to redirect the call (default)&lt;br&gt;&#x60;completed&#x60; to hang up the call if it is answered, cancel it if it is an unanswered outbound call, or reject it if it an unanswered inbound call
    /// </summary>
    /// <value>The call state. Possible values:&lt;br&gt;&#x60;active&#x60; to redirect the call (default)&lt;br&gt;&#x60;completed&#x60; to hang up the call if it is answered, cancel it if it is an unanswered outbound call, or reject it if it an unanswered inbound call</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CallStateEnum
    {
        /// <summary>
        /// Enum Active for value: active
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 1,

        /// <summary>
        /// Enum Completed for value: completed
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed = 2
    }

}
