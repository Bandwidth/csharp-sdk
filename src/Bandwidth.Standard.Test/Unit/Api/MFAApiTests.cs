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
using Xunit;

using Bandwidth.Standard.Client;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Model;
using Moq;
using System.Net;

namespace Bandwidth.Standard.Test.Unit.Api
{
    /// <summary>
    ///  Class for testing MFAApi
    /// </summary>
    public class MFAApiTests : IDisposable
    {
        private MFAApi instance;
        private Mock<ISynchronousClient> mockClient;
        private Mock<IAsynchronousClient> mockAsynchronousClient;
        private Configuration fakeConfiguration;

        public MFAApiTests()
        {
            mockClient = new Mock<ISynchronousClient>();
            mockAsynchronousClient = new Mock<IAsynchronousClient>();
            fakeConfiguration = new Configuration();
            fakeConfiguration.BasePath = "https://mfa.bandwidth.com/api/v1";
            fakeConfiguration.Username = "username";
            fakeConfiguration.Password = "password";
            instance = new MFAApi(mockClient.Object, mockAsynchronousClient.Object, fakeConfiguration);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MFAApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<MFAApi>(instance);
        }

        /// <summary>
        /// Test GenerateMessagingCode
        /// </summary>
        [Fact]
        public void GenerateMessagingCodeTest()
        {
            string accountId = "9900000";
            CodeRequest codeRequest = new CodeRequest("+19195551234", "+19195554321", "66fd98ae-ac8d-a00f-7fcd-ba3280aeb9b1", "2FA", "Your temporary {NAME} {SCOPE} code is {CODE}", 6);

            var apiResponse = new ApiResponse<MessagingCodeResponse>(HttpStatusCode.OK, new MessagingCodeResponse("123-456-abcd"));
            mockClient.Setup(x => x.Post<MessagingCodeResponse>("/accounts/{accountId}/code/messaging", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.GenerateMessagingCodeWithHttpInfo(accountId, codeRequest);
            
            Assert.IsType<ApiResponse<MessagingCodeResponse>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test GenerateVoiceCode
        /// </summary>
        [Fact]
        public void GenerateVoiceCodeTest()
        {
            string accountId = "9900000";
            CodeRequest codeRequest = new CodeRequest("+19195551234", "+19195554321", "66fd98ae-ac8d-a00f-7fcd-ba3280aeb9b1", "2FA", "Your temporary {NAME} {SCOPE} code is {CODE}", 6);
            
            var apiResponse = new ApiResponse<VoiceCodeResponse>(HttpStatusCode.OK, new VoiceCodeResponse("c-1234"));
            mockClient.Setup(x => x.Post<VoiceCodeResponse>("/accounts/{accountId}/code/voice", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.GenerateVoiceCodeWithHttpInfo(accountId, codeRequest);
            
            Assert.IsType<ApiResponse<VoiceCodeResponse>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test VerifyCode
        /// </summary>
        [Fact]
        public void VerifyCodeTest()
        {
            string accountId = "9900000";
            VerifyCodeRequest verifyCodeRequest = new VerifyCodeRequest("+19195551234", "2FA", 3, "123456");

            var apiResponse = new ApiResponse<VerifyCodeResponse>(HttpStatusCode.OK, new VerifyCodeResponse(true));
            mockClient.Setup(x => x.Post<VerifyCodeResponse>("/accounts/{accountId}/code/verify", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.VerifyCodeWithHttpInfo(accountId, verifyCodeRequest);
            
            Assert.IsType<ApiResponse<VerifyCodeResponse>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test failed Generate Messaging Code Request
        /// </summary>
        [Fact]
        public void GenerateMessagingCodeBadRequest()
        {
            string accountId = "9900000";
            CodeRequest codeRequest = new CodeRequest("+19195551234", "+19195554321", "not-an-application-id", "2FA", "Your temporary {NAME} {SCOPE} code is {CODE}", 6);

            var apiResponse = new ApiResponse<MessagingCodeResponse>(HttpStatusCode.BadRequest, null);
            mockClient.Setup(x => x.Post<MessagingCodeResponse>("/accounts/{accountId}/code/messaging", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.GenerateMessagingCode(accountId, codeRequest));

            Assert.Equal("Error calling GenerateMessagingCode: ", Exception.Message);
            Assert.Equal(400, Exception.ErrorCode);
        }

        /// <summary>
        /// Test failed Generate Voice Code Request
        /// </summary>
        [Fact]
        public void GenerateVoiceCodeBadRequest()
        {
            string accountId = "9900000";
            CodeRequest codeRequest = new CodeRequest("+19195551234", "+19195554321", "not-an-application-id", "2FA", "Your temporary {NAME} {SCOPE} code is {CODE}", 6);

            var apiResponse = new ApiResponse<VoiceCodeResponse>(HttpStatusCode.BadRequest, null);
            mockClient.Setup(x => x.Post<VoiceCodeResponse>("/accounts/{accountId}/code/voice", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.GenerateVoiceCode(accountId, codeRequest));

            Assert.Equal("Error calling GenerateVoiceCode: ", Exception.Message);
            Assert.Equal(400, Exception.ErrorCode);
        }

        /// <summary>
        /// Test unauthorized Generate Messaging Code Request
        /// </summary>
        [Fact]
        public void GenerateMessagingCodeUnauthorizedRequest()
        {
            string accountId = "9900000";
            CodeRequest codeRequest = new CodeRequest("+19195551234", "+19195554321", "123-456-abcd", "2FA", "Your temporary {NAME} {SCOPE} code is {CODE}", 6);
            fakeConfiguration.Username = "badUsername";
            fakeConfiguration.Password = "badPassword";

            var apiResponse = new ApiResponse<MessagingCodeResponse>(HttpStatusCode.Unauthorized, new MessagingCodeResponse("Unauthorized"));
            mockClient.Setup(x => x.Post<MessagingCodeResponse>("/accounts/{accountId}/code/messaging", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.GenerateMessagingCode(accountId, codeRequest));

            Assert.Equal("Error calling GenerateMessagingCode: ", Exception.Message);
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test unauthorized Generate Voice Code Request
        /// </summary>
        [Fact]
        public void GenerateVoiceCodeUnauthorizedRequest()
        {
            string accountId = "9900000";
            CodeRequest codeRequest = new CodeRequest("+19195551234", "+19195554321", "123-456-abcd", "2FA", "Your temporary {NAME} {SCOPE} code is {CODE}", 6);
            fakeConfiguration.Username = "badUsername";
            fakeConfiguration.Password = "badPassword";

            var apiResponse = new ApiResponse<VoiceCodeResponse>(HttpStatusCode.Unauthorized, new VoiceCodeResponse("Unauthorized"));
            mockClient.Setup(x => x.Post<VoiceCodeResponse>("/accounts/{accountId}/code/voice", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.GenerateVoiceCode(accountId, codeRequest));

            Assert.Equal("Error calling GenerateVoiceCode: ", Exception.Message);
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test forbidden Generate Messaging Code Request
        /// </summary>
        [Fact]
        public void GenerateMessagingCodeForbiddenRequest()
        {
            string accountId = "9900000";
            CodeRequest codeRequest = new CodeRequest("+19195551234", "+19195554321", "123-456-abcd", "2FA", "Your temporary {NAME} {SCOPE} code is {CODE}", 6);
            fakeConfiguration.Username = "forbiddenUsername";
            fakeConfiguration.Password = "badPassword";

            var apiResponse = new ApiResponse<MessagingCodeResponse>(HttpStatusCode.Forbidden, new MessagingCodeResponse("Missing Authentication Token"));
            mockClient.Setup(x => x.Post<MessagingCodeResponse>("/accounts/{accountId}/code/messaging", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.GenerateMessagingCode(accountId, codeRequest));

            Assert.Equal("Error calling GenerateMessagingCode: ", Exception.Message);
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test forbidden Generate Voice Code Request
        /// </summary>
        [Fact]
        public void GenerateVoiceCodeForbiddenRequest()
        {
            string accountId = "9900000";
            CodeRequest codeRequest = new CodeRequest("+19195551234", "+19195554321", "123-456-abcd", "2FA", "Your temporary {NAME} {SCOPE} code is {CODE}", 6);
            fakeConfiguration.Username = "forbiddenUsername";
            fakeConfiguration.Password = "badPassword";

            var apiResponse = new ApiResponse<VoiceCodeResponse>(HttpStatusCode.Forbidden, new VoiceCodeResponse("Missing Authentication Token"));
            mockClient.Setup(x => x.Post<VoiceCodeResponse>("/accounts/{accountId}/code/voice", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            ApiException Exception = Assert.Throws<ApiException>(() => instance.GenerateVoiceCode(accountId, codeRequest));

            Assert.Equal("Error calling GenerateVoiceCode: ", Exception.Message);
            Assert.Equal(403, Exception.ErrorCode);
        }
    }
}
