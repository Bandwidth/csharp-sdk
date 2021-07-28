// <copyright file="BandwidthMessage.cs" company="APIMatic">
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
    /// BandwidthMessage.
    /// </summary>
    public class BandwidthMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BandwidthMessage"/> class.
        /// </summary>
        public BandwidthMessage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BandwidthMessage"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="owner">owner.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="time">time.</param>
        /// <param name="segmentCount">segmentCount.</param>
        /// <param name="direction">direction.</param>
        /// <param name="to">to.</param>
        /// <param name="from">from.</param>
        /// <param name="media">media.</param>
        /// <param name="text">text.</param>
        /// <param name="tag">tag.</param>
        /// <param name="priority">priority.</param>
        public BandwidthMessage(
            string id = null,
            string owner = null,
            string applicationId = null,
            string time = null,
            int? segmentCount = null,
            string direction = null,
            List<string> to = null,
            string from = null,
            List<string> media = null,
            string text = null,
            string tag = null,
            string priority = null)
        {
            this.Id = id;
            this.Owner = owner;
            this.ApplicationId = applicationId;
            this.Time = time;
            this.SegmentCount = segmentCount;
            this.Direction = direction;
            this.To = to;
            this.From = from;
            this.Media = media;
            this.Text = text;
            this.Tag = tag;
            this.Priority = priority;
        }

        /// <summary>
        /// The id of the message
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The Bandwidth phone number associated with the message
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// The application ID associated with the message
        /// </summary>
        [JsonProperty("applicationId", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The datetime stamp of the message in ISO 8601
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// The number of segments the original message from the user is broken into before sending over to carrier networks
        /// </summary>
        [JsonProperty("segmentCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? SegmentCount { get; set; }

        /// <summary>
        /// The direction of the message relative to Bandwidth. Can be in or out
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// The phone number recipients of the message
        /// </summary>
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> To { get; set; }

        /// <summary>
        /// The phone number the message was sent from
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public string From { get; set; }

        /// <summary>
        /// The list of media URLs sent in the message
        /// </summary>
        [JsonProperty("media", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Media { get; set; }

        /// <summary>
        /// The contents of the message
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// The custom string set by the user
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// The priority specified by the user
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string Priority { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BandwidthMessage : ({string.Join(", ", toStringOutput)})";
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

            return obj is BandwidthMessage other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Owner == null && other.Owner == null) || (this.Owner?.Equals(other.Owner) == true)) &&
                ((this.ApplicationId == null && other.ApplicationId == null) || (this.ApplicationId?.Equals(other.ApplicationId) == true)) &&
                ((this.Time == null && other.Time == null) || (this.Time?.Equals(other.Time) == true)) &&
                ((this.SegmentCount == null && other.SegmentCount == null) || (this.SegmentCount?.Equals(other.SegmentCount) == true)) &&
                ((this.Direction == null && other.Direction == null) || (this.Direction?.Equals(other.Direction) == true)) &&
                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true)) &&
                ((this.Media == null && other.Media == null) || (this.Media?.Equals(other.Media) == true)) &&
                ((this.Text == null && other.Text == null) || (this.Text?.Equals(other.Text) == true)) &&
                ((this.Tag == null && other.Tag == null) || (this.Tag?.Equals(other.Tag) == true)) &&
                ((this.Priority == null && other.Priority == null) || (this.Priority?.Equals(other.Priority) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1547980768;

            if (this.Id != null)
            {
               hashCode += this.Id.GetHashCode();
            }

            if (this.Owner != null)
            {
               hashCode += this.Owner.GetHashCode();
            }

            if (this.ApplicationId != null)
            {
               hashCode += this.ApplicationId.GetHashCode();
            }

            if (this.Time != null)
            {
               hashCode += this.Time.GetHashCode();
            }

            if (this.SegmentCount != null)
            {
               hashCode += this.SegmentCount.GetHashCode();
            }

            if (this.Direction != null)
            {
               hashCode += this.Direction.GetHashCode();
            }

            if (this.To != null)
            {
               hashCode += this.To.GetHashCode();
            }

            if (this.From != null)
            {
               hashCode += this.From.GetHashCode();
            }

            if (this.Media != null)
            {
               hashCode += this.Media.GetHashCode();
            }

            if (this.Text != null)
            {
               hashCode += this.Text.GetHashCode();
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
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Owner = {(this.Owner == null ? "null" : this.Owner == string.Empty ? "" : this.Owner)}");
            toStringOutput.Add($"this.ApplicationId = {(this.ApplicationId == null ? "null" : this.ApplicationId == string.Empty ? "" : this.ApplicationId)}");
            toStringOutput.Add($"this.Time = {(this.Time == null ? "null" : this.Time == string.Empty ? "" : this.Time)}");
            toStringOutput.Add($"this.SegmentCount = {(this.SegmentCount == null ? "null" : this.SegmentCount.ToString())}");
            toStringOutput.Add($"this.Direction = {(this.Direction == null ? "null" : this.Direction == string.Empty ? "" : this.Direction)}");
            toStringOutput.Add($"this.To = {(this.To == null ? "null" : $"[{string.Join(", ", this.To)} ]")}");
            toStringOutput.Add($"this.From = {(this.From == null ? "null" : this.From == string.Empty ? "" : this.From)}");
            toStringOutput.Add($"this.Media = {(this.Media == null ? "null" : $"[{string.Join(", ", this.Media)} ]")}");
            toStringOutput.Add($"this.Text = {(this.Text == null ? "null" : this.Text == string.Empty ? "" : this.Text)}");
            toStringOutput.Add($"this.Tag = {(this.Tag == null ? "null" : this.Tag == string.Empty ? "" : this.Tag)}");
            toStringOutput.Add($"this.Priority = {(this.Priority == null ? "null" : this.Priority == string.Empty ? "" : this.Priority)}");
        }
    }
}