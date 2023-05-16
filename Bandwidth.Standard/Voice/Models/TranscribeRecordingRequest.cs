// <copyright file="TranscribeRecordingRequest.cs" company="APIMatic">
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
    /// TranscribeRecordingRequest.
    /// </summary>
    public class TranscribeRecordingRequest
    {
        private bool? detectLanguage;
        private Models.CallbackMethodEnum? callbackMethod;
        private string username;
        private string password;
        private string tag;
        private double? callbackTimeout;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "detectLanguage", false },
            { "callbackMethod", false },
            { "username", false },
            { "password", false },
            { "tag", false },
            { "callbackTimeout", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscribeRecordingRequest"/> class.
        /// </summary>
        public TranscribeRecordingRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscribeRecordingRequest"/> class.
        /// </summary>
        /// <param name="detectLanguage">detectLanguage.</param>
        /// <param name="callbackUrl">callbackUrl.</param>
        /// <param name="callbackMethod">callbackMethod.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="tag">tag.</param>
        /// <param name="callbackTimeout">callbackTimeout.</param>
        public TranscribeRecordingRequest(
            bool? detectLanguage = null,
            string callbackUrl = null,
            Models.CallbackMethodEnum? callbackMethod = null,
            string username = null,
            string password = null,
            string tag = null,
            double? callbackTimeout = null)
        {

            this.CallbackUrl = callbackUrl;

            if (detectLanguage != null)
            {
                this.DetectLanguage = detectLanguage;
            }

            if (callbackMethod != null)
            {
                this.CallbackMethod = callbackMethod;
            }

            if (username != null)
            {
                this.Username = username;
            }

            if (password != null)
            {
                this.Password = password;
            }

            if (tag != null)
            {
                this.Tag = tag;
            }

            if (callbackTimeout != null)
            {
                this.CallbackTimeout = callbackTimeout;
            }

        }

        /// <summary>
        /// Gets or sets CallbackUrl.
        /// </summary>
        [JsonProperty("callbackUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Gets or sets DetectLanguage
        /// </summary>
        [JsonProperty("detectLanguage")]
        public bool? DetectLanguage {
            get
            {
                return this.detectLanguage;
            }
            set
            {
                this.shouldSerialize["detectLanguage"] = true;
                this.detectLanguage = value;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TranscribeRecordingRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDetectLanguage()
        {
            this.shouldSerialize["detectLanguage"] = false;
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
        public void UnsetTag()
        {
            this.shouldSerialize["tag"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCallbackTimeout()
        {
            this.shouldSerialize["callbackTimeout"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDetectLanguage()
        {
            return this.shouldSerialize["detectLanguage"];
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
        public bool ShouldSerializeTag()
        {
            return this.shouldSerialize["tag"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCallbackTimeout()
        {
            return this.shouldSerialize["callbackTimeout"];
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

            return obj is TranscribeRecordingRequest other &&
                ((this.DetectLanguage == null && other.DetectLanguage == null) || (this.DetectLanguage?.Equals(other.DetectLanguage) == true)) &&
                ((this.CallbackUrl == null && other.CallbackUrl == null) || (this.CallbackUrl?.Equals(other.CallbackUrl) == true)) &&
                ((this.CallbackMethod == null && other.CallbackMethod == null) || (this.CallbackMethod?.Equals(other.CallbackMethod) == true)) &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true)) &&
                ((this.Tag == null && other.Tag == null) || (this.Tag?.Equals(other.Tag) == true)) &&
                ((this.CallbackTimeout == null && other.CallbackTimeout == null) || (this.CallbackTimeout?.Equals(other.CallbackTimeout) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -2127634834;

            if(this.detectLanguage != null)
            {
               hashCode += this.detectLanguage.GetHashCode();
            }

            if (this.CallbackUrl != null)
            {
               hashCode += this.CallbackUrl.GetHashCode();
            }

            if (this.CallbackMethod != null)
            {
               hashCode += this.CallbackMethod.GetHashCode();
            }

            if (this.Username != null)
            {
               hashCode += this.Username.GetHashCode();
            }

            if (this.Password != null)
            {
               hashCode += this.Password.GetHashCode();
            }

            if (this.Tag != null)
            {
               hashCode += this.Tag.GetHashCode();
            }

            if (this.CallbackTimeout != null)
            {
               hashCode += this.CallbackTimeout.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DetectLanguage = {(this.DetectLanguage == null ? "null" : this.DetectLanguage.ToString())}");
            toStringOutput.Add($"this.CallbackUrl = {(this.CallbackUrl == null ? "null" : this.CallbackUrl == string.Empty ? "" : this.CallbackUrl)}");
            toStringOutput.Add($"this.CallbackMethod = {(this.CallbackMethod == null ? "null" : this.CallbackMethod.ToString())}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username == string.Empty ? "" : this.Username)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password == string.Empty ? "" : this.Password)}");
            toStringOutput.Add($"this.Tag = {(this.Tag == null ? "null" : this.Tag == string.Empty ? "" : this.Tag)}");
            toStringOutput.Add($"this.CallbackTimeout = {(this.CallbackTimeout == null ? "null" : this.CallbackTimeout.ToString())}");
        }
    }
}
