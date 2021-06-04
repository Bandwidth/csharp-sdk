// <copyright file="ConferenceRecordingMetadata.cs" company="APIMatic">
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
    /// ConferenceRecordingMetadata.
    /// </summary>
    public class ConferenceRecordingMetadata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceRecordingMetadata"/> class.
        /// </summary>
        public ConferenceRecordingMetadata()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceRecordingMetadata"/> class.
        /// </summary>
        /// <param name="accountId">accountId.</param>
        /// <param name="conferenceId">conferenceId.</param>
        /// <param name="name">name.</param>
        /// <param name="recordingId">recordingId.</param>
        /// <param name="duration">duration.</param>
        /// <param name="channels">channels.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="fileFormat">fileFormat.</param>
        /// <param name="status">status.</param>
        /// <param name="mediaUrl">mediaUrl.</param>
        public ConferenceRecordingMetadata(
            string accountId = null,
            string conferenceId = null,
            string name = null,
            string recordingId = null,
            string duration = null,
            int? channels = null,
            DateTime? startTime = null,
            DateTime? endTime = null,
            Models.FileFormatEnum? fileFormat = null,
            string status = null,
            string mediaUrl = null)
        {
            this.AccountId = accountId;
            this.ConferenceId = conferenceId;
            this.Name = name;
            this.RecordingId = recordingId;
            this.Duration = duration;
            this.Channels = channels;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.FileFormat = fileFormat;
            this.Status = status;
            this.MediaUrl = mediaUrl;
        }

        /// <summary>
        /// Gets or sets AccountId.
        /// </summary>
        [JsonProperty("accountId", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets ConferenceId.
        /// </summary>
        [JsonProperty("conferenceId", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets RecordingId.
        /// </summary>
        [JsonProperty("recordingId", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordingId { get; set; }

        /// <summary>
        /// Format is ISO-8601
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets Channels.
        /// </summary>
        [JsonProperty("channels", NullValueHandling = NullValueHandling.Ignore)]
        public int? Channels { get; set; }

        /// <summary>
        /// Gets or sets StartTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets EndTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets FileFormat.
        /// </summary>
        [JsonProperty("fileFormat", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.FileFormatEnum? FileFormat { get; set; }

        /// <summary>
        /// The current status of the recording. Current possible values are 'processing', 'partial', 'complete', 'deleted', and 'error'. Additional states may be added in the future, so your application must be tolerant of unknown values.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets MediaUrl.
        /// </summary>
        [JsonProperty("mediaUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string MediaUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConferenceRecordingMetadata : ({string.Join(", ", toStringOutput)})";
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

            return obj is ConferenceRecordingMetadata other &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.ConferenceId == null && other.ConferenceId == null) || (this.ConferenceId?.Equals(other.ConferenceId) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.RecordingId == null && other.RecordingId == null) || (this.RecordingId?.Equals(other.RecordingId) == true)) &&
                ((this.Duration == null && other.Duration == null) || (this.Duration?.Equals(other.Duration) == true)) &&
                ((this.Channels == null && other.Channels == null) || (this.Channels?.Equals(other.Channels) == true)) &&
                ((this.StartTime == null && other.StartTime == null) || (this.StartTime?.Equals(other.StartTime) == true)) &&
                ((this.EndTime == null && other.EndTime == null) || (this.EndTime?.Equals(other.EndTime) == true)) &&
                ((this.FileFormat == null && other.FileFormat == null) || (this.FileFormat?.Equals(other.FileFormat) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.MediaUrl == null && other.MediaUrl == null) || (this.MediaUrl?.Equals(other.MediaUrl) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1945146499;

            if (this.AccountId != null)
            {
               hashCode += this.AccountId.GetHashCode();
            }

            if (this.ConferenceId != null)
            {
               hashCode += this.ConferenceId.GetHashCode();
            }

            if (this.Name != null)
            {
               hashCode += this.Name.GetHashCode();
            }

            if (this.RecordingId != null)
            {
               hashCode += this.RecordingId.GetHashCode();
            }

            if (this.Duration != null)
            {
               hashCode += this.Duration.GetHashCode();
            }

            if (this.Channels != null)
            {
               hashCode += this.Channels.GetHashCode();
            }

            if (this.StartTime != null)
            {
               hashCode += this.StartTime.GetHashCode();
            }

            if (this.EndTime != null)
            {
               hashCode += this.EndTime.GetHashCode();
            }

            if (this.FileFormat != null)
            {
               hashCode += this.FileFormat.GetHashCode();
            }

            if (this.Status != null)
            {
               hashCode += this.Status.GetHashCode();
            }

            if (this.MediaUrl != null)
            {
               hashCode += this.MediaUrl.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId == string.Empty ? "" : this.AccountId)}");
            toStringOutput.Add($"this.ConferenceId = {(this.ConferenceId == null ? "null" : this.ConferenceId == string.Empty ? "" : this.ConferenceId)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.RecordingId = {(this.RecordingId == null ? "null" : this.RecordingId == string.Empty ? "" : this.RecordingId)}");
            toStringOutput.Add($"this.Duration = {(this.Duration == null ? "null" : this.Duration == string.Empty ? "" : this.Duration)}");
            toStringOutput.Add($"this.Channels = {(this.Channels == null ? "null" : this.Channels.ToString())}");
            toStringOutput.Add($"this.StartTime = {(this.StartTime == null ? "null" : this.StartTime.ToString())}");
            toStringOutput.Add($"this.EndTime = {(this.EndTime == null ? "null" : this.EndTime.ToString())}");
            toStringOutput.Add($"this.FileFormat = {(this.FileFormat == null ? "null" : this.FileFormat.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.MediaUrl = {(this.MediaUrl == null ? "null" : this.MediaUrl == string.Empty ? "" : this.MediaUrl)}");
        }
    }
}