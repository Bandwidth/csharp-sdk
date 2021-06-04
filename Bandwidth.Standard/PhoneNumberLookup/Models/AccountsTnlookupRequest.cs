// <copyright file="AccountsTnlookupRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.PhoneNumberLookup.Models
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
    /// AccountsTnlookupRequest.
    /// </summary>
    public class AccountsTnlookupRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsTnlookupRequest"/> class.
        /// </summary>
        public AccountsTnlookupRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsTnlookupRequest"/> class.
        /// </summary>
        /// <param name="tns">tns.</param>
        public AccountsTnlookupRequest(
            List<string> tns = null)
        {
            this.Tns = tns;
        }

        /// <summary>
        /// Gets or sets Tns.
        /// </summary>
        [JsonProperty("tns", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tns { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountsTnlookupRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is AccountsTnlookupRequest other &&
                ((this.Tns == null && other.Tns == null) || (this.Tns?.Equals(other.Tns) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 251590775;

            if (this.Tns != null)
            {
               hashCode += this.Tns.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Tns = {(this.Tns == null ? "null" : $"[{string.Join(", ", this.Tns)} ]")}");
        }
    }
}