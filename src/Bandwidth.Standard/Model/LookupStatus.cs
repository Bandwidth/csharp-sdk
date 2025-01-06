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
    /// If requestId exists, the result for that request is returned. See the Examples for details on the various responses that you can receive. Generally, if you see a Response Code of 0 in a result for a TN, information will be available for it.  Any other Response Code will indicate no information was available for the TN.
    /// </summary>
    [DataContract(Name = "lookupStatus")]
    public partial class LookupStatus : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public LookupStatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LookupStatus" /> class.
        /// </summary>
        /// <param name="requestId">The requestId..</param>
        /// <param name="status">status.</param>
        /// <param name="result">The carrier information results for the specified telephone number..</param>
        /// <param name="failedTelephoneNumbers">The telephone numbers whose lookup failed..</param>
        public LookupStatus(string requestId = default(string), LookupStatusEnum? status = default(LookupStatusEnum?), List<LookupResult> result = default(List<LookupResult>), List<string> failedTelephoneNumbers = default(List<string>))
        {
            this.RequestId = requestId;
            this.Status = status;
            this.Result = result;
            this.FailedTelephoneNumbers = failedTelephoneNumbers;
        }

        /// <summary>
        /// The requestId.
        /// </summary>
        /// <value>The requestId.</value>
        /// <example>004223a0-8b17-41b1-bf81-20732adf5590</example>
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The carrier information results for the specified telephone number.
        /// </summary>
        /// <value>The carrier information results for the specified telephone number.</value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public List<LookupResult> Result { get; set; }

        /// <summary>
        /// The telephone numbers whose lookup failed.
        /// </summary>
        /// <value>The telephone numbers whose lookup failed.</value>
        /// <example>[&quot;+191955512345&quot;]</example>
        [DataMember(Name = "failedTelephoneNumbers", EmitDefaultValue = false)]
        public List<string> FailedTelephoneNumbers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LookupStatus {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  FailedTelephoneNumbers: ").Append(FailedTelephoneNumbers).Append("\n");
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
            yield break;
        }
    }

}