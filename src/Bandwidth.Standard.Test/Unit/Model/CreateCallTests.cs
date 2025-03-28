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
    ///  Class for testing CreateCall
    /// </summary>
    public class CreateCallTests : IDisposable
    {
        private CreateCall instance;
        private MachineDetectionConfiguration machineDetection;

        public CreateCallTests()
        {
            machineDetection = new MachineDetectionConfiguration(
                mode: MachineDetectionModeEnum.Async,
                callbackUrl: "https://test.url/",
                callbackMethod: CallbackMethodEnum.POST,
                username: "username",
                password: "password",
                fallbackUrl: "https://fallbackTest.url/",
                fallbackMethod: CallbackMethodEnum.POST,
                fallbackUsername: "fallbackUsername",
                fallbackPassword: "fallbackPassword"
            );

            instance = new CreateCall(
                to: "+19195551234",
                from: "+19195554321",
                applicationId: "1234-qwer-5679-tyui",
                answerUrl: "https://www.myCallbackServer.example/webhooks/answer",
                displayName: "John Doe",
                uui: "1234567890abcdef",
                answerMethod: CallbackMethodEnum.POST,
                username: "username",
                password: "password",
                answerFallbackUrl: "https://fallbackTest.url/",
                answerFallbackMethod: CallbackMethodEnum.POST,
                fallbackUsername: "fallbackUsername",
                fallbackPassword: "fallbackPassword",
                disconnectUrl: "https://disconnectTest.url/",
                disconnectMethod: CallbackMethodEnum.POST,
                callTimeout: 30,
                callbackTimeout: 15,
                machineDetection: machineDetection,
                priority: 1,
                tag: "test"
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateCall
        /// </summary>
        [Fact]
        public void CreateCallInstanceTest()
        {
            Assert.IsType<CreateCall>(instance);
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
        /// Test the property 'DisplayName'
        ///  </summary>
        [Fact]
        public void DisplayNameTest()
        {
            Assert.IsType<string>(instance.DisplayName);
            Assert.Equal("John Doe", instance.DisplayName);
        } 
        /// <summary>
        /// Test the property 'Uui'
        /// </summary>
        [Fact]
        public void UuiTest()
        {
            Assert.IsType<string>(instance.Uui);
            Assert.Equal("1234567890abcdef", instance.Uui);
        }
        /// <summary>
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            Assert.IsType<string>(instance.ApplicationId);
            Assert.Equal("1234-qwer-5679-tyui", instance.ApplicationId);
        }
        /// <summary>
        /// Test the property 'AnswerUrl'
        /// </summary>
        [Fact]
        public void AnswerUrlTest()
        {
            Assert.IsType<string>(instance.AnswerUrl);
            Assert.Equal("https://www.myCallbackServer.example/webhooks/answer", instance.AnswerUrl);
        }
        /// <summary>
        /// Test the property 'AnswerMethod'
        /// </summary>
        [Fact]
        public void AnswerMethodTest()
        {
            Assert.IsType<CallbackMethodEnum>(instance.AnswerMethod);
            Assert.Equal(CallbackMethodEnum.POST, instance.AnswerMethod);
        }
        /// <summary>
        /// Test the property 'Username'
        /// </summary>
        [Fact]
        public void UsernameTest()
        {
            Assert.IsType<string>(instance.Username);
            Assert.Equal("username", instance.Username);
        }
        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Fact]
        public void PasswordTest()
        {
            Assert.IsType<string>(instance.Password);
            Assert.Equal("password", instance.Password);
        }
        /// <summary>
        /// Test the property 'AnswerFallbackUrl'
        /// </summary>
        [Fact]
        public void AnswerFallbackUrlTest()
        {
            Assert.IsType<string>(instance.AnswerFallbackUrl);
            Assert.Equal("https://fallbackTest.url/", instance.AnswerFallbackUrl);
        }
        /// <summary>
        /// Test the property 'AnswerFallbackMethod'
        /// </summary>
        [Fact]
        public void AnswerFallbackMethodTest()
        {
            Assert.IsType<CallbackMethodEnum>(instance.AnswerFallbackMethod);
            Assert.Equal(CallbackMethodEnum.POST, instance.AnswerFallbackMethod);
        }
        /// <summary>
        /// Test the property 'FallbackUsername'
        /// </summary>
        [Fact]
        public void FallbackUsernameTest()
        {
            Assert.IsType<string>(instance.FallbackUsername);
            Assert.Equal("fallbackUsername", instance.FallbackUsername);
        }
        /// <summary>
        /// Test the property 'FallbackPassword'
        /// </summary>
        [Fact]
        public void FallbackPasswordTest()
        {
            Assert.IsType<string>(instance.FallbackPassword);
            Assert.Equal("fallbackPassword", instance.FallbackPassword);
        }
        /// <summary>
        /// Test the property 'DisconnectUrl'
        /// </summary>
        [Fact]
        public void DisconnectUrlTest()
        {
            Assert.IsType<string>(instance.DisconnectUrl);
            Assert.Equal("https://disconnectTest.url/", instance.DisconnectUrl);
        }
        /// <summary>
        /// Test the property 'DisconnectMethod'
        /// </summary>
        [Fact]
        public void DisconnectMethodTest()
        {
            Assert.IsType<CallbackMethodEnum>(instance.DisconnectMethod);
            Assert.Equal(CallbackMethodEnum.POST, instance.DisconnectMethod);
        }
        /// <summary>
        /// Test the property 'CallTimeout'
        /// </summary>
        [Fact]
        public void CallTimeoutTest()
        {
            Assert.IsType<double>(instance.CallTimeout);
            Assert.Equal(30, instance.CallTimeout);
        }
        /// <summary>
        /// Test the property 'CallbackTimeout'
        /// </summary>
        [Fact]
        public void CallbackTimeoutTest()
        {
            Assert.IsType<double>(instance.CallbackTimeout);
            Assert.Equal(15, instance.CallbackTimeout);
        }
        /// <summary>
        /// Test the property 'MachineDetection'
        /// </summary>
        [Fact]
        public void MachineDetectionTest()
        {
            Assert.IsType<MachineDetectionConfiguration>(instance.MachineDetection);
            Assert.Equal(machineDetection, instance.MachineDetection);
        }
        /// <summary>
        /// Test the property 'Priority'
        /// </summary>
        [Fact]
        public void PriorityTest()
        {
            Assert.IsType<int>(instance.Priority);
            Assert.Equal(1, instance.Priority);
        }
        /// <summary>
        /// Test the property 'Tag'
        /// </summary>
        [Fact]
        public void TagTest()
        {
            Assert.IsType<string>(instance.Tag);
            Assert.Equal("test", instance.Tag);
        }

    }

}
