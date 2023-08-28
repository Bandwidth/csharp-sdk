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
    ///  Class for testing CallState
    /// </summary>
    public class CallStateTests : IDisposable
    {
        private CallState instance;

        public CallStateTests()
        {
            instance = new CallState();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CallState
        /// </summary>
        [Fact]
        public void CallStateInstanceTest()
        {
            Assert.IsType<CallState>(instance);
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
        /// Test the property 'ParentCallId'
        /// </summary>
        [Fact]
        public void ParentCallIdTest()
        {
            instance.ParentCallId = "c-1234";
            Assert.IsType<string>(instance.ParentCallId);
            Assert.Equal("c-1234", instance.ParentCallId);
        }
        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            instance.To = "+15551234567";
            Assert.IsType<string>(instance.To);
            Assert.Equal("+15551234567", instance.To);
        }
        /// <summary>
        /// Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            instance.From = "+15557654321";
            Assert.IsType<string>(instance.From);
            Assert.Equal("+15557654321", instance.From);
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
        /// Test the property 'State'
        /// </summary>
        [Fact]
        public void StateTest()
        {
            instance.State = "answered";
            Assert.IsType<string>(instance.State);
            Assert.Equal("answered", instance.State);
        }
        /// <summary>
        /// Test the property 'StirShaken'
        /// </summary>
        [Fact]
        public void StirShakenTest()
        {
            var stirShaken = new Dictionary<string, string>();
            stirShaken.Add("key1", "value1");
            instance.StirShaken = stirShaken;
            Assert.IsType<Dictionary<string, string>>(instance.StirShaken);
            Assert.Equal(stirShaken, instance.StirShaken);
        }
        /// <summary>
        /// Test the property 'Identity'
        /// </summary>
        [Fact]
        public void IdentityTest()
        {
            instance.Identity = "abcdefg1234567";
            Assert.IsType<string>(instance.Identity);
            Assert.Equal("abcdefg1234567", instance.Identity);
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
        /// Test the property 'EndTime'
        /// </summary>
        [Fact]
        public void EndTimeTest()
        {
            instance.EndTime = new DateTime(2020, 1, 1);
            Assert.IsType<DateTime>(instance.EndTime);
            Assert.Equal(new DateTime(2020, 1, 1), instance.EndTime);
        }
        /// <summary>
        /// Test the property 'DisconnectCause'
        /// </summary>
        [Fact]
        public void DisconnectCauseTest()
        {
            instance.DisconnectCause = "| `busy` | Callee was busy. |";
            Assert.IsType<string>(instance.DisconnectCause);
            Assert.Equal("| `busy` | Callee was busy. |", instance.DisconnectCause);
        }
        /// <summary>
        /// Test the property 'ErrorMessage'
        /// </summary>
        [Fact]
        public void ErrorMessageTest()
        {
            instance.ErrorMessage = "error";
            Assert.IsType<string>(instance.ErrorMessage);
            Assert.Equal("error", instance.ErrorMessage);
        }
        /// <summary>
        /// Test the property 'ErrorId'
        /// </summary>
        [Fact]
        public void ErrorIdTest()
        {
            instance.ErrorId = "error-id";
            Assert.IsType<string>(instance.ErrorId);
            Assert.Equal("error-id", instance.ErrorId);
        }
        /// <summary>
        /// Test the property 'LastUpdate'
        /// </summary>
        [Fact]
        public void LastUpdateTest()
        {
            instance.LastUpdate = new DateTime(2020, 1, 1);
            Assert.IsType<DateTime>(instance.LastUpdate);
            Assert.Equal(new DateTime(2020, 1, 1), instance.LastUpdate);
        }

    }

}
