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
    public partial class MessagesList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesList" /> class.
        /// </summary>
        /// <param name="totalCount">The total number of messages matched by the search. When the request has limitTotalCount set to true this value is limited to 10,000..</param>
        /// <param name="pageInfo">pageInfo.</param>
        /// <param name="messages">messages.</param>
        public MessagesList(int totalCount = default(int), PageInfo pageInfo = default(PageInfo), List<ListMessageItem> messages = default(List<ListMessageItem>))
        {
            this.TotalCount = totalCount;
            this.PageInfo = pageInfo;
            this.Messages = messages;
        }

        /// <summary>
        /// The total number of messages matched by the search. When the request has limitTotalCount set to true this value is limited to 10,000.
        /// </summary>
        /// <value>The total number of messages matched by the search. When the request has limitTotalCount set to true this value is limited to 10,000.</value>
        /// <example>100</example>
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