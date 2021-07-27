// <copyright file="MessageRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.Messaging.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Bandwidth.Standard;
    using Bandwidth.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// MessageRequest.
    /// </summary>
    public class MessageRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRequest"/> class.
        /// </summary>
        public MessageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRequest"/> class.
        /// </summary>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="to">to.</param>
        /// <param name="from">from.</param>
        /// <param name="text">text.</param>
        /// <param name="media">media.</param>
        /// <param name="tag">tag.</param>
        /// <param name="priority">priority.</param>
        public MessageRequest(
            string applicationId,
            List<string> to,
            string from,
            string text = null,
            List<string> media = null,
            string tag = null,
            Models.PriorityEnum? priority = null)
        {
            this.ApplicationId = applicationId;
            this.To = to;
            this.From = from;
            this.Text = text;
            this.Media = media;
            this.Tag = tag;
            this.Priority = priority;
        }

        /// <summary>
        /// The ID of the Application your from number is associated with in the Bandwidth Phone Number Dashboard.
        /// </summary>
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The phone number(s) the message should be sent to in E164 format
        /// </summary>
        [JsonProperty("to")]
        public List<string> To { get; set; }

        /// <summary>
        /// One of your telephone numbers the message should come from in E164 format
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }

        /// <summary>
        /// The contents of the text message. Must be 2048 characters or less.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// A list of URLs to include as media attachments as part of the message.
        /// </summary>
        [JsonProperty("media", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Media { get; set; }

        /// <summary>
        /// A custom string that will be included in callback events of the message. Max 1024 characters
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// The message's priority, currently for toll-free or short code SMS only. Messages with a priority value of `"high"` are given preference over your other traffic.
        /// </summary>
        [JsonProperty("priority", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.PriorityEnum? Priority { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MessageRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is MessageRequest other &&
                ((this.ApplicationId == null && other.ApplicationId == null) || (this.ApplicationId?.Equals(other.ApplicationId) == true)) &&
                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true)) &&
                ((this.Text == null && other.Text == null) || (this.Text?.Equals(other.Text) == true)) &&
                ((this.Media == null && other.Media == null) || (this.Media?.Equals(other.Media) == true)) &&
                ((this.Tag == null && other.Tag == null) || (this.Tag?.Equals(other.Tag) == true)) &&
                ((this.Priority == null && other.Priority == null) || (this.Priority?.Equals(other.Priority) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -287486185;

            if (this.ApplicationId != null)
            {
               hashCode += this.ApplicationId.GetHashCode();
            }

            if (this.To != null)
            {
               hashCode += this.To.GetHashCode();
            }

            if (this.From != null)
            {
               hashCode += this.From.GetHashCode();
            }

            if (this.Text != null)
            {
               hashCode += this.Text.GetHashCode();
            }

            if (this.Media != null)
            {
               hashCode += this.Media.GetHashCode();
            }

            if (this.Tag != null)
            {
               hashCode += this.Tag.GetHashCode();
            }

            if (this.Priority != null)
            {
               hashCode += this.Priority.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ApplicationId = {(this.ApplicationId == null ? "null" : this.ApplicationId == string.Empty ? "" : this.ApplicationId)}");
            toStringOutput.Add($"this.To = {(this.To == null ? "null" : $"[{string.Join(", ", this.To)} ]")}");
            toStringOutput.Add($"this.From = {(this.From == null ? "null" : this.From == string.Empty ? "" : this.From)}");
            toStringOutput.Add($"this.Text = {(this.Text == null ? "null" : this.Text == string.Empty ? "" : this.Text)}");
            toStringOutput.Add($"this.Media = {(this.Media == null ? "null" : $"[{string.Join(", ", this.Media)} ]")}");
            toStringOutput.Add($"this.Tag = {(this.Tag == null ? "null" : this.Tag == string.Empty ? "" : this.Tag)}");
            toStringOutput.Add($"this.Priority = {(this.Priority == null ? "null" : this.Priority.ToString())}");
        }
    }
}