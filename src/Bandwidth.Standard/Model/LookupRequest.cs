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
    /// Create phone number lookup request.
    /// </summary>
    [DataContract(Name = "lookupRequest")]
    public partial class LookupRequest : IEquatable<LookupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LookupRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LookupRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LookupRequest" /> class.
        /// </summary>
        /// <param name="tns">tns (required).</param>
        public LookupRequest(List<string> tns = default(List<string>))
        {
            // to ensure "tns" is required (not null)
            if (tns == null)
            {
                throw new ArgumentNullException("tns is a required property for LookupRequest and cannot be null");
            }
            this.Tns = tns;
        }

        /// <summary>
        /// Gets or Sets Tns
        /// </summary>
        [DataMember(Name = "tns", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Tns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LookupRequest {\n");
            sb.Append("  Tns: ").Append(Tns).Append("\n");
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
            return this.Equals(input as LookupRequest);
        }

        /// <summary>
        /// Returns true if LookupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LookupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LookupRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Tns == input.Tns ||
                    this.Tns != null &&
                    input.Tns != null &&
                    this.Tns.SequenceEqual(input.Tns)
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
                if (this.Tns != null)
                {
                    hashCode = (hashCode * 59) + this.Tns.GetHashCode();
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
