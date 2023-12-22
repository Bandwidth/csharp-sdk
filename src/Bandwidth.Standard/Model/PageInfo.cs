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
    /// PageInfo
    /// </summary>
    [DataContract(Name = "pageInfo")]
    public partial class PageInfo : IEquatable<PageInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageInfo" /> class.
        /// </summary>
        /// <param name="prevPage">The link to the previous page for pagination..</param>
        /// <param name="nextPage">The link to the next page for pagination..</param>
        /// <param name="prevPageToken">The isolated pagination token for the previous page..</param>
        /// <param name="nextPageToken">The isolated pagination token for the next page..</param>
        public PageInfo(string prevPage = default(string), string nextPage = default(string), string prevPageToken = default(string), string nextPageToken = default(string))
        {
            this.PrevPage = prevPage;
            this.NextPage = nextPage;
            this.PrevPageToken = prevPageToken;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// The link to the previous page for pagination.
        /// </summary>
        /// <value>The link to the previous page for pagination.</value>
        /// <example>https://messaging.bandwidth.com/api/v2/users/accountId/messages?messageStatus&#x3D;DLR_EXPIRED&amp;nextPage&#x3D;DLAPE902</example>
        [DataMember(Name = "prevPage", EmitDefaultValue = false)]
        public string PrevPage { get; set; }

        /// <summary>
        /// The link to the next page for pagination.
        /// </summary>
        /// <value>The link to the next page for pagination.</value>
        /// <example>https://messaging.bandwidth.com/api/v2/users/accountId/messages?messageStatus&#x3D;DLR_EXPIRED&amp;prevPage&#x3D;GL83PD3C</example>
        [DataMember(Name = "nextPage", EmitDefaultValue = false)]
        public string NextPage { get; set; }

        /// <summary>
        /// The isolated pagination token for the previous page.
        /// </summary>
        /// <value>The isolated pagination token for the previous page.</value>
        /// <example>DLAPE902</example>
        [DataMember(Name = "prevPageToken", EmitDefaultValue = false)]
        public string PrevPageToken { get; set; }

        /// <summary>
        /// The isolated pagination token for the next page.
        /// </summary>
        /// <value>The isolated pagination token for the next page.</value>
        /// <example>GL83PD3C</example>
        [DataMember(Name = "nextPageToken", EmitDefaultValue = false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PageInfo {\n");
            sb.Append("  PrevPage: ").Append(PrevPage).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  PrevPageToken: ").Append(PrevPageToken).Append("\n");
            sb.Append("  NextPageToken: ").Append(NextPageToken).Append("\n");
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
            return this.Equals(input as PageInfo);
        }

        /// <summary>
        /// Returns true if PageInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PageInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PrevPage == input.PrevPage ||
                    (this.PrevPage != null &&
                    this.PrevPage.Equals(input.PrevPage))
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
                ) && 
                (
                    this.PrevPageToken == input.PrevPageToken ||
                    (this.PrevPageToken != null &&
                    this.PrevPageToken.Equals(input.PrevPageToken))
                ) && 
                (
                    this.NextPageToken == input.NextPageToken ||
                    (this.NextPageToken != null &&
                    this.NextPageToken.Equals(input.NextPageToken))
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
                if (this.PrevPage != null)
                {
                    hashCode = (hashCode * 59) + this.PrevPage.GetHashCode();
                }
                if (this.NextPage != null)
                {
                    hashCode = (hashCode * 59) + this.NextPage.GetHashCode();
                }
                if (this.PrevPageToken != null)
                {
                    hashCode = (hashCode * 59) + this.PrevPageToken.GetHashCode();
                }
                if (this.NextPageToken != null)
                {
                    hashCode = (hashCode * 59) + this.NextPageToken.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
