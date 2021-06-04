// <copyright file="ParticipantSubscription.cs" company="APIMatic">
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
    /// ParticipantSubscription.
    /// </summary>
    public class ParticipantSubscription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantSubscription"/> class.
        /// </summary>
        public ParticipantSubscription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantSubscription"/> class.
        /// </summary>
        /// <param name="participantId">participantId.</param>
        public ParticipantSubscription(
            string participantId)
        {
            this.ParticipantId = participantId;
        }

        /// <summary>
        /// Participant the subscriber should be subscribed to
        /// </summary>
        [JsonProperty("participantId")]
        public string ParticipantId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ParticipantSubscription : ({string.Join(", ", toStringOutput)})";
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

            return obj is ParticipantSubscription other &&
                ((this.ParticipantId == null && other.ParticipantId == null) || (this.ParticipantId?.Equals(other.ParticipantId) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1364424941;

            if (this.ParticipantId != null)
            {
               hashCode += this.ParticipantId.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ParticipantId = {(this.ParticipantId == null ? "null" : this.ParticipantId == string.Empty ? "" : this.ParticipantId)}");
        }
    }
}