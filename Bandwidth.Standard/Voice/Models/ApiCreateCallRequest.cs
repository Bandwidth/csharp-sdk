/*
 * Bandwidth.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Bandwidth.Standard;
using Bandwidth.Standard.Utilities;

namespace Bandwidth.Standard.Voice.Models
{
    public class ApiCreateCallRequest 
    {
        public ApiCreateCallRequest() { }

        public ApiCreateCallRequest(string from,
            string to,
            string answerUrl,
            string applicationId,
            double? callTimeout = null,
            string username = null,
            string password = null,
            Models.AnswerMethodEnum? answerMethod = null,
            string disconnectUrl = null,
            Models.DisconnectMethodEnum? disconnectMethod = null,
            string tag = null,
            string obfuscatedTo = null,
            string obfuscatedFrom = null)
        {
            From = from;
            To = to;
            CallTimeout = callTimeout;
            AnswerUrl = answerUrl;
            Username = username;
            Password = password;
            AnswerMethod = answerMethod;
            DisconnectUrl = disconnectUrl;
            DisconnectMethod = disconnectMethod;
            Tag = tag;
            ApplicationId = applicationId;
            ObfuscatedTo = obfuscatedTo;
            ObfuscatedFrom = obfuscatedFrom;
        }

        /// <summary>
        /// Format is E164
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }

        /// <summary>
        /// Format is E164
        /// </summary>
        [JsonProperty("to")]
        public string To { get; set; }

        /// <summary>
        /// Getter for callTimeout
        /// </summary>
        [JsonProperty("callTimeout")]
        public double? CallTimeout { get; set; }

        /// <summary>
        /// Getter for answerUrl
        /// </summary>
        [JsonProperty("answerUrl")]
        public string AnswerUrl { get; set; }

        /// <summary>
        /// Getter for username
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Getter for password
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Getter for answerMethod
        /// </summary>
        [JsonProperty("answerMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.AnswerMethodEnum? AnswerMethod { get; set; }

        /// <summary>
        /// Getter for disconnectUrl
        /// </summary>
        [JsonProperty("disconnectUrl")]
        public string DisconnectUrl { get; set; }

        /// <summary>
        /// Getter for disconnectMethod
        /// </summary>
        [JsonProperty("disconnectMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.DisconnectMethodEnum? DisconnectMethod { get; set; }

        /// <summary>
        /// Getter for tag
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// Getter for applicationId
        /// </summary>
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Getter for obfuscatedTo
        /// </summary>
        [JsonProperty("obfuscatedTo")]
        public string ObfuscatedTo { get; set; }

        /// <summary>
        /// Getter for obfuscatedFrom
        /// </summary>
        [JsonProperty("obfuscatedFrom")]
        public string ObfuscatedFrom { get; set; }

    }
}