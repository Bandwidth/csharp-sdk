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
    /// TranscribeRecording
    /// </summary>
    [DataContract(Name = "transcribeRecording")]
    public partial class TranscribeRecording : IEquatable<TranscribeRecording>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets CallbackMethod
        /// </summary>
        [DataMember(Name = "callbackMethod", EmitDefaultValue = true)]
        public CallbackMethodEnum? CallbackMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TranscribeRecording" /> class.
        /// </summary>
        /// <param name="callbackUrl">The URL to send the [TranscriptionAvailable](/docs/voice/webhooks/transcriptionAvailable) event to. You should not include sensitive or personally-identifiable information in the callbackUrl field! Always use the proper username and password fields for authorization..</param>
        /// <param name="callbackMethod">callbackMethod.</param>
        /// <param name="username">Basic auth username..</param>
        /// <param name="password">Basic auth password..</param>
        /// <param name="tag">(optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present..</param>
        /// <param name="callbackTimeout">This is the timeout (in seconds) to use when delivering the webhook to &#x60;callbackUrl&#x60;. Can be any numeric value (including decimals) between 1 and 25. (default to 15D).</param>
        public TranscribeRecording(string callbackUrl = default(string), CallbackMethodEnum? callbackMethod = default(CallbackMethodEnum?), string username = default(string), string password = default(string), string tag = default(string), double? callbackTimeout = 15D)
        {
            this.CallbackUrl = callbackUrl;
            this.CallbackMethod = callbackMethod;
            this.Username = username;
            this.Password = password;
            this.Tag = tag;
            // use default value if no "callbackTimeout" provided
            this.CallbackTimeout = callbackTimeout ?? 15D;
        }

        /// <summary>
        /// The URL to send the [TranscriptionAvailable](/docs/voice/webhooks/transcriptionAvailable) event to. You should not include sensitive or personally-identifiable information in the callbackUrl field! Always use the proper username and password fields for authorization.
        /// </summary>
        /// <value>The URL to send the [TranscriptionAvailable](/docs/voice/webhooks/transcriptionAvailable) event to. You should not include sensitive or personally-identifiable information in the callbackUrl field! Always use the proper username and password fields for authorization.</value>
        [DataMember(Name = "callbackUrl", EmitDefaultValue = false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Basic auth username.
        /// </summary>
        /// <value>Basic auth username.</value>
        [DataMember(Name = "username", EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// Basic auth password.
        /// </summary>
        /// <value>Basic auth password.</value>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// (optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present.
        /// </summary>
        /// <value>(optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present.</value>
        [DataMember(Name = "tag", EmitDefaultValue = true)]
        public string Tag { get; set; }

        /// <summary>
        /// This is the timeout (in seconds) to use when delivering the webhook to &#x60;callbackUrl&#x60;. Can be any numeric value (including decimals) between 1 and 25.
        /// </summary>
        /// <value>This is the timeout (in seconds) to use when delivering the webhook to &#x60;callbackUrl&#x60;. Can be any numeric value (including decimals) between 1 and 25.</value>
        [DataMember(Name = "callbackTimeout", EmitDefaultValue = true)]
        public double? CallbackTimeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TranscribeRecording {\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  CallbackMethod: ").Append(CallbackMethod).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  CallbackTimeout: ").Append(CallbackTimeout).Append("\n");
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
            return this.Equals(input as TranscribeRecording);
        }

        /// <summary>
        /// Returns true if TranscribeRecording instances are equal
        /// </summary>
        /// <param name="input">Instance of TranscribeRecording to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranscribeRecording input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.CallbackMethod == input.CallbackMethod ||
                    this.CallbackMethod.Equals(input.CallbackMethod)
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.CallbackTimeout == input.CallbackTimeout ||
                    (this.CallbackTimeout != null &&
                    this.CallbackTimeout.Equals(input.CallbackTimeout))
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
                if (this.CallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CallbackMethod.GetHashCode();
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.Tag != null)
                {
                    hashCode = (hashCode * 59) + this.Tag.GetHashCode();
                }
                if (this.CallbackTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackTimeout.GetHashCode();
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
            // Username (string) maxLength
            if (this.Username != null && this.Username.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be less than 1024.", new [] { "Username" });
            }

            // Password (string) maxLength
            if (this.Password != null && this.Password.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be less than 1024.", new [] { "Password" });
            }

            // CallbackTimeout (double?) maximum
            if (this.CallbackTimeout > (double?)25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallbackTimeout, must be a value less than or equal to 25.", new [] { "CallbackTimeout" });
            }

            // CallbackTimeout (double?) minimum
            if (this.CallbackTimeout < (double?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallbackTimeout, must be a value greater than or equal to 1.", new [] { "CallbackTimeout" });
            }

            yield break;
        }
    }

}
