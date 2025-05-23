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
    /// RbmMessageCarouselCard
    /// </summary>
    [DataContract(Name = "rbmMessageCarouselCard")]
    public partial class RbmMessageCarouselCard : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets CardWidth
        /// </summary>
        [DataMember(Name = "cardWidth", IsRequired = true, EmitDefaultValue = true)]
        public CardWidthEnum CardWidth { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RbmMessageCarouselCard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RbmMessageCarouselCard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RbmMessageCarouselCard" /> class.
        /// </summary>
        /// <param name="cardWidth">cardWidth (required).</param>
        /// <param name="cardContents">cardContents (required).</param>
        /// <param name="suggestions">An array of suggested actions for the recipient..</param>
        public RbmMessageCarouselCard(CardWidthEnum cardWidth = default(CardWidthEnum), List<RbmCardContent> cardContents = default(List<RbmCardContent>), List<MultiChannelAction> suggestions = default(List<MultiChannelAction>))
        {
            this.CardWidth = cardWidth;
            // to ensure "cardContents" is required (not null)
            if (cardContents == null)
            {
                throw new ArgumentNullException("cardContents is a required property for RbmMessageCarouselCard and cannot be null");
            }
            this.CardContents = cardContents;
            this.Suggestions = suggestions;
        }

        /// <summary>
        /// Gets or Sets CardContents
        /// </summary>
        [DataMember(Name = "cardContents", IsRequired = true, EmitDefaultValue = true)]
        public List<RbmCardContent> CardContents { get; set; }

        /// <summary>
        /// An array of suggested actions for the recipient.
        /// </summary>
        /// <value>An array of suggested actions for the recipient.</value>
        [DataMember(Name = "suggestions", EmitDefaultValue = false)]
        public List<MultiChannelAction> Suggestions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RbmMessageCarouselCard {\n");
            sb.Append("  CardWidth: ").Append(CardWidth).Append("\n");
            sb.Append("  CardContents: ").Append(CardContents).Append("\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
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
            yield break;
        }
    }

}
