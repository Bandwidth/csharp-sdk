// <copyright file="MachineDetectionRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.Voice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Bandwidth.Standard;
    using Bandwidth.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// MachineDetectionRequest.
    /// </summary>
    public class MachineDetectionRequest
    {
        private string callbackUrl;
        private Models.CallbackMethodEnum? callbackMethod;
        private string fallbackUrl;
        private Models.FallbackMethodEnum? fallbackMethod;
        private string username;
        private string password;
        private string fallbackUsername;
        private string fallbackPassword;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "callbackUrl", false },
            { "callbackMethod", false },
            { "fallbackUrl", false },
            { "fallbackMethod", false },
            { "username", false },
            { "password", false },
            { "fallbackUsername", false },
            { "fallbackPassword", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MachineDetectionRequest"/> class.
        /// </summary>
        public MachineDetectionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MachineDetectionRequest"/> class.
        /// </summary>
        /// <param name="mode">mode.</param>
        /// <param name="detectionTimeout">detectionTimeout.</param>
        /// <param name="silenceTimeout">silenceTimeout.</param>
        /// <param name="speechThreshold">speechThreshold.</param>
        /// <param name="speechEndThreshold">speechEndThreshold.</param>
        /// <param name="delayResult">delayResult.</param>
        /// <param name="callbackUrl">callbackUrl.</param>
        /// <param name="callbackMethod">callbackMethod.</param>
        /// <param name="fallbackUrl">fallbackUrl.</param>
        /// <param name="fallbackMethod">fallbackMethod.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="fallbackUsername">fallbackUsername.</param>
        /// <param name="fallbackPassword">fallbackPassword.</param>
        public MachineDetectionRequest(
            Models.ModeEnum? mode = null,
            double? detectionTimeout = null,
            double? silenceTimeout = null,
            double? speechThreshold = null,
            double? speechEndThreshold = null,
            bool? delayResult = null,
            string callbackUrl = null,
            Models.CallbackMethodEnum? callbackMethod = null,
            string fallbackUrl = null,
            Models.FallbackMethodEnum? fallbackMethod = null,
            string username = null,
            string password = null,
            string fallbackUsername = null,
            string fallbackPassword = null)
        {
            this.Mode = mode;
            this.DetectionTimeout = detectionTimeout;
            this.SilenceTimeout = silenceTimeout;
            this.SpeechThreshold = speechThreshold;
            this.SpeechEndThreshold = speechEndThreshold;
            this.DelayResult = delayResult;
            if (callbackUrl != null)
            {
                this.CallbackUrl = callbackUrl;
            }

            if (callbackMethod != null)
            {
                this.CallbackMethod = callbackMethod;
            }

            if (fallbackUrl != null)
            {
                this.FallbackUrl = fallbackUrl;
            }

            if (fallbackMethod != null)
            {
                this.FallbackMethod = fallbackMethod;
            }

            if (username != null)
            {
                this.Username = username;
            }

            if (password != null)
            {
                this.Password = password;
            }

            if (fallbackUsername != null)
            {
                this.FallbackUsername = fallbackUsername;
            }

            if (fallbackPassword != null)
            {
                this.FallbackPassword = fallbackPassword;
            }

        }

        /// <summary>
        /// The machine detection mode. If set to 'async', the detection result will be sent in a 'machineDetectionComplete' callback. If set to 'sync', the 'answer' callback will wait for the machine detection to complete and will include its result. Default is 'async'.
        /// </summary>
        [JsonProperty("mode", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ModeEnum? Mode { get; set; }

        /// <summary>
        /// Total amount of time (in seconds) before giving up.
        /// </summary>
        [JsonProperty("detectionTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public double? DetectionTimeout { get; set; }

        /// <summary>
        /// If no speech is detected in this period, a callback with a 'silence' result is sent. Default is 10 seconds.
        /// </summary>
        [JsonProperty("silenceTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public double? SilenceTimeout { get; set; }

        /// <summary>
        /// When speech has ended and a result couldn't be determined based on the audio content itself, this value is used to determine if the speaker is a machine based on the speech duration. If the length of the speech detected is greater than or equal to this threshold, the result will be 'answering-machine'. If the length of speech detected is below this threshold, the result will be 'human'. Default is 10 seconds.
        /// </summary>
        [JsonProperty("speechThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? SpeechThreshold { get; set; }

        /// <summary>
        /// Amount of silence (in seconds) before assuming the callee has finished speaking.
        /// </summary>
        [JsonProperty("speechEndThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? SpeechEndThreshold { get; set; }

        /// <summary>
        /// If set to 'true' and if an answering machine is detected, the 'answering-machine' callback will be delayed until the machine is done speaking or until the 'detectionTimeout' is exceeded. If false, the 'answering-machine' result is sent immediately. Default is 'false'.
        /// </summary>
        [JsonProperty("delayResult", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DelayResult { get; set; }

        /// <summary>
        /// The URL to send the 'machineDetectionComplete' callback when the detection is completed. Only for 'async' mode.
        /// </summary>
        [JsonProperty("callbackUrl")]
        public string CallbackUrl
        {
            get
            {
                return this.callbackUrl;
            }

            set
            {
                this.shouldSerialize["callbackUrl"] = true;
                this.callbackUrl = value;
            }
        }

        /// <summary>
        /// Gets or sets CallbackMethod.
        /// </summary>
        [JsonProperty("callbackMethod", ItemConverterType = typeof(StringEnumConverter))]
        public Models.CallbackMethodEnum? CallbackMethod
        {
            get
            {
                return this.callbackMethod;
            }

            set
            {
                this.shouldSerialize["callbackMethod"] = true;
                this.callbackMethod = value;
            }
        }

        /// <summary>
        /// Gets or sets FallbackUrl.
        /// </summary>
        [JsonProperty("fallbackUrl")]
        public string FallbackUrl
        {
            get
            {
                return this.fallbackUrl;
            }

            set
            {
                this.shouldSerialize["fallbackUrl"] = true;
                this.fallbackUrl = value;
            }
        }

        /// <summary>
        /// Gets or sets FallbackMethod.
        /// </summary>
        [JsonProperty("fallbackMethod", ItemConverterType = typeof(StringEnumConverter))]
        public Models.FallbackMethodEnum? FallbackMethod
        {
            get
            {
                return this.fallbackMethod;
            }

            set
            {
                this.shouldSerialize["fallbackMethod"] = true;
                this.fallbackMethod = value;
            }
        }

        /// <summary>
        /// Gets or sets Username.
        /// </summary>
        [JsonProperty("username")]
        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                this.shouldSerialize["username"] = true;
                this.username = value;
            }
        }

        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        [JsonProperty("password")]
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.shouldSerialize["password"] = true;
                this.password = value;
            }
        }

        /// <summary>
        /// Gets or sets FallbackUsername.
        /// </summary>
        [JsonProperty("fallbackUsername")]
        public string FallbackUsername
        {
            get
            {
                return this.fallbackUsername;
            }

            set
            {
                this.shouldSerialize["fallbackUsername"] = true;
                this.fallbackUsername = value;
            }
        }

        /// <summary>
        /// Gets or sets FallbackPassword.
        /// </summary>
        [JsonProperty("fallbackPassword")]
        public string FallbackPassword
        {
            get
            {
                return this.fallbackPassword;
            }

            set
            {
                this.shouldSerialize["fallbackPassword"] = true;
                this.fallbackPassword = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MachineDetectionRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCallbackUrl()
        {
            this.shouldSerialize["callbackUrl"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCallbackMethod()
        {
            this.shouldSerialize["callbackMethod"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFallbackUrl()
        {
            this.shouldSerialize["fallbackUrl"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFallbackMethod()
        {
            this.shouldSerialize["fallbackMethod"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUsername()
        {
            this.shouldSerialize["username"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPassword()
        {
            this.shouldSerialize["password"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFallbackUsername()
        {
            this.shouldSerialize["fallbackUsername"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFallbackPassword()
        {
            this.shouldSerialize["fallbackPassword"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCallbackUrl()
        {
            return this.shouldSerialize["callbackUrl"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCallbackMethod()
        {
            return this.shouldSerialize["callbackMethod"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFallbackUrl()
        {
            return this.shouldSerialize["fallbackUrl"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFallbackMethod()
        {
            return this.shouldSerialize["fallbackMethod"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUsername()
        {
            return this.shouldSerialize["username"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePassword()
        {
            return this.shouldSerialize["password"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFallbackUsername()
        {
            return this.shouldSerialize["fallbackUsername"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFallbackPassword()
        {
            return this.shouldSerialize["fallbackPassword"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is MachineDetectionRequest other &&
                ((this.Mode == null && other.Mode == null) || (this.Mode?.Equals(other.Mode) == true)) &&
                ((this.DetectionTimeout == null && other.DetectionTimeout == null) || (this.DetectionTimeout?.Equals(other.DetectionTimeout) == true)) &&
                ((this.SilenceTimeout == null && other.SilenceTimeout == null) || (this.SilenceTimeout?.Equals(other.SilenceTimeout) == true)) &&
                ((this.SpeechThreshold == null && other.SpeechThreshold == null) || (this.SpeechThreshold?.Equals(other.SpeechThreshold) == true)) &&
                ((this.SpeechEndThreshold == null && other.SpeechEndThreshold == null) || (this.SpeechEndThreshold?.Equals(other.SpeechEndThreshold) == true)) &&
                ((this.DelayResult == null && other.DelayResult == null) || (this.DelayResult?.Equals(other.DelayResult) == true)) &&
                ((this.CallbackUrl == null && other.CallbackUrl == null) || (this.CallbackUrl?.Equals(other.CallbackUrl) == true)) &&
                ((this.CallbackMethod == null && other.CallbackMethod == null) || (this.CallbackMethod?.Equals(other.CallbackMethod) == true)) &&
                ((this.FallbackUrl == null && other.FallbackUrl == null) || (this.FallbackUrl?.Equals(other.FallbackUrl) == true)) &&
                ((this.FallbackMethod == null && other.FallbackMethod == null) || (this.FallbackMethod?.Equals(other.FallbackMethod) == true)) &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true)) &&
                ((this.FallbackUsername == null && other.FallbackUsername == null) || (this.FallbackUsername?.Equals(other.FallbackUsername) == true)) &&
                ((this.FallbackPassword == null && other.FallbackPassword == null) || (this.FallbackPassword?.Equals(other.FallbackPassword) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 796471952;

            if (this.Mode != null)
            {
               hashCode += this.Mode.GetHashCode();
            }

            if (this.DetectionTimeout != null)
            {
               hashCode += this.DetectionTimeout.GetHashCode();
            }

            if (this.SilenceTimeout != null)
            {
               hashCode += this.SilenceTimeout.GetHashCode();
            }

            if (this.SpeechThreshold != null)
            {
               hashCode += this.SpeechThreshold.GetHashCode();
            }

            if (this.SpeechEndThreshold != null)
            {
               hashCode += this.SpeechEndThreshold.GetHashCode();
            }

            if (this.DelayResult != null)
            {
               hashCode += this.DelayResult.GetHashCode();
            }

            if (this.CallbackUrl != null)
            {
               hashCode += this.CallbackUrl.GetHashCode();
            }

            if (this.CallbackMethod != null)
            {
               hashCode += this.CallbackMethod.GetHashCode();
            }

            if (this.FallbackUrl != null)
            {
               hashCode += this.FallbackUrl.GetHashCode();
            }

            if (this.FallbackMethod != null)
            {
               hashCode += this.FallbackMethod.GetHashCode();
            }

            if (this.Username != null)
            {
               hashCode += this.Username.GetHashCode();
            }

            if (this.Password != null)
            {
               hashCode += this.Password.GetHashCode();
            }

            if (this.FallbackUsername != null)
            {
               hashCode += this.FallbackUsername.GetHashCode();
            }

            if (this.FallbackPassword != null)
            {
               hashCode += this.FallbackPassword.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Mode = {(this.Mode == null ? "null" : this.Mode.ToString())}");
            toStringOutput.Add($"this.DetectionTimeout = {(this.DetectionTimeout == null ? "null" : this.DetectionTimeout.ToString())}");
            toStringOutput.Add($"this.SilenceTimeout = {(this.SilenceTimeout == null ? "null" : this.SilenceTimeout.ToString())}");
            toStringOutput.Add($"this.SpeechThreshold = {(this.SpeechThreshold == null ? "null" : this.SpeechThreshold.ToString())}");
            toStringOutput.Add($"this.SpeechEndThreshold = {(this.SpeechEndThreshold == null ? "null" : this.SpeechEndThreshold.ToString())}");
            toStringOutput.Add($"this.DelayResult = {(this.DelayResult == null ? "null" : this.DelayResult.ToString())}");
            toStringOutput.Add($"this.CallbackUrl = {(this.CallbackUrl == null ? "null" : this.CallbackUrl == string.Empty ? "" : this.CallbackUrl)}");
            toStringOutput.Add($"this.CallbackMethod = {(this.CallbackMethod == null ? "null" : this.CallbackMethod.ToString())}");
            toStringOutput.Add($"this.FallbackUrl = {(this.FallbackUrl == null ? "null" : this.FallbackUrl == string.Empty ? "" : this.FallbackUrl)}");
            toStringOutput.Add($"this.FallbackMethod = {(this.FallbackMethod == null ? "null" : this.FallbackMethod.ToString())}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username == string.Empty ? "" : this.Username)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password == string.Empty ? "" : this.Password)}");
            toStringOutput.Add($"this.FallbackUsername = {(this.FallbackUsername == null ? "null" : this.FallbackUsername == string.Empty ? "" : this.FallbackUsername)}");
            toStringOutput.Add($"this.FallbackPassword = {(this.FallbackPassword == null ? "null" : this.FallbackPassword == string.Empty ? "" : this.FallbackPassword)}");
        }
    }
}