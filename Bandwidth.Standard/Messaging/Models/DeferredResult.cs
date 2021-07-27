// <copyright file="DeferredResult.cs" company="APIMatic">
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
    /// DeferredResult.
    /// </summary>
    public class DeferredResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeferredResult"/> class.
        /// </summary>
        public DeferredResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeferredResult"/> class.
        /// </summary>
        /// <param name="result">result.</param>
        /// <param name="setOrExpired">setOrExpired.</param>
        public DeferredResult(
            object result = null,
            bool? setOrExpired = null)
        {
            this.Result = result;
            this.SetOrExpired = setOrExpired;
        }

        /// <summary>
        /// Gets or sets Result.
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public object Result { get; set; }

        /// <summary>
        /// Gets or sets SetOrExpired.
        /// </summary>
        [JsonProperty("setOrExpired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SetOrExpired { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeferredResult : ({string.Join(", ", toStringOutput)})";
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

            return obj is DeferredResult other &&
                ((this.Result == null && other.Result == null) || (this.Result?.Equals(other.Result) == true)) &&
                ((this.SetOrExpired == null && other.SetOrExpired == null) || (this.SetOrExpired?.Equals(other.SetOrExpired) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1571367651;

            if (this.Result != null)
            {
               hashCode += this.Result.GetHashCode();
            }

            if (this.SetOrExpired != null)
            {
               hashCode += this.SetOrExpired.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Result = {(this.Result == null ? "null" : this.Result.ToString())}");
            toStringOutput.Add($"this.SetOrExpired = {(this.SetOrExpired == null ? "null" : this.SetOrExpired.ToString())}");
        }
    }
}