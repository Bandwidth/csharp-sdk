// <copyright file="Diversion.cs" company="APIMatic">
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
    /// Diversion.
    /// </summary>
    public class MachineDetectionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MachineDetectionResult"/> class.
        /// </summary>
        public MachineDetectionResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MachineDetectionResult"/> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="duration">duration.</param>
        public MachineDetectionResult(
            string value = null,
            string duration = null)
        {
            this.Value = value;
            this.Duration = duration;
        }

        /// <summary>
        /// Gets or sets Value.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets Duration.
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public string Duration { get; set; }

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

            return obj is MachineDetectionResult other &&
                ((this.Value == null && other.Value == null) || (this.Value?.Equals(other.Value) == true)) &&
                ((this.Duration == null && other.Duration == null) || (this.Duration?.Equals(other.Duration) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 2065332573;

            if (this.Value != null)
            {
               hashCode += this.Value.GetHashCode();
            }

            if (this.Duration != null)
            {
               hashCode += this.Duration.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Value = {(this.Value == null ? "null" : this.Value == string.Empty ? "" : this.Value)}");
            toStringOutput.Add($"this.Duration = {(this.Duration == null ? "null" : this.Duration == string.Empty ? "" : this.Duration)}");
        }
    }
}
