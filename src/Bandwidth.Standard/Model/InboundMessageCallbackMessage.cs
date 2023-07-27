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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Bandwidth.Standard.Client.OpenAPIDateConverter;

namespace Bandwidth.Standard.Model
{
    /// <summary>
    /// Inbound Message Callback Message Schema
    /// </summary>
    [DataContract]
    public partial class InboundMessageCallbackMessage :  IEquatable<InboundMessageCallbackMessage>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=true)]
        public MessageDirectionEnum Direction { get; set; }
        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public PriorityEnum? Priority { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundMessageCallbackMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InboundMessageCallbackMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundMessageCallbackMessage" /> class.
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
        /// <param name="tag">tag.</param>
        /// <param name="media">media.</param>
        /// <param name="priority">priority.</param>
        public InboundMessageCallbackMessage(string id = default(string), string owner = default(string), string applicationId = default(string), DateTime time = default(DateTime), int segmentCount = default(int), MessageDirectionEnum direction = default(MessageDirectionEnum), List<string> to = default(List<string>), string from = default(string), string text = default(string), string tag = default(string), List<string> media = default(List<string>), PriorityEnum? priority = default(PriorityEnum?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for InboundMessageCallbackMessage and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new InvalidDataException("owner is a required property for InboundMessageCallbackMessage and cannot be null");
            }
            else
            {
                this.Owner = owner;
            }

            // to ensure "applicationId" is required (not null)
            if (applicationId == null)
            {
                throw new InvalidDataException("applicationId is a required property for InboundMessageCallbackMessage and cannot be null");
            }
            else
            {
                this.ApplicationId = applicationId;
            }

            // to ensure "time" is required (not null)
            if (time == null)
            {
                throw new InvalidDataException("time is a required property for InboundMessageCallbackMessage and cannot be null");
            }
            else
            {
                this.Time = time;
            }

            // to ensure "segmentCount" is required (not null)
            if (segmentCount == null)
            {
                throw new InvalidDataException("segmentCount is a required property for InboundMessageCallbackMessage and cannot be null");
            }
            else
            {
                this.SegmentCount = segmentCount;
            }

            // to ensure "direction" is required (not null)
            if (direction == null)
            {
                throw new InvalidDataException("direction is a required property for InboundMessageCallbackMessage and cannot be null");
            }
            else
            {
                this.Direction = direction;
            }

            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for InboundMessageCallbackMessage and cannot be null");
            }
            else
            {
                this.To = to;
            }

            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new InvalidDataException("from is a required property for InboundMessageCallbackMessage and cannot be null");
            }
            else
            {
                this.From = from;
            }

            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new InvalidDataException("text is a required property for InboundMessageCallbackMessage and cannot be null");
            }
            else
            {
                this.Text = text;
            }

            this.Tag = tag;
            this.Media = media;
            this.Priority = priority;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=true)]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=true)]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or Sets SegmentCount
        /// </summary>
        [DataMember(Name="segmentCount", EmitDefaultValue=true)]
        public int SegmentCount { get; set; }


        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=true)]
        public List<string> To { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=true)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public List<string> Media { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboundMessageCallbackMessage {\n");
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
            return this.Equals(input as InboundMessageCallbackMessage);
        }

        /// <summary>
        /// Returns true if InboundMessageCallbackMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of InboundMessageCallbackMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundMessageCallbackMessage input)
        {
            if (input == null)
                return false;

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
                    (this.SegmentCount != null &&
                    this.SegmentCount.Equals(input.SegmentCount))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
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
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.SegmentCount != null)
                    hashCode = hashCode * 59 + this.SegmentCount.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Media != null)
                    hashCode = hashCode * 59 + this.Media.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
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
