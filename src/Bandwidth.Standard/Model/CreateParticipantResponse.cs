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
    /// Response generated when a Participant is created.
    /// </summary>
    [DataContract(Name = "createParticipantResponse")]
    public partial class CreateParticipantResponse : IEquatable<CreateParticipantResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateParticipantResponse" /> class.
        /// </summary>
        /// <param name="participant">participant.</param>
        /// <param name="token">Auth token for the returned participant.  This should be passed to the participant so that they can connect to the platform..</param>
        public CreateParticipantResponse(Participant participant = default(Participant), string token = default(string))
        {
            this.Participant = participant;
            this.Token = token;
        }

        /// <summary>
        /// Gets or Sets Participant
        /// </summary>
        [DataMember(Name = "participant", EmitDefaultValue = false)]
        public Participant Participant { get; set; }

        /// <summary>
        /// Auth token for the returned participant.  This should be passed to the participant so that they can connect to the platform.
        /// </summary>
        /// <value>Auth token for the returned participant.  This should be passed to the participant so that they can connect to the platform.</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateParticipantResponse {\n");
            sb.Append("  Participant: ").Append(Participant).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as CreateParticipantResponse);
        }

        /// <summary>
        /// Returns true if CreateParticipantResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateParticipantResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateParticipantResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Participant == input.Participant ||
                    (this.Participant != null &&
                    this.Participant.Equals(input.Participant))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.Participant != null)
                {
                    hashCode = (hashCode * 59) + this.Participant.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}