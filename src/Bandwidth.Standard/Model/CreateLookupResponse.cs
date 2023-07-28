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
    /// The request has been accepted for processing but not yet finished and in a terminal state (COMPLETE, PARTIAL_COMPLETE, or FAILED).
    /// </summary>
    [DataContract]
    public partial class CreateLookupResponse :  IEquatable<CreateLookupResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public LookupStatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLookupResponse" /> class.
        /// </summary>
        /// <param name="requestId">The phone number lookup request ID from Bandwidth..</param>
        /// <param name="status">status.</param>
        public CreateLookupResponse(string requestId = default(string), LookupStatusEnum? status = default(LookupStatusEnum?))
        {
            this.RequestId = requestId;
            this.Status = status;
        }

        /// <summary>
        /// The phone number lookup request ID from Bandwidth.
        /// </summary>
        /// <value>The phone number lookup request ID from Bandwidth.</value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLookupResponse {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
            return this.Equals(input as CreateLookupResponse);
        }

        /// <summary>
        /// Returns true if CreateLookupResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateLookupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateLookupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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