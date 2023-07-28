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
    /// ConferenceRecordingMetadata
    /// </summary>
    [DataContract]
    public partial class ConferenceRecordingMetadata :  IEquatable<ConferenceRecordingMetadata>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets FileFormat
        /// </summary>
        [DataMember(Name="fileFormat", EmitDefaultValue=false)]
        public FileFormatEnum? FileFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceRecordingMetadata" /> class.
        /// </summary>
        /// <param name="accountId">The user account associated with the call..</param>
        /// <param name="conferenceId">The unique, Bandwidth-generated ID of the conference that was recorded.</param>
        /// <param name="name">The user-specified name of the conference that was recorded.</param>
        /// <param name="recordingId">The unique ID of this recording.</param>
        /// <param name="duration">The duration of the recording in ISO-8601 format.</param>
        /// <param name="channels">Always &#x60;1&#x60; for conference recordings; multi-channel recordings are not supported on conferences..</param>
        /// <param name="startTime">Time the call was started, in ISO 8601 format..</param>
        /// <param name="endTime">The time that the recording ended in ISO-8601 format.</param>
        /// <param name="fileFormat">fileFormat.</param>
        /// <param name="status">The current status of the process. For recording, current possible values are &#39;processing&#39;, &#39;partial&#39;, &#39;complete&#39;, &#39;deleted&#39;, and &#39;error&#39;. For transcriptions, current possible values are &#39;none&#39;, &#39;processing&#39;, &#39;available&#39;, &#39;error&#39;, &#39;timeout&#39;, &#39;file-size-too-big&#39;, and &#39;file-size-too-small&#39;. Additional states may be added in the future, so your application must be tolerant of unknown values..</param>
        /// <param name="mediaUrl">The URL that can be used to download the recording. Only present if the recording is finished and may be downloaded..</param>
        public ConferenceRecordingMetadata(string accountId = default(string), string conferenceId = default(string), string name = default(string), string recordingId = default(string), string duration = default(string), int channels = default(int), DateTime startTime = default(DateTime), DateTime endTime = default(DateTime), FileFormatEnum? fileFormat = default(FileFormatEnum?), string status = default(string), string mediaUrl = default(string))
        {
            this.MediaUrl = mediaUrl;
            this.AccountId = accountId;
            this.ConferenceId = conferenceId;
            this.Name = name;
            this.RecordingId = recordingId;
            this.Duration = duration;
            this.Channels = channels;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.FileFormat = fileFormat;
            this.Status = status;
            this.MediaUrl = mediaUrl;
        }

        /// <summary>
        /// The user account associated with the call.
        /// </summary>
        /// <value>The user account associated with the call.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The unique, Bandwidth-generated ID of the conference that was recorded
        /// </summary>
        /// <value>The unique, Bandwidth-generated ID of the conference that was recorded</value>
        [DataMember(Name="conferenceId", EmitDefaultValue=false)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// The user-specified name of the conference that was recorded
        /// </summary>
        /// <value>The user-specified name of the conference that was recorded</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The unique ID of this recording
        /// </summary>
        /// <value>The unique ID of this recording</value>
        [DataMember(Name="recordingId", EmitDefaultValue=false)]
        public string RecordingId { get; set; }

        /// <summary>
        /// The duration of the recording in ISO-8601 format
        /// </summary>
        /// <value>The duration of the recording in ISO-8601 format</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public string Duration { get; set; }

        /// <summary>
        /// Always &#x60;1&#x60; for conference recordings; multi-channel recordings are not supported on conferences.
        /// </summary>
        /// <value>Always &#x60;1&#x60; for conference recordings; multi-channel recordings are not supported on conferences.</value>
        [DataMember(Name="channels", EmitDefaultValue=false)]
        public int Channels { get; set; }

        /// <summary>
        /// Time the call was started, in ISO 8601 format.
        /// </summary>
        /// <value>Time the call was started, in ISO 8601 format.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The time that the recording ended in ISO-8601 format
        /// </summary>
        /// <value>The time that the recording ended in ISO-8601 format</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime EndTime { get; set; }


        /// <summary>
        /// The current status of the process. For recording, current possible values are &#39;processing&#39;, &#39;partial&#39;, &#39;complete&#39;, &#39;deleted&#39;, and &#39;error&#39;. For transcriptions, current possible values are &#39;none&#39;, &#39;processing&#39;, &#39;available&#39;, &#39;error&#39;, &#39;timeout&#39;, &#39;file-size-too-big&#39;, and &#39;file-size-too-small&#39;. Additional states may be added in the future, so your application must be tolerant of unknown values.
        /// </summary>
        /// <value>The current status of the process. For recording, current possible values are &#39;processing&#39;, &#39;partial&#39;, &#39;complete&#39;, &#39;deleted&#39;, and &#39;error&#39;. For transcriptions, current possible values are &#39;none&#39;, &#39;processing&#39;, &#39;available&#39;, &#39;error&#39;, &#39;timeout&#39;, &#39;file-size-too-big&#39;, and &#39;file-size-too-small&#39;. Additional states may be added in the future, so your application must be tolerant of unknown values.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The URL that can be used to download the recording. Only present if the recording is finished and may be downloaded.
        /// </summary>
        /// <value>The URL that can be used to download the recording. Only present if the recording is finished and may be downloaded.</value>
        [DataMember(Name="mediaUrl", EmitDefaultValue=true)]
        public string MediaUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConferenceRecordingMetadata {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ConferenceId: ").Append(ConferenceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  FileFormat: ").Append(FileFormat).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  MediaUrl: ").Append(MediaUrl).Append("\n");
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
            return this.Equals(input as ConferenceRecordingMetadata);
        }

        /// <summary>
        /// Returns true if ConferenceRecordingMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of ConferenceRecordingMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConferenceRecordingMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
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
                    this.RecordingId == input.RecordingId ||
                    (this.RecordingId != null &&
                    this.RecordingId.Equals(input.RecordingId))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.Channels == input.Channels ||
                    (this.Channels != null &&
                    this.Channels.Equals(input.Channels))
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
                    this.FileFormat == input.FileFormat ||
                    (this.FileFormat != null &&
                    this.FileFormat.Equals(input.FileFormat))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.MediaUrl == input.MediaUrl ||
                    (this.MediaUrl != null &&
                    this.MediaUrl.Equals(input.MediaUrl))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.ConferenceId != null)
                    hashCode = hashCode * 59 + this.ConferenceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RecordingId != null)
                    hashCode = hashCode * 59 + this.RecordingId.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Channels != null)
                    hashCode = hashCode * 59 + this.Channels.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.FileFormat != null)
                    hashCode = hashCode * 59 + this.FileFormat.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.MediaUrl != null)
                    hashCode = hashCode * 59 + this.MediaUrl.GetHashCode();
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