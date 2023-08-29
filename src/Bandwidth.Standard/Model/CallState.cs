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
    /// CallState
    /// </summary>
    [DataContract(Name = "callState")]
    public partial class CallState : IEquatable<CallState>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        public CallDirectionEnum? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallState" /> class.
        /// </summary>
        /// <param name="applicationId">The application id associated with the call..</param>
        /// <param name="accountId">The account id associated with the call..</param>
        /// <param name="callId">The programmable voice API call ID..</param>
        /// <param name="parentCallId">The A-leg call id, set only if this call is the B-leg of a [&#x60;&lt;Transfer&gt;&#x60;](/docs/voice/bxml/transfer)..</param>
        /// <param name="to">The phone number that received the call, in E.164 format (e.g. +15555555555), or if the call was to a SIP URI, the SIP URI..</param>
        /// <param name="from">The phone number that made the call, in E.164 format (e.g. +15555555555)..</param>
        /// <param name="direction">direction.</param>
        /// <param name="state">The current state of the call. Current possible values are &#x60;queued&#x60;, &#x60;initiated&#x60;, &#x60;answered&#x60; and &#x60;disconnected&#x60;. Additional states may be added in the future, so your application must be tolerant of unknown values..</param>
        /// <param name="stirShaken">For inbound calls, the Bandwidth STIR/SHAKEN implementation will verify the information provided in the inbound invite request &#x60;Identity&#x60; header. The verification status is stored in the call state &#x60;stirShaken&#x60; property as follows.  | Property          | Description | |:- -- -- -- -- -- -- -- -- -|:- -- -- -- -- -- -| | verstat | (optional) The verification status indicating whether the verification was successful or not. Possible values are &#x60;TN-Verification-Passed&#x60; or &#x60;TN-Verification-Failed&#x60;. | | attestationIndicator | (optional) The attestation level verified by Bandwidth. Possible values are &#x60;A&#x60; (full), &#x60;B&#x60; (partial) or &#x60;C&#x60; (gateway). | | originatingId | (optional) A unique origination identifier. |  Note that these are common properties but that the &#x60;stirShaken&#x60; object is free form and can contain other key-value pairs.  More information: [Understanding STIR/SHAKEN](https://www.bandwidth.com/regulations/stir-shaken)..</param>
        /// <param name="identity">The value of the &#x60;Identity&#x60; header from the inbound invite request. Only present for inbound calls and if the account is configured to forward this header..</param>
        /// <param name="enqueuedTime">The time this call was placed in queue..</param>
        /// <param name="startTime">The time the call was initiated, in ISO 8601 format. &#x60;null&#x60; if the call is still in your queue..</param>
        /// <param name="answerTime">Populated once the call has been answered, with the time in ISO 8601 format..</param>
        /// <param name="endTime">Populated once the call has ended, with the time in ISO 8601 format..</param>
        /// <param name="disconnectCause">| Cause | Description | |:- -- -- -|:- -- -- -- -- -- -| | &#x60;hangup&#x60;| One party hung up the call, a [&#x60;&lt;Hangup&gt;&#x60;](../../bxml/verbs/hangup.md) verb was executed, or there was no more BXML to execute; it indicates that the call ended normally. | | &#x60;busy&#x60; | Callee was busy. | | &#x60;timeout&#x60; | Call wasn&#39;t answered before the &#x60;callTimeout&#x60; was reached. | | &#x60;cancel&#x60; | Call was cancelled by its originator while it was ringing. | | &#x60;rejected&#x60; | Call was rejected by the callee. | | &#x60;callback-error&#x60; | BXML callback couldn&#39;t be delivered to your callback server. | | &#x60;invalid-bxml&#x60; | Invalid BXML was returned in response to a callback. | | &#x60;application-error&#x60; | An unsupported action was tried on the call, e.g. trying to play a .ogg audio. | | &#x60;account-limit&#x60; | Account rate limits were reached. | | &#x60;node-capacity-exceeded&#x60; | System maximum capacity was reached. | | &#x60;error&#x60; | Some error not described in any of the other causes happened on the call. | | &#x60;unknown&#x60; | Unknown error happened on the call. |  Note: This list is not exhaustive and other values can appear in the future..</param>
        /// <param name="errorMessage">Populated only if the call ended with an error, with text explaining the reason..</param>
        /// <param name="errorId">Populated only if the call ended with an error, with a Bandwidth internal id that references the error event..</param>
        /// <param name="lastUpdate">The last time the call had a state update, in ISO 8601 format..</param>
        public CallState(string applicationId = default(string), string accountId = default(string), string callId = default(string), string parentCallId = default(string), string to = default(string), string from = default(string), CallDirectionEnum? direction = default(CallDirectionEnum?), string state = default(string), Dictionary<string, string> stirShaken = default(Dictionary<string, string>), string identity = default(string), DateTime? enqueuedTime = default(DateTime?), DateTime? startTime = default(DateTime?), DateTime? answerTime = default(DateTime?), DateTime? endTime = default(DateTime?), string disconnectCause = default(string), string errorMessage = default(string), string errorId = default(string), DateTime lastUpdate = default(DateTime))
        {
            this.ApplicationId = applicationId;
            this.AccountId = accountId;
            this.CallId = callId;
            this.ParentCallId = parentCallId;
            this.To = to;
            this.From = from;
            this.Direction = direction;
            this.State = state;
            this.StirShaken = stirShaken;
            this.Identity = identity;
            this.EnqueuedTime = enqueuedTime;
            this.StartTime = startTime;
            this.AnswerTime = answerTime;
            this.EndTime = endTime;
            this.DisconnectCause = disconnectCause;
            this.ErrorMessage = errorMessage;
            this.ErrorId = errorId;
            this.LastUpdate = lastUpdate;
        }

        /// <summary>
        /// The application id associated with the call.
        /// </summary>
        /// <value>The application id associated with the call.</value>
        /// <example>04e88489-df02-4e34-a0ee-27a91849555f</example>
        [DataMember(Name = "applicationId", EmitDefaultValue = false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The account id associated with the call.
        /// </summary>
        /// <value>The account id associated with the call.</value>
        /// <example>9900000</example>
        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The programmable voice API call ID.
        /// </summary>
        /// <value>The programmable voice API call ID.</value>
        /// <example>c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85</example>
        [DataMember(Name = "callId", EmitDefaultValue = false)]
        public string CallId { get; set; }

        /// <summary>
        /// The A-leg call id, set only if this call is the B-leg of a [&#x60;&lt;Transfer&gt;&#x60;](/docs/voice/bxml/transfer).
        /// </summary>
        /// <value>The A-leg call id, set only if this call is the B-leg of a [&#x60;&lt;Transfer&gt;&#x60;](/docs/voice/bxml/transfer).</value>
        /// <example>c-25ac29a2-1331029c-2cb0-4a07-b215-b22865662d85</example>
        [DataMember(Name = "parentCallId", EmitDefaultValue = true)]
        public string ParentCallId { get; set; }

        /// <summary>
        /// The phone number that received the call, in E.164 format (e.g. +15555555555), or if the call was to a SIP URI, the SIP URI.
        /// </summary>
        /// <value>The phone number that received the call, in E.164 format (e.g. +15555555555), or if the call was to a SIP URI, the SIP URI.</value>
        /// <example>+19195551234</example>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// The phone number that made the call, in E.164 format (e.g. +15555555555).
        /// </summary>
        /// <value>The phone number that made the call, in E.164 format (e.g. +15555555555).</value>
        /// <example>19195554321</example>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// The current state of the call. Current possible values are &#x60;queued&#x60;, &#x60;initiated&#x60;, &#x60;answered&#x60; and &#x60;disconnected&#x60;. Additional states may be added in the future, so your application must be tolerant of unknown values.
        /// </summary>
        /// <value>The current state of the call. Current possible values are &#x60;queued&#x60;, &#x60;initiated&#x60;, &#x60;answered&#x60; and &#x60;disconnected&#x60;. Additional states may be added in the future, so your application must be tolerant of unknown values.</value>
        /// <example>disconnected</example>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// For inbound calls, the Bandwidth STIR/SHAKEN implementation will verify the information provided in the inbound invite request &#x60;Identity&#x60; header. The verification status is stored in the call state &#x60;stirShaken&#x60; property as follows.  | Property          | Description | |:- -- -- -- -- -- -- -- -- -|:- -- -- -- -- -- -| | verstat | (optional) The verification status indicating whether the verification was successful or not. Possible values are &#x60;TN-Verification-Passed&#x60; or &#x60;TN-Verification-Failed&#x60;. | | attestationIndicator | (optional) The attestation level verified by Bandwidth. Possible values are &#x60;A&#x60; (full), &#x60;B&#x60; (partial) or &#x60;C&#x60; (gateway). | | originatingId | (optional) A unique origination identifier. |  Note that these are common properties but that the &#x60;stirShaken&#x60; object is free form and can contain other key-value pairs.  More information: [Understanding STIR/SHAKEN](https://www.bandwidth.com/regulations/stir-shaken).
        /// </summary>
        /// <value>For inbound calls, the Bandwidth STIR/SHAKEN implementation will verify the information provided in the inbound invite request &#x60;Identity&#x60; header. The verification status is stored in the call state &#x60;stirShaken&#x60; property as follows.  | Property          | Description | |:- -- -- -- -- -- -- -- -- -|:- -- -- -- -- -- -| | verstat | (optional) The verification status indicating whether the verification was successful or not. Possible values are &#x60;TN-Verification-Passed&#x60; or &#x60;TN-Verification-Failed&#x60;. | | attestationIndicator | (optional) The attestation level verified by Bandwidth. Possible values are &#x60;A&#x60; (full), &#x60;B&#x60; (partial) or &#x60;C&#x60; (gateway). | | originatingId | (optional) A unique origination identifier. |  Note that these are common properties but that the &#x60;stirShaken&#x60; object is free form and can contain other key-value pairs.  More information: [Understanding STIR/SHAKEN](https://www.bandwidth.com/regulations/stir-shaken).</value>
        /// <example>{&quot;verstat&quot;:&quot;TN-Verification-Passed&quot;,&quot;attestationIndicator&quot;:&quot;A&quot;,&quot;originatingId&quot;:&quot;abc123&quot;}</example>
        [DataMember(Name = "stirShaken", EmitDefaultValue = true)]
        public Dictionary<string, string> StirShaken { get; set; }

        /// <summary>
        /// The value of the &#x60;Identity&#x60; header from the inbound invite request. Only present for inbound calls and if the account is configured to forward this header.
        /// </summary>
        /// <value>The value of the &#x60;Identity&#x60; header from the inbound invite request. Only present for inbound calls and if the account is configured to forward this header.</value>
        /// <example>eyJhbGciOiJFUzI1NiIsInBwdCI6InNoYWtlbiIsInR5cCI6InBhc3Nwb3J0IiwieDV1IjoiaHR0cHM6Ly9idy1zaGFrZW4tY2VydC1wdWIuczMuYW1hem9uYXdzLmNvbS9iYW5kd2lkdGgtc2hha2VuLWNlcnRfMjAyMzA3MTYucGVtIn0.eyJhdHRlc3QiOiJBIiwiZGVzdCI6eyJ0biI6WyIxOTg0MjgyMDI4MCJdfSwiaWF0IjoxNjU2NTM0MzM2LCJvcmlnIjp7InRuIjoiMTkxOTQ0NDI2ODMifSwib3JpZ2lkIjoiNDk0NTlhOGEtNDJmNi0zNTFjLTkzNjEtYWRmNTdhOWUwOGNhIn0.56un9sRw_uH-sbJvnUsqdevlVxbOVjn8MVlGTlBMicjaZuRRwxfiNp-C9zYCMKTTCbc-QdYPN05F61XNVN4D3w;info&#x3D;&lt;https://bw-shaken-cert-pub.s3.amazonaws.com/bandwidth-shaken-cert_20230716.pem&gt;;alg&#x3D;ES256;ppt&#x3D;shaken</example>
        [DataMember(Name = "identity", EmitDefaultValue = true)]
        public string Identity { get; set; }

        /// <summary>
        /// The time this call was placed in queue.
        /// </summary>
        /// <value>The time this call was placed in queue.</value>
        /// <example>2022-06-16T13:15:07.160Z</example>
        [DataMember(Name = "enqueuedTime", EmitDefaultValue = true)]
        public DateTime? EnqueuedTime { get; set; }

        /// <summary>
        /// The time the call was initiated, in ISO 8601 format. &#x60;null&#x60; if the call is still in your queue.
        /// </summary>
        /// <value>The time the call was initiated, in ISO 8601 format. &#x60;null&#x60; if the call is still in your queue.</value>
        /// <example>2022-06-16T13:15:07.160Z</example>
        [DataMember(Name = "startTime", EmitDefaultValue = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Populated once the call has been answered, with the time in ISO 8601 format.
        /// </summary>
        /// <value>Populated once the call has been answered, with the time in ISO 8601 format.</value>
        /// <example>2022-06-16T13:15:18.126Z</example>
        [DataMember(Name = "answerTime", EmitDefaultValue = true)]
        public DateTime? AnswerTime { get; set; }

        /// <summary>
        /// Populated once the call has ended, with the time in ISO 8601 format.
        /// </summary>
        /// <value>Populated once the call has ended, with the time in ISO 8601 format.</value>
        /// <example>2022-06-16T13:15:18.314Z</example>
        [DataMember(Name = "endTime", EmitDefaultValue = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// | Cause | Description | |:- -- -- -|:- -- -- -- -- -- -| | &#x60;hangup&#x60;| One party hung up the call, a [&#x60;&lt;Hangup&gt;&#x60;](../../bxml/verbs/hangup.md) verb was executed, or there was no more BXML to execute; it indicates that the call ended normally. | | &#x60;busy&#x60; | Callee was busy. | | &#x60;timeout&#x60; | Call wasn&#39;t answered before the &#x60;callTimeout&#x60; was reached. | | &#x60;cancel&#x60; | Call was cancelled by its originator while it was ringing. | | &#x60;rejected&#x60; | Call was rejected by the callee. | | &#x60;callback-error&#x60; | BXML callback couldn&#39;t be delivered to your callback server. | | &#x60;invalid-bxml&#x60; | Invalid BXML was returned in response to a callback. | | &#x60;application-error&#x60; | An unsupported action was tried on the call, e.g. trying to play a .ogg audio. | | &#x60;account-limit&#x60; | Account rate limits were reached. | | &#x60;node-capacity-exceeded&#x60; | System maximum capacity was reached. | | &#x60;error&#x60; | Some error not described in any of the other causes happened on the call. | | &#x60;unknown&#x60; | Unknown error happened on the call. |  Note: This list is not exhaustive and other values can appear in the future.
        /// </summary>
        /// <value>| Cause | Description | |:- -- -- -|:- -- -- -- -- -- -| | &#x60;hangup&#x60;| One party hung up the call, a [&#x60;&lt;Hangup&gt;&#x60;](../../bxml/verbs/hangup.md) verb was executed, or there was no more BXML to execute; it indicates that the call ended normally. | | &#x60;busy&#x60; | Callee was busy. | | &#x60;timeout&#x60; | Call wasn&#39;t answered before the &#x60;callTimeout&#x60; was reached. | | &#x60;cancel&#x60; | Call was cancelled by its originator while it was ringing. | | &#x60;rejected&#x60; | Call was rejected by the callee. | | &#x60;callback-error&#x60; | BXML callback couldn&#39;t be delivered to your callback server. | | &#x60;invalid-bxml&#x60; | Invalid BXML was returned in response to a callback. | | &#x60;application-error&#x60; | An unsupported action was tried on the call, e.g. trying to play a .ogg audio. | | &#x60;account-limit&#x60; | Account rate limits were reached. | | &#x60;node-capacity-exceeded&#x60; | System maximum capacity was reached. | | &#x60;error&#x60; | Some error not described in any of the other causes happened on the call. | | &#x60;unknown&#x60; | Unknown error happened on the call. |  Note: This list is not exhaustive and other values can appear in the future.</value>
        [DataMember(Name = "disconnectCause", EmitDefaultValue = true)]
        public string DisconnectCause { get; set; }

        /// <summary>
        /// Populated only if the call ended with an error, with text explaining the reason.
        /// </summary>
        /// <value>Populated only if the call ended with an error, with text explaining the reason.</value>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Populated only if the call ended with an error, with a Bandwidth internal id that references the error event.
        /// </summary>
        /// <value>Populated only if the call ended with an error, with a Bandwidth internal id that references the error event.</value>
        [DataMember(Name = "errorId", EmitDefaultValue = true)]
        public string ErrorId { get; set; }

        /// <summary>
        /// The last time the call had a state update, in ISO 8601 format.
        /// </summary>
        /// <value>The last time the call had a state update, in ISO 8601 format.</value>
        /// <example>2022-06-16T13:15:18.314Z</example>
        [DataMember(Name = "lastUpdate", EmitDefaultValue = false)]
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CallState {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  ParentCallId: ").Append(ParentCallId).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StirShaken: ").Append(StirShaken).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  EnqueuedTime: ").Append(EnqueuedTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  AnswerTime: ").Append(AnswerTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  DisconnectCause: ").Append(DisconnectCause).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  ErrorId: ").Append(ErrorId).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
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
            return this.Equals(input as CallState);
        }

        /// <summary>
        /// Returns true if CallState instances are equal
        /// </summary>
        /// <param name="input">Instance of CallState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallState input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.CallId == input.CallId ||
                    (this.CallId != null &&
                    this.CallId.Equals(input.CallId))
                ) && 
                (
                    this.ParentCallId == input.ParentCallId ||
                    (this.ParentCallId != null &&
                    this.ParentCallId.Equals(input.ParentCallId))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StirShaken == input.StirShaken ||
                    this.StirShaken != null &&
                    input.StirShaken != null &&
                    this.StirShaken.SequenceEqual(input.StirShaken)
                ) && 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
                ) && 
                (
                    this.EnqueuedTime == input.EnqueuedTime ||
                    (this.EnqueuedTime != null &&
                    this.EnqueuedTime.Equals(input.EnqueuedTime))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.AnswerTime == input.AnswerTime ||
                    (this.AnswerTime != null &&
                    this.AnswerTime.Equals(input.AnswerTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.DisconnectCause == input.DisconnectCause ||
                    (this.DisconnectCause != null &&
                    this.DisconnectCause.Equals(input.DisconnectCause))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.ErrorId == input.ErrorId ||
                    (this.ErrorId != null &&
                    this.ErrorId.Equals(input.ErrorId))
                ) && 
                (
                    this.LastUpdate == input.LastUpdate ||
                    (this.LastUpdate != null &&
                    this.LastUpdate.Equals(input.LastUpdate))
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
                if (this.ApplicationId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationId.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.CallId != null)
                {
                    hashCode = (hashCode * 59) + this.CallId.GetHashCode();
                }
                if (this.ParentCallId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentCallId.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Direction.GetHashCode();
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.StirShaken != null)
                {
                    hashCode = (hashCode * 59) + this.StirShaken.GetHashCode();
                }
                if (this.Identity != null)
                {
                    hashCode = (hashCode * 59) + this.Identity.GetHashCode();
                }
                if (this.EnqueuedTime != null)
                {
                    hashCode = (hashCode * 59) + this.EnqueuedTime.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.AnswerTime != null)
                {
                    hashCode = (hashCode * 59) + this.AnswerTime.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.DisconnectCause != null)
                {
                    hashCode = (hashCode * 59) + this.DisconnectCause.GetHashCode();
                }
                if (this.ErrorMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorMessage.GetHashCode();
                }
                if (this.ErrorId != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorId.GetHashCode();
                }
                if (this.LastUpdate != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdate.GetHashCode();
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
