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
    /// Defines webhookSubscriptionTypeEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookSubscriptionTypeEnum
    {
        /// <summary>
        /// Enum TOLLFREEVERIFICATIONSTATUS for value: TOLLFREE_VERIFICATION_STATUS
        /// </summary>
        [EnumMember(Value = "TOLLFREE_VERIFICATION_STATUS")]
        TOLLFREEVERIFICATIONSTATUS = 1,

        /// <summary>
        /// Enum MESSAGINGPORTOUTAPPROVALSTATUS for value: MESSAGING_PORTOUT_APPROVAL_STATUS
        /// </summary>
        [EnumMember(Value = "MESSAGING_PORTOUT_APPROVAL_STATUS")]
        MESSAGINGPORTOUTAPPROVALSTATUS = 2
    }

}
