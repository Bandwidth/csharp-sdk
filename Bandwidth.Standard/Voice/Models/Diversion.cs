// <copyright file="Diversion.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.Voice.Models
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
    /// Diversion.
    /// </summary>
    public class Diversion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Diversion"/> class.
        /// </summary>
        public Diversion()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Diversion"/> class.
        /// </summary>
        /// <param name="reason">reason.</param>
        /// <param name="privacy">privacy.</param>
        /// <param name="unknown">unknown.</param>
        /// <param name="origTo">origTo.</param>
        public Diversion(
            string reason = null,
            string privacy = null,
            string unknown = null,
            string origTo = null)
        {
            this.Reason = reason;
            this.Privacy = privacy;
            this.Unknown = unknown;
            this.OrigTo = origTo;
        }

        /// <summary>
        /// Gets or sets Reason.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets Privacy.
        /// </summary>
        [JsonProperty("privacy", NullValueHandling = NullValueHandling.Ignore)]
        public string Privacy { get; set; }

        /// <summary>
        /// Gets or sets Unknown.
        /// </summary>
        [JsonProperty("unknown", NullValueHandling = NullValueHandling.Ignore)]
        public string Unknown { get; set; }

        /// <summary>
        /// Gets or sets OrigTo.
        /// </summary>
        [JsonProperty("origTo", NullValueHandling = NullValueHandling.Ignore)]
        public string OrigTo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Diversion : ({string.Join(", ", toStringOutput)})";
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

            return obj is Diversion other &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true)) &&
                ((this.Privacy == null && other.Privacy == null) || (this.Privacy?.Equals(other.Privacy) == true)) &&
                ((this.Unknown == null && other.Unknown == null) || (this.Unknown?.Equals(other.Unknown) == true)) &&
                ((this.OrigTo == null && other.OrigTo == null) || (this.OrigTo?.Equals(other.OrigTo) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 2065332573;

            if (this.Reason != null)
            {
               hashCode += this.Reason.GetHashCode();
            }

            if (this.Privacy != null)
            {
               hashCode += this.Privacy.GetHashCode();
            }

            if (this.Unknown != null)
            {
               hashCode += this.Unknown.GetHashCode();
            }

            if (this.OrigTo != null)
            {
               hashCode += this.OrigTo.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason == string.Empty ? "" : this.Reason)}");
            toStringOutput.Add($"this.Privacy = {(this.Privacy == null ? "null" : this.Privacy == string.Empty ? "" : this.Privacy)}");
            toStringOutput.Add($"this.Unknown = {(this.Unknown == null ? "null" : this.Unknown == string.Empty ? "" : this.Unknown)}");
            toStringOutput.Add($"this.OrigTo = {(this.OrigTo == null ? "null" : this.OrigTo == string.Empty ? "" : this.OrigTo)}");
        }
    }
}