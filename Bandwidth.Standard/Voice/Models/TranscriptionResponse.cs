// <copyright file="TranscriptionResponse.cs" company="APIMatic">
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
    /// TranscriptionResponse.
    /// </summary>
    public class TranscriptionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionResponse"/> class.
        /// </summary>
        public TranscriptionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionResponse"/> class.
        /// </summary>
        /// <param name="transcripts">transcripts.</param>
        public TranscriptionResponse(
            List<Models.Transcript> transcripts = null)
        {
            this.Transcripts = transcripts;
        }

        /// <summary>
        /// Gets or sets Transcripts.
        /// </summary>
        [JsonProperty("transcripts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Transcript> Transcripts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TranscriptionResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is TranscriptionResponse other &&
                ((this.Transcripts == null && other.Transcripts == null) || (this.Transcripts?.Equals(other.Transcripts) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1678227722;

            if (this.Transcripts != null)
            {
               hashCode += this.Transcripts.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Transcripts = {(this.Transcripts == null ? "null" : $"[{string.Join(", ", this.Transcripts)} ]")}");
        }
    }
}