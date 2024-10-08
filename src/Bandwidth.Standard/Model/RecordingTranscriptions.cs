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
    /// RecordingTranscriptions
    /// </summary>
    [DataContract(Name = "recordingTranscriptions")]
    public partial class RecordingTranscriptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingTranscriptions" /> class.
        /// </summary>
        /// <param name="transcripts">transcripts.</param>
        public RecordingTranscriptions(List<Transcription> transcripts = default(List<Transcription>))
        {
            this.Transcripts = transcripts;
        }

        /// <summary>
        /// Gets or Sets Transcripts
        /// </summary>
        [DataMember(Name = "transcripts", EmitDefaultValue = false)]
        public List<Transcription> Transcripts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecordingTranscriptions {\n");
            sb.Append("  Transcripts: ").Append(Transcripts).Append("\n");
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
