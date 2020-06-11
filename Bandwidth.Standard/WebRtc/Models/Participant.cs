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
            Models.Permissions permissions = null,
            List<string> sessions = null,
            Models.Subscriptions subscriptions = null,
            string tag = null)
        {
            Id = id;
            CallbackUrl = callbackUrl;
            Permissions = permissions;
            Sessions = sessions;
            Subscriptions = subscriptions;
            Tag = tag;
        }

        /// <summary>
        /// Getter for id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Full callback url to use for notifications about this participant
        /// </summary>
        [JsonProperty("callbackUrl")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Getter for permissions
        /// </summary>
        [JsonProperty("permissions")]
        public Models.Permissions Permissions { get; set; }

        /// <summary>
        /// List of session ids this participant is associated with
        /// Capped to one
        /// </summary>
        [JsonProperty("sessions")]
        public List<string> Sessions { get; set; }

        /// <summary>
        /// Getter for subscriptions
        /// </summary>
        [JsonProperty("subscriptions")]
        public Models.Subscriptions Subscriptions { get; set; }

        /// <summary>
        /// User defined tag to associate with the participant
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

    }
}