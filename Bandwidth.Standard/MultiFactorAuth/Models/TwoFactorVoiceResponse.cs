// <copyright file="TwoFactorVoiceResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.MultiFactorAuth.Models
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
    /// TwoFactorVoiceResponse.
    /// </summary>
    public class TwoFactorVoiceResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorVoiceResponse"/> class.
        /// </summary>
        public TwoFactorVoiceResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorVoiceResponse"/> class.
        /// </summary>
        /// <param name="callId">callId.</param>
        public TwoFactorVoiceResponse(
            string callId = null)
        {
            this.CallId = callId;
        }

        /// <summary>
        /// Gets or sets CallId.
        /// </summary>
        [JsonProperty("callId", NullValueHandling = NullValueHandling.Ignore)]
        public string CallId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TwoFactorVoiceResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is TwoFactorVoiceResponse other &&
                ((this.CallId == null && other.CallId == null) || (this.CallId?.Equals(other.CallId) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1475004682;

            if (this.CallId != null)
            {
               hashCode += this.CallId.GetHashCode();
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
        }
    }
}