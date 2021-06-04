// <copyright file="Result.cs" company="APIMatic">
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
    /// Result.
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Result"/> class.
        /// </summary>
        public Result()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Result"/> class.
        /// </summary>
        /// <param name="responseCode">Response Code.</param>
        /// <param name="message">Message.</param>
        /// <param name="e164Format">E.164 Format.</param>
        /// <param name="formatted">Formatted.</param>
        /// <param name="country">Country.</param>
        /// <param name="lineType">Line Type.</param>
        /// <param name="lineProvider">Line Provider.</param>
        /// <param name="mobileCountryCode">Mobile Country Code.</param>
        /// <param name="mobileNetworkCode">Mobile Network Code.</param>
        public Result(
            int? responseCode = null,
            string message = null,
            string e164Format = null,
            string formatted = null,
            string country = null,
            string lineType = null,
            string lineProvider = null,
            string mobileCountryCode = null,
            string mobileNetworkCode = null)
        {
            this.ResponseCode = responseCode;
            this.Message = message;
            this.E164Format = e164Format;
            this.Formatted = formatted;
            this.Country = country;
            this.LineType = lineType;
            this.LineProvider = lineProvider;
            this.MobileCountryCode = mobileCountryCode;
            this.MobileNetworkCode = mobileNetworkCode;
        }

        /// <summary>
        /// Our vendor's response code.
        /// </summary>
        [JsonProperty("Response Code", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Message associated with the response code.
        /// </summary>
        [JsonProperty("Message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// The telephone number in E.164 format.
        /// </summary>
        [JsonProperty("E.164 Format", NullValueHandling = NullValueHandling.Ignore)]
        public string E164Format { get; set; }

        /// <summary>
        /// The formatted version of the telephone number.
        /// </summary>
        [JsonProperty("Formatted", NullValueHandling = NullValueHandling.Ignore)]
        public string Formatted { get; set; }

        /// <summary>
        /// The country of the telephone number.
        /// </summary>
        [JsonProperty("Country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// The line type of the telephone number.
        /// </summary>
        [JsonProperty("Line Type", NullValueHandling = NullValueHandling.Ignore)]
        public string LineType { get; set; }

        /// <summary>
        /// The service provider of the telephone number.
        /// </summary>
        [JsonProperty("Line Provider", NullValueHandling = NullValueHandling.Ignore)]
        public string LineProvider { get; set; }

        /// <summary>
        /// The first half of the Home Network Identity (HNI).
        /// </summary>
        [JsonProperty("Mobile Country Code", NullValueHandling = NullValueHandling.Ignore)]
        public string MobileCountryCode { get; set; }

        /// <summary>
        /// The second half of the HNI.
        /// </summary>
        [JsonProperty("Mobile Network Code", NullValueHandling = NullValueHandling.Ignore)]
        public string MobileNetworkCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Result : ({string.Join(", ", toStringOutput)})";
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

            return obj is Result other &&
                ((this.ResponseCode == null && other.ResponseCode == null) || (this.ResponseCode?.Equals(other.ResponseCode) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.E164Format == null && other.E164Format == null) || (this.E164Format?.Equals(other.E164Format) == true)) &&
                ((this.Formatted == null && other.Formatted == null) || (this.Formatted?.Equals(other.Formatted) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.LineType == null && other.LineType == null) || (this.LineType?.Equals(other.LineType) == true)) &&
                ((this.LineProvider == null && other.LineProvider == null) || (this.LineProvider?.Equals(other.LineProvider) == true)) &&
                ((this.MobileCountryCode == null && other.MobileCountryCode == null) || (this.MobileCountryCode?.Equals(other.MobileCountryCode) == true)) &&
                ((this.MobileNetworkCode == null && other.MobileNetworkCode == null) || (this.MobileNetworkCode?.Equals(other.MobileNetworkCode) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1345119612;

            if (this.ResponseCode != null)
            {
               hashCode += this.ResponseCode.GetHashCode();
            }

            if (this.Message != null)
            {
               hashCode += this.Message.GetHashCode();
            }

            if (this.E164Format != null)
            {
               hashCode += this.E164Format.GetHashCode();
            }

            if (this.Formatted != null)
            {
               hashCode += this.Formatted.GetHashCode();
            }

            if (this.Country != null)
            {
               hashCode += this.Country.GetHashCode();
            }

            if (this.LineType != null)
            {
               hashCode += this.LineType.GetHashCode();
            }

            if (this.LineProvider != null)
            {
               hashCode += this.LineProvider.GetHashCode();
            }

            if (this.MobileCountryCode != null)
            {
               hashCode += this.MobileCountryCode.GetHashCode();
            }

            if (this.MobileNetworkCode != null)
            {
               hashCode += this.MobileNetworkCode.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ResponseCode = {(this.ResponseCode == null ? "null" : this.ResponseCode.ToString())}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message == string.Empty ? "" : this.Message)}");
            toStringOutput.Add($"this.E164Format = {(this.E164Format == null ? "null" : this.E164Format == string.Empty ? "" : this.E164Format)}");
            toStringOutput.Add($"this.Formatted = {(this.Formatted == null ? "null" : this.Formatted == string.Empty ? "" : this.Formatted)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country == string.Empty ? "" : this.Country)}");
            toStringOutput.Add($"this.LineType = {(this.LineType == null ? "null" : this.LineType == string.Empty ? "" : this.LineType)}");
            toStringOutput.Add($"this.LineProvider = {(this.LineProvider == null ? "null" : this.LineProvider == string.Empty ? "" : this.LineProvider)}");
            toStringOutput.Add($"this.MobileCountryCode = {(this.MobileCountryCode == null ? "null" : this.MobileCountryCode == string.Empty ? "" : this.MobileCountryCode)}");
            toStringOutput.Add($"this.MobileNetworkCode = {(this.MobileNetworkCode == null ? "null" : this.MobileNetworkCode == string.Empty ? "" : this.MobileNetworkCode)}");
        }
    }
}