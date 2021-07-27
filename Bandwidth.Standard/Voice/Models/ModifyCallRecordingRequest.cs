// <copyright file="ModifyCallRecordingRequest.cs" company="APIMatic">
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
    /// ModifyCallRecordingRequest.
    /// </summary>
    public class ModifyCallRecordingRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyCallRecordingRequest"/> class.
        /// </summary>
        public ModifyCallRecordingRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyCallRecordingRequest"/> class.
        /// </summary>
        /// <param name="state">state.</param>
        public ModifyCallRecordingRequest(
            Models.State1Enum state)
        {
            this.State = state;
        }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state", ItemConverterType = typeof(StringEnumConverter))]
        public Models.State1Enum State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ModifyCallRecordingRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is ModifyCallRecordingRequest other &&
                this.State.Equals(other.State);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -2144844992;
            hashCode += this.State.GetHashCode();

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.State = {this.State}");
        }
    }
}