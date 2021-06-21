// <copyright file="AccountsTnlookupResponse.cs" company="APIMatic">
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
    /// AccountsTnlookupResponse.
    /// </summary>
    public class AccountsTnlookupResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsTnlookupResponse"/> class.
        /// </summary>
        public AccountsTnlookupResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsTnlookupResponse"/> class.
        /// </summary>
        /// <param name="requestId">requestId.</param>
        /// <param name="status">status.</param>
        public AccountsTnlookupResponse(
            string requestId = null,
            string status = null)
        {
            this.RequestId = requestId;
            this.Status = status;
        }

        /// <summary>
        /// The requestId.
        /// </summary>
        [JsonProperty("requestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the request.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountsTnlookupResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is AccountsTnlookupResponse other &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 268549923;

            if (this.RequestId != null)
            {
               hashCode += this.RequestId.GetHashCode();
            }

            if (this.Status != null)
            {
               hashCode += this.Status.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId == string.Empty ? "" : this.RequestId)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
        }
    }
}