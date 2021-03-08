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

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Participant : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(Id == null ? "null" : Id == string.Empty ? "" : Id)}");
            toStringOutput.Add($"CallbackUrl = {(CallbackUrl == null ? "null" : CallbackUrl == string.Empty ? "" : CallbackUrl)}");
            toStringOutput.Add($"PublishPermissions = {(PublishPermissions == null ? "null" : $"[{ string.Join(", ", PublishPermissions)} ]")}");
            toStringOutput.Add($"Sessions = {(Sessions == null ? "null" : $"[{ string.Join(", ", Sessions)} ]")}");
            toStringOutput.Add($"Subscriptions = {(Subscriptions == null ? "null" : Subscriptions.ToString())}");
            toStringOutput.Add($"Tag = {(Tag == null ? "null" : Tag == string.Empty ? "" : Tag)}");
            toStringOutput.Add($"DeviceApiVersion = {(DeviceApiVersion == null ? "null" : DeviceApiVersion.ToString())}");
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is Participant other &&
                ((Id == null && other.Id == null) || (Id?.Equals(other.Id) == true)) &&
                ((CallbackUrl == null && other.CallbackUrl == null) || (CallbackUrl?.Equals(other.CallbackUrl) == true)) &&
                ((PublishPermissions == null && other.PublishPermissions == null) || (PublishPermissions?.Equals(other.PublishPermissions) == true)) &&
                ((Sessions == null && other.Sessions == null) || (Sessions?.Equals(other.Sessions) == true)) &&
                ((Subscriptions == null && other.Subscriptions == null) || (Subscriptions?.Equals(other.Subscriptions) == true)) &&
                ((Tag == null && other.Tag == null) || (Tag?.Equals(other.Tag) == true)) &&
                ((DeviceApiVersion == null && other.DeviceApiVersion == null) || (DeviceApiVersion?.Equals(other.DeviceApiVersion) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -1308942381;

            if (Id != null)
            {
               hashCode += Id.GetHashCode();
            }

            if (CallbackUrl != null)
            {
               hashCode += CallbackUrl.GetHashCode();
            }

            if (PublishPermissions != null)
            {
               hashCode += PublishPermissions.GetHashCode();
            }

            if (Sessions != null)
            {
               hashCode += Sessions.GetHashCode();
            }

            if (Subscriptions != null)
            {
               hashCode += Subscriptions.GetHashCode();
            }

            if (Tag != null)
            {
               hashCode += Tag.GetHashCode();
            }

            if (DeviceApiVersion != null)
            {
               hashCode += DeviceApiVersion.GetHashCode();
            }

            return hashCode;
        }

    }
}