using System;
using Xunit;

using Bandwidth.Standard.Client;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Model;
using System.Net;

namespace Bandwidth.Standard.Test.Integration
{
    /// <summary>
    ///  Class for testing MFAApi
    /// </summary>
    public class MFAIntegrationTests : IDisposable
    {
        private string accountId;
        private CodeRequest badCodeRequest;
        private Configuration fakeConfiguration;
        private MFAApi forbiddenInstance;
        private MFAApi instance;
        private CodeRequest messagingCodeRequest;
        private MFAApi unauthorizedInstance;
        private VerifyCodeRequest verifyCodeRequest;
        private CodeRequest voiceCodeRequest;

        public MFAIntegrationTests()
        {
            // Authorized API Client
            fakeConfiguration = new Configuration();
            fakeConfiguration.BasePath = "https://mfa.bandwidth.com/api/v1";
            fakeConfiguration.Username = Environment.GetEnvironmentVariable("BW_USERNAME");
            fakeConfiguration.Password = Environment.GetEnvironmentVariable("BW_PASSWORD");
            instance = new MFAApi(fakeConfiguration);

            // Unauthorized API Client
            unauthorizedInstance = new MFAApi();

            // Forbidden API Client
            fakeConfiguration.Username = Environment.GetEnvironmentVariable("BW_USERNAME_FORBIDDEN");
            fakeConfiguration.Password = "badPassword";
            forbiddenInstance = new MFAApi(fakeConfiguration);

            // Code Request for generating a messaging code
            messagingCodeRequest = new CodeRequest(
                to: Environment.GetEnvironmentVariable("USER_NUMBER"),
                from: Environment.GetEnvironmentVariable("BW_NUMBER"),
                applicationId: Environment.GetEnvironmentVariable("BW_MESSAGING_APPLICATION_ID"),
                message: "Your temporary {NAME} {SCOPE} code is {CODE}",
                scope: "2FA",
                digits: 6
            );

            // Code Request for generating a voice code
            voiceCodeRequest = new CodeRequest(
                to: Environment.GetEnvironmentVariable("USER_NUMBER"),
                from: Environment.GetEnvironmentVariable("BW_NUMBER"),
                applicationId: Environment.GetEnvironmentVariable("BW_VOICE_APPLICATION_ID"),
                message: "Your temporary {NAME} {SCOPE} code is {CODE}",
                scope: "2FA",
                digits: 6
            );

            // Bad Code Request
            badCodeRequest = new CodeRequest(
                to: Environment.GetEnvironmentVariable("USER_NUMBER"),
                from: Environment.GetEnvironmentVariable("BW_NUMBER"),
                applicationId: "not an application id",
                message: "Your temporary {NAME} {SCOPE} code is {CODE}",
                scope: "2FA",
                digits: 6
            );

            // Verify Code Request
            verifyCodeRequest = new VerifyCodeRequest(
                to: Environment.GetEnvironmentVariable("USER_NUMBER"),
                expirationTimeInMinutes: 3,
                code: "123456"
            );

            accountId = Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");
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
        /// Test a successful GenerateMessagingCode request
        /// </summary>
        [Fact]
        public void GenerateMessagingCodeTest()
        {
            var response = instance.GenerateMessagingCodeWithHttpInfo(accountId, messagingCodeRequest);
            Assert.IsType<ApiResponse<MessagingCodeResponse>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test GenerateMessagingCode with a bad code request
        /// </summary>
        [Fact]
        public void GenerateMessagingCodeBadRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => instance.GenerateMessagingCode(accountId, badCodeRequest));
            Assert.Equal(400, Exception.ErrorCode);
        }

        /// <summary>
        /// Test GenerateMessagingCode with an unauthorized client
        /// </summary>
        [Fact]
        public void GenerateMessagingCodeUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.GenerateMessagingCode(accountId, messagingCodeRequest));
            Assert.Equal(401, Exception.ErrorCode); 
        }

        /// <summary>
        /// Test GenerateMessagingCode with a forbidden client
        /// </summary>
        [Fact]
        public void GenerateMessagingCodeForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.GenerateMessagingCode(accountId, messagingCodeRequest));
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test a successful GenerateVoiceCode request
        /// </summary>
        [Fact]
        public void GenerateVoiceCodeTest()
        {
            var response = instance.GenerateVoiceCodeWithHttpInfo(accountId, voiceCodeRequest);
            Assert.IsType<ApiResponse<VoiceCodeResponse>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test GenerateVoiceCode with a bad code request
        /// </summary>
        [Fact]
        public void GenerateVoiceCodeBadRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => instance.GenerateVoiceCode(accountId, badCodeRequest));
            Assert.Equal(400, Exception.ErrorCode);
        }

        /// <summary>
        /// Test GenerateVoiceCode with an unauthorized client
        /// </summary>
        [Fact]
        public void GenerateVoiceCodeUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.GenerateVoiceCode(accountId, voiceCodeRequest));
            Assert.Equal(401, Exception.ErrorCode); 
        }

        /// <summary>
        /// Test GenerateVoiceCode with a forbidden client
        /// </summary>
        [Fact]
        public void GenerateVoiceCodeForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.GenerateVoiceCode(accountId, voiceCodeRequest));
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test a successful VerifyCode request
        /// </summary>
        [Fact]
        public void VerifyCodeTest()
        {
            var response = instance.VerifyCodeWithHttpInfo(accountId, verifyCodeRequest);
            Assert.IsType<ApiResponse<VerifyCodeResponse>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test VerifyCode with an unauthorized client
        /// </summary>
        [Fact]
        public void VerifyCodeUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.VerifyCode(accountId, verifyCodeRequest));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test VerifyCode with a forbidden client
        /// </summary>
        [Fact]
        public void VerifyCodeForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.VerifyCode(accountId, verifyCodeRequest));
            Assert.Equal(403, Exception.ErrorCode);
        }
    }
}
