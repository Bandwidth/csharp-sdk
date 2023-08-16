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
    /// Message Failed Callback Message Schema
    /// </summary>
    [DataContract(Name = "messageFailedCallbackMessage")]
    public partial class MessageFailedCallbackMessage : IEquatable<MessageFailedCallbackMessage>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name = "direction", IsRequired = true, EmitDefaultValue = true)]
        public MessageDirectionEnum Direction { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", IsRequired = true, EmitDefaultValue = true)]
        public PriorityEnum Priority { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageFailedCallbackMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageFailedCallbackMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageFailedCallbackMessage" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="owner">owner (required).</param>
        /// <param name="applicationId">applicationId (required).</param>
        /// <param name="time">time (required).</param>
        /// <param name="segmentCount">segmentCount (required).</param>
        /// <param name="direction">direction (required).</param>
        /// <param name="to">to (required).</param>
        /// <param name="from">from (required).</param>
        /// <param name="text">text (required).</param>
        /// <param name="tag">tag (required).</param>
        /// <param name="media">media.</param>
        /// <param name="priority">priority (required).</param>
        public MessageFailedCallbackMessage(string id = default(string), string owner = default(string), string applicationId = default(string), DateTime time = default(DateTime), int segmentCount = default(int), MessageDirectionEnum direction = default(MessageDirectionEnum), List<string> to = default(List<string>), string from = default(string), string text = default(string), string tag = default(string), List<string> media = default(List<string>), PriorityEnum priority = default(PriorityEnum))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for MessageFailedCallbackMessage and cannot be null");
            }
            this.Id = id;
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new ArgumentNullException("owner is a required property for MessageFailedCallbackMessage and cannot be null");
            }
            this.Owner = owner;
            // to ensure "applicationId" is required (not null)
            if (applicationId == null)
            {
                throw new ArgumentNullException("applicationId is a required property for MessageFailedCallbackMessage and cannot be null");
            }
            this.ApplicationId = applicationId;
            this.Time = time;
            this.SegmentCount = segmentCount;
            this.Direction = direction;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for MessageFailedCallbackMessage and cannot be null");
            }
            this.To = to;
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new ArgumentNullException("from is a required property for MessageFailedCallbackMessage and cannot be null");
            }
            this.From = from;
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for MessageFailedCallbackMessage and cannot be null");
            }
            this.Text = text;
            // to ensure "tag" is required (not null)
            if (tag == null)
            {
                throw new ArgumentNullException("tag is a required property for MessageFailedCallbackMessage and cannot be null");
            }
            this.Tag = tag;
            this.Priority = priority;
            this.Media = media;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>&quot;1661365814859loidf7mcwd4qacn7&quot;</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        /// <example>&quot;+15553332222&quot;</example>
        [DataMember(Name = "owner", IsRequired = true, EmitDefaultValue = true)]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        /// <example>&quot;93de2206-9669-4e07-948d-329f4b722ee2&quot;</example>
        [DataMember(Name = "applicationId", IsRequired = true, EmitDefaultValue = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        /// <example>&quot;2016-09-14T18:20:16Z&quot;</example>
        [DataMember(Name = "time", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or Sets SegmentCount
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "segmentCount", IsRequired = true, EmitDefaultValue = true)]
        public int SegmentCount { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public List<string> To { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        /// <example>&quot;+15553332222&quot;</example>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        /// <example>&quot;Hello world&quot;</example>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        /// <example>&quot;custom string&quot;</example>
        [DataMember(Name = "tag", IsRequired = true, EmitDefaultValue = true)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name = "media", EmitDefaultValue = false)]
        public List<string> Media { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MessageFailedCallbackMessage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  SegmentCount: ").Append(SegmentCount).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
            return this.Equals(input as MessageFailedCallbackMessage);
        }

        /// <summary>
        /// Returns true if MessageFailedCallbackMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageFailedCallbackMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageFailedCallbackMessage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.SegmentCount == input.SegmentCount ||
                    this.SegmentCount.Equals(input.SegmentCount)
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
                ) && 
                (
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Media == input.Media ||
                    this.Media != null &&
                    input.Media != null &&
                    this.Media.SequenceEqual(input.Media)
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Owner != null)
                {
                    hashCode = (hashCode * 59) + this.Owner.GetHashCode();
                }
                if (this.ApplicationId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationId.GetHashCode();
                }
                if (this.Time != null)
                {
                    hashCode = (hashCode * 59) + this.Time.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SegmentCount.GetHashCode();
                hashCode = (hashCode * 59) + this.Direction.GetHashCode();
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.Tag != null)
                {
                    hashCode = (hashCode * 59) + this.Tag.GetHashCode();
                }
                if (this.Media != null)
                {
                    hashCode = (hashCode * 59) + this.Media.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Priority.GetHashCode();
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
