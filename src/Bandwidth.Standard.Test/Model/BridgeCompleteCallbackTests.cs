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
    ///  Class for testing BridgeCompleteCallback
    /// </summary>
    public class BridgeCompleteCallbackTests : IDisposable
    {
        private BridgeCompleteCallback instance;

        public BridgeCompleteCallbackTests()
        {
            instance = new BridgeCompleteCallback();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BridgeCompleteCallback
        /// </summary>
        [Fact]
        public void BridgeCompleteCallbackInstanceTest()
        {
            Assert.IsType<BridgeCompleteCallback>(instance);
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
            instance.EnqueuedTime = new DateTime(2020, 1, 1);
            Assert.IsType<DateTime>(instance.EnqueuedTime);
            Assert.Equal(new DateTime(2020, 1, 1), instance.EnqueuedTime);
        }
        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            instance.AccountId = "920000";
            Assert.IsType<string>(instance.AccountId);
            Assert.Equal("920000", instance.AccountId);
        }
        /// <summary>
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            instance.ApplicationId = "123-456-abcd";
            Assert.IsType<string>(instance.ApplicationId);
            Assert.Equal("123-456-abcd", instance.ApplicationId);
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
        /// Test the property 'Direction'
        /// </summary>
        [Fact]
        public void DirectionTest()
        {
            instance.Direction = CallDirectionEnum.Inbound;
            Assert.IsType<CallDirectionEnum>(instance.Direction);
            Assert.Equal(CallDirectionEnum.Inbound, instance.Direction);
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
        /// Test the property 'CallUrl'
        /// </summary>
        [Fact]
        public void CallUrlTest()
        {
            instance.CallUrl = "https://test.url/";
            Assert.IsType<string>(instance.CallUrl);
            Assert.Equal("https://test.url/", instance.CallUrl);
        }
        /// <summary>
        /// Test the property 'EnqueuedTime'
        /// </summary>
        [Fact]
        public void EnqueuedTimeTest()
        {
            instance.EnqueuedTime = new DateTime(2020, 1, 1);
            Assert.IsType<DateTime>(instance.EnqueuedTime);
            Assert.Equal(new DateTime(2020, 1, 1), instance.EnqueuedTime);
        }
        /// <summary>
        /// Test the property 'StartTime'
        /// </summary>
        [Fact]
        public void StartTimeTest()
        {
            instance.StartTime = new DateTime(2020, 1, 1);
            Assert.IsType<DateTime>(instance.StartTime);
            Assert.Equal(new DateTime(2020, 1, 1), instance.StartTime);
        }
        /// <summary>
        /// Test the property 'AnswerTime'
        /// </summary>
        [Fact]
        public void AnswerTimeTest()
        {
            instance.AnswerTime = new DateTime(2020, 1, 1);
            Assert.IsType<DateTime>(instance.AnswerTime);
            Assert.Equal(new DateTime(2020, 1, 1), instance.AnswerTime);
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
        /// Test the property 'Cause'
        /// </summary>
        [Fact]
        public void CauseTest()
        {
            instance.Cause = "busy";
            Assert.IsType<string>(instance.Cause);
            Assert.Equal("busy", instance.Cause);
        }
        /// <summary>
        /// Test the property 'ErrorMessage'
        /// </summary>
        [Fact]
        public void ErrorMessageTest()
        {
            instance.ErrorMessage = "Call c-123 is already bridged with another call";
            Assert.IsType<string>(instance.ErrorMessage);
            Assert.Equal("Call c-123 is already bridged with another call", instance.ErrorMessage);
        }
        /// <summary>
        /// Test the property 'ErrorId'
        /// </summary>
        [Fact]
        public void ErrorIdTest()
        {
            instance.ErrorId = "123456";
            Assert.IsType<string>(instance.ErrorId);
            Assert.Equal("123456", instance.ErrorId);
        }

    }

}
