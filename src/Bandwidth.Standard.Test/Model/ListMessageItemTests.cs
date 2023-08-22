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
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Model;
using Bandwidth.Standard.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Bandwidth.Standard.Test.Model
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
            // TODO unit test for the property 'MessageId'
        }
        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            instance.AccountId = "123-456-abcd";
            Assert.IsType<string>(instance.AccountId);
            Assert.Equal("123-456-abcd", instance.AccountId);
        }
        /// <summary>
        /// Test the property 'SourceTn'
        /// </summary>
        [Fact]
        public void SourceTnTest()
        {
            // TODO unit test for the property 'SourceTn'
        }
        /// <summary>
        /// Test the property 'DestinationTn'
        /// </summary>
        [Fact]
        public void DestinationTnTest()
        {
            // TODO unit test for the property 'DestinationTn'
        }
        /// <summary>
        /// Test the property 'MessageStatus'
        /// </summary>
        [Fact]
        public void MessageStatusTest()
        {
            // TODO unit test for the property 'MessageStatus'
        }
        /// <summary>
        /// Test the property 'MessageDirection'
        /// </summary>
        [Fact]
        public void MessageDirectionTest()
        {
            // TODO unit test for the property 'MessageDirection'
        }
        /// <summary>
        /// Test the property 'MessageType'
        /// </summary>
        [Fact]
        public void MessageTypeTest()
        {
            // TODO unit test for the property 'MessageType'
        }
        /// <summary>
        /// Test the property 'SegmentCount'
        /// </summary>
        [Fact]
        public void SegmentCountTest()
        {
            // TODO unit test for the property 'SegmentCount'
        }
        /// <summary>
        /// Test the property 'ErrorCode'
        /// </summary>
        [Fact]
        public void ErrorCodeTest()
        {
            // TODO unit test for the property 'ErrorCode'
        }
        /// <summary>
        /// Test the property 'ReceiveTime'
        /// </summary>
        [Fact]
        public void ReceiveTimeTest()
        {
            // TODO unit test for the property 'ReceiveTime'
        }
        /// <summary>
        /// Test the property 'CarrierName'
        /// </summary>
        [Fact]
        public void CarrierNameTest()
        {
            // TODO unit test for the property 'CarrierName'
        }
        /// <summary>
        /// Test the property 'MessageSize'
        /// </summary>
        [Fact]
        public void MessageSizeTest()
        {
            // TODO unit test for the property 'MessageSize'
        }
        /// <summary>
        /// Test the property 'MessageLength'
        /// </summary>
        [Fact]
        public void MessageLengthTest()
        {
            // TODO unit test for the property 'MessageLength'
        }
        /// <summary>
        /// Test the property 'AttachmentCount'
        /// </summary>
        [Fact]
        public void AttachmentCountTest()
        {
            // TODO unit test for the property 'AttachmentCount'
        }
        /// <summary>
        /// Test the property 'RecipientCount'
        /// </summary>
        [Fact]
        public void RecipientCountTest()
        {
            // TODO unit test for the property 'RecipientCount'
        }
        /// <summary>
        /// Test the property 'CampaignClass'
        /// </summary>
        [Fact]
        public void CampaignClassTest()
        {
            // TODO unit test for the property 'CampaignClass'
        }

    }

}
