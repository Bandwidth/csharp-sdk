// <copyright file="TranscriptionMetadata.cs" company="APIMatic">
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
    /// TranscriptionMetadata.
    /// </summary>
    public class TranscriptionMetadata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionMetadata"/> class.
        /// </summary>
        public TranscriptionMetadata()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionMetadata"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="completedTime">completedTime.</param>
        /// <param name="url">url.</param>
        public TranscriptionMetadata(
            string id = null,
            string status = null,
            string completedTime = null,
            string url = null)
        {
            this.Id = id;
            this.Status = status;
            this.CompletedTime = completedTime;
            this.Url = url;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The current status of the transcription. Current values are 'none', 'processing', 'available', 'error', 'timeout', 'file-size-too-big', and 'file-size-too-small'. Additional states may be added in the future, so your application must be tolerant of unknown values.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets CompletedTime.
        /// </summary>
        [JsonProperty("completedTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CompletedTime { get; set; }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TranscriptionMetadata : ({string.Join(", ", toStringOutput)})";
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

            return obj is TranscriptionMetadata other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.CompletedTime == null && other.CompletedTime == null) || (this.CompletedTime?.Equals(other.CompletedTime) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1232223399;

            if (this.Id != null)
            {
               hashCode += this.Id.GetHashCode();
            }

            if (this.Status != null)
            {
               hashCode += this.Status.GetHashCode();
            }

            if (this.CompletedTime != null)
            {
               hashCode += this.CompletedTime.GetHashCode();
            }

            if (this.Url != null)
            {
               hashCode += this.Url.GetHashCode();
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
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.CompletedTime = {(this.CompletedTime == null ? "null" : this.CompletedTime == string.Empty ? "" : this.CompletedTime)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url == string.Empty ? "" : this.Url)}");
        }
    }
}