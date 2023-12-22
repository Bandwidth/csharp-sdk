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

namespace Bandwidth.Standard.Test.Model
{
    /// <summary>
    ///  Class for testing InboundMessageCallbackMessage
    /// </summary>
    public class InboundMessageCallbackMessageTests : IDisposable
    {
        private InboundMessageCallbackMessage instance;

        public InboundMessageCallbackMessageTests()
        {
            instance = new InboundMessageCallbackMessage(id: "abc123", owner: "+15553332222", applicationId: "123-456-abcd", to: new List<string> { "+15557654321" }, from: "+15553332222", text: "Hello world");
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InboundMessageCallbackMessage
        /// </summary>
        [Fact]
        public void InboundMessageCallbackMessageInstanceTest()
        {
            Assert.IsType<InboundMessageCallbackMessage>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            Assert.IsType<string>(instance.Id);
            Assert.Equal("abc123", instance.Id);
        }
        /// <summary>
        /// Test the property 'Owner'
        /// </summary>
        [Fact]
        public void OwnerTest()
        {
            Assert.IsType<string>(instance.Owner);
            Assert.Equal("+15553332222", instance.Owner);
        }
        /// <summary>
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            Assert.IsType<string>(instance.ApplicationId);
            Assert.Equal("123-456-abcd", instance.ApplicationId);
        }
        /// <summary>
        /// Test the property 'Time'
        /// </summary>
        [Fact]
        public void TimeTest()
        {
            instance.Time = new DateTime(2020, 1, 1);
            Assert.IsType<DateTime>(instance.Time);
            Assert.Equal(new DateTime(2020, 1, 1), instance.Time);
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
        /// Test the property 'Direction'
        /// </summary>
        [Fact]
        public void DirectionTest()
        {
            instance.Direction = MessageDirectionEnum.In;
            Assert.IsType<MessageDirectionEnum>(instance.Direction);
            Assert.Equal(MessageDirectionEnum.In, instance.Direction);
        }
        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            Assert.IsType<List<string>>(instance.To);
            Assert.Equal(new List<string> { "+15557654321" }, instance.To);
        }
        /// <summary>
        /// Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            Assert.IsType<string>(instance.From);
            Assert.Equal("+15553332222", instance.From);
        }
        /// <summary>
        /// Test the property 'Text'
        /// </summary>
        [Fact]
        public void TextTest()
        {
            Assert.IsType<string>(instance.Text);
            Assert.Equal("Hello world", instance.Text);
        }
        /// <summary>
        /// Test the property 'Tag'
        /// </summary>
        [Fact]
        public void TagTest()
        {
            instance.Tag = "test";
            Assert.IsType<string>(instance.Tag);
            Assert.Equal("test", instance.Tag);
        }
        /// <summary>
        /// Test the property 'Media'
        /// </summary>
        [Fact]
        public void MediaTest()
        {
            instance.Media = new List<string> { "https://test.url/" };
            Assert.IsType<List<string>>(instance.Media);
            Assert.Equal(new List<string> { "https://test.url/" }, instance.Media);
        }
        /// <summary>
        /// Test the property 'Priority'
        /// </summary>
        [Fact]
        public void PriorityTest()
        {
            instance.Priority = PriorityEnum.Default;
            Assert.IsType<PriorityEnum>(instance.Priority);
            Assert.Equal(PriorityEnum.Default, instance.Priority);
        }

    }

}
