using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Bandwidth.Standard.Client;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Model;
using Moq;
using System.Net;

namespace Bandwidth.Standard.Test.Integration
{
    /// <summary>
    ///  Class for testing CallsApi
    /// </summary>
    public class CallsIntegrationTests : IDisposable
    {
        private CallsApi instance;
        private CallsApi unauthorizedInstance;
        private CallsApi forbiddenInstance;
        private Configuration fakeConfiguration;
        private CreateCall createCallBody;
        private CreateCall mantecaCallBody;
        private UpdateCall fakeUpdateCall;
        private string accountId;
        public CallsIntegrationTests()
        {   
            accountId = Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");
            fakeConfiguration = new Configuration();
            fakeConfiguration.BasePath = "https://voice.bandwidth.com/api/v2";
            fakeConfiguration.Username = Environment.GetEnvironmentVariable("BW_USERNAME");
            fakeConfiguration.Password = Environment.GetEnvironmentVariable("BW_PASSWORD");
            instance = new CallsApi(fakeConfiguration);

            // Unauthorized API Client
            fakeConfiguration.Username = "badUsername";
            fakeConfiguration.Password = "badPassword";
            unauthorizedInstance = new CallsApi(fakeConfiguration);

            // Forbidden API Client
            fakeConfiguration.Username = Environment.GetEnvironmentVariable("BW_USERNAME_FORBIDDEN");
            fakeConfiguration.Password = Environment.GetEnvironmentVariable("BW_PASSWORD_FORBIDDEN");
            forbiddenInstance = new CallsApi(fakeConfiguration);



            createCallBody = new CreateCall(
                to: Environment.GetEnvironmentVariable("USER_NUMBER"),
                from: Environment.GetEnvironmentVariable("BW_NUMBER"),
                displayName: "Test Call",
                applicationId: Environment.GetEnvironmentVariable("BW_VOICE_APPLICATION_ID"),
                answerUrl: Environment.GetEnvironmentVariable("BASE_CALLBACK_URL"),
                answerMethod: CallbackMethodEnum.POST,
                username: "mySecretUsername",
                password: "mySecretPassword!",
                answerFallbackUrl: "https://www.myFallbackServer.com/webhooks/answer",
                answerFallbackMethod: CallbackMethodEnum.POST,
                fallbackUsername: "mySecretUsername",
                fallbackPassword: "mySecretPassword!",
                disconnectUrl: "https://myServer.com/bandwidth/webhooks/disconnectUrl",
                disconnectMethod: CallbackMethodEnum.POST,
                callTimeout: 30,
                callbackTimeout: 15,
                machineDetection: new MachineDetectionConfiguration(
                    mode: MachineDetectionModeEnum.Async,
                    detectionTimeout: 15,
                    silenceTimeout: 10,
                    speechThreshold: 10,
                    speechEndThreshold: 5,
                    machineSpeechEndThreshold: 5,
                    delayResult: false,
                    callbackUrl: "https://myServer.com/bandwidth/webhooks/machineDetectionComplete",
                    callbackMethod: CallbackMethodEnum.POST,
                    username: "MySecretUsername",
                    password: "MySecretPassword!",
                    fallbackUrl: "https://myFallbackServer.com/bandwidth/webhooks/machineDetectionComplete",
                    fallbackMethod: CallbackMethodEnum.POST,
                    fallbackUsername: "MySecretUsername",
                    fallbackPassword: "MySecretPassword!"
                ),
                priority: 5,
                tag: "tag Example"
            );

            mantecaCallBody = new CreateCall(
                to: Environment.GetEnvironmentVariable("MANTECA_IDLE_NUMBER"),
                from: Environment.GetEnvironmentVariable("MANTECA_ACTIVE_NUMBER"),
                applicationId: Environment.GetEnvironmentVariable("MANTECA_APPLICATION_ID"),
                answerUrl: Environment.GetEnvironmentVariable("MANTECA_BASE_URL") + "/bxml/pause"
            );

            fakeUpdateCall = new UpdateCall(
                state: CallStateEnum.Active,
                redirectUrl: "https://www.myCallbackServer.example/webhooks/redirect",
                redirectMethod: RedirectMethodEnum.POST,
                username: Environment.GetEnvironmentVariable("BW_USERNAME"),
                password: Environment.GetEnvironmentVariable("BW_PASSWORD"),
                redirectFallbackUrl: "https://myFallbackServer.example/bandwidth/webhooks/redirect",
                redirectFallbackMethod: RedirectMethodEnum.POST,
                fallbackUsername: "fallbackUsername",
                fallbackPassword: "fallbackPassword",
                tag: "My Custom Tag"
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test CreateCall
        /// </summary>
        [Fact] 
        public void CreateCallTest()
        {            
            ApiResponse<CreateCallResponse> response = instance.CreateCallWithHttpInfo(accountId, createCallBody);
            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
            Assert.IsType<string>(response.Data.CallId);
            Assert.Equal(Environment.GetEnvironmentVariable("BW_ACCOUNT_ID"), response.Data.AccountId);
            Assert.Equal(Environment.GetEnvironmentVariable("BW_VOICE_APPLICATION_ID"), response.Data.ApplicationId);
            Assert.Equal(Environment.GetEnvironmentVariable("USER_NUMBER"), response.Data.To);
            Assert.Equal(Environment.GetEnvironmentVariable("BW_NUMBER"), response.Data.From);
        }

        /// <summary>
        /// Test Create Call bad request
        /// </summary>
        [Fact]
        public void CreateCallBadRequestTest()
        {
            createCallBody.To = "not a phone number";
            ApiException Exception = Assert.Throws<ApiException>(() => instance.CreateCallWithHttpInfo(accountId, createCallBody));
            Assert.Equal(400, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Create Call unauthorized request
        /// </summary>
        [Fact]
        public void CreateCallUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.CreateCallWithHttpInfo(accountId, createCallBody));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Create Call forbidden request
        /// </summary>
        [Fact]
        public void CreateCallForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.CreateCallWithHttpInfo(accountId, createCallBody));
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Call State
        /// </summary>
        [Fact]
        public void GetCallStateTest()
        {
            CreateCallResponse createCallResponse = instance.CreateCall(accountId, createCallBody);
            var callId = createCallResponse.CallId;

            System.Threading.Thread.Sleep(5000);

            ApiResponse<CallState> response = instance.GetCallStateWithHttpInfo(accountId, callId);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(callId, response.Data.CallId);
            Assert.IsType<string>(response.Data.CallId);
            Assert.Equal(CallDirectionEnum.Outbound, response.Data.Direction);
            Assert.IsType<DateTime>(response.Data.EnqueuedTime);
            Assert.IsType<DateTime>(response.Data.LastUpdate);
            Assert.IsType<DateTime>(response.Data.StartTime);
        }

        /// <summary>
        /// Test Get Call State unauthorized request
        /// </summary>
        [Fact]
        public void GetCallStateUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.GetCallStateWithHttpInfo(accountId, "Call-Id"));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Call State forbidden request
        /// </summary>
        [Fact]
        public void GetCallStateForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.GetCallStateWithHttpInfo(accountId, "Call-Id"));
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Call State not found request
        /// </summary>
        [Fact]
        public void GetCallStateNotFoundRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => instance.GetCallStateWithHttpInfo(accountId, "Call-Id"));
            Assert.Equal(404, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Call
        /// </summary>
        [Fact]
        public void UpdateCallTest()
        {
            CreateCallResponse createCallResponse = instance.CreateCall(accountId, mantecaCallBody);
            string callId = createCallResponse.CallId;

            var updateCallBody = new UpdateCall(
                state: CallStateEnum.Active,
                redirectUrl: Environment.GetEnvironmentVariable("MANTECA_BASE_URL") + "/bxml/pause",
                redirectMethod: RedirectMethodEnum.POST,
                username: "mySecretUsername",
                password: "mySecretPassword!",
                redirectFallbackUrl: Environment.GetEnvironmentVariable("MANTECA_BASE_URL") + "/bxml/pause",
                redirectFallbackMethod: RedirectMethodEnum.POST,
                fallbackUsername: "mySecretUsername",
                fallbackPassword: "mySecretPassword!",
                tag: "My Custom Tag"
            );

            System.Threading.Thread.Sleep(5000);
            ApiResponse<Object> response = instance.UpdateCallWithHttpInfo(accountId, callId, updateCallBody);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            System.Threading.Thread.Sleep(5000);
            //Hanging up the call
            updateCallBody.State = CallStateEnum.Completed;
            response = instance.UpdateCallWithHttpInfo(accountId, callId, updateCallBody);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test Update Call bad request
        /// </summary>
        [Fact]
        public void UpdateCallBadRequest()
        {
            CreateCallResponse createCallResponse = instance.CreateCall(accountId, mantecaCallBody);
            string callId = createCallResponse.CallId;

            System.Threading.Thread.Sleep(5000);
            
            fakeUpdateCall.State = null;
            ApiException Exception = Assert.Throws<ApiException>(() => instance.UpdateCall(accountId, callId, fakeUpdateCall));
            Assert.Equal(400, Exception.ErrorCode);

            //Hanging up the call
            fakeUpdateCall.State = CallStateEnum.Completed;
            var updateCallResponse = instance.UpdateCallWithHttpInfo(accountId, callId, fakeUpdateCall);
            Assert.Equal(HttpStatusCode.OK, updateCallResponse.StatusCode);
        }

        /// <summary>
        /// Test Update Call unauthorized request
        /// </summary>
        [Fact]
        public void UpdateCallUnauthorizedRequest()
        {
            fakeUpdateCall.State = CallStateEnum.Completed;

            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.UpdateCallWithHttpInfo(accountId, "Call-Id", fakeUpdateCall));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Call forbidden request
        /// </summary>
        [Fact]
        public void UpdateCallForbiddenRequest()
        {
            CreateCallResponse createCallResponse = instance.CreateCall(accountId, mantecaCallBody);

            string callId = createCallResponse.CallId;
            System.Threading.Thread.Sleep(5000);
            fakeUpdateCall.State = CallStateEnum.Completed;

            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.UpdateCall(accountId, callId, fakeUpdateCall));
            Assert.Equal(403, Exception.ErrorCode);

            System.Threading.Thread.Sleep(5000);

            ApiResponse<Object> response = instance.UpdateCallWithHttpInfo(accountId, callId, fakeUpdateCall);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test Update Call not found request
        /// </summary>
        [Fact]
        public void UpdateCallNotFoundRequest()
        {
            fakeUpdateCall.State = CallStateEnum.Completed;

            ApiException Exception = Assert.Throws<ApiException>(() => instance.UpdateCallWithHttpInfo(accountId, "Call-Id", fakeUpdateCall));
            
            Assert.Equal(404, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Call BXML
        /// </summary>
        [Fact]
        public void UpdateCallBxml()
        {
            CreateCallResponse createCallResponse = instance.CreateCall(accountId, mantecaCallBody);

            string callId = createCallResponse.CallId;
            System.Threading.Thread.Sleep(5000);

            ApiResponse<Object> updateCallBxmlResponse = instance.UpdateCallBxmlWithHttpInfo(accountId, callId, "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Bxml>  <SpeakSentence>This is a test sentence.</SpeakSentence></Bxml>");
            Assert.Equal(HttpStatusCode.NoContent, updateCallBxmlResponse.StatusCode);

            System.Threading.Thread.Sleep(5000);
            
            fakeUpdateCall.State = CallStateEnum.Completed;
            ApiResponse<Object> updateCallResponse = instance.UpdateCallWithHttpInfo(accountId, callId, fakeUpdateCall);
            Assert.Equal(HttpStatusCode.OK, updateCallResponse.StatusCode);
        }

        /// <summary>
        /// Test Update Call BXML bad request
        /// </summary>
        [Fact]
        public void UpdateCallBxmlBadRequest()
        {
            ApiResponse<CreateCallResponse> createCallResponse = instance.CreateCallWithHttpInfo(accountId, mantecaCallBody);

            string callId = createCallResponse.Data.CallId;
            System.Threading.Thread.Sleep(5000);

            ApiException Exception = Assert.Throws<ApiException>(() => instance.UpdateCallBxmlWithHttpInfo(accountId, callId, "invalid BXML"));
            Assert.Equal(400, Exception.ErrorCode);

            System.Threading.Thread.Sleep(5000);

            fakeUpdateCall.State = CallStateEnum.Completed;
            ApiResponse<Object> updateCallResponse = instance.UpdateCallWithHttpInfo(accountId, callId, fakeUpdateCall);
            Assert.Equal(HttpStatusCode.OK, updateCallResponse.StatusCode);
        }

        /// <summary>
        /// Test Update Call BXML unauthorized request
        /// </summary>
        [Fact]
        public void UpdateCallBxmlUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.UpdateCallBxmlWithHttpInfo(accountId, "Call-Id", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Bxml>  <SpeakSentence>This is a test sentence.</SpeakSentence></Bxml>"));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Call BXML forbidden request
        /// </summary>
        [Fact]
        public void UpdateCallBxmlForbiddenRequest()
        {
            CreateCallResponse createCallResponse = instance.CreateCall(accountId, mantecaCallBody);

            string callId = createCallResponse.CallId;
            System.Threading.Thread.Sleep(5000);

            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.UpdateCallBxmlWithHttpInfo(accountId, callId, "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Bxml>  <SpeakSentence>This is a test sentence.</SpeakSentence></Bxml>"));
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Call BXML not found request
        /// </summary>
        [Fact]
        public void UpdateCallBxmlNotFoundRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => instance.UpdateCallBxmlWithHttpInfo(accountId, "Call-Id", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Bxml>  <SpeakSentence>This is a test sentence.</SpeakSentence></Bxml>"));
            Assert.Equal(404, Exception.ErrorCode);
        }
    }
}
