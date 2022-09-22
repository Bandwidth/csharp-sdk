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
    /// The machine detection request used to perform &lt;a href&#x3D;&#39;/docs/voice/guides/machineDetection&#39;&gt;machine detection&lt;/a&gt; on the call.
    /// </summary>
    [DataContract(Name = "machineDetectionConfiguration")]
    public partial class MachineDetectionConfiguration : IEquatable<MachineDetectionConfiguration>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public MachineDetectionModeEnum? Mode { get; set; }

        /// <summary>
        /// Gets or Sets CallbackMethod
        /// </summary>
        [DataMember(Name = "callbackMethod", EmitDefaultValue = true)]
        public CallbackMethodEnum? CallbackMethod { get; set; }

        /// <summary>
        /// Gets or Sets FallbackMethod
        /// </summary>
        [DataMember(Name = "fallbackMethod", EmitDefaultValue = true)]
        public CallbackMethodEnum? FallbackMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MachineDetectionConfiguration" /> class.
        /// </summary>
        /// <param name="mode">mode.</param>
        /// <param name="detectionTimeout">The timeout used for the whole operation, in seconds. If no result is determined in this period, a callback with a &#x60;timeout&#x60; result is sent. (default to 15D).</param>
        /// <param name="silenceTimeout">If no speech is detected in this period, a callback with a &#39;silence&#39; result is sent. (default to 10D).</param>
        /// <param name="speechThreshold">When speech has ended and a result couldn&#39;t be determined based on the audio content itself, this value is used to determine if the speaker is a machine based on the speech duration. If the length of the speech detected is greater than or equal to this threshold, the result will be &#39;answering-machine&#39;. If the length of speech detected is below this threshold, the result will be &#39;human&#39;. (default to 10D).</param>
        /// <param name="speechEndThreshold">Amount of silence (in seconds) before assuming the callee has finished speaking. (default to 5D).</param>
        /// <param name="machineSpeechEndThreshold">When an answering machine is detected, the amount of silence (in seconds) before assuming the message has finished playing.  If not provided it will default to the speechEndThreshold value..</param>
        /// <param name="delayResult">If set to &#39;true&#39; and if an answering machine is detected, the &#39;answering-machine&#39; callback will be delayed until the machine is done speaking, or an end of message tone is detected, or until the &#39;detectionTimeout&#39; is exceeded. If false, the &#39;answering-machine&#39; result is sent immediately. (default to false).</param>
        /// <param name="callbackUrl">The URL to send the &#39;machineDetectionComplete&#39; webhook when the detection is completed. Only for &#39;async&#39; mode..</param>
        /// <param name="callbackMethod">callbackMethod.</param>
        /// <param name="username">Basic auth username..</param>
        /// <param name="password">Basic auth password..</param>
        /// <param name="fallbackUrl">A fallback URL which, if provided, will be used to retry the machine detection complete webhook delivery in case &#x60;callbackUrl&#x60; fails to respond.</param>
        /// <param name="fallbackMethod">fallbackMethod.</param>
        /// <param name="fallbackUsername">Basic auth username..</param>
        /// <param name="fallbackPassword">Basic auth password..</param>
        public MachineDetectionConfiguration(MachineDetectionModeEnum? mode = default(MachineDetectionModeEnum?), double? detectionTimeout = 15D, double? silenceTimeout = 10D, double? speechThreshold = 10D, double? speechEndThreshold = 5D, double? machineSpeechEndThreshold = default(double?), bool? delayResult = false, string callbackUrl = default(string), CallbackMethodEnum? callbackMethod = default(CallbackMethodEnum?), string username = default(string), string password = default(string), string fallbackUrl = default(string), CallbackMethodEnum? fallbackMethod = default(CallbackMethodEnum?), string fallbackUsername = default(string), string fallbackPassword = default(string))
        {
            this.Mode = mode;
            // use default value if no "detectionTimeout" provided
            this.DetectionTimeout = detectionTimeout ?? 15D;
            // use default value if no "silenceTimeout" provided
            this.SilenceTimeout = silenceTimeout ?? 10D;
            // use default value if no "speechThreshold" provided
            this.SpeechThreshold = speechThreshold ?? 10D;
            // use default value if no "speechEndThreshold" provided
            this.SpeechEndThreshold = speechEndThreshold ?? 5D;
            this.MachineSpeechEndThreshold = machineSpeechEndThreshold;
            // use default value if no "delayResult" provided
            this.DelayResult = delayResult ?? false;
            this.CallbackUrl = callbackUrl;
            this.CallbackMethod = callbackMethod;
            this.Username = username;
            this.Password = password;
            this.FallbackUrl = fallbackUrl;
            this.FallbackMethod = fallbackMethod;
            this.FallbackUsername = fallbackUsername;
            this.FallbackPassword = fallbackPassword;
        }

        /// <summary>
        /// The timeout used for the whole operation, in seconds. If no result is determined in this period, a callback with a &#x60;timeout&#x60; result is sent.
        /// </summary>
        /// <value>The timeout used for the whole operation, in seconds. If no result is determined in this period, a callback with a &#x60;timeout&#x60; result is sent.</value>
        [DataMember(Name = "detectionTimeout", EmitDefaultValue = true)]
        public double? DetectionTimeout { get; set; }

        /// <summary>
        /// If no speech is detected in this period, a callback with a &#39;silence&#39; result is sent.
        /// </summary>
        /// <value>If no speech is detected in this period, a callback with a &#39;silence&#39; result is sent.</value>
        [DataMember(Name = "silenceTimeout", EmitDefaultValue = true)]
        public double? SilenceTimeout { get; set; }

        /// <summary>
        /// When speech has ended and a result couldn&#39;t be determined based on the audio content itself, this value is used to determine if the speaker is a machine based on the speech duration. If the length of the speech detected is greater than or equal to this threshold, the result will be &#39;answering-machine&#39;. If the length of speech detected is below this threshold, the result will be &#39;human&#39;.
        /// </summary>
        /// <value>When speech has ended and a result couldn&#39;t be determined based on the audio content itself, this value is used to determine if the speaker is a machine based on the speech duration. If the length of the speech detected is greater than or equal to this threshold, the result will be &#39;answering-machine&#39;. If the length of speech detected is below this threshold, the result will be &#39;human&#39;.</value>
        [DataMember(Name = "speechThreshold", EmitDefaultValue = true)]
        public double? SpeechThreshold { get; set; }

        /// <summary>
        /// Amount of silence (in seconds) before assuming the callee has finished speaking.
        /// </summary>
        /// <value>Amount of silence (in seconds) before assuming the callee has finished speaking.</value>
        [DataMember(Name = "speechEndThreshold", EmitDefaultValue = true)]
        public double? SpeechEndThreshold { get; set; }

        /// <summary>
        /// When an answering machine is detected, the amount of silence (in seconds) before assuming the message has finished playing.  If not provided it will default to the speechEndThreshold value.
        /// </summary>
        /// <value>When an answering machine is detected, the amount of silence (in seconds) before assuming the message has finished playing.  If not provided it will default to the speechEndThreshold value.</value>
        [DataMember(Name = "machineSpeechEndThreshold", EmitDefaultValue = true)]
        public double? MachineSpeechEndThreshold { get; set; }

        /// <summary>
        /// If set to &#39;true&#39; and if an answering machine is detected, the &#39;answering-machine&#39; callback will be delayed until the machine is done speaking, or an end of message tone is detected, or until the &#39;detectionTimeout&#39; is exceeded. If false, the &#39;answering-machine&#39; result is sent immediately.
        /// </summary>
        /// <value>If set to &#39;true&#39; and if an answering machine is detected, the &#39;answering-machine&#39; callback will be delayed until the machine is done speaking, or an end of message tone is detected, or until the &#39;detectionTimeout&#39; is exceeded. If false, the &#39;answering-machine&#39; result is sent immediately.</value>
        [DataMember(Name = "delayResult", EmitDefaultValue = true)]
        public bool? DelayResult { get; set; }

        /// <summary>
        /// The URL to send the &#39;machineDetectionComplete&#39; webhook when the detection is completed. Only for &#39;async&#39; mode.
        /// </summary>
        /// <value>The URL to send the &#39;machineDetectionComplete&#39; webhook when the detection is completed. Only for &#39;async&#39; mode.</value>
        [DataMember(Name = "callbackUrl", EmitDefaultValue = true)]
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
        /// A fallback URL which, if provided, will be used to retry the machine detection complete webhook delivery in case &#x60;callbackUrl&#x60; fails to respond
        /// </summary>
        /// <value>A fallback URL which, if provided, will be used to retry the machine detection complete webhook delivery in case &#x60;callbackUrl&#x60; fails to respond</value>
        [DataMember(Name = "fallbackUrl", EmitDefaultValue = true)]
        public string FallbackUrl { get; set; }

        /// <summary>
        /// Basic auth username.
        /// </summary>
        /// <value>Basic auth username.</value>
        [DataMember(Name = "fallbackUsername", EmitDefaultValue = true)]
        public string FallbackUsername { get; set; }

        /// <summary>
        /// Basic auth password.
        /// </summary>
        /// <value>Basic auth password.</value>
        [DataMember(Name = "fallbackPassword", EmitDefaultValue = true)]
        public string FallbackPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MachineDetectionConfiguration {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  DetectionTimeout: ").Append(DetectionTimeout).Append("\n");
            sb.Append("  SilenceTimeout: ").Append(SilenceTimeout).Append("\n");
            sb.Append("  SpeechThreshold: ").Append(SpeechThreshold).Append("\n");
            sb.Append("  SpeechEndThreshold: ").Append(SpeechEndThreshold).Append("\n");
            sb.Append("  MachineSpeechEndThreshold: ").Append(MachineSpeechEndThreshold).Append("\n");
            sb.Append("  DelayResult: ").Append(DelayResult).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  CallbackMethod: ").Append(CallbackMethod).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  FallbackUrl: ").Append(FallbackUrl).Append("\n");
            sb.Append("  FallbackMethod: ").Append(FallbackMethod).Append("\n");
            sb.Append("  FallbackUsername: ").Append(FallbackUsername).Append("\n");
            sb.Append("  FallbackPassword: ").Append(FallbackPassword).Append("\n");
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
            return this.Equals(input as MachineDetectionConfiguration);
        }

        /// <summary>
        /// Returns true if MachineDetectionConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of MachineDetectionConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MachineDetectionConfiguration input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
                ) && 
                (
                    this.DetectionTimeout == input.DetectionTimeout ||
                    (this.DetectionTimeout != null &&
                    this.DetectionTimeout.Equals(input.DetectionTimeout))
                ) && 
                (
                    this.SilenceTimeout == input.SilenceTimeout ||
                    (this.SilenceTimeout != null &&
                    this.SilenceTimeout.Equals(input.SilenceTimeout))
                ) && 
                (
                    this.SpeechThreshold == input.SpeechThreshold ||
                    (this.SpeechThreshold != null &&
                    this.SpeechThreshold.Equals(input.SpeechThreshold))
                ) && 
                (
                    this.SpeechEndThreshold == input.SpeechEndThreshold ||
                    (this.SpeechEndThreshold != null &&
                    this.SpeechEndThreshold.Equals(input.SpeechEndThreshold))
                ) && 
                (
                    this.MachineSpeechEndThreshold == input.MachineSpeechEndThreshold ||
                    (this.MachineSpeechEndThreshold != null &&
                    this.MachineSpeechEndThreshold.Equals(input.MachineSpeechEndThreshold))
                ) && 
                (
                    this.DelayResult == input.DelayResult ||
                    (this.DelayResult != null &&
                    this.DelayResult.Equals(input.DelayResult))
                ) && 
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
                    this.FallbackUrl == input.FallbackUrl ||
                    (this.FallbackUrl != null &&
                    this.FallbackUrl.Equals(input.FallbackUrl))
                ) && 
                (
                    this.FallbackMethod == input.FallbackMethod ||
                    this.FallbackMethod.Equals(input.FallbackMethod)
                ) && 
                (
                    this.FallbackUsername == input.FallbackUsername ||
                    (this.FallbackUsername != null &&
                    this.FallbackUsername.Equals(input.FallbackUsername))
                ) && 
                (
                    this.FallbackPassword == input.FallbackPassword ||
                    (this.FallbackPassword != null &&
                    this.FallbackPassword.Equals(input.FallbackPassword))
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
                hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                if (this.DetectionTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.DetectionTimeout.GetHashCode();
                }
                if (this.SilenceTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.SilenceTimeout.GetHashCode();
                }
                if (this.SpeechThreshold != null)
                {
                    hashCode = (hashCode * 59) + this.SpeechThreshold.GetHashCode();
                }
                if (this.SpeechEndThreshold != null)
                {
                    hashCode = (hashCode * 59) + this.SpeechEndThreshold.GetHashCode();
                }
                if (this.MachineSpeechEndThreshold != null)
                {
                    hashCode = (hashCode * 59) + this.MachineSpeechEndThreshold.GetHashCode();
                }
                if (this.DelayResult != null)
                {
                    hashCode = (hashCode * 59) + this.DelayResult.GetHashCode();
                }
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
                if (this.FallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FallbackUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FallbackMethod.GetHashCode();
                if (this.FallbackUsername != null)
                {
                    hashCode = (hashCode * 59) + this.FallbackUsername.GetHashCode();
                }
                if (this.FallbackPassword != null)
                {
                    hashCode = (hashCode * 59) + this.FallbackPassword.GetHashCode();
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
            // CallbackUrl (string) maxLength
            if (this.CallbackUrl != null && this.CallbackUrl.Length > 2048)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallbackUrl, length must be less than 2048.", new [] { "CallbackUrl" });
            }

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

            // FallbackUrl (string) maxLength
            if (this.FallbackUrl != null && this.FallbackUrl.Length > 2048)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FallbackUrl, length must be less than 2048.", new [] { "FallbackUrl" });
            }

            // FallbackUsername (string) maxLength
            if (this.FallbackUsername != null && this.FallbackUsername.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FallbackUsername, length must be less than 1024.", new [] { "FallbackUsername" });
            }

            // FallbackPassword (string) maxLength
            if (this.FallbackPassword != null && this.FallbackPassword.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FallbackPassword, length must be less than 1024.", new [] { "FallbackPassword" });
            }

            yield break;
        }
    }

}
