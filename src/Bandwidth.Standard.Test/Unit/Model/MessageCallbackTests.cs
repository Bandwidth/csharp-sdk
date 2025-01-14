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
    ///  Class for testing MessageCallback
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MessageCallbackTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MessageCallback
        //private MessageCallback instance;

        public MessageCallbackTests()
        {
            instance = new MessageCallback();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MessageCallback
        /// </summary>
        [Fact]
        public void MessageCallbackInstanceTest()
        {
            Assert.IsType<MessageCallback>(instance);
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
            instance.Type = CallbackTypeEnum.Received;
            Assert.IsType<CallbackTypeEnum>(instance.Type);
            Assert.Equal(CallbackTypeEnum.Received, instance.Type);
        }

        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            instance.To = "+19195551234"
            Assert.IsType<string>(instance.To);
            Assert.Equal("+19195551234", instance.To);
        }

        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            instance.Description = "test";
            Assert.IsType<string>(instance.Description);
            Assert.Equal("test", instance.Description);
        }

        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            instance.Message = "test";
            Assert.IsType<string>(instance.Message);
            Assert.Equal("test", instance.Message);
        }

        /// <summary>
        /// Test the property 'ErrorCode'
        /// </summary>
        [Fact]
        public void ErrorCodeTest()
        {
            instance.ErrorCode = 123;
            Assert.IsType<int>(instance.ErrorCode);
            Assert.Equal(123, instance.ErrorCode);
        }
    }
}
