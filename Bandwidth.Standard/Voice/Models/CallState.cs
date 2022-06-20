// <copyright file="CallState.cs" company="APIMatic">
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
    /// CallState.
    /// </summary>
    public class CallState
    {
        private string parentCallId;
        private string identity;
        private DateTime? answerTime;
        private DateTime? endTime;
        private string disconnectCause;
        private string errorMessage;
        private string errorId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "parentCallId", false },
            { "identity", false },
            { "answerTime", false },
            { "endTime", false },
            { "disconnectCause", false },
            { "errorMessage", false },
            { "errorId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CallState"/> class.
        /// </summary>
        public CallState()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallState"/> class.
        /// </summary>
        /// <param name="callId">callId.</param>
        /// <param name="parentCallId">parentCallId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="accountId">accountId.</param>
        /// <param name="to">to.</param>
        /// <param name="from">from.</param>
        /// <param name="direction">direction.</param>
        /// <param name="state">state.</param>
        /// <param name="identity">identity.</param>
        /// <param name="stirShaken">stirShaken.</param>
        /// <param name="enqueuedTime">enqueuedTime.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="answerTime">answerTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="disconnectCause">disconnectCause.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="errorId">errorId.</param>
        /// <param name="lastUpdate">lastUpdate.</param>
        public CallState(
            string callId = null,
            string parentCallId = null,
            string applicationId = null,
            string accountId = null,
            string to = null,
            string from = null,
            string direction = null,
            string state = null,
            string identity = null,
            Dictionary<string, string> stirShaken = null,
            DateTime? enqueuedTime = null,
            DateTime? startTime = null,
            DateTime? answerTime = null,
            DateTime? endTime = null,
            string disconnectCause = null,
            string errorMessage = null,
            string errorId = null,
            DateTime? lastUpdate = null)
        {
            this.CallId = callId;
            if (parentCallId != null)
            {
                this.ParentCallId = parentCallId;
            }

            this.ApplicationId = applicationId;
            this.AccountId = accountId;
            this.To = to;
            this.From = from;
            this.Direction = direction;
            this.State = state;
            if (identity != null)
            {
                this.Identity = identity;
            }

            this.StirShaken = stirShaken;
            this.EnqueuedTime = enqueuedTime;
            this.StartTime = startTime;
            if (answerTime != null)
            {
                this.AnswerTime = answerTime;
            }

            if (endTime != null)
            {
                this.EndTime = endTime;
            }

            if (disconnectCause != null)
            {
                this.DisconnectCause = disconnectCause;
            }

            if (errorMessage != null)
            {
                this.ErrorMessage = errorMessage;
            }

            if (errorId != null)
            {
                this.ErrorId = errorId;
            }

            this.LastUpdate = lastUpdate;
        }

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
        /// Gets or sets Direction.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// The current state of the call. Current possible values are 'initiated', 'answered' and 'disconnected'. Additional states may be added in the future, so your application must be tolerant of unknown values.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets Identity.
        /// </summary>
        [JsonProperty("identity")]
        public string Identity
        {
            get
            {
                return this.identity;
            }

            set
            {
                this.shouldSerialize["identity"] = true;
                this.identity = value;
            }
        }

        /// <summary>
        /// Gets or sets StirShaken.
        /// </summary>
        [JsonProperty("stirShaken", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> StirShaken { get; set; }

        /// <summary>
        /// Gets or sets EnqueuedTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("enqueuedTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EnqueuedTime { get; set; }

        /// <summary>
        /// Gets or sets StartTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets AnswerTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("answerTime")]
        public DateTime? AnswerTime
        {
            get
            {
                return this.answerTime;
            }

            set
            {
                this.shouldSerialize["answerTime"] = true;
                this.answerTime = value;
            }
        }

        /// <summary>
        /// Gets or sets EndTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("endTime")]
        public DateTime? EndTime
        {
            get
            {
                return this.endTime;
            }

            set
            {
                this.shouldSerialize["endTime"] = true;
                this.endTime = value;
            }
        }

        /// <summary>
        /// The reason the call was disconnected, or null if the call is still active. Current values are 'cancel', 'timeout', 'busy', 'rejected', 'hangup', 'invalid-bxml', 'callback-error', 'application-error', 'error', 'account-limit', 'node-capacity-exceeded' and 'unknown'. Additional causes may be added in the future, so your application must be tolerant of unknown values.
        /// </summary>
        [JsonProperty("disconnectCause")]
        public string DisconnectCause
        {
            get
            {
                return this.disconnectCause;
            }

            set
            {
                this.shouldSerialize["disconnectCause"] = true;
                this.disconnectCause = value;
            }
        }

        /// <summary>
        /// Gets or sets ErrorMessage.
        /// </summary>
        [JsonProperty("errorMessage")]
        public string ErrorMessage
        {
            get
            {
                return this.errorMessage;
            }

            set
            {
                this.shouldSerialize["errorMessage"] = true;
                this.errorMessage = value;
            }
        }

        /// <summary>
        /// Gets or sets ErrorId.
        /// </summary>
        [JsonProperty("errorId")]
        public string ErrorId
        {
            get
            {
                return this.errorId;
            }

            set
            {
                this.shouldSerialize["errorId"] = true;
                this.errorId = value;
            }
        }

        /// <summary>
        /// Gets or sets LastUpdate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastUpdate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CallState : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetParentCallId()
        {
            this.shouldSerialize["parentCallId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIdentity()
        {
            this.shouldSerialize["identity"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAnswerTime()
        {
            this.shouldSerialize["answerTime"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEndTime()
        {
            this.shouldSerialize["endTime"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDisconnectCause()
        {
            this.shouldSerialize["disconnectCause"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetErrorMessage()
        {
            this.shouldSerialize["errorMessage"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetErrorId()
        {
            this.shouldSerialize["errorId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeParentCallId()
        {
            return this.shouldSerialize["parentCallId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIdentity()
        {
            return this.shouldSerialize["identity"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnswerTime()
        {
            return this.shouldSerialize["answerTime"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEndTime()
        {
            return this.shouldSerialize["endTime"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDisconnectCause()
        {
            return this.shouldSerialize["disconnectCause"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeErrorMessage()
        {
            return this.shouldSerialize["errorMessage"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeErrorId()
        {
            return this.shouldSerialize["errorId"];
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

            return obj is CallState other &&
                ((this.CallId == null && other.CallId == null) || (this.CallId?.Equals(other.CallId) == true)) &&
                ((this.ParentCallId == null && other.ParentCallId == null) || (this.ParentCallId?.Equals(other.ParentCallId) == true)) &&
                ((this.ApplicationId == null && other.ApplicationId == null) || (this.ApplicationId?.Equals(other.ApplicationId) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true)) &&
                ((this.Direction == null && other.Direction == null) || (this.Direction?.Equals(other.Direction) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Identity == null && other.Identity == null) || (this.Identity?.Equals(other.Identity) == true)) &&
                ((this.StirShaken == null && other.StirShaken == null) || (this.StirShaken?.Equals(other.StirShaken) == true)) &&
                ((this.EnqueuedTime == null && other.EnqueuedTime == null) || this.EnqueuedTime?.Equals(other.EnqueuedTime) == true) &&
                ((this.StartTime == null && other.StartTime == null) || (this.StartTime?.Equals(other.StartTime) == true)) &&
                ((this.AnswerTime == null && other.AnswerTime == null) || (this.AnswerTime?.Equals(other.AnswerTime) == true)) &&
                ((this.EndTime == null && other.EndTime == null) || (this.EndTime?.Equals(other.EndTime) == true)) &&
                ((this.DisconnectCause == null && other.DisconnectCause == null) || (this.DisconnectCause?.Equals(other.DisconnectCause) == true)) &&
                ((this.ErrorMessage == null && other.ErrorMessage == null) || (this.ErrorMessage?.Equals(other.ErrorMessage) == true)) &&
                ((this.ErrorId == null && other.ErrorId == null) || (this.ErrorId?.Equals(other.ErrorId) == true)) &&
                ((this.LastUpdate == null && other.LastUpdate == null) || (this.LastUpdate?.Equals(other.LastUpdate) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1153789297;

            if (this.CallId != null)
            {
               hashCode += this.CallId.GetHashCode();
            }

            if (this.ParentCallId != null)
            {
               hashCode += this.ParentCallId.GetHashCode();
            }

            if (this.ApplicationId != null)
            {
               hashCode += this.ApplicationId.GetHashCode();
            }

            if (this.AccountId != null)
            {
               hashCode += this.AccountId.GetHashCode();
            }

            if (this.To != null)
            {
               hashCode += this.To.GetHashCode();
            }

            if (this.From != null)
            {
               hashCode += this.From.GetHashCode();
            }

            if (this.Direction != null)
            {
               hashCode += this.Direction.GetHashCode();
            }

            if (this.State != null)
            {
               hashCode += this.State.GetHashCode();
            }

            if (this.Identity != null)
            {
               hashCode += this.Identity.GetHashCode();
            }

            if (this.StirShaken != null)
            {
               hashCode += this.StirShaken.GetHashCode();
            }

            if (this.EnqueuedTime != null)
            {
               hashCode += this.EnqueuedTime.GetHashCode();
            } 
            
            if (this.StartTime != null)
            {
               hashCode += this.StartTime.GetHashCode();
            }

            if (this.AnswerTime != null)
            {
               hashCode += this.AnswerTime.GetHashCode();
            }

            if (this.EndTime != null)
            {
               hashCode += this.EndTime.GetHashCode();
            }

            if (this.DisconnectCause != null)
            {
               hashCode += this.DisconnectCause.GetHashCode();
            }

            if (this.ErrorMessage != null)
            {
               hashCode += this.ErrorMessage.GetHashCode();
            }

            if (this.ErrorId != null)
            {
               hashCode += this.ErrorId.GetHashCode();
            }

            if (this.LastUpdate != null)
            {
               hashCode += this.LastUpdate.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CallId = {(this.CallId == null ? "null" : this.CallId == string.Empty ? "" : this.CallId)}");
            toStringOutput.Add($"this.ParentCallId = {(this.ParentCallId == null ? "null" : this.ParentCallId == string.Empty ? "" : this.ParentCallId)}");
            toStringOutput.Add($"this.ApplicationId = {(this.ApplicationId == null ? "null" : this.ApplicationId == string.Empty ? "" : this.ApplicationId)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId == string.Empty ? "" : this.AccountId)}");
            toStringOutput.Add($"this.To = {(this.To == null ? "null" : this.To == string.Empty ? "" : this.To)}");
            toStringOutput.Add($"this.From = {(this.From == null ? "null" : this.From == string.Empty ? "" : this.From)}");
            toStringOutput.Add($"this.Direction = {(this.Direction == null ? "null" : this.Direction == string.Empty ? "" : this.Direction)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State == string.Empty ? "" : this.State)}");
            toStringOutput.Add($"this.Identity = {(this.Identity == null ? "null" : this.Identity == string.Empty ? "" : this.Identity)}");
            toStringOutput.Add($"StirShaken = {(this.StirShaken == null ? "null" : this.StirShaken.ToString())}");
            toStringOutput.Add($"this.EnqueuedTime = {(this.EnqueuedTime == null ? "null" : this.EnqueuedTime.ToString())}");
            toStringOutput.Add($"this.StartTime = {(this.StartTime == null ? "null" : this.StartTime.ToString())}");
            toStringOutput.Add($"this.AnswerTime = {(this.AnswerTime == null ? "null" : this.AnswerTime.ToString())}");
            toStringOutput.Add($"this.EndTime = {(this.EndTime == null ? "null" : this.EndTime.ToString())}");
            toStringOutput.Add($"this.DisconnectCause = {(this.DisconnectCause == null ? "null" : this.DisconnectCause == string.Empty ? "" : this.DisconnectCause)}");
            toStringOutput.Add($"this.ErrorMessage = {(this.ErrorMessage == null ? "null" : this.ErrorMessage == string.Empty ? "" : this.ErrorMessage)}");
            toStringOutput.Add($"this.ErrorId = {(this.ErrorId == null ? "null" : this.ErrorId == string.Empty ? "" : this.ErrorId)}");
            toStringOutput.Add($"this.LastUpdate = {(this.LastUpdate == null ? "null" : this.LastUpdate.ToString())}");
        }
    }
}
