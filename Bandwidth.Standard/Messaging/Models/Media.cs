// <copyright file="Media.cs" company="APIMatic">
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
    /// Media.
    /// </summary>
    public class Media
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Media"/> class.
        /// </summary>
        public Media()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Media"/> class.
        /// </summary>
        /// <param name="content">content.</param>
        /// <param name="contentLength">contentLength.</param>
        /// <param name="mediaName">mediaName.</param>
        public Media(
            string content = null,
            int? contentLength = null,
            string mediaName = null)
        {
            this.Content = content;
            this.ContentLength = contentLength;
            this.MediaName = mediaName;
        }

        /// <summary>
        /// Gets or sets Content.
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets ContentLength.
        /// </summary>
        [JsonProperty("contentLength", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContentLength { get; set; }

        /// <summary>
        /// Gets or sets MediaName.
        /// </summary>
        [JsonProperty("mediaName", NullValueHandling = NullValueHandling.Ignore)]
        public string MediaName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Media : ({string.Join(", ", toStringOutput)})";
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

            return obj is Media other &&
                ((this.Content == null && other.Content == null) || (this.Content?.Equals(other.Content) == true)) &&
                ((this.ContentLength == null && other.ContentLength == null) || (this.ContentLength?.Equals(other.ContentLength) == true)) &&
                ((this.MediaName == null && other.MediaName == null) || (this.MediaName?.Equals(other.MediaName) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 457305241;

            if (this.Content != null)
            {
               hashCode += this.Content.GetHashCode();
            }

            if (this.ContentLength != null)
            {
               hashCode += this.ContentLength.GetHashCode();
            }

            if (this.MediaName != null)
            {
               hashCode += this.MediaName.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Content = {(this.Content == null ? "null" : this.Content == string.Empty ? "" : this.Content)}");
            toStringOutput.Add($"this.ContentLength = {(this.ContentLength == null ? "null" : this.ContentLength.ToString())}");
            toStringOutput.Add($"this.MediaName = {(this.MediaName == null ? "null" : this.MediaName == string.Empty ? "" : this.MediaName)}");
        }
    }
}