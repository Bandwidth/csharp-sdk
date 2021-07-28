// <copyright file="TwoFactorCodeRequestSchema.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.MultiFactorAuth.Models
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
    /// TwoFactorCodeRequestSchema.
    /// </summary>
    public class TwoFactorCodeRequestSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorCodeRequestSchema"/> class.
        /// </summary>
        public TwoFactorCodeRequestSchema()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorCodeRequestSchema"/> class.
        /// </summary>
        /// <param name="to">to.</param>
        /// <param name="from">from.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="message">message.</param>
        /// <param name="digits">digits.</param>
        /// <param name="scope">scope.</param>
        public TwoFactorCodeRequestSchema(
            string to,
            string from,
            string applicationId,
            string message,
            double digits,
            string scope = null)
        {
            this.To = to;
            this.From = from;
            this.ApplicationId = applicationId;
            this.Scope = scope;
            this.Message = message;
            this.Digits = digits;
        }

        /// <summary>
        /// The phone number to send the 2fa code to.
        /// </summary>
        [JsonProperty("to")]
        public string To { get; set; }

        /// <summary>
        /// The application phone number, the sender of the 2fa code.
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }

        /// <summary>
        /// The application unique ID, obtained from Bandwidth.
        /// </summary>
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// An optional field to denote what scope or action the 2fa code is addressing.  If not supplied, defaults to "2FA".
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <summary>
        /// The message format of the 2fa code.  There are three values that the system will replace "{CODE}", "{NAME}", "{SCOPE}".  The "{SCOPE}" and "{NAME} value template are optional, while "{CODE}" must be supplied.  As the name would suggest, code will be replace with the actual 2fa code.  Name is replaced with the application name, configured during provisioning of 2fa.  The scope value is the same value sent during the call and partitioned by the server.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// The number of digits for your 2fa code.  The valid number ranges from 2 to 8, inclusively.
        /// </summary>
        [JsonProperty("digits")]
        public double Digits { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TwoFactorCodeRequestSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is TwoFactorCodeRequestSchema other &&
                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true)) &&
                ((this.ApplicationId == null && other.ApplicationId == null) || (this.ApplicationId?.Equals(other.ApplicationId) == true)) &&
                ((this.Scope == null && other.Scope == null) || (this.Scope?.Equals(other.Scope) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                this.Digits.Equals(other.Digits);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1960364933;

            if (this.To != null)
            {
               hashCode += this.To.GetHashCode();
            }

            if (this.From != null)
            {
               hashCode += this.From.GetHashCode();
            }

            if (this.ApplicationId != null)
            {
               hashCode += this.ApplicationId.GetHashCode();
            }

            if (this.Scope != null)
            {
               hashCode += this.Scope.GetHashCode();
            }

            if (this.Message != null)
            {
               hashCode += this.Message.GetHashCode();
            }

            hashCode += this.Digits.GetHashCode();

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.To = {(this.To == null ? "null" : this.To == string.Empty ? "" : this.To)}");
            toStringOutput.Add($"this.From = {(this.From == null ? "null" : this.From == string.Empty ? "" : this.From)}");
            toStringOutput.Add($"this.ApplicationId = {(this.ApplicationId == null ? "null" : this.ApplicationId == string.Empty ? "" : this.ApplicationId)}");
            toStringOutput.Add($"this.Scope = {(this.Scope == null ? "null" : this.Scope == string.Empty ? "" : this.Scope)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message == string.Empty ? "" : this.Message)}");
            toStringOutput.Add($"this.Digits = {this.Digits}");
        }
    }
}