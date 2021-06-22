// <copyright file="OrderRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.PhoneNumberLookup.Models
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
    /// OrderRequest.
    /// </summary>
    public class OrderRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRequest"/> class.
        /// </summary>
        public OrderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRequest"/> class.
        /// </summary>
        /// <param name="tns">tns.</param>
        public OrderRequest(
            List<string> tns = null)
        {
            this.Tns = tns;
        }

        /// <summary>
        /// Gets or sets Tns.
        /// </summary>
        [JsonProperty("tns", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tns { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrderRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is OrderRequest other &&
                ((this.Tns == null && other.Tns == null) || (this.Tns?.Equals(other.Tns) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 2089408671;

            if (this.Tns != null)
            {
               hashCode += this.Tns.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Tns = {(this.Tns == null ? "null" : $"[{string.Join(", ", this.Tns)} ]")}");
        }
    }
}