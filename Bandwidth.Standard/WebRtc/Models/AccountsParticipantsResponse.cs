// <copyright file="AccountsParticipantsResponse.cs" company="APIMatic">
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
    /// AccountsParticipantsResponse.
    /// </summary>
    public class AccountsParticipantsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsParticipantsResponse"/> class.
        /// </summary>
        public AccountsParticipantsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsParticipantsResponse"/> class.
        /// </summary>
        /// <param name="participant">participant.</param>
        /// <param name="token">token.</param>
        public AccountsParticipantsResponse(
            Models.Participant participant = null,
            string token = null)
        {
            this.Participant = participant;
            this.Token = token;
        }

        /// <summary>
        /// A participant object
        /// </summary>
        [JsonProperty("participant", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Participant Participant { get; set; }

        /// <summary>
        /// Auth token for the returned participant
        /// This should be passed to the participant so that they can connect to the platform
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountsParticipantsResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is AccountsParticipantsResponse other &&
                ((this.Participant == null && other.Participant == null) || (this.Participant?.Equals(other.Participant) == true)) &&
                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -815453959;

            if (this.Participant != null)
            {
               hashCode += this.Participant.GetHashCode();
            }

            if (this.Token != null)
            {
               hashCode += this.Token.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Participant = {(this.Participant == null ? "null" : this.Participant.ToString())}");
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token == string.Empty ? "" : this.Token)}");
        }
    }
}