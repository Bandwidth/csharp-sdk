// <copyright file="TwoFactorVerifyCodeResponse.cs" company="APIMatic">
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
    /// TwoFactorVerifyCodeResponse.
    /// </summary>
    public class TwoFactorVerifyCodeResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorVerifyCodeResponse"/> class.
        /// </summary>
        public TwoFactorVerifyCodeResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorVerifyCodeResponse"/> class.
        /// </summary>
        /// <param name="valid">valid.</param>
        public TwoFactorVerifyCodeResponse(
            bool? valid = null)
        {
            this.Valid = valid;
        }

        /// <summary>
        /// Gets or sets Valid.
        /// </summary>
        [JsonProperty("valid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Valid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TwoFactorVerifyCodeResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is TwoFactorVerifyCodeResponse other &&
                ((this.Valid == null && other.Valid == null) || (this.Valid?.Equals(other.Valid) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1979617985;

            if (this.Valid != null)
            {
               hashCode += this.Valid.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Valid = {(this.Valid == null ? "null" : this.Valid.ToString())}");
        }
    }
}