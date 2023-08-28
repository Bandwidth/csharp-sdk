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
    /// Message Sending Callback
    /// </summary>
    [DataContract(Name = "messageSendingCallback")]
    public partial class MessageSendingCallback : IEquatable<MessageSendingCallback>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSendingCallback" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageSendingCallback() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSendingCallback" /> class.
        /// </summary>
        /// <param name="time">time (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="to">to (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="message">message (required).</param>
        public MessageSendingCallback(DateTime time = default(DateTime), string type = default(string), string to = default(string), string description = default(string), MessageSendingCallbackMessage message = default(MessageSendingCallbackMessage))
        {
            this.Time = time;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for MessageSendingCallback and cannot be null");
            }
            this.Type = type;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for MessageSendingCallback and cannot be null");
            }
            this.To = to;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for MessageSendingCallback and cannot be null");
            }
            this.Description = description;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for MessageSendingCallback and cannot be null");
            }
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        /// <example>2016-09-14T18:20:16Z</example>
        [DataMember(Name = "time", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>message-sending</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        /// <example>+15552223333</example>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /// <example>Message is sending to carrier</example>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public MessageSendingCallbackMessage Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MessageSendingCallback {\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MessageSendingCallback);
        }

        /// <summary>
        /// Returns true if MessageSendingCallback instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageSendingCallback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageSendingCallback input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Time != null)
                {
                    hashCode = (hashCode * 59) + this.Time.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
