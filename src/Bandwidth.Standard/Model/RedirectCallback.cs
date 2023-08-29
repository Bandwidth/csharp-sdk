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
    /// The Redirect event is fired when a &lt;Redirect&gt; verb is executed. Its purpose is to get the next set of verbs from the calling application.
    /// </summary>
    [DataContract(Name = "redirectCallback")]
    public partial class RedirectCallback : IEquatable<RedirectCallback>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        public CallDirectionEnum? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectCallback" /> class.
        /// </summary>
        /// <param name="eventType">The event type, value can be one of the following: answer, bridgeComplete, bridgeTargetComplete, conferenceCreated, conferenceRedirect, conferenceMemberJoin, conferenceMemberExit, conferenceCompleted, conferenceRecordingAvailable, disconnect, dtmf, gather, initiate, machineDetectionComplete, recordingComplete, recordingAvailable, redirect, transcriptionAvailable, transferAnswer, transferComplete, transferDisconnect..</param>
        /// <param name="eventTime">The approximate UTC date and time when the event was generated by the Bandwidth server, in ISO 8601 format. This may not be exactly the time of event execution..</param>
        /// <param name="accountId">The user account associated with the call..</param>
        /// <param name="applicationId">The id of the application associated with the call..</param>
        /// <param name="from">The provided identifier of the caller: can be a phone number in E.164 format (e.g. +15555555555) or one of Private, Restricted, Unavailable, or Anonymous..</param>
        /// <param name="to">The phone number that received the call, in E.164 format (e.g. +15555555555)..</param>
        /// <param name="direction">direction.</param>
        /// <param name="callId">The call id associated with the event..</param>
        /// <param name="callUrl">The URL of the call associated with the event..</param>
        /// <param name="parentCallId">(optional) If the event is related to the B leg of a &lt;Transfer&gt;, the call id of the original call leg that executed the &lt;Transfer&gt;. Otherwise, this field will not be present..</param>
        /// <param name="enqueuedTime">(optional) If call queueing is enabled and this is an outbound call, time the call was queued, in ISO 8601 format..</param>
        /// <param name="startTime">Time the call was started, in ISO 8601 format..</param>
        /// <param name="answerTime">Time the call was answered, in ISO 8601 format..</param>
        /// <param name="tag">(optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present..</param>
        /// <param name="transferCallerId">The phone number used as the from field of the B-leg call, in E.164 format (e.g. +15555555555) or one of Restricted, Anonymous, Private, or Unavailable..</param>
        /// <param name="transferTo">The phone number used as the to field of the B-leg call, in E.164 format (e.g. +15555555555)..</param>
        public RedirectCallback(string eventType = default(string), DateTime eventTime = default(DateTime), string accountId = default(string), string applicationId = default(string), string from = default(string), string to = default(string), CallDirectionEnum? direction = default(CallDirectionEnum?), string callId = default(string), string callUrl = default(string), string parentCallId = default(string), DateTime? enqueuedTime = default(DateTime?), DateTime startTime = default(DateTime), DateTime? answerTime = default(DateTime?), string tag = default(string), string transferCallerId = default(string), string transferTo = default(string))
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
            this.ParentCallId = parentCallId;
            this.EnqueuedTime = enqueuedTime;
            this.StartTime = startTime;
            this.AnswerTime = answerTime;
            this.Tag = tag;
            this.TransferCallerId = transferCallerId;
            this.TransferTo = transferTo;
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
        /// (optional) If the event is related to the B leg of a &lt;Transfer&gt;, the call id of the original call leg that executed the &lt;Transfer&gt;. Otherwise, this field will not be present.
        /// </summary>
        /// <value>(optional) If the event is related to the B leg of a &lt;Transfer&gt;, the call id of the original call leg that executed the &lt;Transfer&gt;. Otherwise, this field will not be present.</value>
        /// <example>c-95ac8d6e-1a31c52e-b38f-4198-93c1-51633ec68f8d</example>
        [DataMember(Name = "parentCallId", EmitDefaultValue = false)]
        public string ParentCallId { get; set; }

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
        /// (optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present.
        /// </summary>
        /// <value>(optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present.</value>
        /// <example>exampleTag</example>
        [DataMember(Name = "tag", EmitDefaultValue = true)]
        public string Tag { get; set; }

        /// <summary>
        /// The phone number used as the from field of the B-leg call, in E.164 format (e.g. +15555555555) or one of Restricted, Anonymous, Private, or Unavailable.
        /// </summary>
        /// <value>The phone number used as the from field of the B-leg call, in E.164 format (e.g. +15555555555) or one of Restricted, Anonymous, Private, or Unavailable.</value>
        /// <example>+15555555555</example>
        [DataMember(Name = "transferCallerId", EmitDefaultValue = false)]
        public string TransferCallerId { get; set; }

        /// <summary>
        /// The phone number used as the to field of the B-leg call, in E.164 format (e.g. +15555555555).
        /// </summary>
        /// <value>The phone number used as the to field of the B-leg call, in E.164 format (e.g. +15555555555).</value>
        /// <example>+15555555555)</example>
        [DataMember(Name = "transferTo", EmitDefaultValue = false)]
        public string TransferTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RedirectCallback {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  CallUrl: ").Append(CallUrl).Append("\n");
            sb.Append("  ParentCallId: ").Append(ParentCallId).Append("\n");
            sb.Append("  EnqueuedTime: ").Append(EnqueuedTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  AnswerTime: ").Append(AnswerTime).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  TransferCallerId: ").Append(TransferCallerId).Append("\n");
            sb.Append("  TransferTo: ").Append(TransferTo).Append("\n");
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
            return this.Equals(input as RedirectCallback);
        }

        /// <summary>
        /// Returns true if RedirectCallback instances are equal
        /// </summary>
        /// <param name="input">Instance of RedirectCallback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RedirectCallback input)
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
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
                ) && 
                (
                    this.CallId == input.CallId ||
                    (this.CallId != null &&
                    this.CallId.Equals(input.CallId))
                ) && 
                (
                    this.CallUrl == input.CallUrl ||
                    (this.CallUrl != null &&
                    this.CallUrl.Equals(input.CallUrl))
                ) && 
                (
                    this.ParentCallId == input.ParentCallId ||
                    (this.ParentCallId != null &&
                    this.ParentCallId.Equals(input.ParentCallId))
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
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.TransferCallerId == input.TransferCallerId ||
                    (this.TransferCallerId != null &&
                    this.TransferCallerId.Equals(input.TransferCallerId))
                ) && 
                (
                    this.TransferTo == input.TransferTo ||
                    (this.TransferTo != null &&
                    this.TransferTo.Equals(input.TransferTo))
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
                hashCode = (hashCode * 59) + this.Direction.GetHashCode();
                if (this.CallId != null)
                {
                    hashCode = (hashCode * 59) + this.CallId.GetHashCode();
                }
                if (this.CallUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CallUrl.GetHashCode();
                }
                if (this.ParentCallId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentCallId.GetHashCode();
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
                if (this.Tag != null)
                {
                    hashCode = (hashCode * 59) + this.Tag.GetHashCode();
                }
                if (this.TransferCallerId != null)
                {
                    hashCode = (hashCode * 59) + this.TransferCallerId.GetHashCode();
                }
                if (this.TransferTo != null)
                {
                    hashCode = (hashCode * 59) + this.TransferTo.GetHashCode();
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
