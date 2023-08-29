/*
 * Bandwidth
 *
 * Bandwidth's Communication APIs
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: letstalk@bandwidth.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Bandwidth.Standard.Client.OpenAPIDateConverter;

namespace Bandwidth.Standard.Model
{
    /// <summary>
    /// The Disconnect event is fired when a call ends, for any reason.
    /// </summary>
    [DataContract(Name = "disconnectCallback")]
    public partial class DisconnectCallback : IEquatable<DisconnectCallback>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        public CallDirectionEnum? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DisconnectCallback" /> class.
        /// </summary>
        /// <param name="eventType">The event type, value can be one of the following: answer, bridgeComplete, bridgeTargetComplete, conferenceCreated, conferenceRedirect, conferenceMemberJoin, conferenceMemberExit, conferenceCompleted, conferenceRecordingAvailable, disconnect, dtmf, gather, initiate, machineDetectionComplete, recordingComplete, recordingAvailable, redirect, transcriptionAvailable, transferAnswer, transferComplete, transferDisconnect..</param>
        /// <param name="eventTime">The approximate UTC date and time when the event was generated by the Bandwidth server, in ISO 8601 format. This may not be exactly the time of event execution..</param>
        /// <param name="accountId">The user account associated with the call..</param>
        /// <param name="applicationId">The id of the application associated with the call..</param>
        /// <param name="from">The provided identifier of the caller: can be a phone number in E.164 format (e.g. +15555555555) or one of Private, Restricted, Unavailable, or Anonymous..</param>
        /// <param name="to">The phone number that received the call, in E.164 format (e.g. +15555555555)..</param>
        /// <param name="callId">The call id associated with the event..</param>
        /// <param name="direction">direction.</param>
        /// <param name="callUrl">The URL of the call associated with the event..</param>
        /// <param name="enqueuedTime">(optional) If call queueing is enabled and this is an outbound call, time the call was queued, in ISO 8601 format..</param>
        /// <param name="startTime">Time the call was started, in ISO 8601 format..</param>
        /// <param name="answerTime">Time the call was answered, in ISO 8601 format..</param>
        /// <param name="endTime">The time that the recording ended in ISO-8601 format.</param>
        /// <param name="cause">Reason the call failed - hangup, busy, timeout, cancel, rejected, callback-error, invalid-bxml, application-error, account-limit, node-capacity-exceeded, error, or unknown..</param>
        /// <param name="errorMessage">Text explaining the reason that caused the call to fail in case of errors..</param>
        /// <param name="errorId">Bandwidth&#39;s internal id that references the error event..</param>
        /// <param name="tag">(optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present..</param>
        public DisconnectCallback(string eventType = default(string), DateTime eventTime = default(DateTime), string accountId = default(string), string applicationId = default(string), string from = default(string), string to = default(string), string callId = default(string), CallDirectionEnum? direction = default(CallDirectionEnum?), string callUrl = default(string), DateTime? enqueuedTime = default(DateTime?), DateTime startTime = default(DateTime), DateTime? answerTime = default(DateTime?), DateTime endTime = default(DateTime), string cause = default(string), string errorMessage = default(string), string errorId = default(string), string tag = default(string))
        {
            this.EventType = eventType;
            this.EventTime = eventTime;
            this.AccountId = accountId;
            this.ApplicationId = applicationId;
            this.From = from;
            this.To = to;
            this.CallId = callId;
            this.Direction = direction;
            this.CallUrl = callUrl;
            this.EnqueuedTime = enqueuedTime;
            this.StartTime = startTime;
            this.AnswerTime = answerTime;
            this.EndTime = endTime;
            this.Cause = cause;
            this.ErrorMessage = errorMessage;
            this.ErrorId = errorId;
            this.Tag = tag;
        }

        /// <summary>
        /// The event type, value can be one of the following: answer, bridgeComplete, bridgeTargetComplete, conferenceCreated, conferenceRedirect, conferenceMemberJoin, conferenceMemberExit, conferenceCompleted, conferenceRecordingAvailable, disconnect, dtmf, gather, initiate, machineDetectionComplete, recordingComplete, recordingAvailable, redirect, transcriptionAvailable, transferAnswer, transferComplete, transferDisconnect.
        /// </summary>
        /// <value>The event type, value can be one of the following: answer, bridgeComplete, bridgeTargetComplete, conferenceCreated, conferenceRedirect, conferenceMemberJoin, conferenceMemberExit, conferenceCompleted, conferenceRecordingAvailable, disconnect, dtmf, gather, initiate, machineDetectionComplete, recordingComplete, recordingAvailable, redirect, transcriptionAvailable, transferAnswer, transferComplete, transferDisconnect.</value>
        /// <example>bridgeComplete</example>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// The approximate UTC date and time when the event was generated by the Bandwidth server, in ISO 8601 format. This may not be exactly the time of event execution.
        /// </summary>
        /// <value>The approximate UTC date and time when the event was generated by the Bandwidth server, in ISO 8601 format. This may not be exactly the time of event execution.</value>
        /// <example>2022-06-17T22:19:40.375Z</example>
        [DataMember(Name = "eventTime", EmitDefaultValue = false)]
        public DateTime EventTime { get; set; }

        /// <summary>
        /// The user account associated with the call.
        /// </summary>
        /// <value>The user account associated with the call.</value>
        /// <example>920012</example>
        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The id of the application associated with the call.
        /// </summary>
        /// <value>The id of the application associated with the call.</value>
        /// <example>04e88489-df02-4e34-a0ee-27a91849555f</example>
        [DataMember(Name = "applicationId", EmitDefaultValue = false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The provided identifier of the caller: can be a phone number in E.164 format (e.g. +15555555555) or one of Private, Restricted, Unavailable, or Anonymous.
        /// </summary>
        /// <value>The provided identifier of the caller: can be a phone number in E.164 format (e.g. +15555555555) or one of Private, Restricted, Unavailable, or Anonymous.</value>
        /// <example>+15555555555</example>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// The phone number that received the call, in E.164 format (e.g. +15555555555).
        /// </summary>
        /// <value>The phone number that received the call, in E.164 format (e.g. +15555555555).</value>
        /// <example>+15555555555</example>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// The call id associated with the event.
        /// </summary>
        /// <value>The call id associated with the event.</value>
        /// <example>c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85</example>
        [DataMember(Name = "callId", EmitDefaultValue = false)]
        public string CallId { get; set; }

        /// <summary>
        /// The URL of the call associated with the event.
        /// </summary>
        /// <value>The URL of the call associated with the event.</value>
        /// <example>https://voice.bandwidth.com/api/v2/accounts/9900000/calls/c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85</example>
        [DataMember(Name = "callUrl", EmitDefaultValue = false)]
        public string CallUrl { get; set; }

        /// <summary>
        /// (optional) If call queueing is enabled and this is an outbound call, time the call was queued, in ISO 8601 format.
        /// </summary>
        /// <value>(optional) If call queueing is enabled and this is an outbound call, time the call was queued, in ISO 8601 format.</value>
        /// <example>2022-06-17T22:20Z</example>
        [DataMember(Name = "enqueuedTime", EmitDefaultValue = true)]
        public DateTime? EnqueuedTime { get; set; }

        /// <summary>
        /// Time the call was started, in ISO 8601 format.
        /// </summary>
        /// <value>Time the call was started, in ISO 8601 format.</value>
        /// <example>2022-06-17T22:19:40.375Z</example>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Time the call was answered, in ISO 8601 format.
        /// </summary>
        /// <value>Time the call was answered, in ISO 8601 format.</value>
        /// <example>2022-06-17T22:20Z</example>
        [DataMember(Name = "answerTime", EmitDefaultValue = true)]
        public DateTime? AnswerTime { get; set; }

        /// <summary>
        /// The time that the recording ended in ISO-8601 format
        /// </summary>
        /// <value>The time that the recording ended in ISO-8601 format</value>
        /// <example>2022-06-17T22:20Z</example>
        [DataMember(Name = "endTime", EmitDefaultValue = false)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Reason the call failed - hangup, busy, timeout, cancel, rejected, callback-error, invalid-bxml, application-error, account-limit, node-capacity-exceeded, error, or unknown.
        /// </summary>
        /// <value>Reason the call failed - hangup, busy, timeout, cancel, rejected, callback-error, invalid-bxml, application-error, account-limit, node-capacity-exceeded, error, or unknown.</value>
        /// <example>busy</example>
        [DataMember(Name = "cause", EmitDefaultValue = false)]
        public string Cause { get; set; }

        /// <summary>
        /// Text explaining the reason that caused the call to fail in case of errors.
        /// </summary>
        /// <value>Text explaining the reason that caused the call to fail in case of errors.</value>
        /// <example>Call c-2a913f94-6a486f3a-3cae-4034-bcc3-f0c9fa77ca2f is already bridged with another call</example>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Bandwidth&#39;s internal id that references the error event.
        /// </summary>
        /// <value>Bandwidth&#39;s internal id that references the error event.</value>
        /// <example>4642074b-7b58-478b-96e4-3a60955c6765</example>
        [DataMember(Name = "errorId", EmitDefaultValue = true)]
        public string ErrorId { get; set; }

        /// <summary>
        /// (optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present.
        /// </summary>
        /// <value>(optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present.</value>
        /// <example>exampleTag</example>
        [DataMember(Name = "tag", EmitDefaultValue = true)]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DisconnectCallback {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  CallUrl: ").Append(CallUrl).Append("\n");
            sb.Append("  EnqueuedTime: ").Append(EnqueuedTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  AnswerTime: ").Append(AnswerTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Cause: ").Append(Cause).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  ErrorId: ").Append(ErrorId).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisconnectCallback);
        }

        /// <summary>
        /// Returns true if DisconnectCallback instances are equal
        /// </summary>
        /// <param name="input">Instance of DisconnectCallback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisconnectCallback input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.EventTime == input.EventTime ||
                    (this.EventTime != null &&
                    this.EventTime.Equals(input.EventTime))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.CallId == input.CallId ||
                    (this.CallId != null &&
                    this.CallId.Equals(input.CallId))
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
                ) && 
                (
                    this.CallUrl == input.CallUrl ||
                    (this.CallUrl != null &&
                    this.CallUrl.Equals(input.CallUrl))
                ) && 
                (
                    this.EnqueuedTime == input.EnqueuedTime ||
                    (this.EnqueuedTime != null &&
                    this.EnqueuedTime.Equals(input.EnqueuedTime))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.AnswerTime == input.AnswerTime ||
                    (this.AnswerTime != null &&
                    this.AnswerTime.Equals(input.AnswerTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Cause == input.Cause ||
                    (this.Cause != null &&
                    this.Cause.Equals(input.Cause))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.ErrorId == input.ErrorId ||
                    (this.ErrorId != null &&
                    this.ErrorId.Equals(input.ErrorId))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.EventTime != null)
                {
                    hashCode = (hashCode * 59) + this.EventTime.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.ApplicationId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationId.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.CallId != null)
                {
                    hashCode = (hashCode * 59) + this.CallId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Direction.GetHashCode();
                if (this.CallUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CallUrl.GetHashCode();
                }
                if (this.EnqueuedTime != null)
                {
                    hashCode = (hashCode * 59) + this.EnqueuedTime.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.AnswerTime != null)
                {
                    hashCode = (hashCode * 59) + this.AnswerTime.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.Cause != null)
                {
                    hashCode = (hashCode * 59) + this.Cause.GetHashCode();
                }
                if (this.ErrorMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorMessage.GetHashCode();
                }
                if (this.ErrorId != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorId.GetHashCode();
                }
                if (this.Tag != null)
                {
                    hashCode = (hashCode * 59) + this.Tag.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
