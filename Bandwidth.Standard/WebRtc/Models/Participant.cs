// <copyright file="Participant.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.WebRtc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Bandwidth.Standard;
    using Bandwidth.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Participant.
    /// </summary>
    public class Participant
    {
        private string callbackUrl;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "callbackUrl", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Participant"/> class.
        /// </summary>
        public Participant()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Participant"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="callbackUrl">callbackUrl.</param>
        /// <param name="publishPermissions">publishPermissions.</param>
        /// <param name="sessions">sessions.</param>
        /// <param name="subscriptions">subscriptions.</param>
        /// <param name="tag">tag.</param>
        /// <param name="deviceApiVersion">deviceApiVersion.</param>
        public Participant(
            string id = null,
            string callbackUrl = null,
            List<Models.PublishPermissionEnum> publishPermissions = null,
            List<string> sessions = null,
            Models.Subscriptions subscriptions = null,
            string tag = null,
            Models.DeviceApiVersionEnum? deviceApiVersion = Models.DeviceApiVersionEnum.V2)
        {
            this.Id = id;
            if (callbackUrl != null)
            {
                this.CallbackUrl = callbackUrl;
            }

            this.PublishPermissions = publishPermissions;
            this.Sessions = sessions;
            this.Subscriptions = subscriptions;
            this.Tag = tag;
            this.DeviceApiVersion = deviceApiVersion;
        }

        /// <summary>
        /// Unique id of the participant
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Full callback url to use for notifications about this participant
        /// </summary>
        [JsonProperty("callbackUrl")]
        public string CallbackUrl
        {
            get
            {
                return this.callbackUrl;
            }

            set
            {
                this.shouldSerialize["callbackUrl"] = true;
                this.callbackUrl = value;
            }
        }

        /// <summary>
        /// Defines if this participant can publish audio or video
        /// </summary>
        [JsonProperty("publishPermissions", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PublishPermissionEnum> PublishPermissions { get; set; }

        /// <summary>
        /// List of session ids this participant is associated with
        /// Capped to one
        /// </summary>
        [JsonProperty("sessions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Sessions { get; set; }

        /// <summary>
        /// Gets or sets Subscriptions.
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
        [JsonProperty("deviceApiVersion", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeviceApiVersionEnum? DeviceApiVersion { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Participant : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCallbackUrl()
        {
            this.shouldSerialize["callbackUrl"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCallbackUrl()
        {
            return this.shouldSerialize["callbackUrl"];
        }

        /// <inheritdoc/>
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
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.CallbackUrl == null && other.CallbackUrl == null) || (this.CallbackUrl?.Equals(other.CallbackUrl) == true)) &&
                ((this.PublishPermissions == null && other.PublishPermissions == null) || (this.PublishPermissions?.Equals(other.PublishPermissions) == true)) &&
                ((this.Sessions == null && other.Sessions == null) || (this.Sessions?.Equals(other.Sessions) == true)) &&
                ((this.Subscriptions == null && other.Subscriptions == null) || (this.Subscriptions?.Equals(other.Subscriptions) == true)) &&
                ((this.Tag == null && other.Tag == null) || (this.Tag?.Equals(other.Tag) == true)) &&
                ((this.DeviceApiVersion == null && other.DeviceApiVersion == null) || (this.DeviceApiVersion?.Equals(other.DeviceApiVersion) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1308942381;

            if (this.Id != null)
            {
               hashCode += this.Id.GetHashCode();
            }

            if (this.CallbackUrl != null)
            {
               hashCode += this.CallbackUrl.GetHashCode();
            }

            if (this.PublishPermissions != null)
            {
               hashCode += this.PublishPermissions.GetHashCode();
            }

            if (this.Sessions != null)
            {
               hashCode += this.Sessions.GetHashCode();
            }

            if (this.Subscriptions != null)
            {
               hashCode += this.Subscriptions.GetHashCode();
            }

            if (this.Tag != null)
            {
               hashCode += this.Tag.GetHashCode();
            }

            if (this.DeviceApiVersion != null)
            {
               hashCode += this.DeviceApiVersion.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.CallbackUrl = {(this.CallbackUrl == null ? "null" : this.CallbackUrl == string.Empty ? "" : this.CallbackUrl)}");
            toStringOutput.Add($"this.PublishPermissions = {(this.PublishPermissions == null ? "null" : $"[{string.Join(", ", this.PublishPermissions)} ]")}");
            toStringOutput.Add($"this.Sessions = {(this.Sessions == null ? "null" : $"[{string.Join(", ", this.Sessions)} ]")}");
            toStringOutput.Add($"this.Subscriptions = {(this.Subscriptions == null ? "null" : this.Subscriptions.ToString())}");
            toStringOutput.Add($"this.Tag = {(this.Tag == null ? "null" : this.Tag == string.Empty ? "" : this.Tag)}");
            toStringOutput.Add($"this.DeviceApiVersion = {(this.DeviceApiVersion == null ? "null" : this.DeviceApiVersion.ToString())}");
        }
    }
}