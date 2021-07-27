// <copyright file="Subscriptions.cs" company="APIMatic">
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
    /// Subscriptions.
    /// </summary>
    public class Subscriptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscriptions"/> class.
        /// </summary>
        public Subscriptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscriptions"/> class.
        /// </summary>
        /// <param name="sessionId">sessionId.</param>
        /// <param name="participants">participants.</param>
        public Subscriptions(
            string sessionId,
            List<Models.ParticipantSubscription> participants = null)
        {
            this.SessionId = sessionId;
            this.Participants = participants;
        }

        /// <summary>
        /// Session the subscriptions are associated with
        /// If this is the only field, the subscriber will be subscribed to all participants in the session (including any participants that are later added to the session)
        /// </summary>
        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// Subset of participants to subscribe to in the session. Optional.
        /// </summary>
        [JsonProperty("participants", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ParticipantSubscription> Participants { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Subscriptions : ({string.Join(", ", toStringOutput)})";
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

            return obj is Subscriptions other &&
                ((this.SessionId == null && other.SessionId == null) || (this.SessionId?.Equals(other.SessionId) == true)) &&
                ((this.Participants == null && other.Participants == null) || (this.Participants?.Equals(other.Participants) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1970062954;

            if (this.SessionId != null)
            {
               hashCode += this.SessionId.GetHashCode();
            }

            if (this.Participants != null)
            {
               hashCode += this.Participants.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SessionId = {(this.SessionId == null ? "null" : this.SessionId == string.Empty ? "" : this.SessionId)}");
            toStringOutput.Add($"this.Participants = {(this.Participants == null ? "null" : $"[{string.Join(", ", this.Participants)} ]")}");
        }
    }
}