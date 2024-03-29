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
    /// (optional) if machine detection was requested in sync mode, the result will be specified here. Possible values are the same as the async counterpart: Machine Detection Complete
    /// </summary>
    [DataContract(Name = "machineDetectionResult")]
    public partial class MachineDetectionResult : IEquatable<MachineDetectionResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MachineDetectionResult" /> class.
        /// </summary>
        /// <param name="value">Possible values are answering-machine, human, silence, timeout, or error..</param>
        /// <param name="duration">The amount of time it took to determine the result..</param>
        public MachineDetectionResult(string value = default(string), string duration = default(string))
        {
            this.Value = value;
            this.Duration = duration;
        }

        /// <summary>
        /// Possible values are answering-machine, human, silence, timeout, or error.
        /// </summary>
        /// <value>Possible values are answering-machine, human, silence, timeout, or error.</value>
        /// <example>answering-machine</example>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// The amount of time it took to determine the result.
        /// </summary>
        /// <value>The amount of time it took to determine the result.</value>
        /// <example>PT4.9891287S</example>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public string Duration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MachineDetectionResult {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
            return this.Equals(input as MachineDetectionResult);
        }

        /// <summary>
        /// Returns true if MachineDetectionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of MachineDetectionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MachineDetectionResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
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
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.Duration != null)
                {
                    hashCode = (hashCode * 59) + this.Duration.GetHashCode();
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
