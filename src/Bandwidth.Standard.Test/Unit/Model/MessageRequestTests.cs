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
    ///  Class for testing MessageRequest
    /// </summary>
    public class MessageRequestTests : IDisposable
    {
        private MessageRequest instance;

        public MessageRequestTests()
        {
            instance = new MessageRequest(
                applicationId: "123-456-abcd",
                to: new List<string> { "+15557654321" },
                from: "+15551113333"
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MessageRequest
        /// </summary>
        [Fact]
        public void MessageRequestInstanceTest()
        {
            Assert.IsType<MessageRequest>(instance);
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
            Assert.Equal("+15551113333", instance.From);
        }
        /// <summary>
        /// Test the property 'Text'
        /// </summary>
        [Fact]
        public void TextTest()
        {
            instance.Text = "Hello world";
            Assert.IsType<string>(instance.Text);
            Assert.Equal("Hello world", instance.Text);
        }
        /// <summary>
        /// Test the property 'Media'
        /// </summary>
        [Fact]
        public void MediaTest()
        {
            instance.Media = new List<string> { "https://test.com" };
            Assert.IsType<List<string>>(instance.Media);
            Assert.Equal(new List<string> { "https://test.com" }, instance.Media);
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
        /// Test the property 'Priority'
        /// </summary>
        [Fact]
        public void PriorityTest()
        {
            instance.Priority = PriorityEnum.Default;
            Assert.IsType<PriorityEnum>(instance.Priority);
            Assert.Equal(PriorityEnum.Default, instance.Priority);
        }
        /// <summary>
        /// Test the property 'Expiration'
        /// </summary>
        [Fact]
        public void ExpirationTest()
        {
            instance.Expiration = new DateTime(2020, 1, 1);
            Assert.IsType<DateTime>(instance.Expiration);
            Assert.Equal(new DateTime(2020, 1, 1), instance.Expiration);
        }

    }

}
