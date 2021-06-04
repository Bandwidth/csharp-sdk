// <copyright file="ConferenceState.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.Voice.Models
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
    /// ConferenceState.
    /// </summary>
    public class ConferenceState
    {
        private DateTime? completedTime;
        private string conferenceEventUrl;
        private Models.ConferenceEventMethodEnum? conferenceEventMethod;
        private string tag;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "completedTime", false },
            { "conferenceEventUrl", false },
            { "conferenceEventMethod", false },
            { "tag", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceState"/> class.
        /// </summary>
        public ConferenceState()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceState"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="completedTime">completedTime.</param>
        /// <param name="conferenceEventUrl">conferenceEventUrl.</param>
        /// <param name="conferenceEventMethod">conferenceEventMethod.</param>
        /// <param name="tag">tag.</param>
        /// <param name="activeMembers">activeMembers.</param>
        public ConferenceState(
            string id = null,
            string name = null,
            DateTime? createdTime = null,
            DateTime? completedTime = null,
            string conferenceEventUrl = null,
            Models.ConferenceEventMethodEnum? conferenceEventMethod = null,
            string tag = null,
            List<Models.ConferenceMemberState> activeMembers = null)
        {
            this.Id = id;
            this.Name = name;
            this.CreatedTime = createdTime;
            if (completedTime != null)
            {
                this.CompletedTime = completedTime;
            }

            if (conferenceEventUrl != null)
            {
                this.ConferenceEventUrl = conferenceEventUrl;
            }

            if (conferenceEventMethod != null)
            {
                this.ConferenceEventMethod = conferenceEventMethod;
            }

            if (tag != null)
            {
                this.Tag = tag;
            }

            this.ActiveMembers = activeMembers;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets CreatedTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets CompletedTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("completedTime")]
        public DateTime? CompletedTime
        {
            get
            {
                return this.completedTime;
            }

            set
            {
                this.shouldSerialize["completedTime"] = true;
                this.completedTime = value;
            }
        }

        /// <summary>
        /// Gets or sets ConferenceEventUrl.
        /// </summary>
        [JsonProperty("conferenceEventUrl")]
        public string ConferenceEventUrl
        {
            get
            {
                return this.conferenceEventUrl;
            }

            set
            {
                this.shouldSerialize["conferenceEventUrl"] = true;
                this.conferenceEventUrl = value;
            }
        }

        /// <summary>
        /// Gets or sets ConferenceEventMethod.
        /// </summary>
        [JsonProperty("conferenceEventMethod", ItemConverterType = typeof(StringEnumConverter))]
        public Models.ConferenceEventMethodEnum? ConferenceEventMethod
        {
            get
            {
                return this.conferenceEventMethod;
            }

            set
            {
                this.shouldSerialize["conferenceEventMethod"] = true;
                this.conferenceEventMethod = value;
            }
        }

        /// <summary>
        /// Gets or sets Tag.
        /// </summary>
        [JsonProperty("tag")]
        public string Tag
        {
            get
            {
                return this.tag;
            }

            set
            {
                this.shouldSerialize["tag"] = true;
                this.tag = value;
            }
        }

        /// <summary>
        /// Gets or sets ActiveMembers.
        /// </summary>
        [JsonProperty("activeMembers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ConferenceMemberState> ActiveMembers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConferenceState : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCompletedTime()
        {
            this.shouldSerialize["completedTime"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetConferenceEventUrl()
        {
            this.shouldSerialize["conferenceEventUrl"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetConferenceEventMethod()
        {
            this.shouldSerialize["conferenceEventMethod"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTag()
        {
            this.shouldSerialize["tag"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCompletedTime()
        {
            return this.shouldSerialize["completedTime"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeConferenceEventUrl()
        {
            return this.shouldSerialize["conferenceEventUrl"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeConferenceEventMethod()
        {
            return this.shouldSerialize["conferenceEventMethod"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTag()
        {
            return this.shouldSerialize["tag"];
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

            return obj is ConferenceState other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.CreatedTime == null && other.CreatedTime == null) || (this.CreatedTime?.Equals(other.CreatedTime) == true)) &&
                ((this.CompletedTime == null && other.CompletedTime == null) || (this.CompletedTime?.Equals(other.CompletedTime) == true)) &&
                ((this.ConferenceEventUrl == null && other.ConferenceEventUrl == null) || (this.ConferenceEventUrl?.Equals(other.ConferenceEventUrl) == true)) &&
                ((this.ConferenceEventMethod == null && other.ConferenceEventMethod == null) || (this.ConferenceEventMethod?.Equals(other.ConferenceEventMethod) == true)) &&
                ((this.Tag == null && other.Tag == null) || (this.Tag?.Equals(other.Tag) == true)) &&
                ((this.ActiveMembers == null && other.ActiveMembers == null) || (this.ActiveMembers?.Equals(other.ActiveMembers) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -96155115;

            if (this.Id != null)
            {
               hashCode += this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
               hashCode += this.Name.GetHashCode();
            }

            if (this.CreatedTime != null)
            {
               hashCode += this.CreatedTime.GetHashCode();
            }

            if (this.CompletedTime != null)
            {
               hashCode += this.CompletedTime.GetHashCode();
            }

            if (this.ConferenceEventUrl != null)
            {
               hashCode += this.ConferenceEventUrl.GetHashCode();
            }

            if (this.ConferenceEventMethod != null)
            {
               hashCode += this.ConferenceEventMethod.GetHashCode();
            }

            if (this.Tag != null)
            {
               hashCode += this.Tag.GetHashCode();
            }

            if (this.ActiveMembers != null)
            {
               hashCode += this.ActiveMembers.GetHashCode();
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
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.CreatedTime = {(this.CreatedTime == null ? "null" : this.CreatedTime.ToString())}");
            toStringOutput.Add($"this.CompletedTime = {(this.CompletedTime == null ? "null" : this.CompletedTime.ToString())}");
            toStringOutput.Add($"this.ConferenceEventUrl = {(this.ConferenceEventUrl == null ? "null" : this.ConferenceEventUrl == string.Empty ? "" : this.ConferenceEventUrl)}");
            toStringOutput.Add($"this.ConferenceEventMethod = {(this.ConferenceEventMethod == null ? "null" : this.ConferenceEventMethod.ToString())}");
            toStringOutput.Add($"this.Tag = {(this.Tag == null ? "null" : this.Tag == string.Empty ? "" : this.Tag)}");
            toStringOutput.Add($"this.ActiveMembers = {(this.ActiveMembers == null ? "null" : $"[{string.Join(", ", this.ActiveMembers)} ]")}");
        }
    }
}