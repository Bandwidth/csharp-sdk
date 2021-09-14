// <copyright file="Transcription.cs" company="APIMatic">
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
    /// Transcription.
    /// </summary>
    public class Transcription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Transcription"/> class.
        /// </summary>
        public Transcription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcription"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="url">url.</param>
        /// <param name="status">status.</param>
        /// <param name="completedTime">completedTime.</param>
        public Transcription(
            string id = null,
            string url = null,
            string status = null,
            string completedTime = null)
        {
            this.Id = id;
            this.Url = url;
            this.Status = status;
            this.CompletedTime = completedTime;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets CompletedTime.
        /// </summary>
        [JsonProperty("completedTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CompletedTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Transcription : ({string.Join(", ", toStringOutput)})";
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

            return obj is Transcription other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.CompletedTime == null && other.CompletedTime == null) || (this.CompletedTime?.Equals(other.CompletedTime) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1428643410;

            if (this.Id != null)
            {
               hashCode += this.Id.GetHashCode();
            }

            if (this.Url != null)
            {
               hashCode += this.Url.GetHashCode();
            }

            if (this.Status != null)
            {
               hashCode += this.Status.GetHashCode();
            }

            if (this.CompletedTime != null)
            {
               hashCode += this.CompletedTime.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url == string.Empty ? "" : this.Url)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.CompletedTime = {(this.CompletedTime == null ? "null" : this.CompletedTime == string.Empty ? "" : this.CompletedTime)}");
        }
    }
}