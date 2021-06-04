// <copyright file="AccountsTnlookupResponse1.cs" company="APIMatic">
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
    /// AccountsTnlookupResponse1.
    /// </summary>
    public class AccountsTnlookupResponse1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsTnlookupResponse1"/> class.
        /// </summary>
        public AccountsTnlookupResponse1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsTnlookupResponse1"/> class.
        /// </summary>
        /// <param name="requestId">requestId.</param>
        /// <param name="status">status.</param>
        /// <param name="failedTelephoneNumbers">failedTelephoneNumbers.</param>
        /// <param name="result">result.</param>
        public AccountsTnlookupResponse1(
            string requestId = null,
            string status = null,
            List<string> failedTelephoneNumbers = null,
            List<Models.Result> result = null)
        {
            this.RequestId = requestId;
            this.Status = status;
            this.FailedTelephoneNumbers = failedTelephoneNumbers;
            this.Result = result;
        }

        /// <summary>
        /// The requestId.
        /// </summary>
        [JsonProperty("requestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the request (IN_PROGRESS, COMPLETE, PARTIAL_COMPLETE, or FAILED).
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// The telephone numbers whose lookup failed
        /// </summary>
        [JsonProperty("failedTelephoneNumbers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FailedTelephoneNumbers { get; set; }

        /// <summary>
        /// The carrier information results for the specified telephone number.
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Result> Result { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountsTnlookupResponse1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is AccountsTnlookupResponse1 other &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.FailedTelephoneNumbers == null && other.FailedTelephoneNumbers == null) || (this.FailedTelephoneNumbers?.Equals(other.FailedTelephoneNumbers) == true)) &&
                ((this.Result == null && other.Result == null) || (this.Result?.Equals(other.Result) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 961778214;

            if (this.RequestId != null)
            {
               hashCode += this.RequestId.GetHashCode();
            }

            if (this.Status != null)
            {
               hashCode += this.Status.GetHashCode();
            }

            if (this.FailedTelephoneNumbers != null)
            {
               hashCode += this.FailedTelephoneNumbers.GetHashCode();
            }

            if (this.Result != null)
            {
               hashCode += this.Result.GetHashCode();
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
            toStringOutput.Add($"this.FailedTelephoneNumbers = {(this.FailedTelephoneNumbers == null ? "null" : $"[{string.Join(", ", this.FailedTelephoneNumbers)} ]")}");
            toStringOutput.Add($"this.Result = {(this.Result == null ? "null" : $"[{string.Join(", ", this.Result)} ]")}");
        }
    }
}