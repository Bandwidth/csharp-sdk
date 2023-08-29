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
    /// ListMessageItem
    /// </summary>
    [DataContract(Name = "listMessageItem")]
    public partial class ListMessageItem : IEquatable<ListMessageItem>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets MessageStatus
        /// </summary>
        [DataMember(Name = "messageStatus", EmitDefaultValue = false)]
        public MessageStatusEnum? MessageStatus { get; set; }

        /// <summary>
        /// Gets or Sets MessageDirection
        /// </summary>
        [DataMember(Name = "messageDirection", EmitDefaultValue = false)]
        public ListMessageDirectionEnum? MessageDirection { get; set; }

        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [DataMember(Name = "messageType", EmitDefaultValue = false)]
        public MessageTypeEnum? MessageType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListMessageItem" /> class.
        /// </summary>
        /// <param name="messageId">The message id.</param>
        /// <param name="accountId">The account id associated with this message..</param>
        /// <param name="sourceTn">The source phone number of the message..</param>
        /// <param name="destinationTn">The recipient phone number of the message..</param>
        /// <param name="messageStatus">messageStatus.</param>
        /// <param name="messageDirection">messageDirection.</param>
        /// <param name="messageType">messageType.</param>
        /// <param name="segmentCount">The number of segments the message was sent as..</param>
        /// <param name="errorCode">The numeric error code of the message..</param>
        /// <param name="receiveTime">The ISO 8601 datetime of the message..</param>
        /// <param name="carrierName">The name of the carrier. Not currently supported for MMS coming soon..</param>
        /// <param name="messageSize">The size of the message including message content and headers..</param>
        /// <param name="messageLength">The length of the message content..</param>
        /// <param name="attachmentCount">The number of attachments the message has..</param>
        /// <param name="recipientCount">The number of recipients the message has..</param>
        /// <param name="campaignClass">The campaign class of the message if it has one..</param>
        /// <param name="campaignId">The campaign ID of the message if it has one..</param>
        public ListMessageItem(string messageId = default(string), string accountId = default(string), string sourceTn = default(string), string destinationTn = default(string), MessageStatusEnum? messageStatus = default(MessageStatusEnum?), ListMessageDirectionEnum? messageDirection = default(ListMessageDirectionEnum?), MessageTypeEnum? messageType = default(MessageTypeEnum?), int segmentCount = default(int), int errorCode = default(int), DateTime receiveTime = default(DateTime), string carrierName = default(string), int? messageSize = default(int?), int messageLength = default(int), int? attachmentCount = default(int?), int? recipientCount = default(int?), string campaignClass = default(string), string campaignId = default(string))
        {
            this.MessageId = messageId;
            this.AccountId = accountId;
            this.SourceTn = sourceTn;
            this.DestinationTn = destinationTn;
            this.MessageStatus = messageStatus;
            this.MessageDirection = messageDirection;
            this.MessageType = messageType;
            this.SegmentCount = segmentCount;
            this.ErrorCode = errorCode;
            this.ReceiveTime = receiveTime;
            this.CarrierName = carrierName;
            this.MessageSize = messageSize;
            this.MessageLength = messageLength;
            this.AttachmentCount = attachmentCount;
            this.RecipientCount = recipientCount;
            this.CampaignClass = campaignClass;
            this.CampaignId = campaignId;
        }

        /// <summary>
        /// The message id
        /// </summary>
        /// <value>The message id</value>
        /// <example>1589228074636lm4k2je7j7jklbn2</example>
        [DataMember(Name = "messageId", EmitDefaultValue = false)]
        public string MessageId { get; set; }

        /// <summary>
        /// The account id associated with this message.
        /// </summary>
        /// <value>The account id associated with this message.</value>
        /// <example>9900000</example>
        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The source phone number of the message.
        /// </summary>
        /// <value>The source phone number of the message.</value>
        /// <example>+15554443333</example>
        [DataMember(Name = "sourceTn", EmitDefaultValue = false)]
        public string SourceTn { get; set; }

        /// <summary>
        /// The recipient phone number of the message.
        /// </summary>
        /// <value>The recipient phone number of the message.</value>
        /// <example>+15554442222</example>
        [DataMember(Name = "destinationTn", EmitDefaultValue = false)]
        public string DestinationTn { get; set; }

        /// <summary>
        /// The number of segments the message was sent as.
        /// </summary>
        /// <value>The number of segments the message was sent as.</value>
        /// <example>1</example>
        [DataMember(Name = "segmentCount", EmitDefaultValue = false)]
        public int SegmentCount { get; set; }

        /// <summary>
        /// The numeric error code of the message.
        /// </summary>
        /// <value>The numeric error code of the message.</value>
        /// <example>9902</example>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public int ErrorCode { get; set; }

        /// <summary>
        /// The ISO 8601 datetime of the message.
        /// </summary>
        /// <value>The ISO 8601 datetime of the message.</value>
        /// <example>2020-04-07T14:03:07Z</example>
        [DataMember(Name = "receiveTime", EmitDefaultValue = false)]
        public DateTime ReceiveTime { get; set; }

        /// <summary>
        /// The name of the carrier. Not currently supported for MMS coming soon.
        /// </summary>
        /// <value>The name of the carrier. Not currently supported for MMS coming soon.</value>
        /// <example>other</example>
        [DataMember(Name = "carrierName", EmitDefaultValue = true)]
        public string CarrierName { get; set; }

        /// <summary>
        /// The size of the message including message content and headers.
        /// </summary>
        /// <value>The size of the message including message content and headers.</value>
        /// <example>27</example>
        [DataMember(Name = "messageSize", EmitDefaultValue = true)]
        public int? MessageSize { get; set; }

        /// <summary>
        /// The length of the message content.
        /// </summary>
        /// <value>The length of the message content.</value>
        /// <example>18</example>
        [DataMember(Name = "messageLength", EmitDefaultValue = false)]
        public int MessageLength { get; set; }

        /// <summary>
        /// The number of attachments the message has.
        /// </summary>
        /// <value>The number of attachments the message has.</value>
        /// <example>1</example>
        [DataMember(Name = "attachmentCount", EmitDefaultValue = true)]
        public int? AttachmentCount { get; set; }

        /// <summary>
        /// The number of recipients the message has.
        /// </summary>
        /// <value>The number of recipients the message has.</value>
        /// <example>1</example>
        [DataMember(Name = "recipientCount", EmitDefaultValue = true)]
        public int? RecipientCount { get; set; }

        /// <summary>
        /// The campaign class of the message if it has one.
        /// </summary>
        /// <value>The campaign class of the message if it has one.</value>
        /// <example>T</example>
        [DataMember(Name = "campaignClass", EmitDefaultValue = true)]
        public string CampaignClass { get; set; }

        /// <summary>
        /// The campaign ID of the message if it has one.
        /// </summary>
        /// <value>The campaign ID of the message if it has one.</value>
        /// <example>CJEUMDK</example>
        [DataMember(Name = "campaignId", EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListMessageItem {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  SourceTn: ").Append(SourceTn).Append("\n");
            sb.Append("  DestinationTn: ").Append(DestinationTn).Append("\n");
            sb.Append("  MessageStatus: ").Append(MessageStatus).Append("\n");
            sb.Append("  MessageDirection: ").Append(MessageDirection).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  SegmentCount: ").Append(SegmentCount).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ReceiveTime: ").Append(ReceiveTime).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  MessageSize: ").Append(MessageSize).Append("\n");
            sb.Append("  MessageLength: ").Append(MessageLength).Append("\n");
            sb.Append("  AttachmentCount: ").Append(AttachmentCount).Append("\n");
            sb.Append("  RecipientCount: ").Append(RecipientCount).Append("\n");
            sb.Append("  CampaignClass: ").Append(CampaignClass).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
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
            return this.Equals(input as ListMessageItem);
        }

        /// <summary>
        /// Returns true if ListMessageItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ListMessageItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListMessageItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.SourceTn == input.SourceTn ||
                    (this.SourceTn != null &&
                    this.SourceTn.Equals(input.SourceTn))
                ) && 
                (
                    this.DestinationTn == input.DestinationTn ||
                    (this.DestinationTn != null &&
                    this.DestinationTn.Equals(input.DestinationTn))
                ) && 
                (
                    this.MessageStatus == input.MessageStatus ||
                    this.MessageStatus.Equals(input.MessageStatus)
                ) && 
                (
                    this.MessageDirection == input.MessageDirection ||
                    this.MessageDirection.Equals(input.MessageDirection)
                ) && 
                (
                    this.MessageType == input.MessageType ||
                    this.MessageType.Equals(input.MessageType)
                ) && 
                (
                    this.SegmentCount == input.SegmentCount ||
                    this.SegmentCount.Equals(input.SegmentCount)
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    this.ErrorCode.Equals(input.ErrorCode)
                ) && 
                (
                    this.ReceiveTime == input.ReceiveTime ||
                    (this.ReceiveTime != null &&
                    this.ReceiveTime.Equals(input.ReceiveTime))
                ) && 
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
                ) && 
                (
                    this.MessageSize == input.MessageSize ||
                    (this.MessageSize != null &&
                    this.MessageSize.Equals(input.MessageSize))
                ) && 
                (
                    this.MessageLength == input.MessageLength ||
                    this.MessageLength.Equals(input.MessageLength)
                ) && 
                (
                    this.AttachmentCount == input.AttachmentCount ||
                    (this.AttachmentCount != null &&
                    this.AttachmentCount.Equals(input.AttachmentCount))
                ) && 
                (
                    this.RecipientCount == input.RecipientCount ||
                    (this.RecipientCount != null &&
                    this.RecipientCount.Equals(input.RecipientCount))
                ) && 
                (
                    this.CampaignClass == input.CampaignClass ||
                    (this.CampaignClass != null &&
                    this.CampaignClass.Equals(input.CampaignClass))
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
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
                if (this.MessageId != null)
                {
                    hashCode = (hashCode * 59) + this.MessageId.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.SourceTn != null)
                {
                    hashCode = (hashCode * 59) + this.SourceTn.GetHashCode();
                }
                if (this.DestinationTn != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationTn.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MessageStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.MessageDirection.GetHashCode();
                hashCode = (hashCode * 59) + this.MessageType.GetHashCode();
                hashCode = (hashCode * 59) + this.SegmentCount.GetHashCode();
                hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                if (this.ReceiveTime != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiveTime.GetHashCode();
                }
                if (this.CarrierName != null)
                {
                    hashCode = (hashCode * 59) + this.CarrierName.GetHashCode();
                }
                if (this.MessageSize != null)
                {
                    hashCode = (hashCode * 59) + this.MessageSize.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MessageLength.GetHashCode();
                if (this.AttachmentCount != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentCount.GetHashCode();
                }
                if (this.RecipientCount != null)
                {
                    hashCode = (hashCode * 59) + this.RecipientCount.GetHashCode();
                }
                if (this.CampaignClass != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignClass.GetHashCode();
                }
                if (this.CampaignId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignId.GetHashCode();
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
