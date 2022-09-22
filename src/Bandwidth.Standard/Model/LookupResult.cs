/*
 * Bandwidth
 *
 * Bandwidth's Communication APIs
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: letstalk@bandwidth.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Bandwidth.Standard.Client.OpenAPIDateConverter;

namespace Bandwidth.Standard.Model
{
    /// <summary>
    /// Carrier information results for the specified telephone number.
    /// </summary>
    [DataContract(Name = "lookupResult")]
    public partial class LookupResult : IEquatable<LookupResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LookupResult" /> class.
        /// </summary>
        /// <param name="responseCode">Our vendor&#39;s response code..</param>
        /// <param name="message">Message associated with the response code..</param>
        /// <param name="e164Format">The telephone number in E.164 format..</param>
        /// <param name="formatted">The formatted version of the telephone number..</param>
        /// <param name="country">The country of the telephone number..</param>
        /// <param name="lineType">The line type of the telephone number..</param>
        /// <param name="lineProvider">The messaging service provider of the telephone number..</param>
        /// <param name="mobileCountryCode">The first half of the Home Network Identity (HNI)..</param>
        /// <param name="mobileNetworkCode">The second half of the HNI..</param>
        public LookupResult(int responseCode = default(int), string message = default(string), string e164Format = default(string), string formatted = default(string), string country = default(string), string lineType = default(string), string lineProvider = default(string), string mobileCountryCode = default(string), string mobileNetworkCode = default(string))
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
        /// Our vendor&#39;s response code.
        /// </summary>
        /// <value>Our vendor&#39;s response code.</value>
        [DataMember(Name = "Response Code", EmitDefaultValue = false)]
        public int ResponseCode { get; set; }

        /// <summary>
        /// Message associated with the response code.
        /// </summary>
        /// <value>Message associated with the response code.</value>
        [DataMember(Name = "Message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// The telephone number in E.164 format.
        /// </summary>
        /// <value>The telephone number in E.164 format.</value>
        [DataMember(Name = "E.164 Format", EmitDefaultValue = false)]
        public string E164Format { get; set; }

        /// <summary>
        /// The formatted version of the telephone number.
        /// </summary>
        /// <value>The formatted version of the telephone number.</value>
        [DataMember(Name = "Formatted", EmitDefaultValue = false)]
        public string Formatted { get; set; }

        /// <summary>
        /// The country of the telephone number.
        /// </summary>
        /// <value>The country of the telephone number.</value>
        [DataMember(Name = "Country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// The line type of the telephone number.
        /// </summary>
        /// <value>The line type of the telephone number.</value>
        [DataMember(Name = "Line Type", EmitDefaultValue = false)]
        public string LineType { get; set; }

        /// <summary>
        /// The messaging service provider of the telephone number.
        /// </summary>
        /// <value>The messaging service provider of the telephone number.</value>
        [DataMember(Name = "Line Provider", EmitDefaultValue = false)]
        public string LineProvider { get; set; }

        /// <summary>
        /// The first half of the Home Network Identity (HNI).
        /// </summary>
        /// <value>The first half of the Home Network Identity (HNI).</value>
        [DataMember(Name = "Mobile Country Code", EmitDefaultValue = false)]
        public string MobileCountryCode { get; set; }

        /// <summary>
        /// The second half of the HNI.
        /// </summary>
        /// <value>The second half of the HNI.</value>
        [DataMember(Name = "Mobile Network Code", EmitDefaultValue = false)]
        public string MobileNetworkCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LookupResult {\n");
            sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  E164Format: ").Append(E164Format).Append("\n");
            sb.Append("  Formatted: ").Append(Formatted).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  LineType: ").Append(LineType).Append("\n");
            sb.Append("  LineProvider: ").Append(LineProvider).Append("\n");
            sb.Append("  MobileCountryCode: ").Append(MobileCountryCode).Append("\n");
            sb.Append("  MobileNetworkCode: ").Append(MobileNetworkCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LookupResult);
        }

        /// <summary>
        /// Returns true if LookupResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LookupResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LookupResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ResponseCode == input.ResponseCode ||
                    this.ResponseCode.Equals(input.ResponseCode)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.E164Format == input.E164Format ||
                    (this.E164Format != null &&
                    this.E164Format.Equals(input.E164Format))
                ) && 
                (
                    this.Formatted == input.Formatted ||
                    (this.Formatted != null &&
                    this.Formatted.Equals(input.Formatted))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.LineType == input.LineType ||
                    (this.LineType != null &&
                    this.LineType.Equals(input.LineType))
                ) && 
                (
                    this.LineProvider == input.LineProvider ||
                    (this.LineProvider != null &&
                    this.LineProvider.Equals(input.LineProvider))
                ) && 
                (
                    this.MobileCountryCode == input.MobileCountryCode ||
                    (this.MobileCountryCode != null &&
                    this.MobileCountryCode.Equals(input.MobileCountryCode))
                ) && 
                (
                    this.MobileNetworkCode == input.MobileNetworkCode ||
                    (this.MobileNetworkCode != null &&
                    this.MobileNetworkCode.Equals(input.MobileNetworkCode))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.ResponseCode.GetHashCode();
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.E164Format != null)
                {
                    hashCode = (hashCode * 59) + this.E164Format.GetHashCode();
                }
                if (this.Formatted != null)
                {
                    hashCode = (hashCode * 59) + this.Formatted.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.LineType != null)
                {
                    hashCode = (hashCode * 59) + this.LineType.GetHashCode();
                }
                if (this.LineProvider != null)
                {
                    hashCode = (hashCode * 59) + this.LineProvider.GetHashCode();
                }
                if (this.MobileCountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.MobileCountryCode.GetHashCode();
                }
                if (this.MobileNetworkCode != null)
                {
                    hashCode = (hashCode * 59) + this.MobileNetworkCode.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
