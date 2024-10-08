/*
 * Bandwidth
 *
 * Bandwidth's Communication APIs
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: letstalk@bandwidth.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Bandwidth.Standard.Model;
using Bandwidth.Standard.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Bandwidth.Standard.Test.Unit.Model
{
    /// <summary>
    ///  Class for testing ListMessageItem
    /// </summary>
    public class ListMessageItemTests : IDisposable
    {
        private ListMessageItem instance;

        public ListMessageItemTests()
        {
            instance = new ListMessageItem();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ListMessageItem
        /// </summary>
        [Fact]
        public void ListMessageItemInstanceTest()
        {
            Assert.IsType<ListMessageItem>(instance);
        }


        /// <summary>
        /// Test the property 'MessageId'
        /// </summary>
        [Fact]
        public void MessageIdTest()
        {
            instance.MessageId = "1234";
            Assert.IsType<string>(instance.MessageId);
            Assert.Equal("1234", instance.MessageId);
        }
        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            instance.AccountId = "1234";
            Assert.IsType<string>(instance.AccountId);
            Assert.Equal("1234", instance.AccountId);
        }
        /// <summary>
        /// Test the property 'SourceTn'
        /// </summary>
        [Fact]
        public void SourceTnTest()
        {
            instance.SourceTn = "+15551234567";
            Assert.IsType<string>(instance.SourceTn);
            Assert.Equal("+15551234567", instance.SourceTn);
        }
        /// <summary>
        /// Test the property 'DestinationTn'
        /// </summary>
        [Fact]
        public void DestinationTnTest()
        {
            instance.DestinationTn = "+15557654321";
            Assert.IsType<string>(instance.DestinationTn);
            Assert.Equal("+15557654321", instance.DestinationTn);
        }
        /// <summary>
        /// Test the property 'MessageStatus'
        /// </summary>
        [Fact]
        public void MessageStatusTest()
        {
            instance.MessageStatus = MessageStatusEnum.RECEIVED;
            Assert.IsType<MessageStatusEnum>(instance.MessageStatus);
            Assert.Equal(MessageStatusEnum.RECEIVED, instance.MessageStatus);
        }
        /// <summary>
        /// Test the property 'MessageDirection'
        /// </summary>
        [Fact]
        public void MessageDirectionTest()
        {
            instance.MessageDirection = ListMessageDirectionEnum.INBOUND;
            Assert.IsType<ListMessageDirectionEnum>(instance.MessageDirection);
            Assert.Equal(ListMessageDirectionEnum.INBOUND, instance.MessageDirection);
        }
        /// <summary>
        /// Test the property 'MessageType'
        /// </summary>
        [Fact]
        public void MessageTypeTest()
        {
            instance.MessageType = MessageTypeEnum.Sms;
            Assert.IsType<MessageTypeEnum>(instance.MessageType);
            Assert.Equal(MessageTypeEnum.Sms, instance.MessageType);
        }
        /// <summary>
        /// Test the property 'SegmentCount'
        /// </summary>
        [Fact]
        public void SegmentCountTest()
        {
            instance.SegmentCount = 1;
            Assert.IsType<int>(instance.SegmentCount);
            Assert.Equal(1, instance.SegmentCount);
        }
        /// <summary>
        /// Test the property 'ErrorCode'
        /// </summary>
        [Fact]
        public void ErrorCodeTest()
        {
            instance.ErrorCode = 9902;
            Assert.IsType<int>(instance.ErrorCode);
            Assert.Equal(9902, instance.ErrorCode);
        }
        /// <summary>
        /// Test the property 'ReceiveTime'
        /// </summary>
        [Fact]
        public void ReceiveTimeTest()
        {
            instance.ReceiveTime = new DateTime(2020, 1, 1);
            Assert.IsType<DateTime>(instance.ReceiveTime);
            Assert.Equal(new DateTime(2020, 1, 1), instance.ReceiveTime);
        }
        /// <summary>
        /// Test the property 'CarrierName'
        /// </summary>
        [Fact]
        public void CarrierNameTest()
        {
            instance.CarrierName = "other";
            Assert.IsType<string>(instance.CarrierName);
            Assert.Equal("other", instance.CarrierName);
        }
        /// <summary>
        /// Test the property 'MessageSize'
        /// </summary>
        [Fact]
        public void MessageSizeTest()
        {
            instance.MessageSize = 27;
            Assert.IsType<int>(instance.MessageSize);
            Assert.Equal(27, instance.MessageSize);
        }
        /// <summary>
        /// Test the property 'MessageLength'
        /// </summary>
        [Fact]
        public void MessageLengthTest()
        {
            instance.MessageLength = 27;
            Assert.IsType<int>(instance.MessageLength);
            Assert.Equal(27, instance.MessageLength);
        }
        /// <summary>
        /// Test the property 'AttachmentCount'
        /// </summary>
        [Fact]
        public void AttachmentCountTest()
        {
            instance.AttachmentCount = 1;
            Assert.IsType<int>(instance.AttachmentCount);
            Assert.Equal(1, instance.AttachmentCount);
        }
        /// <summary>
        /// Test the property 'RecipientCount'
        /// </summary>
        [Fact]
        public void RecipientCountTest()
        {
            instance.RecipientCount = 1;
            Assert.IsType<int>(instance.RecipientCount);
            Assert.Equal(1, instance.RecipientCount);
        }
        /// <summary>
        /// Test the property 'CampaignClass'
        /// </summary>
        [Fact]
        public void CampaignClassTest()
        {
            instance.CampaignClass = "T";
            Assert.IsType<string>(instance.CampaignClass);
            Assert.Equal("T", instance.CampaignClass);
        }
        /// <summary>
        /// Test the property 'CampaignId'
        /// </summary>
        [Fact]
        public void CampaignIdTest()
        {
            instance.CampaignId = "CJEUMDK";
            Assert.IsType<string>(instance.CampaignId);
            Assert.Equal("CJEUMDK", instance.CampaignId);
        }

    }

}
