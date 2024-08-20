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
    /// UpdateCall
    /// </summary>
    [DataContract(Name = "updateCall")]
    public partial class UpdateCall : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public CallStateEnum? State { get; set; }

        /// <summary>
        /// Gets or Sets RedirectMethod
        /// </summary>
        [DataMember(Name = "redirectMethod", EmitDefaultValue = true)]
        public RedirectMethodEnum? RedirectMethod { get; set; }

        /// <summary>
        /// Gets or Sets RedirectFallbackMethod
        /// </summary>
        [DataMember(Name = "redirectFallbackMethod", EmitDefaultValue = true)]
        public RedirectMethodEnum? RedirectFallbackMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCall" /> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="redirectUrl">The URL to send the [Redirect](/docs/voice/bxml/redirect) event to which will provide new BXML.  Required if &#x60;state&#x60; is &#x60;active&#x60;.  Not allowed if &#x60;state&#x60; is &#x60;completed&#x60;..</param>
        /// <param name="redirectMethod">redirectMethod.</param>
        /// <param name="username">Basic auth username..</param>
        /// <param name="password">Basic auth password..</param>
        /// <param name="redirectFallbackUrl">A fallback url which, if provided, will be used to retry the redirect callback delivery in case &#x60;redirectUrl&#x60; fails to respond..</param>
        /// <param name="redirectFallbackMethod">redirectFallbackMethod.</param>
        /// <param name="fallbackUsername">Basic auth username..</param>
        /// <param name="fallbackPassword">Basic auth password..</param>
        /// <param name="tag">A custom string that will be sent with this and all future callbacks unless overwritten by a future &#x60;tag&#x60; attribute or [&#x60;&lt;Tag&gt;&#x60;](/docs/voice/bxml/tag) verb, or cleared.  May be cleared by setting &#x60;tag&#x3D;\&quot;\&quot;&#x60;.  Max length 256 characters.  Not allowed if &#x60;state&#x60; is &#x60;completed&#x60;..</param>
        public UpdateCall(CallStateEnum? state = default(CallStateEnum?), string redirectUrl = default(string), RedirectMethodEnum? redirectMethod = default(RedirectMethodEnum?), string username = default(string), string password = default(string), string redirectFallbackUrl = default(string), RedirectMethodEnum? redirectFallbackMethod = default(RedirectMethodEnum?), string fallbackUsername = default(string), string fallbackPassword = default(string), string tag = default(string))
        {
            this.State = state;
            this.RedirectUrl = redirectUrl;
            this.RedirectMethod = redirectMethod;
            this.Username = username;
            this.Password = password;
            this.RedirectFallbackUrl = redirectFallbackUrl;
            this.RedirectFallbackMethod = redirectFallbackMethod;
            this.FallbackUsername = fallbackUsername;
            this.FallbackPassword = fallbackPassword;
            this.Tag = tag;
        }

        /// <summary>
        /// The URL to send the [Redirect](/docs/voice/bxml/redirect) event to which will provide new BXML.  Required if &#x60;state&#x60; is &#x60;active&#x60;.  Not allowed if &#x60;state&#x60; is &#x60;completed&#x60;.
        /// </summary>
        /// <value>The URL to send the [Redirect](/docs/voice/bxml/redirect) event to which will provide new BXML.  Required if &#x60;state&#x60; is &#x60;active&#x60;.  Not allowed if &#x60;state&#x60; is &#x60;completed&#x60;.</value>
        /// <example>https://myServer.example/bandwidth/webhooks/redirect</example>
        [DataMember(Name = "redirectUrl", EmitDefaultValue = true)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Basic auth username.
        /// </summary>
        /// <value>Basic auth username.</value>
        /// <example>mySecretUsername</example>
        [DataMember(Name = "username", EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// Basic auth password.
        /// </summary>
        /// <value>Basic auth password.</value>
        /// <example>mySecretPassword1!</example>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// A fallback url which, if provided, will be used to retry the redirect callback delivery in case &#x60;redirectUrl&#x60; fails to respond.
        /// </summary>
        /// <value>A fallback url which, if provided, will be used to retry the redirect callback delivery in case &#x60;redirectUrl&#x60; fails to respond.</value>
        /// <example>https://myFallbackServer.example/bandwidth/webhooks/redirect</example>
        [DataMember(Name = "redirectFallbackUrl", EmitDefaultValue = true)]
        public string RedirectFallbackUrl { get; set; }

        /// <summary>
        /// Basic auth username.
        /// </summary>
        /// <value>Basic auth username.</value>
        /// <example>mySecretUsername</example>
        [DataMember(Name = "fallbackUsername", EmitDefaultValue = true)]
        public string FallbackUsername { get; set; }

        /// <summary>
        /// Basic auth password.
        /// </summary>
        /// <value>Basic auth password.</value>
        /// <example>mySecretPassword1!</example>
        [DataMember(Name = "fallbackPassword", EmitDefaultValue = true)]
        public string FallbackPassword { get; set; }

        /// <summary>
        /// A custom string that will be sent with this and all future callbacks unless overwritten by a future &#x60;tag&#x60; attribute or [&#x60;&lt;Tag&gt;&#x60;](/docs/voice/bxml/tag) verb, or cleared.  May be cleared by setting &#x60;tag&#x3D;\&quot;\&quot;&#x60;.  Max length 256 characters.  Not allowed if &#x60;state&#x60; is &#x60;completed&#x60;.
        /// </summary>
        /// <value>A custom string that will be sent with this and all future callbacks unless overwritten by a future &#x60;tag&#x60; attribute or [&#x60;&lt;Tag&gt;&#x60;](/docs/voice/bxml/tag) verb, or cleared.  May be cleared by setting &#x60;tag&#x3D;\&quot;\&quot;&#x60;.  Max length 256 characters.  Not allowed if &#x60;state&#x60; is &#x60;completed&#x60;.</value>
        /// <example>My Custom Tag</example>
        [DataMember(Name = "tag", EmitDefaultValue = true)]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateCall {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  RedirectMethod: ").Append(RedirectMethod).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  RedirectFallbackUrl: ").Append(RedirectFallbackUrl).Append("\n");
            sb.Append("  RedirectFallbackMethod: ").Append(RedirectFallbackMethod).Append("\n");
            sb.Append("  FallbackUsername: ").Append(FallbackUsername).Append("\n");
            sb.Append("  FallbackPassword: ").Append(FallbackPassword).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            // Username (string) maxLength
            if (this.Username != null && this.Username.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for Username, length must be less than 1024.", new [] { "Username" });
            }

            // Password (string) maxLength
            if (this.Password != null && this.Password.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for Password, length must be less than 1024.", new [] { "Password" });
            }

            // FallbackUsername (string) maxLength
            if (this.FallbackUsername != null && this.FallbackUsername.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for FallbackUsername, length must be less than 1024.", new [] { "FallbackUsername" });
            }

            // FallbackPassword (string) maxLength
            if (this.FallbackPassword != null && this.FallbackPassword.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for FallbackPassword, length must be less than 1024.", new [] { "FallbackPassword" });
            }

            // Tag (string) maxLength
            if (this.Tag != null && this.Tag.Length > 256)
            {
                yield return new ValidationResult("Invalid value for Tag, length must be less than 256.", new [] { "Tag" });
            }

            yield break;
        }
    }

}
