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
    /// The Conference Completed event is fired when the last member leaves the conference. The response to this event may not contain BXML.
    /// </summary>
    [DataContract(Name = "conferenceCompletedCallback")]
    public partial class ConferenceCompletedCallback : IEquatable<ConferenceCompletedCallback>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceCompletedCallback" /> class.
        /// </summary>
        /// <param name="eventType">The event type, value can be one of the following: answer, bridgeComplete, bridgeTargetComplete, conferenceCreated, conferenceRedirect, conferenceMemberJoin, conferenceMemberExit, conferenceCompleted, conferenceRecordingAvailable, disconnect, dtmf, gather, initiate, machineDetectionComplete, recordingComplete, recordingAvailable, redirect, transcriptionAvailable, transferAnswer, transferComplete, transferDisconnect..</param>
        /// <param name="eventTime">The approximate UTC date and time when the event was generated by the Bandwidth server, in ISO 8601 format. This may not be exactly the time of event execution..</param>
        /// <param name="conferenceId">The unique, Bandwidth-generated ID of the conference that was recorded.</param>
        /// <param name="name">The user-specified name of the conference that was recorded.</param>
        /// <param name="tag">(optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present..</param>
        public ConferenceCompletedCallback(string eventType = default(string), DateTime eventTime = default(DateTime), string conferenceId = default(string), string name = default(string), string tag = default(string))
        {
            this.EventType = eventType;
            this.EventTime = eventTime;
            this.ConferenceId = conferenceId;
            this.Name = name;
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
            sb.Append("class ConferenceCompletedCallback {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  ConferenceId: ").Append(ConferenceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as ConferenceCompletedCallback);
        }

        /// <summary>
        /// Returns true if ConferenceCompletedCallback instances are equal
        /// </summary>
        /// <param name="input">Instance of ConferenceCompletedCallback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConferenceCompletedCallback input)
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
