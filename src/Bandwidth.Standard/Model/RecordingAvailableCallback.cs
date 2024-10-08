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
    /// The Recording Available event is sent after a recording has been processed. It indicates that the recording is available for download.
    /// </summary>
    [DataContract(Name = "recordingAvailableCallback")]
    public partial class RecordingAvailableCallback : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        public CallDirectionEnum? Direction { get; set; }

        /// <summary>
        /// Gets or Sets FileFormat
        /// </summary>
        [DataMember(Name = "fileFormat", EmitDefaultValue = false)]
        public FileFormatEnum? FileFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingAvailableCallback" /> class.
        /// </summary>
        /// <param name="eventType">The event type, value can be one of the following: answer, bridgeComplete, bridgeTargetComplete, conferenceCreated, conferenceRedirect, conferenceMemberJoin, conferenceMemberExit, conferenceCompleted, conferenceRecordingAvailable, disconnect, dtmf, gather, initiate, machineDetectionComplete, recordingComplete, recordingAvailable, redirect, transcriptionAvailable, transferAnswer, transferComplete, transferDisconnect..</param>
        /// <param name="eventTime">The approximate UTC date and time when the event was generated by the Bandwidth server, in ISO 8601 format. This may not be exactly the time of event execution..</param>
        /// <param name="accountId">The user account associated with the call..</param>
        /// <param name="applicationId">The id of the application associated with the call..</param>
        /// <param name="from">The provided identifier of the caller. Must be a phone number in E.164 format (e.g. +15555555555)..</param>
        /// <param name="to">The phone number that received the call, in E.164 format (e.g. +15555555555)..</param>
        /// <param name="direction">direction.</param>
        /// <param name="callId">The call id associated with the event..</param>
        /// <param name="callUrl">The URL of the call associated with the event..</param>
        /// <param name="parentCallId">(optional) If the event is related to the B leg of a &lt;Transfer&gt;, the call id of the original call leg that executed the &lt;Transfer&gt;. Otherwise, this field will not be present..</param>
        /// <param name="recordingId">The unique ID of this recording.</param>
        /// <param name="mediaUrl">The URL that can be used to download the recording. Only present if the recording is finished and may be downloaded..</param>
        /// <param name="enqueuedTime">(optional) If call queueing is enabled and this is an outbound call, time the call was queued, in ISO 8601 format..</param>
        /// <param name="startTime">Time the call was started, in ISO 8601 format..</param>
        /// <param name="endTime">The time that the recording ended in ISO-8601 format.</param>
        /// <param name="duration">The duration of the recording in ISO-8601 format.</param>
        /// <param name="fileFormat">fileFormat.</param>
        /// <param name="channels">Always &#x60;1&#x60; for conference recordings; multi-channel recordings are not supported on conferences..</param>
        /// <param name="tag">(optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present..</param>
        /// <param name="status">The current status of the process. For recording, current possible values are &#39;processing&#39;, &#39;partial&#39;, &#39;complete&#39;, &#39;deleted&#39;, and &#39;error&#39;. For transcriptions, current possible values are &#39;none&#39;, &#39;processing&#39;, &#39;available&#39;, &#39;error&#39;, &#39;timeout&#39;, &#39;file-size-too-big&#39;, and &#39;file-size-too-small&#39;. Additional states may be added in the future, so your application must be tolerant of unknown values..</param>
        /// <param name="transferCallerId">The phone number used as the from field of the B-leg call, in E.164 format (e.g. +15555555555)..</param>
        /// <param name="transferTo">The phone number used as the to field of the B-leg call, in E.164 format (e.g. +15555555555)..</param>
        public RecordingAvailableCallback(string eventType = default(string), DateTime eventTime = default(DateTime), string accountId = default(string), string applicationId = default(string), string from = default(string), string to = default(string), CallDirectionEnum? direction = default(CallDirectionEnum?), string callId = default(string), string callUrl = default(string), string parentCallId = default(string), string recordingId = default(string), string mediaUrl = default(string), DateTime? enqueuedTime = default(DateTime?), DateTime startTime = default(DateTime), DateTime endTime = default(DateTime), string duration = default(string), FileFormatEnum? fileFormat = default(FileFormatEnum?), int channels = default(int), string tag = default(string), string status = default(string), string transferCallerId = default(string), string transferTo = default(string))
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
            this.RecordingId = recordingId;
            this.MediaUrl = mediaUrl;
            this.EnqueuedTime = enqueuedTime;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Duration = duration;
            this.FileFormat = fileFormat;
            this.Channels = channels;
            this.Tag = tag;
            this.Status = status;
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
        /// <example>9900000</example>
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
        /// The unique ID of this recording
        /// </summary>
        /// <value>The unique ID of this recording</value>
        /// <example>r-fbe05094-9fd2afe9-bf5b-4c68-820a-41a01c1c5833</example>
        [DataMember(Name = "recordingId", EmitDefaultValue = false)]
        public string RecordingId { get; set; }

        /// <summary>
        /// The URL that can be used to download the recording. Only present if the recording is finished and may be downloaded.
        /// </summary>
        /// <value>The URL that can be used to download the recording. Only present if the recording is finished and may be downloaded.</value>
        /// <example>https://voice.bandwidth.com/api/v2/accounts/9900000/conferences/conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9/recordings/r-fbe05094-9fd2afe9-bf5b-4c68-820a-41a01c1c5833/media</example>
        [DataMember(Name = "mediaUrl", EmitDefaultValue = true)]
        public string MediaUrl { get; set; }

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
        /// Always &#x60;1&#x60; for conference recordings; multi-channel recordings are not supported on conferences.
        /// </summary>
        /// <value>Always &#x60;1&#x60; for conference recordings; multi-channel recordings are not supported on conferences.</value>
        /// <example>1</example>
        [DataMember(Name = "channels", EmitDefaultValue = false)]
        public int Channels { get; set; }

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
        /// The phone number used as the from field of the B-leg call, in E.164 format (e.g. +15555555555).
        /// </summary>
        /// <value>The phone number used as the from field of the B-leg call, in E.164 format (e.g. +15555555555).</value>
        /// <example>+15555555555</example>
        [DataMember(Name = "transferCallerId", EmitDefaultValue = false)]
        public string TransferCallerId { get; set; }

        /// <summary>
        /// The phone number used as the to field of the B-leg call, in E.164 format (e.g. +15555555555).
        /// </summary>
        /// <value>The phone number used as the to field of the B-leg call, in E.164 format (e.g. +15555555555).</value>
        /// <example>+15555555555</example>
        [DataMember(Name = "transferTo", EmitDefaultValue = false)]
        public string TransferTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecordingAvailableCallback {\n");
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
            sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
            sb.Append("  MediaUrl: ").Append(MediaUrl).Append("\n");
            sb.Append("  EnqueuedTime: ").Append(EnqueuedTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  FileFormat: ").Append(FileFormat).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
