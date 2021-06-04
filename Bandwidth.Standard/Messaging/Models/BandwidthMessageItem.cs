// <copyright file="BandwidthMessageItem.cs" company="APIMatic">
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
    /// BandwidthMessageItem.
    /// </summary>
    public class BandwidthMessageItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BandwidthMessageItem"/> class.
        /// </summary>
        public BandwidthMessageItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BandwidthMessageItem"/> class.
        /// </summary>
        /// <param name="messageId">messageId.</param>
        /// <param name="accountId">accountId.</param>
        /// <param name="sourceTn">sourceTn.</param>
        /// <param name="destinationTn">destinationTn.</param>
        /// <param name="messageStatus">messageStatus.</param>
        /// <param name="messageDirection">messageDirection.</param>
        /// <param name="messageType">messageType.</param>
        /// <param name="segmentCount">segmentCount.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="receiveTime">receiveTime.</param>
        /// <param name="carrierName">carrierName.</param>
        /// <param name="messageSize">messageSize.</param>
        /// <param name="messageLength">messageLength.</param>
        /// <param name="attachmentCount">attachmentCount.</param>
        /// <param name="recipientCount">recipientCount.</param>
        /// <param name="campaignClass">campaignClass.</param>
        public BandwidthMessageItem(
            string messageId = null,
            string accountId = null,
            string sourceTn = null,
            string destinationTn = null,
            string messageStatus = null,
            string messageDirection = null,
            string messageType = null,
            int? segmentCount = null,
            int? errorCode = null,
            string receiveTime = null,
            string carrierName = null,
            int? messageSize = null,
            int? messageLength = null,
            int? attachmentCount = null,
            int? recipientCount = null,
            string campaignClass = null)
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
        }

        /// <summary>
        /// The message id
        /// </summary>
        [JsonProperty("messageId", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageId { get; set; }

        /// <summary>
        /// The account id of the message
        /// </summary>
        [JsonProperty("accountId", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// The source phone number of the message
        /// </summary>
        [JsonProperty("sourceTn", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceTn { get; set; }

        /// <summary>
        /// The recipient phone number of the message
        /// </summary>
        [JsonProperty("destinationTn", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationTn { get; set; }

        /// <summary>
        /// The status of the message
        /// </summary>
        [JsonProperty("messageStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageStatus { get; set; }

        /// <summary>
        /// The direction of the message relative to Bandwidth. INBOUND or OUTBOUND
        /// </summary>
        [JsonProperty("messageDirection", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageDirection { get; set; }

        /// <summary>
        /// The type of message. sms or mms
        /// </summary>
        [JsonProperty("messageType", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageType { get; set; }

        /// <summary>
        /// The number of segments the message was sent as
        /// </summary>
        [JsonProperty("segmentCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? SegmentCount { get; set; }

        /// <summary>
        /// The numeric error code of the message
        /// </summary>
        [JsonProperty("errorCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// The ISO 8601 datetime of the message
        /// </summary>
        [JsonProperty("receiveTime", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// The name of the carrier. Not currently supported for MMS, coming soon
        /// </summary>
        [JsonProperty("carrierName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierName { get; set; }

        /// <summary>
        /// The size of the message including message content and headers
        /// </summary>
        [JsonProperty("messageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? MessageSize { get; set; }

        /// <summary>
        /// The length of the message content
        /// </summary>
        [JsonProperty("messageLength", NullValueHandling = NullValueHandling.Ignore)]
        public int? MessageLength { get; set; }

        /// <summary>
        /// The number of attachments the message has
        /// </summary>
        [JsonProperty("attachmentCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachmentCount { get; set; }

        /// <summary>
        /// The number of recipients the message has
        /// </summary>
        [JsonProperty("recipientCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecipientCount { get; set; }

        /// <summary>
        /// The campaign class of the message, if it has one
        /// </summary>
        [JsonProperty("campaignClass", NullValueHandling = NullValueHandling.Ignore)]
        public string CampaignClass { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BandwidthMessageItem : ({string.Join(", ", toStringOutput)})";
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

            return obj is BandwidthMessageItem other &&
                ((this.MessageId == null && other.MessageId == null) || (this.MessageId?.Equals(other.MessageId) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.SourceTn == null && other.SourceTn == null) || (this.SourceTn?.Equals(other.SourceTn) == true)) &&
                ((this.DestinationTn == null && other.DestinationTn == null) || (this.DestinationTn?.Equals(other.DestinationTn) == true)) &&
                ((this.MessageStatus == null && other.MessageStatus == null) || (this.MessageStatus?.Equals(other.MessageStatus) == true)) &&
                ((this.MessageDirection == null && other.MessageDirection == null) || (this.MessageDirection?.Equals(other.MessageDirection) == true)) &&
                ((this.MessageType == null && other.MessageType == null) || (this.MessageType?.Equals(other.MessageType) == true)) &&
                ((this.SegmentCount == null && other.SegmentCount == null) || (this.SegmentCount?.Equals(other.SegmentCount) == true)) &&
                ((this.ErrorCode == null && other.ErrorCode == null) || (this.ErrorCode?.Equals(other.ErrorCode) == true)) &&
                ((this.ReceiveTime == null && other.ReceiveTime == null) || (this.ReceiveTime?.Equals(other.ReceiveTime) == true)) &&
                ((this.CarrierName == null && other.CarrierName == null) || (this.CarrierName?.Equals(other.CarrierName) == true)) &&
                ((this.MessageSize == null && other.MessageSize == null) || (this.MessageSize?.Equals(other.MessageSize) == true)) &&
                ((this.MessageLength == null && other.MessageLength == null) || (this.MessageLength?.Equals(other.MessageLength) == true)) &&
                ((this.AttachmentCount == null && other.AttachmentCount == null) || (this.AttachmentCount?.Equals(other.AttachmentCount) == true)) &&
                ((this.RecipientCount == null && other.RecipientCount == null) || (this.RecipientCount?.Equals(other.RecipientCount) == true)) &&
                ((this.CampaignClass == null && other.CampaignClass == null) || (this.CampaignClass?.Equals(other.CampaignClass) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1624510059;

            if (this.MessageId != null)
            {
               hashCode += this.MessageId.GetHashCode();
            }

            if (this.AccountId != null)
            {
               hashCode += this.AccountId.GetHashCode();
            }

            if (this.SourceTn != null)
            {
               hashCode += this.SourceTn.GetHashCode();
            }

            if (this.DestinationTn != null)
            {
               hashCode += this.DestinationTn.GetHashCode();
            }

            if (this.MessageStatus != null)
            {
               hashCode += this.MessageStatus.GetHashCode();
            }

            if (this.MessageDirection != null)
            {
               hashCode += this.MessageDirection.GetHashCode();
            }

            if (this.MessageType != null)
            {
               hashCode += this.MessageType.GetHashCode();
            }

            if (this.SegmentCount != null)
            {
               hashCode += this.SegmentCount.GetHashCode();
            }

            if (this.ErrorCode != null)
            {
               hashCode += this.ErrorCode.GetHashCode();
            }

            if (this.ReceiveTime != null)
            {
               hashCode += this.ReceiveTime.GetHashCode();
            }

            if (this.CarrierName != null)
            {
               hashCode += this.CarrierName.GetHashCode();
            }

            if (this.MessageSize != null)
            {
               hashCode += this.MessageSize.GetHashCode();
            }

            if (this.MessageLength != null)
            {
               hashCode += this.MessageLength.GetHashCode();
            }

            if (this.AttachmentCount != null)
            {
               hashCode += this.AttachmentCount.GetHashCode();
            }

            if (this.RecipientCount != null)
            {
               hashCode += this.RecipientCount.GetHashCode();
            }

            if (this.CampaignClass != null)
            {
               hashCode += this.CampaignClass.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MessageId = {(this.MessageId == null ? "null" : this.MessageId == string.Empty ? "" : this.MessageId)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId == string.Empty ? "" : this.AccountId)}");
            toStringOutput.Add($"this.SourceTn = {(this.SourceTn == null ? "null" : this.SourceTn == string.Empty ? "" : this.SourceTn)}");
            toStringOutput.Add($"this.DestinationTn = {(this.DestinationTn == null ? "null" : this.DestinationTn == string.Empty ? "" : this.DestinationTn)}");
            toStringOutput.Add($"this.MessageStatus = {(this.MessageStatus == null ? "null" : this.MessageStatus == string.Empty ? "" : this.MessageStatus)}");
            toStringOutput.Add($"this.MessageDirection = {(this.MessageDirection == null ? "null" : this.MessageDirection == string.Empty ? "" : this.MessageDirection)}");
            toStringOutput.Add($"this.MessageType = {(this.MessageType == null ? "null" : this.MessageType == string.Empty ? "" : this.MessageType)}");
            toStringOutput.Add($"this.SegmentCount = {(this.SegmentCount == null ? "null" : this.SegmentCount.ToString())}");
            toStringOutput.Add($"this.ErrorCode = {(this.ErrorCode == null ? "null" : this.ErrorCode.ToString())}");
            toStringOutput.Add($"this.ReceiveTime = {(this.ReceiveTime == null ? "null" : this.ReceiveTime == string.Empty ? "" : this.ReceiveTime)}");
            toStringOutput.Add($"this.CarrierName = {(this.CarrierName == null ? "null" : this.CarrierName == string.Empty ? "" : this.CarrierName)}");
            toStringOutput.Add($"this.MessageSize = {(this.MessageSize == null ? "null" : this.MessageSize.ToString())}");
            toStringOutput.Add($"this.MessageLength = {(this.MessageLength == null ? "null" : this.MessageLength.ToString())}");
            toStringOutput.Add($"this.AttachmentCount = {(this.AttachmentCount == null ? "null" : this.AttachmentCount.ToString())}");
            toStringOutput.Add($"this.RecipientCount = {(this.RecipientCount == null ? "null" : this.RecipientCount.ToString())}");
            toStringOutput.Add($"this.CampaignClass = {(this.CampaignClass == null ? "null" : this.CampaignClass == string.Empty ? "" : this.CampaignClass)}");
        }
    }
}