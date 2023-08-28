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
    ///  Class for testing CreateCallResponse
    /// </summary>
    public class CreateCallResponseTests : IDisposable
    {
        private CreateCallResponse instance;

        public CreateCallResponseTests()
        {
            instance = new CreateCallResponse(applicationId: "04e88489-df02-4e34-a0ee-27a91849555f", accountId: "04e88489-df02-4e34-a0ee-27a91849555f", callId: "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85", to: "+19195551234", from: "+19195554321", callUrl: "https://voice.bandwidth.com/api/v2/accounts/9900000/calls/c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85", answerUrl: "https://myServer.example/bandwidth/webhooks/answer");
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateCallResponse
        /// </summary>
        [Fact]
        public void CreateCallResponseInstanceTest()
        {
            Assert.IsType<CreateCallResponse>(instance);
        }


        /// <summary>
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            Assert.IsType<string>(instance.ApplicationId);
            Assert.Equal("04e88489-df02-4e34-a0ee-27a91849555f", instance.ApplicationId);
        }
        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            Assert.IsType<string>(instance.AccountId);
            Assert.Equal("04e88489-df02-4e34-a0ee-27a91849555f", instance.AccountId);
        }
        /// <summary>
        /// Test the property 'CallId'
        /// </summary>
        [Fact]
        public void CallIdTest()
        {
            Assert.IsType<string>(instance.CallId);
            Assert.Equal("c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85", instance.CallId);
        }
        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            Assert.IsType<string>(instance.To);
            Assert.Equal("+19195551234", instance.To);
        }
        /// <summary>
        /// Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            Assert.IsType<string>(instance.From);
            Assert.Equal("+19195554321", instance.From);
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
        /// Test the property 'CallUrl'
        /// </summary>
        [Fact]
        public void CallUrlTest()
        {
            Assert.IsType<string>(instance.CallUrl);
            Assert.Equal("https://voice.bandwidth.com/api/v2/accounts/9900000/calls/c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85", instance.CallUrl);
        }
        /// <summary>
        /// Test the property 'CallTimeout'
        /// </summary>
        [Fact]
        public void CallTimeoutTest()
        {
            instance.CallTimeout = 30;
            Assert.IsType<double>(instance.CallTimeout);
            Assert.Equal(30, instance.CallTimeout);
        }
        /// <summary>
        /// Test the property 'CallbackTimeout'
        /// </summary>
        [Fact]
        public void CallbackTimeoutTest()
        {
            instance.CallbackTimeout = 15;
            Assert.IsType<double>(instance.CallbackTimeout);
            Assert.Equal(15, instance.CallbackTimeout);
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
        /// Test the property 'AnswerMethod'
        /// </summary>
        [Fact]
        public void AnswerMethodTest()
        {
            instance.AnswerMethod = CallbackMethodEnum.POST;
            Assert.IsType<CallbackMethodEnum>(instance.AnswerMethod);
            Assert.Equal(CallbackMethodEnum.POST, instance.AnswerMethod);
        }
        /// <summary>
        /// Test the property 'AnswerUrl'
        /// </summary>
        [Fact]
        public void AnswerUrlTest()
        {
            Assert.IsType<string>(instance.AnswerUrl);
            Assert.Equal("https://myServer.example/bandwidth/webhooks/answer", instance.AnswerUrl);
        }
        /// <summary>
        /// Test the property 'AnswerFallbackMethod'
        /// </summary>
        [Fact]
        public void AnswerFallbackMethodTest()
        {
            instance.AnswerFallbackMethod = CallbackMethodEnum.POST;
            Assert.IsType<CallbackMethodEnum>(instance.AnswerFallbackMethod);
            Assert.Equal(CallbackMethodEnum.POST, instance.AnswerFallbackMethod);
        }
        /// <summary>
        /// Test the property 'AnswerFallbackUrl'
        /// </summary>
        [Fact]
        public void AnswerFallbackUrlTest()
        {
            instance.AnswerFallbackUrl = "https://fallbackTest.url/";
            Assert.IsType<string>(instance.AnswerFallbackUrl);
            Assert.Equal("https://fallbackTest.url/", instance.AnswerFallbackUrl);
        }
        /// <summary>
        /// Test the property 'DisconnectMethod'
        /// </summary>
        [Fact]
        public void DisconnectMethodTest()
        {
            instance.DisconnectMethod = CallbackMethodEnum.POST;
            Assert.IsType<CallbackMethodEnum>(instance.DisconnectMethod);
            Assert.Equal(CallbackMethodEnum.POST, instance.DisconnectMethod);
        }
        /// <summary>
        /// Test the property 'DisconnectUrl'
        /// </summary>
        [Fact]
        public void DisconnectUrlTest()
        {
            instance.DisconnectUrl = "https://disconnectTest.url/";
            Assert.IsType<string>(instance.DisconnectUrl);
            Assert.Equal("https://disconnectTest.url/", instance.DisconnectUrl);
        }
        /// <summary>
        /// Test the property 'Username'
        /// </summary>
        [Fact]
        public void UsernameTest()
        {
            instance.Username = "username";
            Assert.IsType<string>(instance.Username);
            Assert.Equal("username", instance.Username);
        }
        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Fact]
        public void PasswordTest()
        {
            instance.Password = "password";
            Assert.IsType<string>(instance.Password);
            Assert.Equal("password", instance.Password);
        }
        /// <summary>
        /// Test the property 'FallbackUsername'
        /// </summary>
        [Fact]
        public void FallbackUsernameTest()
        {
            instance.FallbackUsername = "fallbackUsername";
            Assert.IsType<string>(instance.FallbackUsername);
            Assert.Equal("fallbackUsername", instance.FallbackUsername);
        }
        /// <summary>
        /// Test the property 'FallbackPassword'
        /// </summary>
        [Fact]
        public void FallbackPasswordTest()
        {
            instance.FallbackPassword = "fallbackPassword";
            Assert.IsType<string>(instance.FallbackPassword);
            Assert.Equal("fallbackPassword", instance.FallbackPassword);
        }
        /// <summary>
        /// Test the property 'Priority'
        /// </summary>
        [Fact]
        public void PriorityTest()
        {
            instance.Priority = 1;
            Assert.IsType<int>(instance.Priority);
            Assert.Equal(1, instance.Priority);
        }

    }

}
