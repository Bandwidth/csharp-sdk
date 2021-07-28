// <copyright file="CallRecordingMetadata.cs" company="APIMatic">
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
    /// CallRecordingMetadata.
    /// </summary>
    public class CallRecordingMetadata
    {
        private string parentCallId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "parentCallId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CallRecordingMetadata"/> class.
        /// </summary>
        public CallRecordingMetadata()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallRecordingMetadata"/> class.
        /// </summary>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="accountId">accountId.</param>
        /// <param name="callId">callId.</param>
        /// <param name="parentCallId">parentCallId.</param>
        /// <param name="recordingId">recordingId.</param>
        /// <param name="to">to.</param>
        /// <param name="from">from.</param>
        /// <param name="transferCallerId">transferCallerId.</param>
        /// <param name="transferTo">transferTo.</param>
        /// <param name="duration">duration.</param>
        /// <param name="direction">direction.</param>
        /// <param name="channels">channels.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="fileFormat">fileFormat.</param>
        /// <param name="status">status.</param>
        /// <param name="mediaUrl">mediaUrl.</param>
        /// <param name="transcription">transcription.</param>
        public CallRecordingMetadata(
            string applicationId = null,
            string accountId = null,
            string callId = null,
            string parentCallId = null,
            string recordingId = null,
            string to = null,
            string from = null,
            string transferCallerId = null,
            string transferTo = null,
            string duration = null,
            Models.DirectionEnum? direction = null,
            int? channels = null,
            DateTime? startTime = null,
            DateTime? endTime = null,
            Models.FileFormatEnum? fileFormat = null,
            string status = null,
            string mediaUrl = null,
            Models.TranscriptionMetadata transcription = null)
        {
            this.ApplicationId = applicationId;
            this.AccountId = accountId;
            this.CallId = callId;
            if (parentCallId != null)
            {
                this.ParentCallId = parentCallId;
            }

            this.RecordingId = recordingId;
            this.To = to;
            this.From = from;
            this.TransferCallerId = transferCallerId;
            this.TransferTo = transferTo;
            this.Duration = duration;
            this.Direction = direction;
            this.Channels = channels;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.FileFormat = fileFormat;
            this.Status = status;
            this.MediaUrl = mediaUrl;
            this.Transcription = transcription;
        }

        /// <summary>
        /// Gets or sets ApplicationId.
        /// </summary>
        [JsonProperty("applicationId", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets AccountId.
        /// </summary>
        [JsonProperty("accountId", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets CallId.
        /// </summary>
        [JsonProperty("callId", NullValueHandling = NullValueHandling.Ignore)]
        public string CallId { get; set; }

        /// <summary>
        /// Gets or sets ParentCallId.
        /// </summary>
        [JsonProperty("parentCallId")]
        public string ParentCallId
        {
            get
            {
                return this.parentCallId;
            }

            set
            {
                this.shouldSerialize["parentCallId"] = true;
                this.parentCallId = value;
            }
        }

        /// <summary>
        /// Gets or sets RecordingId.
        /// </summary>
        [JsonProperty("recordingId", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordingId { get; set; }

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
        /// Gets or sets TransferCallerId.
        /// </summary>
        [JsonProperty("transferCallerId", NullValueHandling = NullValueHandling.Ignore)]
        public string TransferCallerId { get; set; }

        /// <summary>
        /// Gets or sets TransferTo.
        /// </summary>
        [JsonProperty("transferTo", NullValueHandling = NullValueHandling.Ignore)]
        public string TransferTo { get; set; }

        /// <summary>
        /// Format is ISO-8601
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets Direction.
        /// </summary>
        [JsonProperty("direction", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectionEnum? Direction { get; set; }

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
        /// The current status of the recording. Current values are 'processing', 'partial', 'complete', 'deleted' and 'error'. Additional states may be added in the future, so your application must be tolerant of unknown values.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets MediaUrl.
        /// </summary>
        [JsonProperty("mediaUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string MediaUrl { get; set; }

        /// <summary>
        /// Gets or sets Transcription.
        /// </summary>
        [JsonProperty("transcription", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TranscriptionMetadata Transcription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CallRecordingMetadata : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetParentCallId()
        {
            this.shouldSerialize["parentCallId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeParentCallId()
        {
            return this.shouldSerialize["parentCallId"];
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

            return obj is CallRecordingMetadata other &&
                ((this.ApplicationId == null && other.ApplicationId == null) || (this.ApplicationId?.Equals(other.ApplicationId) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.CallId == null && other.CallId == null) || (this.CallId?.Equals(other.CallId) == true)) &&
                ((this.ParentCallId == null && other.ParentCallId == null) || (this.ParentCallId?.Equals(other.ParentCallId) == true)) &&
                ((this.RecordingId == null && other.RecordingId == null) || (this.RecordingId?.Equals(other.RecordingId) == true)) &&
                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true)) &&
                ((this.TransferCallerId == null && other.TransferCallerId == null) || (this.TransferCallerId?.Equals(other.TransferCallerId) == true)) &&
                ((this.TransferTo == null && other.TransferTo == null) || (this.TransferTo?.Equals(other.TransferTo) == true)) &&
                ((this.Duration == null && other.Duration == null) || (this.Duration?.Equals(other.Duration) == true)) &&
                ((this.Direction == null && other.Direction == null) || (this.Direction?.Equals(other.Direction) == true)) &&
                ((this.Channels == null && other.Channels == null) || (this.Channels?.Equals(other.Channels) == true)) &&
                ((this.StartTime == null && other.StartTime == null) || (this.StartTime?.Equals(other.StartTime) == true)) &&
                ((this.EndTime == null && other.EndTime == null) || (this.EndTime?.Equals(other.EndTime) == true)) &&
                ((this.FileFormat == null && other.FileFormat == null) || (this.FileFormat?.Equals(other.FileFormat) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.MediaUrl == null && other.MediaUrl == null) || (this.MediaUrl?.Equals(other.MediaUrl) == true)) &&
                ((this.Transcription == null && other.Transcription == null) || (this.Transcription?.Equals(other.Transcription) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -824134494;

            if (this.ApplicationId != null)
            {
               hashCode += this.ApplicationId.GetHashCode();
            }

            if (this.AccountId != null)
            {
               hashCode += this.AccountId.GetHashCode();
            }

            if (this.CallId != null)
            {
               hashCode += this.CallId.GetHashCode();
            }

            if (this.ParentCallId != null)
            {
               hashCode += this.ParentCallId.GetHashCode();
            }

            if (this.RecordingId != null)
            {
               hashCode += this.RecordingId.GetHashCode();
            }

            if (this.To != null)
            {
               hashCode += this.To.GetHashCode();
            }

            if (this.From != null)
            {
               hashCode += this.From.GetHashCode();
            }

            if (this.TransferCallerId != null)
            {
               hashCode += this.TransferCallerId.GetHashCode();
            }

            if (this.TransferTo != null)
            {
               hashCode += this.TransferTo.GetHashCode();
            }

            if (this.Duration != null)
            {
               hashCode += this.Duration.GetHashCode();
            }

            if (this.Direction != null)
            {
               hashCode += this.Direction.GetHashCode();
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

            if (this.Transcription != null)
            {
               hashCode += this.Transcription.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ApplicationId = {(this.ApplicationId == null ? "null" : this.ApplicationId == string.Empty ? "" : this.ApplicationId)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId == string.Empty ? "" : this.AccountId)}");
            toStringOutput.Add($"this.CallId = {(this.CallId == null ? "null" : this.CallId == string.Empty ? "" : this.CallId)}");
            toStringOutput.Add($"this.ParentCallId = {(this.ParentCallId == null ? "null" : this.ParentCallId == string.Empty ? "" : this.ParentCallId)}");
            toStringOutput.Add($"this.RecordingId = {(this.RecordingId == null ? "null" : this.RecordingId == string.Empty ? "" : this.RecordingId)}");
            toStringOutput.Add($"this.To = {(this.To == null ? "null" : this.To == string.Empty ? "" : this.To)}");
            toStringOutput.Add($"this.From = {(this.From == null ? "null" : this.From == string.Empty ? "" : this.From)}");
            toStringOutput.Add($"this.TransferCallerId = {(this.TransferCallerId == null ? "null" : this.TransferCallerId == string.Empty ? "" : this.TransferCallerId)}");
            toStringOutput.Add($"this.TransferTo = {(this.TransferTo == null ? "null" : this.TransferTo == string.Empty ? "" : this.TransferTo)}");
            toStringOutput.Add($"this.Duration = {(this.Duration == null ? "null" : this.Duration == string.Empty ? "" : this.Duration)}");
            toStringOutput.Add($"this.Direction = {(this.Direction == null ? "null" : this.Direction.ToString())}");
            toStringOutput.Add($"this.Channels = {(this.Channels == null ? "null" : this.Channels.ToString())}");
            toStringOutput.Add($"this.StartTime = {(this.StartTime == null ? "null" : this.StartTime.ToString())}");
            toStringOutput.Add($"this.EndTime = {(this.EndTime == null ? "null" : this.EndTime.ToString())}");
            toStringOutput.Add($"this.FileFormat = {(this.FileFormat == null ? "null" : this.FileFormat.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.MediaUrl = {(this.MediaUrl == null ? "null" : this.MediaUrl == string.Empty ? "" : this.MediaUrl)}");
            toStringOutput.Add($"this.Transcription = {(this.Transcription == null ? "null" : this.Transcription.ToString())}");
        }
    }
}