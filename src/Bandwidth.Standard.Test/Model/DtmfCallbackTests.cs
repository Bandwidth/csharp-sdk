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
    ///  Class for testing DtmfCallback
    /// </summary>
    public class DtmfCallbackTests : IDisposable
    {
        private DtmfCallback instance;

        public DtmfCallbackTests()
        {
            instance = new DtmfCallback();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DtmfCallback
        /// </summary>
        [Fact]
        public void DtmfCallbackInstanceTest()
        {
            Assert.IsType<DtmfCallback>(instance);
        }


        /// <summary>
        /// Test the property 'EventType'
        /// </summary>
        [Fact]
        public void EventTypeTest()
        {
            // TODO unit test for the property 'EventType'
        }
        /// <summary>
        /// Test the property 'EventTime'
        /// </summary>
        [Fact]
        public void EventTimeTest()
        {
            // TODO unit test for the property 'EventTime'
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
        /// Test the property 'Digit'
        /// </summary>
        [Fact]
        public void DigitTest()
        {
            // TODO unit test for the property 'Digit'
        }
        /// <summary>
        /// Test the property 'CallUrl'
        /// </summary>
        [Fact]
        public void CallUrlTest()
        {
            // TODO unit test for the property 'CallUrl'
        }
        /// <summary>
        /// Test the property 'EnqueuedTime'
        /// </summary>
        [Fact]
        public void EnqueuedTimeTest()
        {
            // TODO unit test for the property 'EnqueuedTime'
        }
        /// <summary>
        /// Test the property 'StartTime'
        /// </summary>
        [Fact]
        public void StartTimeTest()
        {
            // TODO unit test for the property 'StartTime'
        }
        /// <summary>
        /// Test the property 'AnswerTime'
        /// </summary>
        [Fact]
        public void AnswerTimeTest()
        {
            // TODO unit test for the property 'AnswerTime'
        }
        /// <summary>
        /// Test the property 'ParentCallId'
        /// </summary>
        [Fact]
        public void ParentCallIdTest()
        {
            // TODO unit test for the property 'ParentCallId'
        }
        /// <summary>
        /// Test the property 'TransferCallerId'
        /// </summary>
        [Fact]
        public void TransferCallerIdTest()
        {
            // TODO unit test for the property 'TransferCallerId'
        }
        /// <summary>
        /// Test the property 'TransferTo'
        /// </summary>
        [Fact]
        public void TransferToTest()
        {
            // TODO unit test for the property 'TransferTo'
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
