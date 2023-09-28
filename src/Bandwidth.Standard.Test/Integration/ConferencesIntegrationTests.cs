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
    ///  Class for testing ConferencesApi
    /// </summary>
    public class ConferencesIntegrationTests : IDisposable
    {
        private ConferencesApi conferenceApiInstance;
        private ConferencesApi unauthorizedInstance;
        private ConferencesApi forbiddenInstance;
        private ApiClient restClient;
        private UpdateConference updateConferenceBody;
        private CallsApi callsApiInstance;
        private Configuration fakeConfiguration;
        private CreateCall createCallBody;
        private CreateCall mantecaCallBody;
        private UpdateConferenceMember updateConferenceMember;
        private string accountId;
        private string testConferenceId;
        private string testMemberId;
        private string testRecordingId;
        private string testUpdateBxml;

        public ConferencesIntegrationTests()
        {
            fakeConfiguration = new Configuration();
            fakeConfiguration.BasePath = "https://voice.bandwidth.com/api/v2";
            fakeConfiguration.Username = Environment.GetEnvironmentVariable("BW_USERNAME");
            fakeConfiguration.Password = Environment.GetEnvironmentVariable("BW_PASSWORD");
            conferenceApiInstance = new ConferencesApi(fakeConfiguration);


            // Unauthorized API Client
            fakeConfiguration.Username = "badUsername";
            fakeConfiguration.Password = "badPassword";
            unauthorizedInstance = new ConferencesApi(fakeConfiguration);

            // Forbidden API Client
            fakeConfiguration.Username = Environment.GetEnvironmentVariable("BW_USERNAME_FORBIDDEN");
            fakeConfiguration.Password = Environment.GetEnvironmentVariable("BW_PASSWORD_FORBIDDEN");
            forbiddenInstance = new ConferencesApi(fakeConfiguration);

            accountId = Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");

            restClient =  new ApiClient(basePath: "https://voice.bandwidth.com/api/v2");

            updateConferenceBody = new UpdateConference(
                status: ConferenceStateEnum.Active,
                redirectUrl: Environment.GetEnvironmentVariable("MANTECA_BASE_URL") + "/bxml/pause",
                redirectMethod: RedirectMethodEnum.POST,
                username: "mySecretUsername",
                password: "mySecretPassword!",
                redirectFallbackUrl: Environment.GetEnvironmentVariable("MANTECA_BASE_URL") + "/bxml/pause",
                redirectFallbackMethod: RedirectMethodEnum.POST,
                fallbackUsername: "mySecretUsername",
                fallbackPassword: "mySecretPassword!"
            );

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
                answerUrl: Environment.GetEnvironmentVariable("MANTECA_BASE_URL") + "/bxml/joinConferencePause",
                tag: "testID"
            );

            callsApiInstance = new CallsApi(fakeConfiguration);
            updateConferenceMember = new UpdateConferenceMember(mute: false);
            testConferenceId = "Conf-Id";
            testMemberId = "Member-Id";
            testRecordingId = "Recording-Id";
            testUpdateBxml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Bxml><SpeakSentence locale=\"en_US\" gender=\"female\" voice=\"susan\">This is test BXML.</SpeakSentence></Bxml>";
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void CreateConferenceTest()
        {
            // set up request options for creating a call
            var options = new RequestOptions();
            options.HeaderParameters.Add("os", Environment.GetEnvironmentVariable("OPERATING_SYSTEM"));
            options.HeaderParameters.Add("language", "csharp" + Environment.GetEnvironmentVariable("CSHARP_VERSION"));
            options.HeaderParameters.Add("type", "CONFERENCE");

            // initialize call with Manteca
            var response = restClient.Post<CreateCallResponse>(
                path: Environment.GetEnvironmentVariable("MANTECA_BASE_URL") + "tests",
                options: options
            );

            var testId = response.Data.ToString();
            mantecaCallBody.Tag = testId;

            CreateCallResponse callResponse = callsApiInstance.CreateCall(accountId, mantecaCallBody);

            Assert.IsType<string>(callResponse.CallId);
            Assert.Equal(Environment.GetEnvironmentVariable("BW_ACCOUNT_ID"), callResponse.AccountId);
            Assert.Equal(Environment.GetEnvironmentVariable("MANTECA_APPLICATION_ID"), callResponse.ApplicationId);
            Assert.Equal(Environment.GetEnvironmentVariable("MANTECA_IDLE_NUMBER"), callResponse.To);
            Assert.Equal(Environment.GetEnvironmentVariable("MANTECA_ACTIVE_NUMBER"), callResponse.From);

            System.Threading.Thread.Sleep(5000);

            var listConferencesResponse = conferenceApiInstance.ListConferencesWithHttpInfo(
                accountId: accountId,
                name: testId
            );
            Assert.Equal(HttpStatusCode.OK, listConferencesResponse.StatusCode);
        }

        /// <summary>
        /// Test List Conferences Unauthorized
        /// </summary>
        [Fact]
        public void ListConferencesUnauthorizedRequest()
        {
            // string accountId = "9900000";
            // string name = "my-custom-name";
            // string minCreatedTime = "2022-06-21T19:13:21Z";
            // string maxCreatedTime = "2022-06-21T19:13:21Z";
            // int? pageSize = 500;

            // fakeConfiguration.Username = "badUsername";
            // fakeConfiguration.Password = "badPassword";

            // ApiException Exception = Assert.Throws<ApiException>(() => conferenceApiInstance.ListConferencesWithHttpInfo(accountId, name, minCreatedTime, maxCreatedTime, pageSize));

            // Assert.Equal("Error calling ListConferences: ", Exception.Message);
            // Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test List Conferences Forbidden
        /// </summary>
        [Fact]
        public void ListConferenceForbiddenRequest()
        {
            // string accountId = "9900000";
            // string name = "my-custom-name";
            // string minCreatedTime = "2022-06-21T19:13:21Z";
            // string maxCreatedTime = "2022-06-21T19:13:21Z";
            // int? pageSize = 500;

            // fakeConfiguration.Username = "forbiddenUsername";
            // fakeConfiguration.Password = "forbiddenPassword";

            // var apiResponse = new ApiResponse<List<Conference>>(HttpStatusCode.OK, null);
            // mockClient.Setup(x => x.Get<List<Conference>>("/accounts/{accountId}/conferences", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            // var response = conferenceApiInstance.ListConferencesWithHttpInfo(accountId, name, minCreatedTime, maxCreatedTime, pageSize);

            // Assert.IsType<ApiResponse<List<Conference>>>(response);
            // Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test Get Conferences Unauthorized
        /// </summary>
        [Fact]
        public void GetConferencesUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.ListConferencesWithHttpInfo(accountId));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conferences Forbidden
        /// </summary>
        [Fact]
        public void GetConferencesForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.GetConferenceWithHttpInfo(accountId, testConferenceId));
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conferences Not Found
        /// </summary>
        [Fact]
        public void GetConferencesNotFound()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => conferenceApiInstance.GetConferenceWithHttpInfo(accountId, testConferenceId));
            Assert.Equal(404, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conference Member Unauthorized
        /// </summary>
        [Fact]
        public void GetConferenceMemberUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.GetConferenceMemberWithHttpInfo(accountId, testConferenceId, testMemberId));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conference Member Forbidden
        /// </summary>
        [Fact]
        public void GetConferenceMemberForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.GetConferenceMemberWithHttpInfo(accountId, testConferenceId, testMemberId));
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conference Member Not Found
        /// </summary>
        [Fact]
        public void GetConferenceMemberNotFoundRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => conferenceApiInstance.GetConferenceMemberWithHttpInfo(accountId, testConferenceId, testMemberId));
            Assert.Equal(404, Exception.ErrorCode);
        }

        /// <summary>
        /// Test List Conference Recordings Unauthorized
        /// </summary>
        [Fact]
        public void ListConferenceRecordingsUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.ListConferenceRecordingsWithHttpInfo(accountId, testConferenceId));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test List Conference Recordings Forbidden
        /// </summary> 
        [Fact]
        public void ListConferenceRecordingsForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.ListConferenceRecordingsWithHttpInfo(accountId, testConferenceId));
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conference Recording Unauthorized
        /// </summary>
        [Fact]
        public void GetConferenceRecordingUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.GetConferenceRecordingWithHttpInfo(accountId, testConferenceId, testRecordingId));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conference Recording Forbidden
        /// </summary>
        [Fact]
        public void GetConferenceRecordingForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.GetConferenceRecordingWithHttpInfo(accountId, testConferenceId, testRecordingId));
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conference Recording not found
        /// </summary>
        [Fact(Skip = "Actually throws a 500 error and needs to be fixed by the voice team")]
        public void GetConferenceRecordingNotFound()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => conferenceApiInstance.GetConferenceRecordingWithHttpInfo(accountId, testConferenceId, testRecordingId));
            Assert.Equal(404, Exception.ErrorCode); 
        }

        /// <summary>
        /// Test Update Conference Unauthorized Request
        /// </summary>
        [Fact]
        public void UpdateConferenceUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.UpdateConferenceWithHttpInfo(accountId, testConferenceId, updateConferenceBody));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Conference Forbidden Request
        /// </summary>
        [Fact]
        public void UpdateConferenceForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.UpdateConferenceWithHttpInfo(accountId, testConferenceId, updateConferenceBody));
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Conference Not Found
        /// </summary>
        [Fact]
        public void UpdateConferenceNotFoundRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => conferenceApiInstance.UpdateConferenceWithHttpInfo(accountId, testConferenceId, updateConferenceBody));

            Assert.Equal(404, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Conference BXML Unauthorized
        /// </summary> 
        [Fact]
        public void UpdateConferenceBxmlUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.UpdateConferenceBxmlWithHttpInfo(accountId, testConferenceId, testUpdateBxml));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        ///  Test Update Conference BXML Forbidden
        /// </summary>
        [Fact]
        public void UpdateConferenceBxmlForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.UpdateConferenceBxmlWithHttpInfo(accountId, testConferenceId, testUpdateBxml));
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Conference BXML Not Found
        /// </summary>
        [Fact]
        public void UpdateConferenceBxmlNotFoundRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => conferenceApiInstance.UpdateConferenceBxmlWithHttpInfo(accountId, testConferenceId, testUpdateBxml));
            Assert.Equal(404, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Conference Member Unauthorized
        /// </summary>
        [Fact]
        public void UpdateConferenceMemberUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.UpdateConferenceMemberWithHttpInfo(accountId, testConferenceId, testMemberId, updateConferenceMember));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Conference Member Forbidden
        /// </summary>
        [Fact]
        public void UpdateConferenceMemberForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.UpdateConferenceMemberWithHttpInfo(accountId, testConferenceId, testMemberId, updateConferenceMember));
            Assert.Equal(403, Exception.ErrorCode); // not erroring out
        }

        /// <summary>
        /// Test Update Conference Member Not Found
        /// </summary>
        [Fact]
        public void UpdateConferenceMemberNotFoundRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => conferenceApiInstance.UpdateConferenceMember(accountId, testConferenceId, testMemberId, updateConferenceMember));
            Assert.Equal(404, Exception.ErrorCode);
        }
    }
}
