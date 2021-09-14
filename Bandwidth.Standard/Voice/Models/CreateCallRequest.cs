// <copyright file="CreateCallRequest.cs" company="APIMatic">
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
    /// CreateCallRequest.
    /// </summary>
    public class CreateCallRequest
    {
        private string uui;
        private double? callTimeout;
        private double? callbackTimeout;
        private string answerFallbackUrl;
        private string username;
        private string password;
        private string fallbackUsername;
        private string fallbackPassword;
        private Models.AnswerMethodEnum? answerMethod;
        private Models.AnswerFallbackMethodEnum? answerFallbackMethod;
        private string disconnectUrl;
        private Models.DisconnectMethodEnum? disconnectMethod;
        private string tag;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "uui", false },
            { "callTimeout", false },
            { "callbackTimeout", false },
            { "answerFallbackUrl", false },
            { "username", false },
            { "password", false },
            { "fallbackUsername", false },
            { "fallbackPassword", false },
            { "answerMethod", false },
            { "answerFallbackMethod", false },
            { "disconnectUrl", false },
            { "disconnectMethod", false },
            { "tag", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCallRequest"/> class.
        /// </summary>
        public CreateCallRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCallRequest"/> class.
        /// </summary>
        /// <param name="from">from.</param>
        /// <param name="to">to.</param>
        /// <param name="answerUrl">answerUrl.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="uui">uui.</param>
        /// <param name="callTimeout">callTimeout.</param>
        /// <param name="callbackTimeout">callbackTimeout.</param>
        /// <param name="answerFallbackUrl">answerFallbackUrl.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="fallbackUsername">fallbackUsername.</param>
        /// <param name="fallbackPassword">fallbackPassword.</param>
        /// <param name="answerMethod">answerMethod.</param>
        /// <param name="answerFallbackMethod">answerFallbackMethod.</param>
        /// <param name="disconnectUrl">disconnectUrl.</param>
        /// <param name="disconnectMethod">disconnectMethod.</param>
        /// <param name="tag">tag.</param>
        /// <param name="machineDetection">machineDetection.</param>
        public CreateCallRequest(
            string from,
            string to,
            string answerUrl,
            string applicationId,
            string uui = null,
            double? callTimeout = null,
            double? callbackTimeout = null,
            string answerFallbackUrl = null,
            string username = null,
            string password = null,
            string fallbackUsername = null,
            string fallbackPassword = null,
            Models.AnswerMethodEnum? answerMethod = null,
            Models.AnswerFallbackMethodEnum? answerFallbackMethod = null,
            string disconnectUrl = null,
            Models.DisconnectMethodEnum? disconnectMethod = null,
            string tag = null,
            Models.MachineDetectionRequest machineDetection = null)
        {
            this.From = from;
            this.To = to;
            if (uui != null)
            {
                this.Uui = uui;
            }

            if (callTimeout != null)
            {
                this.CallTimeout = callTimeout;
            }

            if (callbackTimeout != null)
            {
                this.CallbackTimeout = callbackTimeout;
            }

            this.AnswerUrl = answerUrl;
            if (answerFallbackUrl != null)
            {
                this.AnswerFallbackUrl = answerFallbackUrl;
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

            if (answerMethod != null)
            {
                this.AnswerMethod = answerMethod;
            }

            if (answerFallbackMethod != null)
            {
                this.AnswerFallbackMethod = answerFallbackMethod;
            }

            if (disconnectUrl != null)
            {
                this.DisconnectUrl = disconnectUrl;
            }

            if (disconnectMethod != null)
            {
                this.DisconnectMethod = disconnectMethod;
            }

            if (tag != null)
            {
                this.Tag = tag;
            }

            this.ApplicationId = applicationId;
            this.MachineDetection = machineDetection;
        }

        /// <summary>
        /// Format is E164
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }

        /// <summary>
        /// Format is E164 or SIP URI
        /// </summary>
        [JsonProperty("to")]
        public string To { get; set; }

        /// <summary>
        /// A comma-separated list of 'User-To-User' headers to be sent in the INVITE when calling a SIP URI. Each value must end with an 'encoding' parameter as described in https://tools.ietf.org/html/rfc7433. Only 'jwt' and 'base64' encodings are allowed. The entire value cannot exceed 350 characters, including parameters and separators.
        /// </summary>
        [JsonProperty("uui")]
        public string Uui
        {
            get
            {
                return this.uui;
            }

            set
            {
                this.shouldSerialize["uui"] = true;
                this.uui = value;
            }
        }

        /// <summary>
        /// Gets or sets CallTimeout.
        /// </summary>
        [JsonProperty("callTimeout")]
        public double? CallTimeout
        {
            get
            {
                return this.callTimeout;
            }

            set
            {
                this.shouldSerialize["callTimeout"] = true;
                this.callTimeout = value;
            }
        }

        /// <summary>
        /// Gets or sets CallbackTimeout.
        /// </summary>
        [JsonProperty("callbackTimeout")]
        public double? CallbackTimeout
        {
            get
            {
                return this.callbackTimeout;
            }

            set
            {
                this.shouldSerialize["callbackTimeout"] = true;
                this.callbackTimeout = value;
            }
        }

        /// <summary>
        /// Gets or sets AnswerUrl.
        /// </summary>
        [JsonProperty("answerUrl")]
        public string AnswerUrl { get; set; }

        /// <summary>
        /// Gets or sets AnswerFallbackUrl.
        /// </summary>
        [JsonProperty("answerFallbackUrl")]
        public string AnswerFallbackUrl
        {
            get
            {
                return this.answerFallbackUrl;
            }

            set
            {
                this.shouldSerialize["answerFallbackUrl"] = true;
                this.answerFallbackUrl = value;
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

        /// <summary>
        /// Gets or sets AnswerMethod.
        /// </summary>
        [JsonProperty("answerMethod", ItemConverterType = typeof(StringEnumConverter))]
        public Models.AnswerMethodEnum? AnswerMethod
        {
            get
            {
                return this.answerMethod;
            }

            set
            {
                this.shouldSerialize["answerMethod"] = true;
                this.answerMethod = value;
            }
        }

        /// <summary>
        /// Gets or sets AnswerFallbackMethod.
        /// </summary>
        [JsonProperty("answerFallbackMethod", ItemConverterType = typeof(StringEnumConverter))]
        public Models.AnswerFallbackMethodEnum? AnswerFallbackMethod
        {
            get
            {
                return this.answerFallbackMethod;
            }

            set
            {
                this.shouldSerialize["answerFallbackMethod"] = true;
                this.answerFallbackMethod = value;
            }
        }

        /// <summary>
        /// Gets or sets DisconnectUrl.
        /// </summary>
        [JsonProperty("disconnectUrl")]
        public string DisconnectUrl
        {
            get
            {
                return this.disconnectUrl;
            }

            set
            {
                this.shouldSerialize["disconnectUrl"] = true;
                this.disconnectUrl = value;
            }
        }

        /// <summary>
        /// Gets or sets DisconnectMethod.
        /// </summary>
        [JsonProperty("disconnectMethod", ItemConverterType = typeof(StringEnumConverter))]
        public Models.DisconnectMethodEnum? DisconnectMethod
        {
            get
            {
                return this.disconnectMethod;
            }

            set
            {
                this.shouldSerialize["disconnectMethod"] = true;
                this.disconnectMethod = value;
            }
        }

        /// <summary>
        /// Gets or sets Tag.
        /// </summary>
        [JsonProperty("tag")]
        public string Tag
        {
            get
            {
                return this.tag;
            }

            set
            {
                this.shouldSerialize["tag"] = true;
                this.tag = value;
            }
        }

        /// <summary>
        /// Gets or sets ApplicationId.
        /// </summary>
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets MachineDetection.
        /// </summary>
        [JsonProperty("machineDetection", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MachineDetectionRequest MachineDetection { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateCallRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUui()
        {
            this.shouldSerialize["uui"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCallTimeout()
        {
            this.shouldSerialize["callTimeout"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCallbackTimeout()
        {
            this.shouldSerialize["callbackTimeout"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAnswerFallbackUrl()
        {
            this.shouldSerialize["answerFallbackUrl"] = false;
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
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAnswerMethod()
        {
            this.shouldSerialize["answerMethod"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAnswerFallbackMethod()
        {
            this.shouldSerialize["answerFallbackMethod"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDisconnectUrl()
        {
            this.shouldSerialize["disconnectUrl"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDisconnectMethod()
        {
            this.shouldSerialize["disconnectMethod"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTag()
        {
            this.shouldSerialize["tag"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUui()
        {
            return this.shouldSerialize["uui"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCallTimeout()
        {
            return this.shouldSerialize["callTimeout"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCallbackTimeout()
        {
            return this.shouldSerialize["callbackTimeout"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnswerFallbackUrl()
        {
            return this.shouldSerialize["answerFallbackUrl"];
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

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnswerMethod()
        {
            return this.shouldSerialize["answerMethod"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnswerFallbackMethod()
        {
            return this.shouldSerialize["answerFallbackMethod"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDisconnectUrl()
        {
            return this.shouldSerialize["disconnectUrl"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDisconnectMethod()
        {
            return this.shouldSerialize["disconnectMethod"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTag()
        {
            return this.shouldSerialize["tag"];
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

            return obj is CreateCallRequest other &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true)) &&
                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.Uui == null && other.Uui == null) || (this.Uui?.Equals(other.Uui) == true)) &&
                ((this.CallTimeout == null && other.CallTimeout == null) || (this.CallTimeout?.Equals(other.CallTimeout) == true)) &&
                ((this.CallbackTimeout == null && other.CallbackTimeout == null) || (this.CallbackTimeout?.Equals(other.CallbackTimeout) == true)) &&
                ((this.AnswerUrl == null && other.AnswerUrl == null) || (this.AnswerUrl?.Equals(other.AnswerUrl) == true)) &&
                ((this.AnswerFallbackUrl == null && other.AnswerFallbackUrl == null) || (this.AnswerFallbackUrl?.Equals(other.AnswerFallbackUrl) == true)) &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true)) &&
                ((this.FallbackUsername == null && other.FallbackUsername == null) || (this.FallbackUsername?.Equals(other.FallbackUsername) == true)) &&
                ((this.FallbackPassword == null && other.FallbackPassword == null) || (this.FallbackPassword?.Equals(other.FallbackPassword) == true)) &&
                ((this.AnswerMethod == null && other.AnswerMethod == null) || (this.AnswerMethod?.Equals(other.AnswerMethod) == true)) &&
                ((this.AnswerFallbackMethod == null && other.AnswerFallbackMethod == null) || (this.AnswerFallbackMethod?.Equals(other.AnswerFallbackMethod) == true)) &&
                ((this.DisconnectUrl == null && other.DisconnectUrl == null) || (this.DisconnectUrl?.Equals(other.DisconnectUrl) == true)) &&
                ((this.DisconnectMethod == null && other.DisconnectMethod == null) || (this.DisconnectMethod?.Equals(other.DisconnectMethod) == true)) &&
                ((this.Tag == null && other.Tag == null) || (this.Tag?.Equals(other.Tag) == true)) &&
                ((this.ApplicationId == null && other.ApplicationId == null) || (this.ApplicationId?.Equals(other.ApplicationId) == true)) &&
                ((this.MachineDetection == null && other.MachineDetection == null) || (this.MachineDetection?.Equals(other.MachineDetection) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 833252467;

            if (this.From != null)
            {
               hashCode += this.From.GetHashCode();
            }

            if (this.To != null)
            {
               hashCode += this.To.GetHashCode();
            }

            if (this.Uui != null)
            {
               hashCode += this.Uui.GetHashCode();
            }

            if (this.CallTimeout != null)
            {
               hashCode += this.CallTimeout.GetHashCode();
            }

            if (this.CallbackTimeout != null)
            {
               hashCode += this.CallbackTimeout.GetHashCode();
            }

            if (this.AnswerUrl != null)
            {
               hashCode += this.AnswerUrl.GetHashCode();
            }

            if (this.AnswerFallbackUrl != null)
            {
               hashCode += this.AnswerFallbackUrl.GetHashCode();
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

            if (this.AnswerMethod != null)
            {
               hashCode += this.AnswerMethod.GetHashCode();
            }

            if (this.AnswerFallbackMethod != null)
            {
               hashCode += this.AnswerFallbackMethod.GetHashCode();
            }

            if (this.DisconnectUrl != null)
            {
               hashCode += this.DisconnectUrl.GetHashCode();
            }

            if (this.DisconnectMethod != null)
            {
               hashCode += this.DisconnectMethod.GetHashCode();
            }

            if (this.Tag != null)
            {
               hashCode += this.Tag.GetHashCode();
            }

            if (this.ApplicationId != null)
            {
               hashCode += this.ApplicationId.GetHashCode();
            }

            if (this.MachineDetection != null)
            {
               hashCode += this.MachineDetection.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.From = {(this.From == null ? "null" : this.From == string.Empty ? "" : this.From)}");
            toStringOutput.Add($"this.To = {(this.To == null ? "null" : this.To == string.Empty ? "" : this.To)}");
            toStringOutput.Add($"this.Uui = {(this.Uui == null ? "null" : this.Uui == string.Empty ? "" : this.Uui)}");
            toStringOutput.Add($"this.CallTimeout = {(this.CallTimeout == null ? "null" : this.CallTimeout.ToString())}");
            toStringOutput.Add($"this.CallbackTimeout = {(this.CallbackTimeout == null ? "null" : this.CallbackTimeout.ToString())}");
            toStringOutput.Add($"this.AnswerUrl = {(this.AnswerUrl == null ? "null" : this.AnswerUrl == string.Empty ? "" : this.AnswerUrl)}");
            toStringOutput.Add($"this.AnswerFallbackUrl = {(this.AnswerFallbackUrl == null ? "null" : this.AnswerFallbackUrl == string.Empty ? "" : this.AnswerFallbackUrl)}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username == string.Empty ? "" : this.Username)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password == string.Empty ? "" : this.Password)}");
            toStringOutput.Add($"this.FallbackUsername = {(this.FallbackUsername == null ? "null" : this.FallbackUsername == string.Empty ? "" : this.FallbackUsername)}");
            toStringOutput.Add($"this.FallbackPassword = {(this.FallbackPassword == null ? "null" : this.FallbackPassword == string.Empty ? "" : this.FallbackPassword)}");
            toStringOutput.Add($"this.AnswerMethod = {(this.AnswerMethod == null ? "null" : this.AnswerMethod.ToString())}");
            toStringOutput.Add($"this.AnswerFallbackMethod = {(this.AnswerFallbackMethod == null ? "null" : this.AnswerFallbackMethod.ToString())}");
            toStringOutput.Add($"this.DisconnectUrl = {(this.DisconnectUrl == null ? "null" : this.DisconnectUrl == string.Empty ? "" : this.DisconnectUrl)}");
            toStringOutput.Add($"this.DisconnectMethod = {(this.DisconnectMethod == null ? "null" : this.DisconnectMethod.ToString())}");
            toStringOutput.Add($"this.Tag = {(this.Tag == null ? "null" : this.Tag == string.Empty ? "" : this.Tag)}");
            toStringOutput.Add($"this.ApplicationId = {(this.ApplicationId == null ? "null" : this.ApplicationId == string.Empty ? "" : this.ApplicationId)}");
            toStringOutput.Add($"this.MachineDetection = {(this.MachineDetection == null ? "null" : this.MachineDetection.ToString())}");
        }
    }
}