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
    ///  Class for testing ConferenceMemberExitCallback
    /// </summary>
    public class ConferenceMemberExitCallbackTests : IDisposable
    {
        private ConferenceMemberExitCallback instance;

        public ConferenceMemberExitCallbackTests()
        {
            instance = new ConferenceMemberExitCallback();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConferenceMemberExitCallback
        /// </summary>
        [Fact]
        public void ConferenceMemberExitCallbackInstanceTest()
        {
            Assert.IsType<ConferenceMemberExitCallback>(instance);
        }


        /// <summary>
        /// Test the property 'EventType'
        /// </summary>
        [Fact]
        public void EventTypeTest()
        {
            instance.EventType = "bridgeComplete";
            Assert.IsType<string>(instance.EventType);
            Assert.Equal("bridgeComplete", instance.EventType);
        }
        /// <summary>
        /// Test the property 'EventTime'
        /// </summary>
        [Fact]
        public void EventTimeTest()
        {
            var date = new DateTime(2020, 1, 1);
            instance.EventTime = date;
            Assert.IsType<DateTime>(instance.EventTime);
            Assert.Equal(date, instance.EventTime);
        }
        /// <summary>
        /// Test the property 'ConferenceId'
        /// </summary>
        [Fact]
        public void ConferenceIdTest()
        {
            instance.ConferenceId = "conf-123";
            Assert.IsType<string>(instance.ConferenceId);
            Assert.Equal("conf-123", instance.ConferenceId);
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            instance.Name = "my-conference-name";
            Assert.IsType<string>(instance.Name);
            Assert.Equal("my-conference-name", instance.Name);
        }
        /// <summary>
        /// Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            instance.From = "+15551234567";
            Assert.IsType<string>(instance.From);
            Assert.Equal("+15551234567", instance.From);
        }
        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            instance.To = "+15557654321";
            Assert.IsType<string>(instance.To);
            Assert.Equal("+15557654321", instance.To);
        }
        /// <summary>
        /// Test the property 'CallId'
        /// </summary>
        [Fact]
        public void CallIdTest()
        {
            instance.CallId = "c-1234";
            Assert.IsType<string>(instance.CallId);
            Assert.Equal("c-1234", instance.CallId);
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
    }
}
