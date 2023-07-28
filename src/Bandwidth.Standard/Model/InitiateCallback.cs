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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Bandwidth.Standard.Client.OpenAPIDateConverter;

namespace Bandwidth.Standard.Model
{
    /// <summary>
    /// The Initiate event is fired when an inbound call is received for a Telephone Number on your Account. It is sent to the URL specified in the application associated with the location (sip-peer) that the called telephone number belongs to.
    /// </summary>
    [DataContract]
    public partial class InitiateCallback :  IEquatable<InitiateCallback>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public CallDirectionEnum? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiateCallback" /> class.
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
        /// <param name="startTime">Time the call was started, in ISO 8601 format..</param>
        /// <param name="diversion">diversion.</param>
        /// <param name="stirShaken">stirShaken.</param>
        public InitiateCallback(string eventType = default(string), DateTime eventTime = default(DateTime), string accountId = default(string), string applicationId = default(string), string from = default(string), string to = default(string), CallDirectionEnum? direction = default(CallDirectionEnum?), string callId = default(string), string callUrl = default(string), DateTime startTime = default(DateTime), Diversion diversion = default(Diversion), StirShaken stirShaken = default(StirShaken))
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
            this.Diversion = diversion;
            this.StirShaken = stirShaken;
        }

        /// <summary>
        /// The event type, value can be one of the following: answer, bridgeComplete, bridgeTargetComplete, conferenceCreated, conferenceRedirect, conferenceMemberJoin, conferenceMemberExit, conferenceCompleted, conferenceRecordingAvailable, disconnect, dtmf, gather, initiate, machineDetectionComplete, recordingComplete, recordingAvailable, redirect, transcriptionAvailable, transferAnswer, transferComplete, transferDisconnect.
        /// </summary>
        /// <value>The event type, value can be one of the following: answer, bridgeComplete, bridgeTargetComplete, conferenceCreated, conferenceRedirect, conferenceMemberJoin, conferenceMemberExit, conferenceCompleted, conferenceRecordingAvailable, disconnect, dtmf, gather, initiate, machineDetectionComplete, recordingComplete, recordingAvailable, redirect, transcriptionAvailable, transferAnswer, transferComplete, transferDisconnect.</value>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The approximate UTC date and time when the event was generated by the Bandwidth server, in ISO 8601 format. This may not be exactly the time of event execution.
        /// </summary>
        /// <value>The approximate UTC date and time when the event was generated by the Bandwidth server, in ISO 8601 format. This may not be exactly the time of event execution.</value>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public DateTime EventTime { get; set; }

        /// <summary>
        /// The user account associated with the call.
        /// </summary>
        /// <value>The user account associated with the call.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The id of the application associated with the call.
        /// </summary>
        /// <value>The id of the application associated with the call.</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The provided identifier of the caller: can be a phone number in E.164 format (e.g. +15555555555) or one of Private, Restricted, Unavailable, or Anonymous.
        /// </summary>
        /// <value>The provided identifier of the caller: can be a phone number in E.164 format (e.g. +15555555555) or one of Private, Restricted, Unavailable, or Anonymous.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// The phone number that received the call, in E.164 format (e.g. +15555555555).
        /// </summary>
        /// <value>The phone number that received the call, in E.164 format (e.g. +15555555555).</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }


        /// <summary>
        /// The call id associated with the event.
        /// </summary>
        /// <value>The call id associated with the event.</value>
        [DataMember(Name="callId", EmitDefaultValue=false)]
        public string CallId { get; set; }

        /// <summary>
        /// The URL of the call associated with the event.
        /// </summary>
        /// <value>The URL of the call associated with the event.</value>
        [DataMember(Name="callUrl", EmitDefaultValue=false)]
        public string CallUrl { get; set; }

        /// <summary>
        /// Time the call was started, in ISO 8601 format.
        /// </summary>
        /// <value>Time the call was started, in ISO 8601 format.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or Sets Diversion
        /// </summary>
        [DataMember(Name="diversion", EmitDefaultValue=false)]
        public Diversion Diversion { get; set; }

        /// <summary>
        /// Gets or Sets StirShaken
        /// </summary>
        [DataMember(Name="stirShaken", EmitDefaultValue=false)]
        public StirShaken StirShaken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitiateCallback {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  CallUrl: ").Append(CallUrl).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Diversion: ").Append(Diversion).Append("\n");
            sb.Append("  StirShaken: ").Append(StirShaken).Append("\n");
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
            return this.Equals(input as InitiateCallback);
        }

        /// <summary>
        /// Returns true if InitiateCallback instances are equal
        /// </summary>
        /// <param name="input">Instance of InitiateCallback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitiateCallback input)
        {
            if (input == null)
                return false;

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
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
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
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Diversion == input.Diversion ||
                    (this.Diversion != null &&
                    this.Diversion.Equals(input.Diversion))
                ) && 
                (
                    this.StirShaken == input.StirShaken ||
                    (this.StirShaken != null &&
                    this.StirShaken.Equals(input.StirShaken))
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
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.EventTime != null)
                    hashCode = hashCode * 59 + this.EventTime.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.CallId != null)
                    hashCode = hashCode * 59 + this.CallId.GetHashCode();
                if (this.CallUrl != null)
                    hashCode = hashCode * 59 + this.CallUrl.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Diversion != null)
                    hashCode = hashCode * 59 + this.Diversion.GetHashCode();
                if (this.StirShaken != null)
                    hashCode = hashCode * 59 + this.StirShaken.GetHashCode();
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