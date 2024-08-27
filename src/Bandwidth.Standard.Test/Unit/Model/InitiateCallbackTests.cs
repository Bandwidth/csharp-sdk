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
    ///  Class for testing InitiateCallback
    /// </summary>
    public class InitiateCallbackTests : IDisposable
    {
        private InitiateCallback instance;

        public InitiateCallbackTests()
        {
            instance = new InitiateCallback();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InitiateCallback
        /// </summary>
        [Fact]
        public void InitiateCallbackInstanceTest()
        {
            Assert.IsType<InitiateCallback>(instance);
        }


        /// <summary>
        /// Test the property 'EventType'
        /// </summary>
        [Fact]
        public void EventTypeTest()
        {
            instance.EventType = "initiate";
            Assert.IsType<string>(instance.EventType);
            Assert.Equal("initiate", instance.EventType);
        }
        /// <summary>
        /// Test the property 'EventTime'
        /// </summary>
        [Fact]
        public void EventTimeTest()
        {
            instance.EventTime = new DateTime(2020, 1, 1);
            Assert.IsType<DateTime>(instance.EventTime);
            Assert.Equal(new DateTime(2020, 1, 1), instance.EventTime);
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
        /// Test the property 'Diversion'
        /// </summary>
        [Fact]
        public void DiversionTest()
        {
            instance.Diversion = new Diversion();
            Assert.IsType<Diversion>(instance.Diversion);
        }
        /// <summary>
        /// Test the property 'StirShaken'
        /// </summary>
        [Fact]
        public void StirShakenTest()
        {
            instance.StirShaken = new StirShaken();
            Assert.IsType<StirShaken>(instance.StirShaken);
        }

    }

}