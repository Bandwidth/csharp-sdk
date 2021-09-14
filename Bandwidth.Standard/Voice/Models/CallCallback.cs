// <copyright file="CallCallback.cs" company="APIMatic">
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
    /// CallCallback.
    /// </summary>
    public class CallCallback
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallCallback"/> class.
        /// </summary>
        public CallCallback()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallCallback"/> class.
        /// </summary>
        /// <param name="eventType">eventType.</param>
        /// <param name="eventTime">eventTime.</param>
        /// <param name="accountId">accountId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="from">from.</param>
        /// <param name="to">to.</param>
        /// <param name="direction">direction.</param>
        /// <param name="callId">callId.</param>
        /// <param name="callUrl">callUrl.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="answerTime">answerTime.</param>
        /// <param name="transferCallerId">transferCallerId.</param>
        /// <param name="transferTo">transferTo.</param>
        /// <param name="cause">cause.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="errorId">errorId.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="digit">digit.</param>
        /// <param name="parentCallId">parentCallId.</param>
        /// <param name="recordingId">recordingId.</param>
        /// <param name="duration">duration.</param>
        /// <param name="fileFormat">fileFormat.</param>
        /// <param name="mediaUrl">mediaUrl.</param>
        /// <param name="tag">tag.</param>
        /// <param name="channels">channels.</param>
        /// <param name="status">status.</param>
        /// <param name="digits">digits.</param>
        /// <param name="terminatingDigit">terminatingDigit.</param>
        /// <param name="transcription">transcription.</param>
        /// <param name="diversion">diversion.</param>
        public CallCallback(
            string eventType = null,
            string eventTime = null,
            string accountId = null,
            string applicationId = null,
            string from = null,
            string to = null,
            string direction = null,
            string callId = null,
            string callUrl = null,
            string startTime = null,
            string answerTime = null,
            string transferCallerId = null,
            string transferTo = null,
            string cause = null,
            string errorMessage = null,
            string errorId = null,
            string endTime = null,
            string digit = null,
            string parentCallId = null,
            string recordingId = null,
            string duration = null,
            string fileFormat = null,
            string mediaUrl = null,
            string tag = null,
            int? channels = null,
            string status = null,
            string digits = null,
            string terminatingDigit = null,
            Models.Transcription transcription = null,
            Models.Diversion diversion = null)
        {
            this.EventType = eventType;
            this.EventTime = eventTime;
            this.AccountId = accountId;
            this.ApplicationId = applicationId;
            this.From = from;
            this.To = to;
            this.Direction = direction;
            this.CallId = callId;
            this.CallUrl = callUrl;
            this.StartTime = startTime;
            this.AnswerTime = answerTime;
            this.TransferCallerId = transferCallerId;
            this.TransferTo = transferTo;
            this.Cause = cause;
            this.ErrorMessage = errorMessage;
            this.ErrorId = errorId;
            this.EndTime = endTime;
            this.Digit = digit;
            this.ParentCallId = parentCallId;
            this.RecordingId = recordingId;
            this.Duration = duration;
            this.FileFormat = fileFormat;
            this.MediaUrl = mediaUrl;
            this.Tag = tag;
            this.Channels = channels;
            this.Status = status;
            this.Digits = digits;
            this.TerminatingDigit = terminatingDigit;
            this.Transcription = transcription;
            this.Diversion = diversion;
        }

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
        /// Gets or sets AccountId.
        /// </summary>
        [JsonProperty("accountId", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets ApplicationId.
        /// </summary>
        [JsonProperty("applicationId", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets From.
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public string From { get; set; }

        /// <summary>
        /// Gets or sets To.
        /// </summary>
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public string To { get; set; }

        /// <summary>
        /// Gets or sets Direction.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets CallId.
        /// </summary>
        [JsonProperty("callId", NullValueHandling = NullValueHandling.Ignore)]
        public string CallId { get; set; }

        /// <summary>
        /// Gets or sets CallUrl.
        /// </summary>
        [JsonProperty("callUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string CallUrl { get; set; }

        /// <summary>
        /// Gets or sets StartTime.
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets AnswerTime.
        /// </summary>
        [JsonProperty("answerTime", NullValueHandling = NullValueHandling.Ignore)]
        public string AnswerTime { get; set; }

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
        /// Gets or sets Cause.
        /// </summary>
        [JsonProperty("cause", NullValueHandling = NullValueHandling.Ignore)]
        public string Cause { get; set; }

        /// <summary>
        /// Gets or sets ErrorMessage.
        /// </summary>
        [JsonProperty("errorMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets ErrorId.
        /// </summary>
        [JsonProperty("errorId", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorId { get; set; }

        /// <summary>
        /// Gets or sets EndTime.
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or sets Digit.
        /// </summary>
        [JsonProperty("digit", NullValueHandling = NullValueHandling.Ignore)]
        public string Digit { get; set; }

        /// <summary>
        /// Gets or sets ParentCallId.
        /// </summary>
        [JsonProperty("parentCallId", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentCallId { get; set; }

        /// <summary>
        /// Gets or sets RecordingId.
        /// </summary>
        [JsonProperty("recordingId", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordingId { get; set; }

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
        /// Gets or sets Tag.
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or sets Channels.
        /// </summary>
        [JsonProperty("channels", NullValueHandling = NullValueHandling.Ignore)]
        public int? Channels { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Digits.
        /// </summary>
        [JsonProperty("digits", NullValueHandling = NullValueHandling.Ignore)]
        public string Digits { get; set; }

        /// <summary>
        /// Gets or sets TerminatingDigit.
        /// </summary>
        [JsonProperty("terminatingDigit", NullValueHandling = NullValueHandling.Ignore)]
        public string TerminatingDigit { get; set; }

        /// <summary>
        /// Gets or sets Transcription.
        /// </summary>
        [JsonProperty("transcription", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Transcription Transcription { get; set; }

        /// <summary>
        /// Gets or sets Diversion.
        /// </summary>
        [JsonProperty("diversion", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Diversion Diversion { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CallCallback : ({string.Join(", ", toStringOutput)})";
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

            return obj is CallCallback other &&
                ((this.EventType == null && other.EventType == null) || (this.EventType?.Equals(other.EventType) == true)) &&
                ((this.EventTime == null && other.EventTime == null) || (this.EventTime?.Equals(other.EventTime) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.ApplicationId == null && other.ApplicationId == null) || (this.ApplicationId?.Equals(other.ApplicationId) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true)) &&
                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.Direction == null && other.Direction == null) || (this.Direction?.Equals(other.Direction) == true)) &&
                ((this.CallId == null && other.CallId == null) || (this.CallId?.Equals(other.CallId) == true)) &&
                ((this.CallUrl == null && other.CallUrl == null) || (this.CallUrl?.Equals(other.CallUrl) == true)) &&
                ((this.StartTime == null && other.StartTime == null) || (this.StartTime?.Equals(other.StartTime) == true)) &&
                ((this.AnswerTime == null && other.AnswerTime == null) || (this.AnswerTime?.Equals(other.AnswerTime) == true)) &&
                ((this.TransferCallerId == null && other.TransferCallerId == null) || (this.TransferCallerId?.Equals(other.TransferCallerId) == true)) &&
                ((this.TransferTo == null && other.TransferTo == null) || (this.TransferTo?.Equals(other.TransferTo) == true)) &&
                ((this.Cause == null && other.Cause == null) || (this.Cause?.Equals(other.Cause) == true)) &&
                ((this.ErrorMessage == null && other.ErrorMessage == null) || (this.ErrorMessage?.Equals(other.ErrorMessage) == true)) &&
                ((this.ErrorId == null && other.ErrorId == null) || (this.ErrorId?.Equals(other.ErrorId) == true)) &&
                ((this.EndTime == null && other.EndTime == null) || (this.EndTime?.Equals(other.EndTime) == true)) &&
                ((this.Digit == null && other.Digit == null) || (this.Digit?.Equals(other.Digit) == true)) &&
                ((this.ParentCallId == null && other.ParentCallId == null) || (this.ParentCallId?.Equals(other.ParentCallId) == true)) &&
                ((this.RecordingId == null && other.RecordingId == null) || (this.RecordingId?.Equals(other.RecordingId) == true)) &&
                ((this.Duration == null && other.Duration == null) || (this.Duration?.Equals(other.Duration) == true)) &&
                ((this.FileFormat == null && other.FileFormat == null) || (this.FileFormat?.Equals(other.FileFormat) == true)) &&
                ((this.MediaUrl == null && other.MediaUrl == null) || (this.MediaUrl?.Equals(other.MediaUrl) == true)) &&
                ((this.Tag == null && other.Tag == null) || (this.Tag?.Equals(other.Tag) == true)) &&
                ((this.Channels == null && other.Channels == null) || (this.Channels?.Equals(other.Channels) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Digits == null && other.Digits == null) || (this.Digits?.Equals(other.Digits) == true)) &&
                ((this.TerminatingDigit == null && other.TerminatingDigit == null) || (this.TerminatingDigit?.Equals(other.TerminatingDigit) == true)) &&
                ((this.Transcription == null && other.Transcription == null) || (this.Transcription?.Equals(other.Transcription) == true)) &&
                ((this.Diversion == null && other.Diversion == null) || (this.Diversion?.Equals(other.Diversion) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1610796767;

            if (this.EventType != null)
            {
               hashCode += this.EventType.GetHashCode();
            }

            if (this.EventTime != null)
            {
               hashCode += this.EventTime.GetHashCode();
            }

            if (this.AccountId != null)
            {
               hashCode += this.AccountId.GetHashCode();
            }

            if (this.ApplicationId != null)
            {
               hashCode += this.ApplicationId.GetHashCode();
            }

            if (this.From != null)
            {
               hashCode += this.From.GetHashCode();
            }

            if (this.To != null)
            {
               hashCode += this.To.GetHashCode();
            }

            if (this.Direction != null)
            {
               hashCode += this.Direction.GetHashCode();
            }

            if (this.CallId != null)
            {
               hashCode += this.CallId.GetHashCode();
            }

            if (this.CallUrl != null)
            {
               hashCode += this.CallUrl.GetHashCode();
            }

            if (this.StartTime != null)
            {
               hashCode += this.StartTime.GetHashCode();
            }

            if (this.AnswerTime != null)
            {
               hashCode += this.AnswerTime.GetHashCode();
            }

            if (this.TransferCallerId != null)
            {
               hashCode += this.TransferCallerId.GetHashCode();
            }

            if (this.TransferTo != null)
            {
               hashCode += this.TransferTo.GetHashCode();
            }

            if (this.Cause != null)
            {
               hashCode += this.Cause.GetHashCode();
            }

            if (this.ErrorMessage != null)
            {
               hashCode += this.ErrorMessage.GetHashCode();
            }

            if (this.ErrorId != null)
            {
               hashCode += this.ErrorId.GetHashCode();
            }

            if (this.EndTime != null)
            {
               hashCode += this.EndTime.GetHashCode();
            }

            if (this.Digit != null)
            {
               hashCode += this.Digit.GetHashCode();
            }

            if (this.ParentCallId != null)
            {
               hashCode += this.ParentCallId.GetHashCode();
            }

            if (this.RecordingId != null)
            {
               hashCode += this.RecordingId.GetHashCode();
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

            if (this.Tag != null)
            {
               hashCode += this.Tag.GetHashCode();
            }

            if (this.Channels != null)
            {
               hashCode += this.Channels.GetHashCode();
            }

            if (this.Status != null)
            {
               hashCode += this.Status.GetHashCode();
            }

            if (this.Digits != null)
            {
               hashCode += this.Digits.GetHashCode();
            }

            if (this.TerminatingDigit != null)
            {
               hashCode += this.TerminatingDigit.GetHashCode();
            }

            if (this.Transcription != null)
            {
               hashCode += this.Transcription.GetHashCode();
            }

            if (this.Diversion != null)
            {
               hashCode += this.Diversion.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EventType = {(this.EventType == null ? "null" : this.EventType == string.Empty ? "" : this.EventType)}");
            toStringOutput.Add($"this.EventTime = {(this.EventTime == null ? "null" : this.EventTime == string.Empty ? "" : this.EventTime)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId == string.Empty ? "" : this.AccountId)}");
            toStringOutput.Add($"this.ApplicationId = {(this.ApplicationId == null ? "null" : this.ApplicationId == string.Empty ? "" : this.ApplicationId)}");
            toStringOutput.Add($"this.From = {(this.From == null ? "null" : this.From == string.Empty ? "" : this.From)}");
            toStringOutput.Add($"this.To = {(this.To == null ? "null" : this.To == string.Empty ? "" : this.To)}");
            toStringOutput.Add($"this.Direction = {(this.Direction == null ? "null" : this.Direction == string.Empty ? "" : this.Direction)}");
            toStringOutput.Add($"this.CallId = {(this.CallId == null ? "null" : this.CallId == string.Empty ? "" : this.CallId)}");
            toStringOutput.Add($"this.CallUrl = {(this.CallUrl == null ? "null" : this.CallUrl == string.Empty ? "" : this.CallUrl)}");
            toStringOutput.Add($"this.StartTime = {(this.StartTime == null ? "null" : this.StartTime == string.Empty ? "" : this.StartTime)}");
            toStringOutput.Add($"this.AnswerTime = {(this.AnswerTime == null ? "null" : this.AnswerTime == string.Empty ? "" : this.AnswerTime)}");
            toStringOutput.Add($"this.TransferCallerId = {(this.TransferCallerId == null ? "null" : this.TransferCallerId == string.Empty ? "" : this.TransferCallerId)}");
            toStringOutput.Add($"this.TransferTo = {(this.TransferTo == null ? "null" : this.TransferTo == string.Empty ? "" : this.TransferTo)}");
            toStringOutput.Add($"this.Cause = {(this.Cause == null ? "null" : this.Cause == string.Empty ? "" : this.Cause)}");
            toStringOutput.Add($"this.ErrorMessage = {(this.ErrorMessage == null ? "null" : this.ErrorMessage == string.Empty ? "" : this.ErrorMessage)}");
            toStringOutput.Add($"this.ErrorId = {(this.ErrorId == null ? "null" : this.ErrorId == string.Empty ? "" : this.ErrorId)}");
            toStringOutput.Add($"this.EndTime = {(this.EndTime == null ? "null" : this.EndTime == string.Empty ? "" : this.EndTime)}");
            toStringOutput.Add($"this.Digit = {(this.Digit == null ? "null" : this.Digit == string.Empty ? "" : this.Digit)}");
            toStringOutput.Add($"this.ParentCallId = {(this.ParentCallId == null ? "null" : this.ParentCallId == string.Empty ? "" : this.ParentCallId)}");
            toStringOutput.Add($"this.RecordingId = {(this.RecordingId == null ? "null" : this.RecordingId == string.Empty ? "" : this.RecordingId)}");
            toStringOutput.Add($"this.Duration = {(this.Duration == null ? "null" : this.Duration == string.Empty ? "" : this.Duration)}");
            toStringOutput.Add($"this.FileFormat = {(this.FileFormat == null ? "null" : this.FileFormat == string.Empty ? "" : this.FileFormat)}");
            toStringOutput.Add($"this.MediaUrl = {(this.MediaUrl == null ? "null" : this.MediaUrl == string.Empty ? "" : this.MediaUrl)}");
            toStringOutput.Add($"this.Tag = {(this.Tag == null ? "null" : this.Tag == string.Empty ? "" : this.Tag)}");
            toStringOutput.Add($"this.Channels = {(this.Channels == null ? "null" : this.Channels.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.Digits = {(this.Digits == null ? "null" : this.Digits == string.Empty ? "" : this.Digits)}");
            toStringOutput.Add($"this.TerminatingDigit = {(this.TerminatingDigit == null ? "null" : this.TerminatingDigit == string.Empty ? "" : this.TerminatingDigit)}");
            toStringOutput.Add($"this.Transcription = {(this.Transcription == null ? "null" : this.Transcription.ToString())}");
            toStringOutput.Add($"this.Diversion = {(this.Diversion == null ? "null" : this.Diversion.ToString())}");
        }
    }
}