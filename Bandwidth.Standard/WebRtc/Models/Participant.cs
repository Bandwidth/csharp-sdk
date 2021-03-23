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

namespace Bandwidth.Standard.WebRtc.Models
{
    public class Participant 
    {
        public Participant() { }

        public Participant(string id = null,
            string callbackUrl = null,
            List<Models.PublishPermissionEnum> publishPermissions = null,
            List<string> sessions = null,
            Models.Subscriptions subscriptions = null,
            string tag = null,
            Models.DeviceApiVersionEnum? deviceApiVersion = Models.DeviceApiVersionEnum.V2)
        {
            Id = id;
            CallbackUrl = callbackUrl;
            PublishPermissions = publishPermissions;
            Sessions = sessions;
            Subscriptions = subscriptions;
            Tag = tag;
            DeviceApiVersion = deviceApiVersion;
        }

        /// <summary>
        /// Unique id of the participant
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Full callback url to use for notifications about this participant
        /// </summary>
        [JsonProperty("callbackUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Defines if this participant can publish audio or video
        /// </summary>
        [JsonProperty("publishPermissions", ItemConverterType = typeof(StringValuedEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PublishPermissionEnum> PublishPermissions { get; set; }

        /// <summary>
        /// List of session ids this participant is associated with
        /// Capped to one
        /// </summary>
        [JsonProperty("sessions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Sessions { get; set; }

        /// <summary>
        /// Getter for subscriptions
        /// </summary>
        [JsonProperty("subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Subscriptions Subscriptions { get; set; }

        /// <summary>
        /// User defined tag to associate with the participant
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }
        
        /// <summary>
        /// Optional field to define the device api version of this participant
        /// </summary>
        [JsonProperty("deviceApiVersion", ItemConverterType = typeof(StringValuedEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeviceApiVersionEnum? DeviceApiVersion { get; set; }
    }
}
