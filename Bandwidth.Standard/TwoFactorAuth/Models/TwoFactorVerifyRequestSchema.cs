// <copyright file="TwoFactorVerifyRequestSchema.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.TwoFactorAuth.Models
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
    /// TwoFactorVerifyRequestSchema.
    /// </summary>
    public class TwoFactorVerifyRequestSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorVerifyRequestSchema"/> class.
        /// </summary>
        public TwoFactorVerifyRequestSchema()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorVerifyRequestSchema"/> class.
        /// </summary>
        /// <param name="to">to.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="expirationTimeInMinutes">expirationTimeInMinutes.</param>
        /// <param name="code">code.</param>
        /// <param name="scope">scope.</param>
        public TwoFactorVerifyRequestSchema(
            string to,
            string applicationId,
            double expirationTimeInMinutes,
            string code,
            string scope = null)
        {
            this.To = to;
            this.ApplicationId = applicationId;
            this.Scope = scope;
            this.ExpirationTimeInMinutes = expirationTimeInMinutes;
            this.Code = code;
        }

        /// <summary>
        /// The phone number to send the 2fa code to.
        /// </summary>
        [JsonProperty("to")]
        public string To { get; set; }

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
        /// The time period, in minutes, to validate the 2fa code.  By setting this to 3 minutes, it will mean any code generated within the last 3 minutes are still valid.  The valid range for expiration time is between 0 and 15 minutes, exclusively and inclusively, respectively.
        /// </summary>
        [JsonProperty("expirationTimeInMinutes")]
        public double ExpirationTimeInMinutes { get; set; }

        /// <summary>
        /// The generated 2fa code to check if valid
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TwoFactorVerifyRequestSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is TwoFactorVerifyRequestSchema other &&
                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.ApplicationId == null && other.ApplicationId == null) || (this.ApplicationId?.Equals(other.ApplicationId) == true)) &&
                ((this.Scope == null && other.Scope == null) || (this.Scope?.Equals(other.Scope) == true)) &&
                this.ExpirationTimeInMinutes.Equals(other.ExpirationTimeInMinutes) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -2106512680;

            if (this.To != null)
            {
               hashCode += this.To.GetHashCode();
            }

            if (this.ApplicationId != null)
            {
               hashCode += this.ApplicationId.GetHashCode();
            }

            if (this.Scope != null)
            {
               hashCode += this.Scope.GetHashCode();
            }

            hashCode += this.ExpirationTimeInMinutes.GetHashCode();

            if (this.Code != null)
            {
               hashCode += this.Code.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.To = {(this.To == null ? "null" : this.To == string.Empty ? "" : this.To)}");
            toStringOutput.Add($"this.ApplicationId = {(this.ApplicationId == null ? "null" : this.ApplicationId == string.Empty ? "" : this.ApplicationId)}");
            toStringOutput.Add($"this.Scope = {(this.Scope == null ? "null" : this.Scope == string.Empty ? "" : this.Scope)}");
            toStringOutput.Add($"this.ExpirationTimeInMinutes = {this.ExpirationTimeInMinutes}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
        }
    }
}