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
    /// MultiChannelCallbackData
    /// </summary>
    [DataContract(Name = "multiChannelCallbackData")]
    public partial class MultiChannelCallbackData : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public MultiChannelStatusEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiChannelCallbackData" /> class.
        /// </summary>
        /// <param name="time">The time of the callback event..</param>
        /// <param name="type">type.</param>
        /// <param name="to">The phone number the message should be sent to in E164 format..</param>
        /// <param name="description">description.</param>
        /// <param name="message">message.</param>
        public MultiChannelCallbackData(DateTime time = default(DateTime), MultiChannelStatusEnum? type = default(MultiChannelStatusEnum?), string to = default(string), string description = default(string), MultiChannelMessageCallbackData message = default(MultiChannelMessageCallbackData))
        {
            this.Time = time;
            this.Type = type;
            this.To = to;
            this.Description = description;
            this.Message = message;
        }

        /// <summary>
        /// The time of the callback event.
        /// </summary>
        /// <value>The time of the callback event.</value>
        /// <example>2025-01-01T18:20:16Z</example>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        public DateTime Time { get; set; }

        /// <summary>
        /// The phone number the message should be sent to in E164 format.
        /// </summary>
        /// <value>The phone number the message should be sent to in E164 format.</value>
        /// <example>+15552223333</example>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /// <example>Incoming message received</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public MultiChannelMessageCallbackData Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MultiChannelCallbackData {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
