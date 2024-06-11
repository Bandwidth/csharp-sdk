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
    /// The Conference Member Exit event is fired whenever a caller exits a conference that specified a callbackUrl. The response may be either empty or a BXML document. Only the following verbs are valid for conferences: PlayAudio, SpeakSentence, StartRecording, StopRecording, PauseRecording, ResumeRecording. Audio verbs will be heard by all members of the conference. Recordings capture audio from all members who are not muted or on hold, as well as any audio verbs that are played into the conference.
    /// </summary>
    [DataContract(Name = "conferenceMemberExitCallback")]
    public partial class ConferenceMemberExitCallback : IEquatable<ConferenceMemberExitCallback>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceMemberExitCallback" /> class.
        /// </summary>
        /// <param name="eventType">The event type, value can be one of the following: answer, bridgeComplete, bridgeTargetComplete, conferenceCreated, conferenceRedirect, conferenceMemberJoin, conferenceMemberExit, conferenceCompleted, conferenceRecordingAvailable, disconnect, dtmf, gather, initiate, machineDetectionComplete, recordingComplete, recordingAvailable, redirect, transcriptionAvailable, transferAnswer, transferComplete, transferDisconnect..</param>
        /// <param name="eventTime">The approximate UTC date and time when the event was generated by the Bandwidth server, in ISO 8601 format. This may not be exactly the time of event execution..</param>
        /// <param name="conferenceId">The unique, Bandwidth-generated ID of the conference that was recorded.</param>
        /// <param name="name">The user-specified name of the conference that was recorded.</param>
        /// <param name="from">The provided identifier of the caller. Must be a phone number in E.164 format (e.g. +15555555555)..</param>
        /// <param name="to">The phone number that received the call, in E.164 format (e.g. +15555555555)..</param>
        /// <param name="callId">The call id associated with the event..</param>
        /// <param name="tag">(optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present..</param>
        public ConferenceMemberExitCallback(string eventType = default(string), DateTime eventTime = default(DateTime), string conferenceId = default(string), string name = default(string), string from = default(string), string to = default(string), string callId = default(string), string tag = default(string))
        {
            this.EventType = eventType;
            this.EventTime = eventTime;
            this.ConferenceId = conferenceId;
            this.Name = name;
            this.From = from;
            this.To = to;
            this.CallId = callId;
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
        /// The unique, Bandwidth-generated ID of the conference that was recorded
        /// </summary>
        /// <value>The unique, Bandwidth-generated ID of the conference that was recorded</value>
        /// <example>conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9</example>
        [DataMember(Name = "conferenceId", EmitDefaultValue = false)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// The user-specified name of the conference that was recorded
        /// </summary>
        /// <value>The user-specified name of the conference that was recorded</value>
        /// <example>my-conference-name</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The provided identifier of the caller. Must be a phone number in E.164 format (e.g. +15555555555).
        /// </summary>
        /// <value>The provided identifier of the caller. Must be a phone number in E.164 format (e.g. +15555555555).</value>
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
            sb.Append("class ConferenceMemberExitCallback {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  ConferenceId: ").Append(ConferenceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
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
            return this.Equals(input as ConferenceMemberExitCallback);
        }

        /// <summary>
        /// Returns true if ConferenceMemberExitCallback instances are equal
        /// </summary>
        /// <param name="input">Instance of ConferenceMemberExitCallback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConferenceMemberExitCallback input)
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
                    this.ConferenceId == input.ConferenceId ||
                    (this.ConferenceId != null &&
                    this.ConferenceId.Equals(input.ConferenceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.ConferenceId != null)
                {
                    hashCode = (hashCode * 59) + this.ConferenceId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
