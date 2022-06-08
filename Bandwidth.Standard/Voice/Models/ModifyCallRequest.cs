// <copyright file="ModifyCallRequest.cs" company="APIMatic">
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
    /// ModifyCallRequest.
    /// </summary>
    public class ModifyCallRequest
    {
        private Models.StateEnum? state;
        private string redirectUrl;
        private string redirectFallbackUrl;
        private Models.RedirectMethodEnum? redirectMethod;
        private Models.RedirectFallbackMethodEnum? redirectFallbackMethod;
        private string username;
        private string password;
        private string fallbackUsername;
        private string fallbackPassword;
        private string tag;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "state", true },
            { "redirectUrl", false },
            { "redirectFallbackUrl", false },
            { "redirectMethod", false },
            { "redirectFallbackMethod", false },
            { "username", false },
            { "password", false },
            { "fallbackUsername", false },
            { "fallbackPassword", false },
            { "tag", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyCallRequest"/> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="redirectUrl">redirectUrl.</param>
        /// <param name="redirectFallbackUrl">redirectFallbackUrl.</param>
        /// <param name="redirectMethod">redirectMethod.</param>
        /// <param name="redirectFallbackMethod">redirectFallbackMethod.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="fallbackUsername">fallbackUsername.</param>
        /// <param name="fallbackPassword">fallbackPassword.</param>
        /// <param name="tag">tag.</param>
        public ModifyCallRequest(
            Models.StateEnum? state = Models.StateEnum.Active,
            string redirectUrl = null,
            string redirectFallbackUrl = null,
            Models.RedirectMethodEnum? redirectMethod = null,
            Models.RedirectFallbackMethodEnum? redirectFallbackMethod = null,
            string username = null,
            string password = null,
            string fallbackUsername = null,
            string fallbackPassword = null,
            string tag = null)
        {
            this.State = state;
            if (redirectUrl != null)
            {
                this.RedirectUrl = redirectUrl;
            }

            if (redirectFallbackUrl != null)
            {
                this.RedirectFallbackUrl = redirectFallbackUrl;
            }

            if (redirectMethod != null)
            {
                this.RedirectMethod = redirectMethod;
            }

            if (redirectFallbackMethod != null)
            {
                this.RedirectFallbackMethod = redirectFallbackMethod;
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

            if (tag != null)
            {
                this.Tag = tag;
            }

        }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state", ItemConverterType = typeof(StringEnumConverter))]
        public Models.StateEnum? State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.shouldSerialize["state"] = true;
                this.state = value;
            }
        }

        /// <summary>
        /// Required if state is 'active'
        /// </summary>
        [JsonProperty("redirectUrl")]
        public string RedirectUrl
        {
            get
            {
                return this.redirectUrl;
            }

            set
            {
                this.shouldSerialize["redirectUrl"] = true;
                this.redirectUrl = value;
            }
        }

        /// <summary>
        /// Gets or sets RedirectFallbackUrl.
        /// </summary>
        [JsonProperty("redirectFallbackUrl")]
        public string RedirectFallbackUrl
        {
            get
            {
                return this.redirectFallbackUrl;
            }

            set
            {
                this.shouldSerialize["redirectFallbackUrl"] = true;
                this.redirectFallbackUrl = value;
            }
        }

        /// <summary>
        /// Gets or sets RedirectMethod.
        /// </summary>
        [JsonProperty("redirectMethod", ItemConverterType = typeof(StringEnumConverter))]
        public Models.RedirectMethodEnum? RedirectMethod
        {
            get
            {
                return this.redirectMethod;
            }

            set
            {
                this.shouldSerialize["redirectMethod"] = true;
                this.redirectMethod = value;
            }
        }

        /// <summary>
        /// Gets or sets RedirectFallbackMethod.
        /// </summary>
        [JsonProperty("redirectFallbackMethod", ItemConverterType = typeof(StringEnumConverter))]
        public Models.RedirectFallbackMethodEnum? RedirectFallbackMethod
        {
            get
            {
                return this.redirectFallbackMethod;
            }

            set
            {
                this.shouldSerialize["redirectFallbackMethod"] = true;
                this.redirectFallbackMethod = value;
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

            return $"ModifyCallRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetState()
        {
            this.shouldSerialize["state"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRedirectUrl()
        {
            this.shouldSerialize["redirectUrl"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRedirectFallbackUrl()
        {
            this.shouldSerialize["redirectFallbackUrl"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRedirectMethod()
        {
            this.shouldSerialize["redirectMethod"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRedirectFallbackMethod()
        {
            this.shouldSerialize["redirectFallbackMethod"] = false;
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
        public bool ShouldSerializeState()
        {
            return this.shouldSerialize["state"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRedirectUrl()
        {
            return this.shouldSerialize["redirectUrl"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRedirectFallbackUrl()
        {
            return this.shouldSerialize["redirectFallbackUrl"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRedirectMethod()
        {
            return this.shouldSerialize["redirectMethod"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRedirectFallbackMethod()
        {
            return this.shouldSerialize["redirectFallbackMethod"];
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

            return obj is ModifyCallRequest other &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.RedirectUrl == null && other.RedirectUrl == null) || (this.RedirectUrl?.Equals(other.RedirectUrl) == true)) &&
                ((this.RedirectFallbackUrl == null && other.RedirectFallbackUrl == null) || (this.RedirectFallbackUrl?.Equals(other.RedirectFallbackUrl) == true)) &&
                ((this.RedirectMethod == null && other.RedirectMethod == null) || (this.RedirectMethod?.Equals(other.RedirectMethod) == true)) &&
                ((this.RedirectFallbackMethod == null && other.RedirectFallbackMethod == null) || (this.RedirectFallbackMethod?.Equals(other.RedirectFallbackMethod) == true)) &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true)) &&
                ((this.FallbackUsername == null && other.FallbackUsername == null) || (this.FallbackUsername?.Equals(other.FallbackUsername) == true)) &&
                ((this.FallbackPassword == null && other.FallbackPassword == null) || (this.FallbackPassword?.Equals(other.FallbackPassword) == true)) &&
                ((this.Tag == null && other.Tag == null) || (this.Tag?.Equals(other.Tag) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1744209208;

            if (this.State != null)
            {
               hashCode += this.State.GetHashCode();
            }

            if (this.RedirectUrl != null)
            {
               hashCode += this.RedirectUrl.GetHashCode();
            }

            if (this.RedirectFallbackUrl != null)
            {
               hashCode += this.RedirectFallbackUrl.GetHashCode();
            }

            if (this.RedirectMethod != null)
            {
               hashCode += this.RedirectMethod.GetHashCode();
            }

            if (this.RedirectFallbackMethod != null)
            {
               hashCode += this.RedirectFallbackMethod.GetHashCode();
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
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.RedirectUrl = {(this.RedirectUrl == null ? "null" : this.RedirectUrl == string.Empty ? "" : this.RedirectUrl)}");
            toStringOutput.Add($"this.RedirectFallbackUrl = {(this.RedirectFallbackUrl == null ? "null" : this.RedirectFallbackUrl == string.Empty ? "" : this.RedirectFallbackUrl)}");
            toStringOutput.Add($"this.RedirectMethod = {(this.RedirectMethod == null ? "null" : this.RedirectMethod.ToString())}");
            toStringOutput.Add($"this.RedirectFallbackMethod = {(this.RedirectFallbackMethod == null ? "null" : this.RedirectFallbackMethod.ToString())}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username == string.Empty ? "" : this.Username)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password == string.Empty ? "" : this.Password)}");
            toStringOutput.Add($"this.FallbackUsername = {(this.FallbackUsername == null ? "null" : this.FallbackUsername == string.Empty ? "" : this.FallbackUsername)}");
            toStringOutput.Add($"this.FallbackPassword = {(this.FallbackPassword == null ? "null" : this.FallbackPassword == string.Empty ? "" : this.FallbackPassword)}");
            toStringOutput.Add($"this.Tag = {(this.Tag == null ? "null" : this.Tag == string.Empty ? "" : this.Tag)}");
        }
    }
}