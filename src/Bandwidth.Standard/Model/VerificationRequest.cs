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
    /// VerificationRequest
    /// </summary>
    [DataContract(Name = "verificationRequest")]
    public partial class VerificationRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VerificationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationRequest" /> class.
        /// </summary>
        /// <param name="businessAddress">businessAddress (required).</param>
        /// <param name="businessContact">businessContact (required).</param>
        /// <param name="messageVolume">Estimated monthly volume of messages from the toll-free number. (required).</param>
        /// <param name="phoneNumbers">phoneNumbers (required).</param>
        /// <param name="useCase">The category of the use case. (required).</param>
        /// <param name="useCaseSummary">A general idea of the use case and customer. (required).</param>
        /// <param name="productionMessageContent">Example of message content. (required).</param>
        /// <param name="optInWorkflow">optInWorkflow (required).</param>
        /// <param name="additionalInformation">Any additional information..</param>
        /// <param name="isvReseller">ISV name..</param>
        public VerificationRequest(Address businessAddress = default(Address), Contact businessContact = default(Contact), int messageVolume = default(int), List<string> phoneNumbers = default(List<string>), string useCase = default(string), string useCaseSummary = default(string), string productionMessageContent = default(string), OptInWorkflow optInWorkflow = default(OptInWorkflow), string additionalInformation = default(string), string isvReseller = default(string))
        {
            // to ensure "businessAddress" is required (not null)
            if (businessAddress == null)
            {
                throw new ArgumentNullException("businessAddress is a required property for VerificationRequest and cannot be null");
            }
            this.BusinessAddress = businessAddress;
            // to ensure "businessContact" is required (not null)
            if (businessContact == null)
            {
                throw new ArgumentNullException("businessContact is a required property for VerificationRequest and cannot be null");
            }
            this.BusinessContact = businessContact;
            this.MessageVolume = messageVolume;
            // to ensure "phoneNumbers" is required (not null)
            if (phoneNumbers == null)
            {
                throw new ArgumentNullException("phoneNumbers is a required property for VerificationRequest and cannot be null");
            }
            this.PhoneNumbers = phoneNumbers;
            // to ensure "useCase" is required (not null)
            if (useCase == null)
            {
                throw new ArgumentNullException("useCase is a required property for VerificationRequest and cannot be null");
            }
            this.UseCase = useCase;
            // to ensure "useCaseSummary" is required (not null)
            if (useCaseSummary == null)
            {
                throw new ArgumentNullException("useCaseSummary is a required property for VerificationRequest and cannot be null");
            }
            this.UseCaseSummary = useCaseSummary;
            // to ensure "productionMessageContent" is required (not null)
            if (productionMessageContent == null)
            {
                throw new ArgumentNullException("productionMessageContent is a required property for VerificationRequest and cannot be null");
            }
            this.ProductionMessageContent = productionMessageContent;
            // to ensure "optInWorkflow" is required (not null)
            if (optInWorkflow == null)
            {
                throw new ArgumentNullException("optInWorkflow is a required property for VerificationRequest and cannot be null");
            }
            this.OptInWorkflow = optInWorkflow;
            this.AdditionalInformation = additionalInformation;
            this.IsvReseller = isvReseller;
        }

        /// <summary>
        /// Gets or Sets BusinessAddress
        /// </summary>
        [DataMember(Name = "businessAddress", IsRequired = true, EmitDefaultValue = true)]
        public Address BusinessAddress { get; set; }

        /// <summary>
        /// Gets or Sets BusinessContact
        /// </summary>
        [DataMember(Name = "businessContact", IsRequired = true, EmitDefaultValue = true)]
        public Contact BusinessContact { get; set; }

        /// <summary>
        /// Estimated monthly volume of messages from the toll-free number.
        /// </summary>
        /// <value>Estimated monthly volume of messages from the toll-free number.</value>
        /// <example>10000</example>
        [DataMember(Name = "messageVolume", IsRequired = true, EmitDefaultValue = true)]
        public int MessageVolume { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumbers
        /// </summary>
        [DataMember(Name = "phoneNumbers", IsRequired = true, EmitDefaultValue = true)]
        public List<string> PhoneNumbers { get; set; }

        /// <summary>
        /// The category of the use case.
        /// </summary>
        /// <value>The category of the use case.</value>
        /// <example>2FA</example>
        [DataMember(Name = "useCase", IsRequired = true, EmitDefaultValue = true)]
        public string UseCase { get; set; }

        /// <summary>
        /// A general idea of the use case and customer.
        /// </summary>
        /// <value>A general idea of the use case and customer.</value>
        /// <example>Text summarizing the use case for the toll-free number</example>
        [DataMember(Name = "useCaseSummary", IsRequired = true, EmitDefaultValue = true)]
        public string UseCaseSummary { get; set; }

        /// <summary>
        /// Example of message content.
        /// </summary>
        /// <value>Example of message content.</value>
        /// <example>Production message content</example>
        [DataMember(Name = "productionMessageContent", IsRequired = true, EmitDefaultValue = true)]
        public string ProductionMessageContent { get; set; }

        /// <summary>
        /// Gets or Sets OptInWorkflow
        /// </summary>
        [DataMember(Name = "optInWorkflow", IsRequired = true, EmitDefaultValue = true)]
        public OptInWorkflow OptInWorkflow { get; set; }

        /// <summary>
        /// Any additional information.
        /// </summary>
        /// <value>Any additional information.</value>
        /// <example>Any additional information</example>
        [DataMember(Name = "additionalInformation", EmitDefaultValue = true)]
        public string AdditionalInformation { get; set; }

        /// <summary>
        /// ISV name.
        /// </summary>
        /// <value>ISV name.</value>
        /// <example>Test ISV</example>
        [DataMember(Name = "isvReseller", EmitDefaultValue = true)]
        public string IsvReseller { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerificationRequest {\n");
            sb.Append("  BusinessAddress: ").Append(BusinessAddress).Append("\n");
            sb.Append("  BusinessContact: ").Append(BusinessContact).Append("\n");
            sb.Append("  MessageVolume: ").Append(MessageVolume).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  UseCase: ").Append(UseCase).Append("\n");
            sb.Append("  UseCaseSummary: ").Append(UseCaseSummary).Append("\n");
            sb.Append("  ProductionMessageContent: ").Append(ProductionMessageContent).Append("\n");
            sb.Append("  OptInWorkflow: ").Append(OptInWorkflow).Append("\n");
            sb.Append("  AdditionalInformation: ").Append(AdditionalInformation).Append("\n");
            sb.Append("  IsvReseller: ").Append(IsvReseller).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // MessageVolume (int) maximum
            if (this.MessageVolume > (int)10000000)
            {
                yield return new ValidationResult("Invalid value for MessageVolume, must be a value less than or equal to 10000000.", new [] { "MessageVolume" });
            }

            // MessageVolume (int) minimum
            if (this.MessageVolume < (int)10)
            {
                yield return new ValidationResult("Invalid value for MessageVolume, must be a value greater than or equal to 10.", new [] { "MessageVolume" });
            }

            // UseCase (string) maxLength
            if (this.UseCase != null && this.UseCase.Length > 500)
            {
                yield return new ValidationResult("Invalid value for UseCase, length must be less than 500.", new [] { "UseCase" });
            }

            // UseCase (string) minLength
            if (this.UseCase != null && this.UseCase.Length < 0)
            {
                yield return new ValidationResult("Invalid value for UseCase, length must be greater than 0.", new [] { "UseCase" });
            }

            // UseCaseSummary (string) maxLength
            if (this.UseCaseSummary != null && this.UseCaseSummary.Length > 500)
            {
                yield return new ValidationResult("Invalid value for UseCaseSummary, length must be less than 500.", new [] { "UseCaseSummary" });
            }

            // UseCaseSummary (string) minLength
            if (this.UseCaseSummary != null && this.UseCaseSummary.Length < 0)
            {
                yield return new ValidationResult("Invalid value for UseCaseSummary, length must be greater than 0.", new [] { "UseCaseSummary" });
            }

            // ProductionMessageContent (string) maxLength
            if (this.ProductionMessageContent != null && this.ProductionMessageContent.Length > 500)
            {
                yield return new ValidationResult("Invalid value for ProductionMessageContent, length must be less than 500.", new [] { "ProductionMessageContent" });
            }

            // ProductionMessageContent (string) minLength
            if (this.ProductionMessageContent != null && this.ProductionMessageContent.Length < 0)
            {
                yield return new ValidationResult("Invalid value for ProductionMessageContent, length must be greater than 0.", new [] { "ProductionMessageContent" });
            }

            // AdditionalInformation (string) maxLength
            if (this.AdditionalInformation != null && this.AdditionalInformation.Length > 500)
            {
                yield return new ValidationResult("Invalid value for AdditionalInformation, length must be less than 500.", new [] { "AdditionalInformation" });
            }

            // AdditionalInformation (string) minLength
            if (this.AdditionalInformation != null && this.AdditionalInformation.Length < 0)
            {
                yield return new ValidationResult("Invalid value for AdditionalInformation, length must be greater than 0.", new [] { "AdditionalInformation" });
            }

            // IsvReseller (string) maxLength
            if (this.IsvReseller != null && this.IsvReseller.Length > 500)
            {
                yield return new ValidationResult("Invalid value for IsvReseller, length must be less than 500.", new [] { "IsvReseller" });
            }

            // IsvReseller (string) minLength
            if (this.IsvReseller != null && this.IsvReseller.Length < 0)
            {
                yield return new ValidationResult("Invalid value for IsvReseller, length must be greater than 0.", new [] { "IsvReseller" });
            }

            yield break;
        }
    }

}
