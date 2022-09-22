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
    /// MessagesList
    /// </summary>
    [DataContract(Name = "messagesList")]
    public partial class MessagesList : IEquatable<MessagesList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesList" /> class.
        /// </summary>
        /// <param name="totalCount">Total number of messages matched by the search..</param>
        /// <param name="pageInfo">pageInfo.</param>
        /// <param name="messages">messages.</param>
        public MessagesList(int totalCount = default(int), PageInfo pageInfo = default(PageInfo), List<ListMessageItem> messages = default(List<ListMessageItem>))
        {
            this.TotalCount = totalCount;
            this.PageInfo = pageInfo;
            this.Messages = messages;
        }

        /// <summary>
        /// Total number of messages matched by the search.
        /// </summary>
        /// <value>Total number of messages matched by the search.</value>
        [DataMember(Name = "totalCount", EmitDefaultValue = false)]
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets or Sets PageInfo
        /// </summary>
        [DataMember(Name = "pageInfo", EmitDefaultValue = false)]
        public PageInfo PageInfo { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name = "messages", EmitDefaultValue = false)]
        public List<ListMessageItem> Messages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MessagesList {\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  PageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
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
            return this.Equals(input as MessagesList);
        }

        /// <summary>
        /// Returns true if MessagesList instances are equal
        /// </summary>
        /// <param name="input">Instance of MessagesList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagesList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
                ) && 
                (
                    this.PageInfo == input.PageInfo ||
                    (this.PageInfo != null &&
                    this.PageInfo.Equals(input.PageInfo))
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    input.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
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
                hashCode = (hashCode * 59) + this.TotalCount.GetHashCode();
                if (this.PageInfo != null)
                {
                    hashCode = (hashCode * 59) + this.PageInfo.GetHashCode();
                }
                if (this.Messages != null)
                {
                    hashCode = (hashCode * 59) + this.Messages.GetHashCode();
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
