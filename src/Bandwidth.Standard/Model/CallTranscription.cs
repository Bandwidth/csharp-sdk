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
    /// CallTranscription
    /// </summary>
    [DataContract(Name = "callTranscription")]
    public partial class CallTranscription : IEquatable<CallTranscription>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DetectedLanguage
        /// </summary>
        [DataMember(Name = "detectedLanguage", EmitDefaultValue = false)]
        public CallTranscriptionDetectedLanguageEnum? DetectedLanguage { get; set; }

        /// <summary>
        /// Gets or Sets Track
        /// </summary>
        [DataMember(Name = "track", EmitDefaultValue = false)]
        public CallTranscriptionTrackEnum? Track { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallTranscription" /> class.
        /// </summary>
        /// <param name="detectedLanguage">detectedLanguage.</param>
        /// <param name="track">track.</param>
        /// <param name="transcript">The transcription itself..</param>
        /// <param name="confidence">How confident the transcription engine was in transcribing the associated audio (from &#x60;0&#x60; to &#x60;1&#x60;)..</param>
        public CallTranscription(CallTranscriptionDetectedLanguageEnum? detectedLanguage = default(CallTranscriptionDetectedLanguageEnum?), CallTranscriptionTrackEnum? track = default(CallTranscriptionTrackEnum?), string transcript = default(string), double confidence = default(double))
        {
            this.DetectedLanguage = detectedLanguage;
            this.Track = track;
            this.Transcript = transcript;
            this.Confidence = confidence;
        }

        /// <summary>
        /// The transcription itself.
        /// </summary>
        /// <value>The transcription itself.</value>
        /// <example>Hello World! This is an example.</example>
        [DataMember(Name = "transcript", EmitDefaultValue = false)]
        public string Transcript { get; set; }

        /// <summary>
        /// How confident the transcription engine was in transcribing the associated audio (from &#x60;0&#x60; to &#x60;1&#x60;).
        /// </summary>
        /// <value>How confident the transcription engine was in transcribing the associated audio (from &#x60;0&#x60; to &#x60;1&#x60;).</value>
        /// <example>0.9</example>
        [DataMember(Name = "confidence", EmitDefaultValue = false)]
        public double Confidence { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CallTranscription {\n");
            sb.Append("  DetectedLanguage: ").Append(DetectedLanguage).Append("\n");
            sb.Append("  Track: ").Append(Track).Append("\n");
            sb.Append("  Transcript: ").Append(Transcript).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
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
            return this.Equals(input as CallTranscription);
        }

        /// <summary>
        /// Returns true if CallTranscription instances are equal
        /// </summary>
        /// <param name="input">Instance of CallTranscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallTranscription input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DetectedLanguage == input.DetectedLanguage ||
                    this.DetectedLanguage.Equals(input.DetectedLanguage)
                ) && 
                (
                    this.Track == input.Track ||
                    this.Track.Equals(input.Track)
                ) && 
                (
                    this.Transcript == input.Transcript ||
                    (this.Transcript != null &&
                    this.Transcript.Equals(input.Transcript))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    this.Confidence.Equals(input.Confidence)
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
                hashCode = (hashCode * 59) + this.DetectedLanguage.GetHashCode();
                hashCode = (hashCode * 59) + this.Track.GetHashCode();
                if (this.Transcript != null)
                {
                    hashCode = (hashCode * 59) + this.Transcript.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Confidence.GetHashCode();
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
            // Confidence (double) maximum
            if (this.Confidence > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Confidence, must be a value less than or equal to 1.", new [] { "Confidence" });
            }

            // Confidence (double) minimum
            if (this.Confidence < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Confidence, must be a value greater than or equal to 0.", new [] { "Confidence" });
            }

            yield break;
        }
    }

}
