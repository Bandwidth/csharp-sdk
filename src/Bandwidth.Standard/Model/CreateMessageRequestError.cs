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
    /// CreateMessageRequestError
    /// </summary>
    [DataContract(Name = "createMessageRequestError")]
    public partial class CreateMessageRequestError : IEquatable<CreateMessageRequestError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageRequestError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateMessageRequestError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageRequestError" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="fieldErrors">fieldErrors.</param>
        public CreateMessageRequestError(string type = default(string), string description = default(string), List<FieldError> fieldErrors = default(List<FieldError>))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for CreateMessageRequestError and cannot be null");
            }
            this.Type = type;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for CreateMessageRequestError and cannot be null");
            }
            this.Description = description;
            this.FieldErrors = fieldErrors;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets FieldErrors
        /// </summary>
        [DataMember(Name = "fieldErrors", EmitDefaultValue = false)]
        public List<FieldError> FieldErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateMessageRequestError {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FieldErrors: ").Append(FieldErrors).Append("\n");
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
            return this.Equals(input as CreateMessageRequestError);
        }

        /// <summary>
        /// Returns true if CreateMessageRequestError instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateMessageRequestError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateMessageRequestError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FieldErrors == input.FieldErrors ||
                    this.FieldErrors != null &&
                    input.FieldErrors != null &&
                    this.FieldErrors.SequenceEqual(input.FieldErrors)
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.FieldErrors != null)
                {
                    hashCode = (hashCode * 59) + this.FieldErrors.GetHashCode();
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
