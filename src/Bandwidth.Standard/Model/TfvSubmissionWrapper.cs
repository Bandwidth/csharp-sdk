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
    /// TfvSubmissionWrapper
    /// </summary>
    [DataContract(Name = "tfvSubmissionWrapper")]
    public partial class TfvSubmissionWrapper : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TfvSubmissionWrapper" /> class.
        /// </summary>
        /// <param name="submission">submission.</param>
        public TfvSubmissionWrapper(VerificationUpdateRequest submission = default(VerificationUpdateRequest))
        {
            this.Submission = submission;
        }

        /// <summary>
        /// Gets or Sets Submission
        /// </summary>
        [DataMember(Name = "submission", EmitDefaultValue = false)]
        public VerificationUpdateRequest Submission { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TfvSubmissionWrapper {\n");
            sb.Append("  Submission: ").Append(Submission).Append("\n");
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
