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
    /// Transcription
    /// </summary>
    [DataContract]
    public partial class Transcription :  IEquatable<Transcription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Transcription" /> class.
        /// </summary>
        /// <param name="text">The transcribed text.</param>
        /// <param name="confidence">The confidence on the recognized content, ranging from &#x60;0.0&#x60; to &#x60;1.0&#x60; with &#x60;1.0&#x60; being the highest confidence..</param>
        public Transcription(string text = default(string), double confidence = default(double))
        {
            this.Text = text;
            this.Confidence = confidence;
        }

        /// <summary>
        /// The transcribed text
        /// </summary>
        /// <value>The transcribed text</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// The confidence on the recognized content, ranging from &#x60;0.0&#x60; to &#x60;1.0&#x60; with &#x60;1.0&#x60; being the highest confidence.
        /// </summary>
        /// <value>The confidence on the recognized content, ranging from &#x60;0.0&#x60; to &#x60;1.0&#x60; with &#x60;1.0&#x60; being the highest confidence.</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public double Confidence { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transcription {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as Transcription);
        }

        /// <summary>
        /// Returns true if Transcription instances are equal
        /// </summary>
        /// <param name="input">Instance of Transcription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transcription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
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
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
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
