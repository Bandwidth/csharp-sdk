// <copyright file="BandwidthMessagesList.cs" company="APIMatic">
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
    /// BandwidthMessagesList.
    /// </summary>
    public class BandwidthMessagesList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BandwidthMessagesList"/> class.
        /// </summary>
        public BandwidthMessagesList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BandwidthMessagesList"/> class.
        /// </summary>
        /// <param name="totalCount">totalCount.</param>
        /// <param name="pageInfo">pageInfo.</param>
        /// <param name="messages">messages.</param>
        public BandwidthMessagesList(
            int? totalCount = null,
            Models.PageInfo pageInfo = null,
            List<Models.BandwidthMessageItem> messages = null)
        {
            this.TotalCount = totalCount;
            this.PageInfo = pageInfo;
            this.Messages = messages;
        }

        /// <summary>
        /// Total number of messages matched by the search
        /// </summary>
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Gets or sets PageInfo.
        /// </summary>
        [JsonProperty("pageInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PageInfo PageInfo { get; set; }

        /// <summary>
        /// Gets or sets Messages.
        /// </summary>
        [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BandwidthMessageItem> Messages { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BandwidthMessagesList : ({string.Join(", ", toStringOutput)})";
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

            return obj is BandwidthMessagesList other &&
                ((this.TotalCount == null && other.TotalCount == null) || (this.TotalCount?.Equals(other.TotalCount) == true)) &&
                ((this.PageInfo == null && other.PageInfo == null) || (this.PageInfo?.Equals(other.PageInfo) == true)) &&
                ((this.Messages == null && other.Messages == null) || (this.Messages?.Equals(other.Messages) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 23261715;

            if (this.TotalCount != null)
            {
               hashCode += this.TotalCount.GetHashCode();
            }

            if (this.PageInfo != null)
            {
               hashCode += this.PageInfo.GetHashCode();
            }

            if (this.Messages != null)
            {
               hashCode += this.Messages.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TotalCount = {(this.TotalCount == null ? "null" : this.TotalCount.ToString())}");
            toStringOutput.Add($"this.PageInfo = {(this.PageInfo == null ? "null" : this.PageInfo.ToString())}");
            toStringOutput.Add($"this.Messages = {(this.Messages == null ? "null" : $"[{string.Join(", ", this.Messages)} ]")}");
        }
    }
}