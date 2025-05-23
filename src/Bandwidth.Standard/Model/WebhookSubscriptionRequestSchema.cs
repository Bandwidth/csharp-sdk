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
    /// WebhookSubscriptionRequestSchema
    /// </summary>
    [DataContract(Name = "webhookSubscriptionRequestSchema")]
    public partial class WebhookSubscriptionRequestSchema : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubscriptionRequestSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookSubscriptionRequestSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubscriptionRequestSchema" /> class.
        /// </summary>
        /// <param name="basicAuthentication">basicAuthentication.</param>
        /// <param name="callbackUrl">Callback URL to receive status updates from Bandwidth. When a webhook subscription is registered with Bandwidth under a given account ID, it will be used to send status updates for all requests submitted under that account ID. (required).</param>
        /// <param name="sharedSecretKey">An ASCII string submitted by the user as a shared secret key for generating an HMAC header for callbacks..</param>
        public WebhookSubscriptionRequestSchema(TfvBasicAuthentication basicAuthentication = default(TfvBasicAuthentication), string callbackUrl = default(string), string sharedSecretKey = default(string))
        {
            // to ensure "callbackUrl" is required (not null)
            if (callbackUrl == null)
            {
                throw new ArgumentNullException("callbackUrl is a required property for WebhookSubscriptionRequestSchema and cannot be null");
            }
            this.CallbackUrl = callbackUrl;
            this.BasicAuthentication = basicAuthentication;
            this.SharedSecretKey = sharedSecretKey;
        }

        /// <summary>
        /// Gets or Sets BasicAuthentication
        /// </summary>
        [DataMember(Name = "basicAuthentication", EmitDefaultValue = false)]
        public TfvBasicAuthentication BasicAuthentication { get; set; }

        /// <summary>
        /// Callback URL to receive status updates from Bandwidth. When a webhook subscription is registered with Bandwidth under a given account ID, it will be used to send status updates for all requests submitted under that account ID.
        /// </summary>
        /// <value>Callback URL to receive status updates from Bandwidth. When a webhook subscription is registered with Bandwidth under a given account ID, it will be used to send status updates for all requests submitted under that account ID.</value>
        /// <example>https://www.example.com/path/to/resource</example>
        [DataMember(Name = "callbackUrl", IsRequired = true, EmitDefaultValue = true)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// An ASCII string submitted by the user as a shared secret key for generating an HMAC header for callbacks.
        /// </summary>
        /// <value>An ASCII string submitted by the user as a shared secret key for generating an HMAC header for callbacks.</value>
        /// <example>This is my $3cret</example>
        [DataMember(Name = "sharedSecretKey", EmitDefaultValue = true)]
        public string SharedSecretKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookSubscriptionRequestSchema {\n");
            sb.Append("  BasicAuthentication: ").Append(BasicAuthentication).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  SharedSecretKey: ").Append(SharedSecretKey).Append("\n");
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
            // CallbackUrl (string) maxLength
            if (this.CallbackUrl != null && this.CallbackUrl.Length > 2000)
            {
                yield return new ValidationResult("Invalid value for CallbackUrl, length must be less than 2000.", new [] { "CallbackUrl" });
            }

            // CallbackUrl (string) minLength
            if (this.CallbackUrl != null && this.CallbackUrl.Length < 0)
            {
                yield return new ValidationResult("Invalid value for CallbackUrl, length must be greater than 0.", new [] { "CallbackUrl" });
            }

            if (this.CallbackUrl != null) {
                // CallbackUrl (string) pattern
                Regex regexCallbackUrl = new Regex(@"^$|(https?:\/\/)?(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,253}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#()?&//=]*)", RegexOptions.CultureInvariant);
                if (!regexCallbackUrl.Match(this.CallbackUrl).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallbackUrl, must match a pattern of " + regexCallbackUrl, new [] { "CallbackUrl" });
                }
            }

            // SharedSecretKey (string) maxLength
            if (this.SharedSecretKey != null && this.SharedSecretKey.Length > 64)
            {
                yield return new ValidationResult("Invalid value for SharedSecretKey, length must be less than 64.", new [] { "SharedSecretKey" });
            }

            // SharedSecretKey (string) minLength
            if (this.SharedSecretKey != null && this.SharedSecretKey.Length < 16)
            {
                yield return new ValidationResult("Invalid value for SharedSecretKey, length must be greater than 16.", new [] { "SharedSecretKey" });
            }

            if (this.SharedSecretKey != null) {
                // SharedSecretKey (string) pattern
                Regex regexSharedSecretKey = new Regex(@"^[ -~]{16,64}$", RegexOptions.CultureInvariant);
                if (!regexSharedSecretKey.Match(this.SharedSecretKey).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SharedSecretKey, must match a pattern of " + regexSharedSecretKey, new [] { "SharedSecretKey" });
                }
            }

            yield break;
        }
    }

}
