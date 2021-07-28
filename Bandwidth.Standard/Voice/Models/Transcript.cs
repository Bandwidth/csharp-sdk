// <copyright file="Transcript.cs" company="APIMatic">
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
    /// Transcript.
    /// </summary>
    public class Transcript
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Transcript"/> class.
        /// </summary>
        public Transcript()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcript"/> class.
        /// </summary>
        /// <param name="text">text.</param>
        /// <param name="confidence">confidence.</param>
        public Transcript(
            string text = null,
            double? confidence = null)
        {
            this.Text = text;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Gets or sets Text.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets Confidence.
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public double? Confidence { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Transcript : ({string.Join(", ", toStringOutput)})";
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

            return obj is Transcript other &&
                ((this.Text == null && other.Text == null) || (this.Text?.Equals(other.Text) == true)) &&
                ((this.Confidence == null && other.Confidence == null) || (this.Confidence?.Equals(other.Confidence) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 866752038;

            if (this.Text != null)
            {
               hashCode += this.Text.GetHashCode();
            }

            if (this.Confidence != null)
            {
               hashCode += this.Confidence.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Text = {(this.Text == null ? "null" : this.Text == string.Empty ? "" : this.Text)}");
            toStringOutput.Add($"this.Confidence = {(this.Confidence == null ? "null" : this.Confidence.ToString())}");
        }
    }
}