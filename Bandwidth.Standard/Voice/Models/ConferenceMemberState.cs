// <copyright file="ConferenceMemberState.cs" company="APIMatic">
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
    /// ConferenceMemberState.
    /// </summary>
    public class ConferenceMemberState
    {
        private List<string> callIdsToCoach;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "callIdsToCoach", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceMemberState"/> class.
        /// </summary>
        public ConferenceMemberState()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceMemberState"/> class.
        /// </summary>
        /// <param name="callId">callId.</param>
        /// <param name="conferenceId">conferenceId.</param>
        /// <param name="memberUrl">memberUrl.</param>
        /// <param name="mute">mute.</param>
        /// <param name="hold">hold.</param>
        /// <param name="callIdsToCoach">callIdsToCoach.</param>
        public ConferenceMemberState(
            string callId = null,
            string conferenceId = null,
            string memberUrl = null,
            bool? mute = null,
            bool? hold = null,
            List<string> callIdsToCoach = null)
        {
            this.CallId = callId;
            this.ConferenceId = conferenceId;
            this.MemberUrl = memberUrl;
            this.Mute = mute;
            this.Hold = hold;
            if (callIdsToCoach != null)
            {
                this.CallIdsToCoach = callIdsToCoach;
            }

        }

        /// <summary>
        /// Gets or sets CallId.
        /// </summary>
        [JsonProperty("callId", NullValueHandling = NullValueHandling.Ignore)]
        public string CallId { get; set; }

        /// <summary>
        /// Gets or sets ConferenceId.
        /// </summary>
        [JsonProperty("conferenceId", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// Gets or sets MemberUrl.
        /// </summary>
        [JsonProperty("memberUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberUrl { get; set; }

        /// <summary>
        /// Gets or sets Mute.
        /// </summary>
        [JsonProperty("mute", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mute { get; set; }

        /// <summary>
        /// Gets or sets Hold.
        /// </summary>
        [JsonProperty("hold", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hold { get; set; }

        /// <summary>
        /// Gets or sets CallIdsToCoach.
        /// </summary>
        [JsonProperty("callIdsToCoach")]
        public List<string> CallIdsToCoach
        {
            get
            {
                return this.callIdsToCoach;
            }

            set
            {
                this.shouldSerialize["callIdsToCoach"] = true;
                this.callIdsToCoach = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConferenceMemberState : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCallIdsToCoach()
        {
            this.shouldSerialize["callIdsToCoach"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCallIdsToCoach()
        {
            return this.shouldSerialize["callIdsToCoach"];
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

            return obj is ConferenceMemberState other &&
                ((this.CallId == null && other.CallId == null) || (this.CallId?.Equals(other.CallId) == true)) &&
                ((this.ConferenceId == null && other.ConferenceId == null) || (this.ConferenceId?.Equals(other.ConferenceId) == true)) &&
                ((this.MemberUrl == null && other.MemberUrl == null) || (this.MemberUrl?.Equals(other.MemberUrl) == true)) &&
                ((this.Mute == null && other.Mute == null) || (this.Mute?.Equals(other.Mute) == true)) &&
                ((this.Hold == null && other.Hold == null) || (this.Hold?.Equals(other.Hold) == true)) &&
                ((this.CallIdsToCoach == null && other.CallIdsToCoach == null) || (this.CallIdsToCoach?.Equals(other.CallIdsToCoach) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 2131508285;

            if (this.CallId != null)
            {
               hashCode += this.CallId.GetHashCode();
            }

            if (this.ConferenceId != null)
            {
               hashCode += this.ConferenceId.GetHashCode();
            }

            if (this.MemberUrl != null)
            {
               hashCode += this.MemberUrl.GetHashCode();
            }

            if (this.Mute != null)
            {
               hashCode += this.Mute.GetHashCode();
            }

            if (this.Hold != null)
            {
               hashCode += this.Hold.GetHashCode();
            }

            if (this.CallIdsToCoach != null)
            {
               hashCode += this.CallIdsToCoach.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CallId = {(this.CallId == null ? "null" : this.CallId == string.Empty ? "" : this.CallId)}");
            toStringOutput.Add($"this.ConferenceId = {(this.ConferenceId == null ? "null" : this.ConferenceId == string.Empty ? "" : this.ConferenceId)}");
            toStringOutput.Add($"this.MemberUrl = {(this.MemberUrl == null ? "null" : this.MemberUrl == string.Empty ? "" : this.MemberUrl)}");
            toStringOutput.Add($"this.Mute = {(this.Mute == null ? "null" : this.Mute.ToString())}");
            toStringOutput.Add($"this.Hold = {(this.Hold == null ? "null" : this.Hold.ToString())}");
            toStringOutput.Add($"this.CallIdsToCoach = {(this.CallIdsToCoach == null ? "null" : $"[{string.Join(", ", this.CallIdsToCoach)} ]")}");
        }
    }
}