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
    /// StirShaken
    /// </summary>
    [DataContract(Name = "stirShaken")]
    public partial class StirShaken : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StirShaken" /> class.
        /// </summary>
        /// <param name="verstat">(optional) The verification status indicating whether the verification was successful or not. Possible values are TN-Verification-Passed and TN-Verification-Failed..</param>
        /// <param name="attestationIndicator">(optional) The attestation level verified by Bandwidth. Possible values are A (full), B (partial) or C (gateway)..</param>
        /// <param name="originatingId">(optional) A unique origination identifier..</param>
        public StirShaken(string verstat = default(string), string attestationIndicator = default(string), string originatingId = default(string))
        {
            this.Verstat = verstat;
            this.AttestationIndicator = attestationIndicator;
            this.OriginatingId = originatingId;
        }

        /// <summary>
        /// (optional) The verification status indicating whether the verification was successful or not. Possible values are TN-Verification-Passed and TN-Verification-Failed.
        /// </summary>
        /// <value>(optional) The verification status indicating whether the verification was successful or not. Possible values are TN-Verification-Passed and TN-Verification-Failed.</value>
        /// <example>Tn-Verification-Passed</example>
        [DataMember(Name = "verstat", EmitDefaultValue = false)]
        public string Verstat { get; set; }

        /// <summary>
        /// (optional) The attestation level verified by Bandwidth. Possible values are A (full), B (partial) or C (gateway).
        /// </summary>
        /// <value>(optional) The attestation level verified by Bandwidth. Possible values are A (full), B (partial) or C (gateway).</value>
        /// <example>A</example>
        [DataMember(Name = "attestationIndicator", EmitDefaultValue = false)]
        public string AttestationIndicator { get; set; }

        /// <summary>
        /// (optional) A unique origination identifier.
        /// </summary>
        /// <value>(optional) A unique origination identifier.</value>
        /// <example>99759086-1335-11ed-9bcf-5f7d464e91af</example>
        [DataMember(Name = "originatingId", EmitDefaultValue = false)]
        public string OriginatingId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StirShaken {\n");
            sb.Append("  Verstat: ").Append(Verstat).Append("\n");
            sb.Append("  AttestationIndicator: ").Append(AttestationIndicator).Append("\n");
            sb.Append("  OriginatingId: ").Append(OriginatingId).Append("\n");
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
