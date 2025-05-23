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
    /// RbmMessageMedia
    /// </summary>
    [DataContract(Name = "rbmMessageMedia")]
    public partial class RbmMessageMedia : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RbmMessageMedia" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RbmMessageMedia() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RbmMessageMedia" /> class.
        /// </summary>
        /// <param name="media">media (required).</param>
        /// <param name="suggestions">An array of suggested actions for the recipient..</param>
        public RbmMessageMedia(RbmMessageContentFile media = default(RbmMessageContentFile), List<MultiChannelAction> suggestions = default(List<MultiChannelAction>))
        {
            // to ensure "media" is required (not null)
            if (media == null)
            {
                throw new ArgumentNullException("media is a required property for RbmMessageMedia and cannot be null");
            }
            this.Media = media;
            this.Suggestions = suggestions;
        }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name = "media", IsRequired = true, EmitDefaultValue = true)]
        public RbmMessageContentFile Media { get; set; }

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
            sb.Append("class RbmMessageMedia {\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
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
