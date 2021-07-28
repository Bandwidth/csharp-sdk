// <copyright file="TwoFactorMessagingResponse.cs" company="APIMatic">
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
    /// TwoFactorMessagingResponse.
    /// </summary>
    public class TwoFactorMessagingResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorMessagingResponse"/> class.
        /// </summary>
        public TwoFactorMessagingResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorMessagingResponse"/> class.
        /// </summary>
        /// <param name="messageId">messageId.</param>
        public TwoFactorMessagingResponse(
            string messageId = null)
        {
            this.MessageId = messageId;
        }

        /// <summary>
        /// Gets or sets MessageId.
        /// </summary>
        [JsonProperty("messageId", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TwoFactorMessagingResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is TwoFactorMessagingResponse other &&
                ((this.MessageId == null && other.MessageId == null) || (this.MessageId?.Equals(other.MessageId) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1575158831;

            if (this.MessageId != null)
            {
               hashCode += this.MessageId.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MessageId = {(this.MessageId == null ? "null" : this.MessageId == string.Empty ? "" : this.MessageId)}");
        }
    }
}