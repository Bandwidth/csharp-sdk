/*
 * Bandwidth
 *
 * Bandwidth's Communication APIs
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: letstalk@bandwidth.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

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

namespace Bandwidth.Standard.Test.Api
{
    /// <summary>
    ///  Class for testing CallsApi
    /// </summary>
    public class CallsApiTests : IDisposable
    {
        private CallsApi instance;
        private Mock<ISynchronousClient> mockClient;
        private Mock<IAsynchronousClient> mockAsynchronousClient;
        private Configuration fakeConfiguration;

        public CallsApiTests()
        {
            mockClient = new Mock<ISynchronousClient>();
            mockAsynchronousClient = new Mock<IAsynchronousClient>();
            fakeConfiguration = new Configuration();
            fakeConfiguration.BasePath = "https://voice.bandwidth.com/api/v2";
            fakeConfiguration.Username = "username";
            fakeConfiguration.Password = "password";
            instance = new CallsApi(mockClient.Object, mockAsynchronousClient.Object, fakeConfiguration);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CallsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<CallsApi>(instance);
        }

        /// <summary>
        /// Test CreateCall
        /// </summary>
        [Fact]
        public void CreateCallTest()
        {
            string accountId = "9900000";
            CreateCall createCall = new CreateCall(
                to: "+19195551234",
                from: "+19195554321",
                applicationId: "1234-qwer-5679-tyui",
                answerUrl: "https://www.myCallbackServer.example/webhooks/answer"
            );
            CreateCallResponse callResponse = new CreateCallResponse(
                applicationId: "04e88489-df02-4e34-a0ee-27a91849555f",
                accountId: "9900000",
                callId: "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85",
                to: "+19195551234",
                from: "+19195554321",
                callUrl: "https://voice.bandwidth.com/api/v2/accounts/9900000/calls/c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85",
                answerMethod: CallbackMethodEnum.POST,
                answerUrl: "https://myServer.example/bandwidth/webhooks/answer",
                disconnectMethod: CallbackMethodEnum.POST
            );

            var apiResponse = new ApiResponse<CreateCallResponse>(HttpStatusCode.Created, callResponse);
            mockClient.Setup(x => x.Post<CreateCallResponse>("/accounts/{accountId}/calls", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.CreateCallWithHttpInfo(accountId, createCall);

            Assert.IsType<ApiResponse<CreateCallResponse>>(response);
            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }

        /// <summary>
        /// Test failed CreateCall Request
        /// </summary>
        [Fact]
        public void CreateCallBadRequest()
        {
            string accountId = "9900000";
            CreateCall createCall = new CreateCall(
                to: "invalidNumber",
                from: "+19195554321",
                applicationId: "1234-qwer-5679-tyui",
                answerUrl: "https://www.myCallbackServer.example/webhooks/answer"
            );

            var apiResponse = new ApiResponse<CreateCallResponse>(HttpStatusCode.BadRequest, null);
            mockClient.Setup(x => x.Post<CreateCallResponse>("/accounts/{accountId}/calls", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.CreateCall(accountId, createCall));
            
            Assert.Equal("Error calling CreateCall: ", Exception.Message);
            Assert.Equal(400, Exception.ErrorCode);
        }

        /// <summary>
        /// Test unauthorized CreateCall Request
        /// </summary>
        [Fact]
        public void CreateCallUnauthorizedRequest()
        {
            string accountId = "9900000";
            CreateCall createCall = new CreateCall(
                to: "+19195551234",
                from: "+19195554321",
                applicationId: "1234-qwer-5679-tyui",
                answerUrl: "https://www.myCallbackServer.example/webhooks/answer"
            );
            fakeConfiguration.Username = "badUsername";
            fakeConfiguration.Password = "badPassword";

            var apiResponse = new ApiResponse<CreateCallResponse>(HttpStatusCode.Unauthorized, null);
            mockClient.Setup(x => x.Post<CreateCallResponse>("/accounts/{accountId}/calls", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.CreateCall(accountId, createCall));
            
            Assert.Equal("Error calling CreateCall: ", Exception.Message);
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test forbidden CreateCall Request
        /// </summary>
        [Fact]
        public void CreateCallForbiddenRequest()
        {
            string accountId = "9900000";
            CreateCall createCall = new CreateCall(
                to: "+19195551234",
                from: "+19195554321",
                applicationId: "1234-qwer-5679-tyui",
                answerUrl: "https://www.myCallbackServer.example/webhooks/answer"
            );
            fakeConfiguration.Username = "forbiddenUsername";
            fakeConfiguration.Password = "forbiddenPassword";

            var apiResponse = new ApiResponse<CreateCallResponse>(HttpStatusCode.Forbidden, null);
            mockClient.Setup(x => x.Post<CreateCallResponse>("/accounts/{accountId}/calls", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.CreateCall(accountId, createCall));
            
            Assert.Equal("Error calling CreateCall: ", Exception.Message);
            Assert.Equal(403, Exception.ErrorCode);
        }
        
        /// <summary>
        /// Test GetCallState
        /// </summary>
        [Fact]
        public void GetCallStateTest()
        {
            string accountId = "9900000";
            string callId = "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85";

            var apiResponse = new ApiResponse<CallState>(HttpStatusCode.OK, new CallState());
            mockClient.Setup(x => x.Get<CallState>("/accounts/{accountId}/calls/{callId}", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.GetCallStateWithHttpInfo(accountId, callId);

            Assert.IsType<ApiResponse<CallState>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test unauthorized GetCallState Request
        /// </summary>
        [Fact]
        public void GetCallStateUnauthorizedRequest()
        {
            string accountId = "9900000";
            string callId = "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85";
            fakeConfiguration.Username = "badUsername";
            fakeConfiguration.Password = "badPassword";

            var apiResponse = new ApiResponse<CallState>(HttpStatusCode.Unauthorized, null);
            mockClient.Setup(x => x.Get<CallState>("/accounts/{accountId}/calls/{callId}", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.GetCallState(accountId, callId));
            
            Assert.Equal("Error calling GetCallState: ", Exception.Message);
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test forbidden GetCallState Request
        /// </summary>
        [Fact]
        public void GetCallStateForbiddenRequest()
        {
            string accountId = "9900000";
            string callId = "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85";
            fakeConfiguration.Username = "forbiddenUsername";
            fakeConfiguration.Password = "forbiddenPassword";

            var apiResponse = new ApiResponse<CallState>(HttpStatusCode.Forbidden, null);
            mockClient.Setup(x => x.Get<CallState>("/accounts/{accountId}/calls/{callId}", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.GetCallState(accountId, callId));

            Assert.Equal("Error calling GetCallState: ", Exception.Message);
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test not found GetCallState Request
        /// </summary>
        [Fact]
        public void GetCallStateNotFoundRequest()
        {
            string accountId = "9900000";
            string callId = "not a call id";

            var apiResponse = new ApiResponse<CallState>(HttpStatusCode.NotFound, null);
            mockClient.Setup(x => x.Get<CallState>("/accounts/{accountId}/calls/{callId}", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.GetCallState(accountId, callId));

            Assert.Equal("Error calling GetCallState: ", Exception.Message);
            Assert.Equal(404, Exception.ErrorCode);
        }
        
        /// <summary>
        /// Test ListCalls
        /// </summary>
        [Fact]
        public void ListCallsTest()
        {
            string accountId = "9900000";
            CallState callState = new CallState(
                state: "answered"
            );

            var apiResponse = new ApiResponse<List<CallState>>(HttpStatusCode.OK, new List<CallState>() { callState });
            mockClient.Setup(x => x.Get<List<CallState>>("/accounts/{accountId}/calls", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.ListCallsWithHttpInfo(accountId);

            Assert.IsType<ApiResponse<CallState[]>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test unauthorized ListCalls Request
        /// </summary>
        [Fact]
        public void ListCallsUnauthorizedRequest()
        {
            string accountId = "9900000";
            fakeConfiguration.Username = "badUsername";
            fakeConfiguration.Password = "badPassword";

            var apiResponse = new ApiResponse<List<CallState>>(HttpStatusCode.Unauthorized, null);
            mockClient.Setup(x => x.Get<List<CallState>>("/accounts/{accountId}/calls", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.ListCalls(accountId));

            Assert.Equal("Error calling ListCalls: ", Exception.Message);
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test forbidden ListCalls Request
        /// </summary>
        [Fact]
        public void ListCallsForbiddenRequest()
        {
            string accountId = "9900000";
            fakeConfiguration.Username = "forbiddenUsername";
            fakeConfiguration.Password = "forbiddenPassword";

            var apiResponse = new ApiResponse<List<CallState>>(HttpStatusCode.Forbidden, null);
            mockClient.Setup(x => x.Get<List<CallState>>("/accounts/{accountId}/calls", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.ListCalls(accountId));

            Assert.Equal("Error calling ListCalls: ", Exception.Message);
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test UpdateCall
        /// </summary>
        [Fact]
        public void UpdateCallTest()
        {
            string accountId = "9900000";
            string callId = "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85";
            UpdateCall updateCall = new UpdateCall(
                state: CallStateEnum.Completed,
                redirectUrl: "https://myServer.example/bandwidth/webhooks/redirect",
                redirectMethod: RedirectMethodEnum.POST,
                username: "username",
                password: "password",
                redirectFallbackUrl: "https://myFallbackServer.example/bandwidth/webhooks/redirect",
                redirectFallbackMethod: RedirectMethodEnum.POST,
                fallbackUsername: "fallbackUsername",
                fallbackPassword: "fallbackPassword",
                tag: "My Custom Tag"
            );

            var apiResponse = new ApiResponse<Object>(HttpStatusCode.OK, new CallState());
            mockClient.Setup(x => x.Post<Object>("/accounts/{accountId}/calls/{callId}", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.UpdateCallWithHttpInfo(accountId, callId, updateCall);
            
            Assert.IsType<ApiResponse<Object>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test failed UpdateCall Request
        /// </summary>
        [Fact]
        public void UpdateCallBadRequest()
        {
            string accountId = "9900000";
            string callId = "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85";
            UpdateCall updateCall = new UpdateCall(
                state: CallStateEnum.Completed,
                redirectUrl: "https://myServer.example/bandwidth/webhooks/redirect",
                redirectMethod: RedirectMethodEnum.POST,
                username: "username",
                password: "password",
                redirectFallbackUrl: "https://myFallbackServer.example/bandwidth/webhooks/redirect",
                redirectFallbackMethod: RedirectMethodEnum.POST,
                fallbackUsername: "fallbackUsername",
                fallbackPassword: "fallbackPassword",
                tag: "My Custom Tag"
            );

            var apiResponse = new ApiResponse<Object>(HttpStatusCode.BadRequest, null);
            mockClient.Setup(x => x.Post<Object>("/accounts/{accountId}/calls/{callId}", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.UpdateCallWithHttpInfo(accountId, callId, updateCall));

            Assert.Equal("Error calling UpdateCall: ", Exception.Message);
            Assert.Equal(400, Exception.ErrorCode);
        }

        /// <summary>
        /// Test unauthorized UpdateCall Request
        /// </summary>
        [Fact]
        public void UpdateCallUnauthorizedRequest()
        {
            string accountId = "9900000";
            string callId = "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85";
            UpdateCall updateCall = new UpdateCall(
                state: CallStateEnum.Completed,
                redirectUrl: "https://myServer.example/bandwidth/webhooks/redirect",
                redirectMethod: RedirectMethodEnum.POST,
                username: "username",
                password: "password",
                redirectFallbackUrl: "https://myFallbackServer.example/bandwidth/webhooks/redirect",
                redirectFallbackMethod: RedirectMethodEnum.POST,
                fallbackUsername: "fallbackUsername",
                fallbackPassword: "fallbackPassword",
                tag: "My Custom Tag"
            );
            fakeConfiguration.Username = "badUsername";
            fakeConfiguration.Password = "badPassword";

            var apiResponse = new ApiResponse<Object>(HttpStatusCode.Unauthorized, null);
            mockClient.Setup(x => x.Post<Object>("/accounts/{accountId}/calls/{callId}", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.UpdateCallWithHttpInfo(accountId, callId, updateCall));

            Assert.Equal("Error calling UpdateCall: ", Exception.Message);
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test forbidden UpdateCall Request
        /// </summary>
        [Fact]
        public void UpdateCallForbiddenRequest()
        {
            string accountId = "9900000";
            string callId = "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85";
            UpdateCall updateCall = new UpdateCall(
                state: CallStateEnum.Completed,
                redirectUrl: "https://myServer.example/bandwidth/webhooks/redirect",
                redirectMethod: RedirectMethodEnum.POST,
                username: "username",
                password: "password",
                redirectFallbackUrl: "https://myFallbackServer.example/bandwidth/webhooks/redirect",
                redirectFallbackMethod: RedirectMethodEnum.POST,
                fallbackUsername: "fallbackUsername",
                fallbackPassword: "fallbackPassword",
                tag: "My Custom Tag"
            );
            fakeConfiguration.Username = "forbiddenUsername";
            fakeConfiguration.Password = "forbiddenPassword";

            var apiResponse = new ApiResponse<Object>(HttpStatusCode.Forbidden, null);
            mockClient.Setup(x => x.Post<Object>("/accounts/{accountId}/calls/{callId}", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.UpdateCallWithHttpInfo(accountId, callId, updateCall));

            Assert.Equal("Error calling UpdateCall: ", Exception.Message);
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test not found UpdateCall Request
        /// </summary>
        [Fact]
        public void UpdateCallNotFoundRequest()
        {
            string accountId = "9900000";
            string callId = "not a call id";
            UpdateCall updateCall = new UpdateCall(
                state: CallStateEnum.Completed,
                redirectUrl: "https://myServer.example/bandwidth/webhooks/redirect",
                redirectMethod: RedirectMethodEnum.POST,
                username: "username",
                password: "password",
                redirectFallbackUrl: "https://myFallbackServer.example/bandwidth/webhooks/redirect",
                redirectFallbackMethod: RedirectMethodEnum.POST,
                fallbackUsername: "fallbackUsername",
                fallbackPassword: "fallbackPassword",
                tag: "My Custom Tag"
            );

            var apiResponse = new ApiResponse<Object>(HttpStatusCode.NotFound, null);
            mockClient.Setup(x => x.Post<Object>("/accounts/{accountId}/calls/{callId}", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.UpdateCallWithHttpInfo(accountId, callId, updateCall));

            Assert.Equal("Error calling UpdateCall: ", Exception.Message);
            Assert.Equal(404, Exception.ErrorCode);
        }

        /// <summary>
        /// Test UpdateCallBxml
        /// </summary>
        [Fact]
        public void UpdateCallBxmlTest()
        {
            string accountId = "9900000";
            string callId = "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85";
            string body = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Bxml>  <SpeakSentence>This is a test sentence.</SpeakSentence></Bxml>";

            var apiResponse = new ApiResponse<Object>(HttpStatusCode.NoContent, null);
            mockClient.Setup(x => x.Put<Object>("/accounts/{accountId}/calls/{callId}/bxml", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.UpdateCallBxmlWithHttpInfo(accountId, callId, body);

            Assert.IsType<ApiResponse<Object>>(response);
            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
        }

        /// <summary>
        /// Test unauthorized UpdateCallBxml Request
        /// </summary>
        [Fact]
        public void UpdateCallBxmlUnauthorizedRequest()
        {
            string accountId = "9900000";
            string callId = "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85";
            string body = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Bxml>  <SpeakSentence>This is a test sentence.</SpeakSentence></Bxml>";
            fakeConfiguration.Username = "badUsername";
            fakeConfiguration.Password = "badPassword";

            var apiResponse = new ApiResponse<Object>(HttpStatusCode.Unauthorized, null);
            mockClient.Setup(x => x.Put<Object>("/accounts/{accountId}/calls/{callId}/bxml", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.UpdateCallBxmlWithHttpInfo(accountId, callId, body));

            Assert.Equal("Error calling UpdateCallBxml: ", Exception.Message);
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test forbidden UpdateCallBxml Request
        /// </summary>
        [Fact]
        public void UpdateCallBxmlForbiddenRequest()
        {
            string accountId = "9900000";
            string callId = "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85";
            string body = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Bxml>  <SpeakSentence>This is a test sentence.</SpeakSentence></Bxml>";
            fakeConfiguration.Username = "forbiddenUsername";
            fakeConfiguration.Password = "forbiddenPassword";

            var apiResponse = new ApiResponse<Object>(HttpStatusCode.Forbidden, null);
            mockClient.Setup(x => x.Put<Object>("/accounts/{accountId}/calls/{callId}/bxml", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.UpdateCallBxmlWithHttpInfo(accountId, callId, body));

            Assert.Equal("Error calling UpdateCallBxml: ", Exception.Message);
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test not found UpdateCallBxml Request
        /// </summary>
        [Fact]
        public void UpdateCallBxmlNotFoundRequest()
        {
            string accountId = "9900000";
            string callId = "not a call id";
            string body = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Bxml>  <SpeakSentence>This is a test sentence.</SpeakSentence></Bxml>";

            var apiResponse = new ApiResponse<Object>(HttpStatusCode.NotFound, null);
            mockClient.Setup(x => x.Put<Object>("/accounts/{accountId}/calls/{callId}/bxml", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.UpdateCallBxmlWithHttpInfo(accountId, callId, body));

            Assert.Equal("Error calling UpdateCallBxml: ", Exception.Message);
            Assert.Equal(404, Exception.ErrorCode);
        }
    }
}
