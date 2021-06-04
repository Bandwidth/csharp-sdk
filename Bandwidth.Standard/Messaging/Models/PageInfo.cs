// <copyright file="PageInfo.cs" company="APIMatic">
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
    /// PageInfo.
    /// </summary>
    public class PageInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageInfo"/> class.
        /// </summary>
        public PageInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageInfo"/> class.
        /// </summary>
        /// <param name="prevPage">prevPage.</param>
        /// <param name="nextPage">nextPage.</param>
        /// <param name="prevPageToken">prevPageToken.</param>
        /// <param name="nextPageToken">nextPageToken.</param>
        public PageInfo(
            string prevPage = null,
            string nextPage = null,
            string prevPageToken = null,
            string nextPageToken = null)
        {
            this.PrevPage = prevPage;
            this.NextPage = nextPage;
            this.PrevPageToken = prevPageToken;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// The link to the previous page for pagination
        /// </summary>
        [JsonProperty("prevPage", NullValueHandling = NullValueHandling.Ignore)]
        public string PrevPage { get; set; }

        /// <summary>
        /// The link to the next page for pagination
        /// </summary>
        [JsonProperty("nextPage", NullValueHandling = NullValueHandling.Ignore)]
        public string NextPage { get; set; }

        /// <summary>
        /// The isolated pagination token for the previous page
        /// </summary>
        [JsonProperty("prevPageToken", NullValueHandling = NullValueHandling.Ignore)]
        public string PrevPageToken { get; set; }

        /// <summary>
        /// The isolated pagination token for the next page
        /// </summary>
        [JsonProperty("nextPageToken", NullValueHandling = NullValueHandling.Ignore)]
        public string NextPageToken { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PageInfo : ({string.Join(", ", toStringOutput)})";
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

            return obj is PageInfo other &&
                ((this.PrevPage == null && other.PrevPage == null) || (this.PrevPage?.Equals(other.PrevPage) == true)) &&
                ((this.NextPage == null && other.NextPage == null) || (this.NextPage?.Equals(other.NextPage) == true)) &&
                ((this.PrevPageToken == null && other.PrevPageToken == null) || (this.PrevPageToken?.Equals(other.PrevPageToken) == true)) &&
                ((this.NextPageToken == null && other.NextPageToken == null) || (this.NextPageToken?.Equals(other.NextPageToken) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1830408517;

            if (this.PrevPage != null)
            {
               hashCode += this.PrevPage.GetHashCode();
            }

            if (this.NextPage != null)
            {
               hashCode += this.NextPage.GetHashCode();
            }

            if (this.PrevPageToken != null)
            {
               hashCode += this.PrevPageToken.GetHashCode();
            }

            if (this.NextPageToken != null)
            {
               hashCode += this.NextPageToken.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PrevPage = {(this.PrevPage == null ? "null" : this.PrevPage == string.Empty ? "" : this.PrevPage)}");
            toStringOutput.Add($"this.NextPage = {(this.NextPage == null ? "null" : this.NextPage == string.Empty ? "" : this.NextPage)}");
            toStringOutput.Add($"this.PrevPageToken = {(this.PrevPageToken == null ? "null" : this.PrevPageToken == string.Empty ? "" : this.PrevPageToken)}");
            toStringOutput.Add($"this.NextPageToken = {(this.NextPageToken == null ? "null" : this.NextPageToken == string.Empty ? "" : this.NextPageToken)}");
        }
    }
}