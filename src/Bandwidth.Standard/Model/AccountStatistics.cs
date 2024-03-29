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
    /// AccountStatistics
    /// </summary>
    [DataContract(Name = "accountStatistics")]
    public partial class AccountStatistics : IEquatable<AccountStatistics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountStatistics" /> class.
        /// </summary>
        /// <param name="currentCallQueueSize">The number of calls currently enqueued..</param>
        /// <param name="maxCallQueueSize">The maximum size of the queue before outgoing calls start being rejected..</param>
        public AccountStatistics(int currentCallQueueSize = default(int), int maxCallQueueSize = default(int))
        {
            this.CurrentCallQueueSize = currentCallQueueSize;
            this.MaxCallQueueSize = maxCallQueueSize;
        }

        /// <summary>
        /// The number of calls currently enqueued.
        /// </summary>
        /// <value>The number of calls currently enqueued.</value>
        /// <example>0</example>
        [DataMember(Name = "currentCallQueueSize", EmitDefaultValue = false)]
        public int CurrentCallQueueSize { get; set; }

        /// <summary>
        /// The maximum size of the queue before outgoing calls start being rejected.
        /// </summary>
        /// <value>The maximum size of the queue before outgoing calls start being rejected.</value>
        /// <example>900</example>
        [DataMember(Name = "maxCallQueueSize", EmitDefaultValue = false)]
        public int MaxCallQueueSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountStatistics {\n");
            sb.Append("  CurrentCallQueueSize: ").Append(CurrentCallQueueSize).Append("\n");
            sb.Append("  MaxCallQueueSize: ").Append(MaxCallQueueSize).Append("\n");
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
            return this.Equals(input as AccountStatistics);
        }

        /// <summary>
        /// Returns true if AccountStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountStatistics input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurrentCallQueueSize == input.CurrentCallQueueSize ||
                    this.CurrentCallQueueSize.Equals(input.CurrentCallQueueSize)
                ) && 
                (
                    this.MaxCallQueueSize == input.MaxCallQueueSize ||
                    this.MaxCallQueueSize.Equals(input.MaxCallQueueSize)
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
                hashCode = (hashCode * 59) + this.CurrentCallQueueSize.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxCallQueueSize.GetHashCode();
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
