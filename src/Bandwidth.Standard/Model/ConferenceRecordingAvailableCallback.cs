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
    /// The Conference Recording Available event is sent after a conference recording has been processed. It indicates that the recording is available for download.
    /// </summary>
    [DataContract(Name = "conferenceRecordingAvailableCallback")]
    public partial class ConferenceRecordingAvailableCallback : IEquatable<ConferenceRecordingAvailableCallback>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FileFormat
        /// </summary>
        [DataMember(Name = "fileFormat", EmitDefaultValue = false)]
        public FileFormatEnum? FileFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceRecordingAvailableCallback" /> class.
        /// </summary>
        /// <param name="eventType">The event type, value can be one of the following: answer, bridgeComplete, bridgeTargetComplete, conferenceCreated, conferenceRedirect, conferenceMemberJoin, conferenceMemberExit, conferenceCompleted, conferenceRecordingAvailable, disconnect, dtmf, gather, initiate, machineDetectionComplete, recordingComplete, recordingAvailable, redirect, transcriptionAvailable, transferAnswer, transferComplete, transferDisconnect..</param>
        /// <param name="eventTime">The approximate UTC date and time when the event was generated by the Bandwidth server, in ISO 8601 format. This may not be exactly the time of event execution..</param>
        /// <param name="conferenceId">The unique, Bandwidth-generated ID of the conference that was recorded.</param>
        /// <param name="name">The user-specified name of the conference that was recorded.</param>
        /// <param name="accountId">The user account associated with the call..</param>
        /// <param name="recordingId">The unique ID of this recording.</param>
        /// <param name="channels">Always &#x60;1&#x60; for conference recordings; multi-channel recordings are not supported on conferences..</param>
        /// <param name="startTime">Time the call was started, in ISO 8601 format..</param>
        /// <param name="endTime">The time that the recording ended in ISO-8601 format.</param>
        /// <param name="duration">The duration of the recording in ISO-8601 format.</param>
        /// <param name="fileFormat">fileFormat.</param>
        /// <param name="mediaUrl">The URL that can be used to download the recording. Only present if the recording is finished and may be downloaded..</param>
        /// <param name="tag">(optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present..</param>
        /// <param name="status">The current status of the process. For recording, current possible values are &#39;processing&#39;, &#39;partial&#39;, &#39;complete&#39;, &#39;deleted&#39;, and &#39;error&#39;. For transcriptions, current possible values are &#39;none&#39;, &#39;processing&#39;, &#39;available&#39;, &#39;error&#39;, &#39;timeout&#39;, &#39;file-size-too-big&#39;, and &#39;file-size-too-small&#39;. Additional states may be added in the future, so your application must be tolerant of unknown values..</param>
        public ConferenceRecordingAvailableCallback(string eventType = default(string), DateTime eventTime = default(DateTime), string conferenceId = default(string), string name = default(string), string accountId = default(string), string recordingId = default(string), int channels = default(int), DateTime startTime = default(DateTime), DateTime endTime = default(DateTime), string duration = default(string), FileFormatEnum? fileFormat = default(FileFormatEnum?), string mediaUrl = default(string), string tag = default(string), string status = default(string))
        {
            this.EventType = eventType;
            this.EventTime = eventTime;
            this.ConferenceId = conferenceId;
            this.Name = name;
            this.AccountId = accountId;
            this.RecordingId = recordingId;
            this.Channels = channels;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Duration = duration;
            this.FileFormat = fileFormat;
            this.MediaUrl = mediaUrl;
            this.Tag = tag;
            this.Status = status;
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
        /// The user account associated with the call.
        /// </summary>
        /// <value>The user account associated with the call.</value>
        /// <example>920012</example>
        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The unique ID of this recording
        /// </summary>
        /// <value>The unique ID of this recording</value>
        /// <example>r-fbe05094-9fd2afe9-bf5b-4c68-820a-41a01c1c5833</example>
        [DataMember(Name = "recordingId", EmitDefaultValue = false)]
        public string RecordingId { get; set; }

        /// <summary>
        /// Always &#x60;1&#x60; for conference recordings; multi-channel recordings are not supported on conferences.
        /// </summary>
        /// <value>Always &#x60;1&#x60; for conference recordings; multi-channel recordings are not supported on conferences.</value>
        /// <example>1</example>
        [DataMember(Name = "channels", EmitDefaultValue = false)]
        public int Channels { get; set; }

        /// <summary>
        /// Time the call was started, in ISO 8601 format.
        /// </summary>
        /// <value>Time the call was started, in ISO 8601 format.</value>
        /// <example>2022-06-17T22:19:40.375Z</example>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The time that the recording ended in ISO-8601 format
        /// </summary>
        /// <value>The time that the recording ended in ISO-8601 format</value>
        /// <example>2022-06-17T22:20Z</example>
        [DataMember(Name = "endTime", EmitDefaultValue = false)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// The duration of the recording in ISO-8601 format
        /// </summary>
        /// <value>The duration of the recording in ISO-8601 format</value>
        /// <example>PT13.67S</example>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public string Duration { get; set; }

        /// <summary>
        /// The URL that can be used to download the recording. Only present if the recording is finished and may be downloaded.
        /// </summary>
        /// <value>The URL that can be used to download the recording. Only present if the recording is finished and may be downloaded.</value>
        /// <example>https://voice.bandwidth.com/api/v2/accounts/9900000/conferences/conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9/recordings/r-fbe05094-9fd2afe9-bf5b-4c68-820a-41a01c1c5833/media</example>
        [DataMember(Name = "mediaUrl", EmitDefaultValue = true)]
        public string MediaUrl { get; set; }

        /// <summary>
        /// (optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present.
        /// </summary>
        /// <value>(optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present.</value>
        /// <example>exampleTag</example>
        [DataMember(Name = "tag", EmitDefaultValue = true)]
        public string Tag { get; set; }

        /// <summary>
        /// The current status of the process. For recording, current possible values are &#39;processing&#39;, &#39;partial&#39;, &#39;complete&#39;, &#39;deleted&#39;, and &#39;error&#39;. For transcriptions, current possible values are &#39;none&#39;, &#39;processing&#39;, &#39;available&#39;, &#39;error&#39;, &#39;timeout&#39;, &#39;file-size-too-big&#39;, and &#39;file-size-too-small&#39;. Additional states may be added in the future, so your application must be tolerant of unknown values.
        /// </summary>
        /// <value>The current status of the process. For recording, current possible values are &#39;processing&#39;, &#39;partial&#39;, &#39;complete&#39;, &#39;deleted&#39;, and &#39;error&#39;. For transcriptions, current possible values are &#39;none&#39;, &#39;processing&#39;, &#39;available&#39;, &#39;error&#39;, &#39;timeout&#39;, &#39;file-size-too-big&#39;, and &#39;file-size-too-small&#39;. Additional states may be added in the future, so your application must be tolerant of unknown values.</value>
        /// <example>completed</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConferenceRecordingAvailableCallback {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  ConferenceId: ").Append(ConferenceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  FileFormat: ").Append(FileFormat).Append("\n");
            sb.Append("  MediaUrl: ").Append(MediaUrl).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as ConferenceRecordingAvailableCallback);
        }

        /// <summary>
        /// Returns true if ConferenceRecordingAvailableCallback instances are equal
        /// </summary>
        /// <param name="input">Instance of ConferenceRecordingAvailableCallback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConferenceRecordingAvailableCallback input)
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
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.RecordingId == input.RecordingId ||
                    (this.RecordingId != null &&
                    this.RecordingId.Equals(input.RecordingId))
                ) && 
                (
                    this.Channels == input.Channels ||
                    this.Channels.Equals(input.Channels)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.FileFormat == input.FileFormat ||
                    this.FileFormat.Equals(input.FileFormat)
                ) && 
                (
                    this.MediaUrl == input.MediaUrl ||
                    (this.MediaUrl != null &&
                    this.MediaUrl.Equals(input.MediaUrl))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.RecordingId != null)
                {
                    hashCode = (hashCode * 59) + this.RecordingId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Channels.GetHashCode();
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.Duration != null)
                {
                    hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FileFormat.GetHashCode();
                if (this.MediaUrl != null)
                {
                    hashCode = (hashCode * 59) + this.MediaUrl.GetHashCode();
                }
                if (this.Tag != null)
                {
                    hashCode = (hashCode * 59) + this.Tag.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
