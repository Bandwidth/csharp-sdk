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
    /// Conference
    /// </summary>
    [DataContract(Name = "conference")]
    public partial class Conference : IEquatable<Conference>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ConferenceEventMethod
        /// </summary>
        [DataMember(Name = "conferenceEventMethod", EmitDefaultValue = true)]
        public CallbackMethodEnum? ConferenceEventMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Conference" /> class.
        /// </summary>
        /// <param name="id">The Bandwidth-generated conference ID.</param>
        /// <param name="name">The name of the conference, as specified by your application.</param>
        /// <param name="createdTime">The time the conference was initiated, in ISO 8601 format..</param>
        /// <param name="completedTime">The time the conference was terminated, in ISO 8601 format..</param>
        /// <param name="conferenceEventUrl">The URL to send the conference-related events..</param>
        /// <param name="conferenceEventMethod">conferenceEventMethod.</param>
        /// <param name="tag">The custom string attached to the conference that will be sent with callbacks..</param>
        /// <param name="activeMembers">A list of active members of the conference. Omitted if this is a response to the [Get Conferences endpoint](/apis/voice#tag/Conferences/operation/listConferences).</param>
        public Conference(string id = default(string), string name = default(string), DateTime createdTime = default(DateTime), DateTime? completedTime = default(DateTime?), string conferenceEventUrl = default(string), CallbackMethodEnum? conferenceEventMethod = default(CallbackMethodEnum?), string tag = default(string), List<ConferenceMember> activeMembers = default(List<ConferenceMember>))
        {
            this.Id = id;
            this.Name = name;
            this.CreatedTime = createdTime;
            this.CompletedTime = completedTime;
            this.ConferenceEventUrl = conferenceEventUrl;
            this.ConferenceEventMethod = conferenceEventMethod;
            this.Tag = tag;
            this.ActiveMembers = activeMembers;
        }

        /// <summary>
        /// The Bandwidth-generated conference ID
        /// </summary>
        /// <value>The Bandwidth-generated conference ID</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the conference, as specified by your application
        /// </summary>
        /// <value>The name of the conference, as specified by your application</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The time the conference was initiated, in ISO 8601 format.
        /// </summary>
        /// <value>The time the conference was initiated, in ISO 8601 format.</value>
        [DataMember(Name = "createdTime", EmitDefaultValue = false)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// The time the conference was terminated, in ISO 8601 format.
        /// </summary>
        /// <value>The time the conference was terminated, in ISO 8601 format.</value>
        [DataMember(Name = "completedTime", EmitDefaultValue = true)]
        public DateTime? CompletedTime { get; set; }

        /// <summary>
        /// The URL to send the conference-related events.
        /// </summary>
        /// <value>The URL to send the conference-related events.</value>
        [DataMember(Name = "conferenceEventUrl", EmitDefaultValue = true)]
        public string ConferenceEventUrl { get; set; }

        /// <summary>
        /// The custom string attached to the conference that will be sent with callbacks.
        /// </summary>
        /// <value>The custom string attached to the conference that will be sent with callbacks.</value>
        [DataMember(Name = "tag", EmitDefaultValue = true)]
        public string Tag { get; set; }

        /// <summary>
        /// A list of active members of the conference. Omitted if this is a response to the [Get Conferences endpoint](/apis/voice#tag/Conferences/operation/listConferences)
        /// </summary>
        /// <value>A list of active members of the conference. Omitted if this is a response to the [Get Conferences endpoint](/apis/voice#tag/Conferences/operation/listConferences)</value>
        [DataMember(Name = "activeMembers", EmitDefaultValue = true)]
        public List<ConferenceMember> ActiveMembers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Conference {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CompletedTime: ").Append(CompletedTime).Append("\n");
            sb.Append("  ConferenceEventUrl: ").Append(ConferenceEventUrl).Append("\n");
            sb.Append("  ConferenceEventMethod: ").Append(ConferenceEventMethod).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  ActiveMembers: ").Append(ActiveMembers).Append("\n");
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
            return this.Equals(input as Conference);
        }

        /// <summary>
        /// Returns true if Conference instances are equal
        /// </summary>
        /// <param name="input">Instance of Conference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Conference input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.CompletedTime == input.CompletedTime ||
                    (this.CompletedTime != null &&
                    this.CompletedTime.Equals(input.CompletedTime))
                ) && 
                (
                    this.ConferenceEventUrl == input.ConferenceEventUrl ||
                    (this.ConferenceEventUrl != null &&
                    this.ConferenceEventUrl.Equals(input.ConferenceEventUrl))
                ) && 
                (
                    this.ConferenceEventMethod == input.ConferenceEventMethod ||
                    this.ConferenceEventMethod.Equals(input.ConferenceEventMethod)
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.ActiveMembers == input.ActiveMembers ||
                    this.ActiveMembers != null &&
                    input.ActiveMembers != null &&
                    this.ActiveMembers.SequenceEqual(input.ActiveMembers)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.CreatedTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedTime.GetHashCode();
                }
                if (this.CompletedTime != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedTime.GetHashCode();
                }
                if (this.ConferenceEventUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ConferenceEventUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ConferenceEventMethod.GetHashCode();
                if (this.Tag != null)
                {
                    hashCode = (hashCode * 59) + this.Tag.GetHashCode();
                }
                if (this.ActiveMembers != null)
                {
                    hashCode = (hashCode * 59) + this.ActiveMembers.GetHashCode();
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
