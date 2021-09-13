// <copyright file="ConferenceCallback.cs" company="APIMatic">
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
    /// ConferenceCallback.
    /// </summary>
    public class ConferenceCallback
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceCallback"/> class.
        /// </summary>
        public ConferenceCallback()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceCallback"/> class.
        /// </summary>
        /// <param name="conferenceId">conferenceId.</param>
        /// <param name="name">name.</param>
        /// <param name="eventType">eventType.</param>
        /// <param name="eventTime">eventTime.</param>
        /// <param name="tag">tag.</param>
        /// <param name="callId">callId.</param>
        /// <param name="to">to.</param>
        /// <param name="from">from.</param>
        /// <param name="accountId">accountId.</param>
        /// <param name="recordingId">recordingId.</param>
        /// <param name="channels">channels.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="duration">duration.</param>
        /// <param name="fileFormat">fileFormat.</param>
        /// <param name="mediaUrl">mediaUrl.</param>
        /// <param name="status">status.</param>
        public ConferenceCallback(
            string conferenceId = null,
            string name = null,
            string eventType = null,
            string eventTime = null,
            string tag = null,
            string callId = null,
            string to = null,
            string from = null,
            string accountId = null,
            string recordingId = null,
            int? channels = null,
            string startTime = null,
            string endTime = null,
            string duration = null,
            string fileFormat = null,
            string mediaUrl = null,
            string status = null)
        {
            this.ConferenceId = conferenceId;
            this.Name = name;
            this.EventType = eventType;
            this.EventTime = eventTime;
            this.Tag = tag;
            this.CallId = callId;
            this.To = to;
            this.From = from;
            this.AccountId = accountId;
            this.RecordingId = recordingId;
            this.Channels = channels;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Duration = duration;
            this.FileFormat = fileFormat;
            this.MediaUrl = mediaUrl;
            this.Status = status;
        }

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
        /// Gets or sets EventType.
        /// </summary>
        [JsonProperty("eventType", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or sets EventTime.
        /// </summary>
        [JsonProperty("eventTime", NullValueHandling = NullValueHandling.Ignore)]
        public string EventTime { get; set; }

        /// <summary>
        /// Gets or sets Tag.
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or sets CallId.
        /// </summary>
        [JsonProperty("callId", NullValueHandling = NullValueHandling.Ignore)]
        public string CallId { get; set; }

        /// <summary>
        /// Gets or sets To.
        /// </summary>
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public string To { get; set; }

        /// <summary>
        /// Gets or sets From.
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public string From { get; set; }

        /// <summary>
        /// Gets or sets AccountId.
        /// </summary>
        [JsonProperty("accountId", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets RecordingId.
        /// </summary>
        [JsonProperty("recordingId", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordingId { get; set; }

        /// <summary>
        /// Gets or sets Channels.
        /// </summary>
        [JsonProperty("channels", NullValueHandling = NullValueHandling.Ignore)]
        public int? Channels { get; set; }

        /// <summary>
        /// Gets or sets StartTime.
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets EndTime.
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or sets Duration.
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets FileFormat.
        /// </summary>
        [JsonProperty("fileFormat", NullValueHandling = NullValueHandling.Ignore)]
        public string FileFormat { get; set; }

        /// <summary>
        /// Gets or sets MediaUrl.
        /// </summary>
        [JsonProperty("mediaUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string MediaUrl { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConferenceCallback : ({string.Join(", ", toStringOutput)})";
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

            return obj is ConferenceCallback other &&
                ((this.ConferenceId == null && other.ConferenceId == null) || (this.ConferenceId?.Equals(other.ConferenceId) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.EventType == null && other.EventType == null) || (this.EventType?.Equals(other.EventType) == true)) &&
                ((this.EventTime == null && other.EventTime == null) || (this.EventTime?.Equals(other.EventTime) == true)) &&
                ((this.Tag == null && other.Tag == null) || (this.Tag?.Equals(other.Tag) == true)) &&
                ((this.CallId == null && other.CallId == null) || (this.CallId?.Equals(other.CallId) == true)) &&
                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.RecordingId == null && other.RecordingId == null) || (this.RecordingId?.Equals(other.RecordingId) == true)) &&
                ((this.Channels == null && other.Channels == null) || (this.Channels?.Equals(other.Channels) == true)) &&
                ((this.StartTime == null && other.StartTime == null) || (this.StartTime?.Equals(other.StartTime) == true)) &&
                ((this.EndTime == null && other.EndTime == null) || (this.EndTime?.Equals(other.EndTime) == true)) &&
                ((this.Duration == null && other.Duration == null) || (this.Duration?.Equals(other.Duration) == true)) &&
                ((this.FileFormat == null && other.FileFormat == null) || (this.FileFormat?.Equals(other.FileFormat) == true)) &&
                ((this.MediaUrl == null && other.MediaUrl == null) || (this.MediaUrl?.Equals(other.MediaUrl) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1074560881;

            if (this.ConferenceId != null)
            {
               hashCode += this.ConferenceId.GetHashCode();
            }

            if (this.Name != null)
            {
               hashCode += this.Name.GetHashCode();
            }

            if (this.EventType != null)
            {
               hashCode += this.EventType.GetHashCode();
            }

            if (this.EventTime != null)
            {
               hashCode += this.EventTime.GetHashCode();
            }

            if (this.Tag != null)
            {
               hashCode += this.Tag.GetHashCode();
            }

            if (this.CallId != null)
            {
               hashCode += this.CallId.GetHashCode();
            }

            if (this.To != null)
            {
               hashCode += this.To.GetHashCode();
            }

            if (this.From != null)
            {
               hashCode += this.From.GetHashCode();
            }

            if (this.AccountId != null)
            {
               hashCode += this.AccountId.GetHashCode();
            }

            if (this.RecordingId != null)
            {
               hashCode += this.RecordingId.GetHashCode();
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

            if (this.Duration != null)
            {
               hashCode += this.Duration.GetHashCode();
            }

            if (this.FileFormat != null)
            {
               hashCode += this.FileFormat.GetHashCode();
            }

            if (this.MediaUrl != null)
            {
               hashCode += this.MediaUrl.GetHashCode();
            }

            if (this.Status != null)
            {
               hashCode += this.Status.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ConferenceId = {(this.ConferenceId == null ? "null" : this.ConferenceId == string.Empty ? "" : this.ConferenceId)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.EventType = {(this.EventType == null ? "null" : this.EventType == string.Empty ? "" : this.EventType)}");
            toStringOutput.Add($"this.EventTime = {(this.EventTime == null ? "null" : this.EventTime == string.Empty ? "" : this.EventTime)}");
            toStringOutput.Add($"this.Tag = {(this.Tag == null ? "null" : this.Tag == string.Empty ? "" : this.Tag)}");
            toStringOutput.Add($"this.CallId = {(this.CallId == null ? "null" : this.CallId == string.Empty ? "" : this.CallId)}");
            toStringOutput.Add($"this.To = {(this.To == null ? "null" : this.To == string.Empty ? "" : this.To)}");
            toStringOutput.Add($"this.From = {(this.From == null ? "null" : this.From == string.Empty ? "" : this.From)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId == string.Empty ? "" : this.AccountId)}");
            toStringOutput.Add($"this.RecordingId = {(this.RecordingId == null ? "null" : this.RecordingId == string.Empty ? "" : this.RecordingId)}");
            toStringOutput.Add($"this.Channels = {(this.Channels == null ? "null" : this.Channels.ToString())}");
            toStringOutput.Add($"this.StartTime = {(this.StartTime == null ? "null" : this.StartTime == string.Empty ? "" : this.StartTime)}");
            toStringOutput.Add($"this.EndTime = {(this.EndTime == null ? "null" : this.EndTime == string.Empty ? "" : this.EndTime)}");
            toStringOutput.Add($"this.Duration = {(this.Duration == null ? "null" : this.Duration == string.Empty ? "" : this.Duration)}");
            toStringOutput.Add($"this.FileFormat = {(this.FileFormat == null ? "null" : this.FileFormat == string.Empty ? "" : this.FileFormat)}");
            toStringOutput.Add($"this.MediaUrl = {(this.MediaUrl == null ? "null" : this.MediaUrl == string.Empty ? "" : this.MediaUrl)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
        }
    }
}