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
    /// TfvBasicAuthentication
    /// </summary>
    [DataContract(Name = "tfvBasicAuthentication")]
    public partial class TfvBasicAuthentication : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TfvBasicAuthentication" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TfvBasicAuthentication() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TfvBasicAuthentication" /> class.
        /// </summary>
        /// <param name="username">username (required).</param>
        /// <param name="password">password (required).</param>
        public TfvBasicAuthentication(string username = default(string), string password = default(string))
        {
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new ArgumentNullException("username is a required property for TfvBasicAuthentication and cannot be null");
            }
            this.Username = username;
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new ArgumentNullException("password is a required property for TfvBasicAuthentication and cannot be null");
            }
            this.Password = password;
        }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        /// <example>username</example>
        [DataMember(Name = "username", IsRequired = true, EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        /// <example>password</example>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TfvBasicAuthentication {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Username (string) maxLength
            if (this.Username != null && this.Username.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Username, length must be less than 100.", new [] { "Username" });
            }

            // Password (string) maxLength
            if (this.Password != null && this.Password.Length > 200)
            {
                yield return new ValidationResult("Invalid value for Password, length must be less than 200.", new [] { "Password" });
            }

            yield break;
        }
    }

}
