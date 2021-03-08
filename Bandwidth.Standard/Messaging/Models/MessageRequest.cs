/*
 * Bandwidth.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Bandwidth.Standard;
using Bandwidth.Standard.Utilities;

namespace Bandwidth.Standard.Messaging.Models
{
    public class MessageRequest 
    {
        public MessageRequest() { }

        public MessageRequest(string applicationId,
            List<string> to,
            string from,
            string text = null,
            List<string> media = null,
            string tag = null,
            Models.PriorityEnum? priority = null)
        {
            ApplicationId = applicationId;
            To = to;
            From = from;
            Text = text;
            Media = media;
            Tag = tag;
            Priority = priority;
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
        [JsonProperty("priority", ItemConverterType = typeof(StringValuedEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.PriorityEnum? Priority { get; set; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MessageRequest : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ApplicationId = {(ApplicationId == null ? "null" : ApplicationId == string.Empty ? "" : ApplicationId)}");
            toStringOutput.Add($"To = {(To == null ? "null" : $"[{ string.Join(", ", To)} ]")}");
            toStringOutput.Add($"From = {(From == null ? "null" : From == string.Empty ? "" : From)}");
            toStringOutput.Add($"Text = {(Text == null ? "null" : Text == string.Empty ? "" : Text)}");
            toStringOutput.Add($"Media = {(Media == null ? "null" : $"[{ string.Join(", ", Media)} ]")}");
            toStringOutput.Add($"Tag = {(Tag == null ? "null" : Tag == string.Empty ? "" : Tag)}");
            toStringOutput.Add($"Priority = {(Priority == null ? "null" : Priority.ToString())}");
        }

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
                ((ApplicationId == null && other.ApplicationId == null) || (ApplicationId?.Equals(other.ApplicationId) == true)) &&
                ((To == null && other.To == null) || (To?.Equals(other.To) == true)) &&
                ((From == null && other.From == null) || (From?.Equals(other.From) == true)) &&
                ((Text == null && other.Text == null) || (Text?.Equals(other.Text) == true)) &&
                ((Media == null && other.Media == null) || (Media?.Equals(other.Media) == true)) &&
                ((Tag == null && other.Tag == null) || (Tag?.Equals(other.Tag) == true)) &&
                ((Priority == null && other.Priority == null) || (Priority?.Equals(other.Priority) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -287486185;

            if (ApplicationId != null)
            {
               hashCode += ApplicationId.GetHashCode();
            }

            if (To != null)
            {
               hashCode += To.GetHashCode();
            }

            if (From != null)
            {
               hashCode += From.GetHashCode();
            }

            if (Text != null)
            {
               hashCode += Text.GetHashCode();
            }

            if (Media != null)
            {
               hashCode += Media.GetHashCode();
            }

            if (Tag != null)
            {
               hashCode += Tag.GetHashCode();
            }

            if (Priority != null)
            {
               hashCode += Priority.GetHashCode();
            }

            return hashCode;
        }

    }
}