// <copyright file="CreateCallResponse.cs" company="APIMatic">
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
    /// CreateCallResponse.
    /// </summary>
    public class CreateCallResponse
    {
        private string answerFallbackUrl;
        private Models.AnswerFallbackMethodEnum? answerFallbackMethod;
        private string disconnectUrl;
        private string username;
        private string password;
        private string fallbackUsername;
        private string fallbackPassword;
        private string tag;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "answerFallbackUrl", false },
            { "answerFallbackMethod", false },
            { "disconnectUrl", false },
            { "username", false },
            { "password", false },
            { "fallbackUsername", false },
            { "fallbackPassword", false },
            { "tag", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCallResponse"/> class.
        /// </summary>
        public CreateCallResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCallResponse"/> class.
        /// </summary>
        /// <param name="accountId">accountId.</param>
        /// <param name="callId">callId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="to">to.</param>
        /// <param name="from">from.</param>
        /// <param name="callUrl">callUrl.</param>
        /// <param name="answerUrl">answerUrl.</param>
        /// <param name="answerMethod">answerMethod.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="callTimeout">callTimeout.</param>
        /// <param name="callbackTimeout">callbackTimeout.</param>
        /// <param name="answerFallbackUrl">answerFallbackUrl.</param>
        /// <param name="answerFallbackMethod">answerFallbackMethod.</param>
        /// <param name="disconnectUrl">disconnectUrl.</param>
        /// <param name="disconnectMethod">disconnectMethod.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="fallbackUsername">fallbackUsername.</param>
        /// <param name="fallbackPassword">fallbackPassword.</param>
        /// <param name="tag">tag.</param>
        public CreateCallResponse(
            string accountId,
            string callId,
            string applicationId,
            string to,
            string from,
            string callUrl,
            string answerUrl,
            Models.AnswerMethodEnum answerMethod,
            DateTime? startTime = null,
            double? callTimeout = null,
            double? callbackTimeout = null,
            string answerFallbackUrl = null,
            Models.AnswerFallbackMethodEnum? answerFallbackMethod = null,
            string disconnectUrl = null,
            Models.DisconnectMethodEnum? disconnectMethod = null,
            string username = null,
            string password = null,
            string fallbackUsername = null,
            string fallbackPassword = null,
            string tag = null)
        {
            this.AccountId = accountId;
            this.CallId = callId;
            this.ApplicationId = applicationId;
            this.To = to;
            this.From = from;
            this.StartTime = startTime;
            this.CallUrl = callUrl;
            this.CallTimeout = callTimeout;
            this.CallbackTimeout = callbackTimeout;
            this.AnswerUrl = answerUrl;
            this.AnswerMethod = answerMethod;
            if (answerFallbackUrl != null)
            {
                this.AnswerFallbackUrl = answerFallbackUrl;
            }

            if (answerFallbackMethod != null)
            {
                this.AnswerFallbackMethod = answerFallbackMethod;
            }

            if (disconnectUrl != null)
            {
                this.DisconnectUrl = disconnectUrl;
            }

            this.DisconnectMethod = disconnectMethod;
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

            if (tag != null)
            {
                this.Tag = tag;
            }

        }

        /// <summary>
        /// Gets or sets AccountId.
        /// </summary>
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets CallId.
        /// </summary>
        [JsonProperty("callId")]
        public string CallId { get; set; }

        /// <summary>
        /// Gets or sets ApplicationId.
        /// </summary>
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets To.
        /// </summary>
        [JsonProperty("to")]
        public string To { get; set; }

        /// <summary>
        /// Gets or sets From.
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }

        /// <summary>
        /// Gets or sets StartTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets CallUrl.
        /// </summary>
        [JsonProperty("callUrl")]
        public string CallUrl { get; set; }

        /// <summary>
        /// Gets or sets CallTimeout.
        /// </summary>
        [JsonProperty("callTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public double? CallTimeout { get; set; }

        /// <summary>
        /// Gets or sets CallbackTimeout.
        /// </summary>
        [JsonProperty("callbackTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public double? CallbackTimeout { get; set; }

        /// <summary>
        /// Gets or sets AnswerUrl.
        /// </summary>
        [JsonProperty("answerUrl")]
        public string AnswerUrl { get; set; }

        /// <summary>
        /// Gets or sets AnswerMethod.
        /// </summary>
        [JsonProperty("answerMethod", ItemConverterType = typeof(StringEnumConverter))]
        public Models.AnswerMethodEnum AnswerMethod { get; set; }

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
        [JsonProperty("disconnectMethod", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Include)]
        public Models.DisconnectMethodEnum? DisconnectMethod { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateCallResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetTag()
        {
            this.shouldSerialize["tag"] = false;
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

            return obj is CreateCallResponse other &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.CallId == null && other.CallId == null) || (this.CallId?.Equals(other.CallId) == true)) &&
                ((this.ApplicationId == null && other.ApplicationId == null) || (this.ApplicationId?.Equals(other.ApplicationId) == true)) &&
                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true)) &&
                ((this.StartTime == null && other.StartTime == null) || (this.StartTime?.Equals(other.StartTime) == true)) &&
                ((this.CallUrl == null && other.CallUrl == null) || (this.CallUrl?.Equals(other.CallUrl) == true)) &&
                ((this.CallTimeout == null && other.CallTimeout == null) || (this.CallTimeout?.Equals(other.CallTimeout) == true)) &&
                ((this.CallbackTimeout == null && other.CallbackTimeout == null) || (this.CallbackTimeout?.Equals(other.CallbackTimeout) == true)) &&
                ((this.AnswerUrl == null && other.AnswerUrl == null) || (this.AnswerUrl?.Equals(other.AnswerUrl) == true)) &&
                this.AnswerMethod.Equals(other.AnswerMethod) &&
                ((this.AnswerFallbackUrl == null && other.AnswerFallbackUrl == null) || (this.AnswerFallbackUrl?.Equals(other.AnswerFallbackUrl) == true)) &&
                ((this.AnswerFallbackMethod == null && other.AnswerFallbackMethod == null) || (this.AnswerFallbackMethod?.Equals(other.AnswerFallbackMethod) == true)) &&
                ((this.DisconnectUrl == null && other.DisconnectUrl == null) || (this.DisconnectUrl?.Equals(other.DisconnectUrl) == true)) &&
                ((this.DisconnectMethod == null && other.DisconnectMethod == null) || (this.DisconnectMethod?.Equals(other.DisconnectMethod) == true)) &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true)) &&
                ((this.FallbackUsername == null && other.FallbackUsername == null) || (this.FallbackUsername?.Equals(other.FallbackUsername) == true)) &&
                ((this.FallbackPassword == null && other.FallbackPassword == null) || (this.FallbackPassword?.Equals(other.FallbackPassword) == true)) &&
                ((this.Tag == null && other.Tag == null) || (this.Tag?.Equals(other.Tag) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1815895087;

            if (this.AccountId != null)
            {
               hashCode += this.AccountId.GetHashCode();
            }

            if (this.CallId != null)
            {
               hashCode += this.CallId.GetHashCode();
            }

            if (this.ApplicationId != null)
            {
               hashCode += this.ApplicationId.GetHashCode();
            }

            if (this.To != null)
            {
               hashCode += this.To.GetHashCode();
            }

            if (this.From != null)
            {
               hashCode += this.From.GetHashCode();
            }

            if (this.StartTime != null)
            {
               hashCode += this.StartTime.GetHashCode();
            }

            if (this.CallUrl != null)
            {
               hashCode += this.CallUrl.GetHashCode();
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

            hashCode += this.AnswerMethod.GetHashCode();

            if (this.AnswerFallbackUrl != null)
            {
               hashCode += this.AnswerFallbackUrl.GetHashCode();
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

            if (this.Tag != null)
            {
               hashCode += this.Tag.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId == string.Empty ? "" : this.AccountId)}");
            toStringOutput.Add($"this.CallId = {(this.CallId == null ? "null" : this.CallId == string.Empty ? "" : this.CallId)}");
            toStringOutput.Add($"this.ApplicationId = {(this.ApplicationId == null ? "null" : this.ApplicationId == string.Empty ? "" : this.ApplicationId)}");
            toStringOutput.Add($"this.To = {(this.To == null ? "null" : this.To == string.Empty ? "" : this.To)}");
            toStringOutput.Add($"this.From = {(this.From == null ? "null" : this.From == string.Empty ? "" : this.From)}");
            toStringOutput.Add($"this.StartTime = {(this.StartTime == null ? "null" : this.StartTime.ToString())}");
            toStringOutput.Add($"this.CallUrl = {(this.CallUrl == null ? "null" : this.CallUrl == string.Empty ? "" : this.CallUrl)}");
            toStringOutput.Add($"this.CallTimeout = {(this.CallTimeout == null ? "null" : this.CallTimeout.ToString())}");
            toStringOutput.Add($"this.CallbackTimeout = {(this.CallbackTimeout == null ? "null" : this.CallbackTimeout.ToString())}");
            toStringOutput.Add($"this.AnswerUrl = {(this.AnswerUrl == null ? "null" : this.AnswerUrl == string.Empty ? "" : this.AnswerUrl)}");
            toStringOutput.Add($"this.AnswerMethod = {this.AnswerMethod}");
            toStringOutput.Add($"this.AnswerFallbackUrl = {(this.AnswerFallbackUrl == null ? "null" : this.AnswerFallbackUrl == string.Empty ? "" : this.AnswerFallbackUrl)}");
            toStringOutput.Add($"this.AnswerFallbackMethod = {(this.AnswerFallbackMethod == null ? "null" : this.AnswerFallbackMethod.ToString())}");
            toStringOutput.Add($"this.DisconnectUrl = {(this.DisconnectUrl == null ? "null" : this.DisconnectUrl == string.Empty ? "" : this.DisconnectUrl)}");
            toStringOutput.Add($"this.DisconnectMethod = {(this.DisconnectMethod == null ? "null" : this.DisconnectMethod.ToString())}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username == string.Empty ? "" : this.Username)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password == string.Empty ? "" : this.Password)}");
            toStringOutput.Add($"this.FallbackUsername = {(this.FallbackUsername == null ? "null" : this.FallbackUsername == string.Empty ? "" : this.FallbackUsername)}");
            toStringOutput.Add($"this.FallbackPassword = {(this.FallbackPassword == null ? "null" : this.FallbackPassword == string.Empty ? "" : this.FallbackPassword)}");
            toStringOutput.Add($"this.Tag = {(this.Tag == null ? "null" : this.Tag == string.Empty ? "" : this.Tag)}");
        }
    }
}