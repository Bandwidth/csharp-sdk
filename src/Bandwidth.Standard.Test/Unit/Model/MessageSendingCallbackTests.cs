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
    ///  Class for testing MessageSendingCallback
    /// </summary>
    public class MessageSendingCallbackTests : IDisposable
    {
        private MessageSendingCallback instance;

        public MessageSendingCallbackTests()
        {
            instance = new MessageSendingCallback(type: "message-sending", to: "+15552223333", description: "Message is sending to carrier", message: new MessageSendingCallbackMessage(id: "1661365814859loidf7mcwd4qacn7", owner: "+15553332222", applicationId: "93de2206-9669-4e07-948d-329f4b722ee", to: new List<string> { "15557654321" }, from: "+15553332222", text: "Hello world", media: new List<string> { "https://test.url/" }));
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MessageSendingCallback
        /// </summary>
        [Fact]
        public void MessageSendingCallbackInstanceTest()
        {
            Assert.IsType<MessageSendingCallback>(instance);
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
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            Assert.IsType<string>(instance.Type);
            Assert.Equal("message-sending", instance.Type);
        }
        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            Assert.IsType<string>(instance.To);
            Assert.Equal("+15552223333", instance.To);
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            Assert.IsType<string>(instance.Description);
            Assert.Equal("Message is sending to carrier", instance.Description);
        }
        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            Assert.IsType<MessageSendingCallbackMessage>(instance.Message);
        }

    }

}