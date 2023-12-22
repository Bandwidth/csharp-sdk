using System;
using Xunit;

using Bandwidth.Standard.Client;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Model;
using System.Net;
using System.Text.Json;
using Newtonsoft.Json.Linq;

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
        private CreateCall mantecaCallBody;
        private UpdateConferenceMember updateConferenceMember;
        private string accountId;
        private string testConferenceId;
        private string testMemberId;
        private string testRecordingId;
        private string testUpdateBxml;

        public ConferencesIntegrationTests()
        {
            accountId = Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");
            testConferenceId = "Conf-Id";
            testMemberId = "Member-Id";
            testRecordingId = "Recording-Id";
            testUpdateBxml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Bxml><SpeakSentence locale=\"en_US\" gender=\"female\" voice=\"susan\">This is test BXML.</SpeakSentence></Bxml>";

            // Authorized API Client
            fakeConfiguration = new Configuration();
            fakeConfiguration.BasePath = "https://voice.bandwidth.com/api/v2";
            fakeConfiguration.Username = Environment.GetEnvironmentVariable("BW_USERNAME");
            fakeConfiguration.Password = Environment.GetEnvironmentVariable("BW_PASSWORD");
            conferenceApiInstance = new ConferencesApi(fakeConfiguration);
            callsApiInstance = new CallsApi(fakeConfiguration);

            // Unauthorized API Client
            fakeConfiguration.Username = "badUsername";
            fakeConfiguration.Password = "badPassword";
            unauthorizedInstance = new ConferencesApi(fakeConfiguration);

            // Forbidden API Client
            fakeConfiguration.Username = Environment.GetEnvironmentVariable("BW_USERNAME_FORBIDDEN");
            fakeConfiguration.Password = Environment.GetEnvironmentVariable("BW_PASSWORD_FORBIDDEN");
            forbiddenInstance = new ConferencesApi(fakeConfiguration);

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

            mantecaCallBody = new CreateCall(
                to: Environment.GetEnvironmentVariable("MANTECA_IDLE_NUMBER"),
                from: Environment.GetEnvironmentVariable("MANTECA_ACTIVE_NUMBER"),
                applicationId: Environment.GetEnvironmentVariable("MANTECA_APPLICATION_ID"),
                answerUrl: Environment.GetEnvironmentVariable("MANTECA_BASE_URL") + "/bxml/joinConferencePause"
            );

            updateConferenceMember = new UpdateConferenceMember(mute: false);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Create and validate a call between two bandwidth numbers.  Initializes the call with the Manteca
        /// system.
        /// </summary>
        /// <returns> 
        /// A tuple containing the test id created in Manteca to track this call, as well as the conference and call id for the created call.
        /// </returns>
        [Fact]
        public Tuple<string, string> CreateConferenceTest()
        {
            // set up request options for creating a call
            var jsonBody = JsonSerializer.Serialize(new
            {
                os = Environment.GetEnvironmentVariable("OPERATING_SYSTEM"),
                language = "csharp" + Environment.GetEnvironmentVariable("DOTNET_VERSION"),
                type = "CONFERENCE"
            });
            var options = new RequestOptions
            {
                Data = jsonBody,
                HeaderParameters = new Multimap<string, string>
                {
                    { "Content-Type", "application/json" }
                }
            };

            // initialize call with Manteca
            var response = restClient.Post<object>(
                path: Environment.GetEnvironmentVariable("MANTECA_BASE_URL") + "/tests",
                options: options
            );
            var testId = response.RawContent;
            mantecaCallBody.Tag = testId;

            CreateCallResponse callResponse = callsApiInstance.CreateCall(accountId, mantecaCallBody);
            var callId = callResponse.CallId;

            Assert.IsType<string>(callId);
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

            // TODO: This is not deterministic; our latest conference may not always be the one we just created due to parallelism.
            // This new solution should guarantee the right conference id is grabbed.
            var conferenceId = listConferencesResponse.Data[0].Id;

            var getConferenceResponse = conferenceApiInstance.GetConferenceWithHttpInfo(
                accountId: accountId,
                conferenceId: conferenceId
            );
            Assert.Equal(HttpStatusCode.OK, getConferenceResponse.StatusCode);
            Assert.Equal(conferenceId, getConferenceResponse.Data.Id);
            Assert.Equal(testId, getConferenceResponse.Data.Name);


            return Tuple.Create(testId, conferenceId);
        }

        /// <summary>
        /// Get the status of the specified test by its id value from Manteca services.
        /// </summary>
        /// <param name="testId">The test id associated with the test to get the status of.</param>
        /// <returns>
        /// A string containing the status of the test requested.
        /// </returns>
        
        public string GetTestStatus(string testId)
        {
            var options = new RequestOptions
            {
                HeaderParameters = new Multimap<string, string>
                {
                    { "Content-Type", "text/plain" }
                }
            };

            // get test status from Manteca
            var response = restClient.Get<object>(
                path: Environment.GetEnvironmentVariable("MANTECA_BASE_URL") + "/tests/" + testId,
                options: options
            );
            
            return response.Content.ToString();
        }

        /// <summary>
        /// Tests a successful flow of creating and ending a conference.
        /// </summary>
        [Fact]
        public void testConferenceAndMembers()
        {
            Tuple <string, string> createCoferenceResponse = CreateConferenceTest();
            var testId = createCoferenceResponse.Item1;
            var conferenceId = createCoferenceResponse.Item2;

            var listConferencesResponse = conferenceApiInstance.ListConferencesWithHttpInfo(accountId);
            Assert.Equal(HttpStatusCode.OK, listConferencesResponse.StatusCode);
            Assert.IsType<string>(listConferencesResponse.Data[0].Name);
            Assert.IsType<string>(listConferencesResponse.Data[0].Id);

            var getConferenceResponse = conferenceApiInstance.GetConferenceWithHttpInfo(accountId, conferenceId);
            Assert.Equal(HttpStatusCode.OK, getConferenceResponse.StatusCode);
            Assert.Equal(conferenceId, getConferenceResponse.Data.Id);
            Assert.IsType<string>(getConferenceResponse.Data.Name);
            
            var callId = getConferenceResponse.Data.ActiveMembers[0].CallId;

            var GetConferenceMemberResponse = conferenceApiInstance.GetConferenceMemberWithHttpInfo(accountId, conferenceId, callId);
            Assert.Equal(HttpStatusCode.OK, GetConferenceMemberResponse.StatusCode);
            Assert.Equal(conferenceId, GetConferenceMemberResponse.Data.ConferenceId);
            Assert.Equal(callId, GetConferenceMemberResponse.Data.CallId);

            var updateConferenceMemberResponse = conferenceApiInstance.UpdateConferenceMemberWithHttpInfo(accountId, conferenceId, callId, updateConferenceMember);
            Assert.Equal(HttpStatusCode.NoContent, updateConferenceMemberResponse.StatusCode);

            var updateConferenceResponse = conferenceApiInstance.UpdateConferenceWithHttpInfo(accountId, conferenceId, updateConferenceBody);
            Assert.Equal(HttpStatusCode.NoContent, updateConferenceResponse.StatusCode);

            testUpdateBxml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Bxml><SpeakSentence locale=\"en_US\" gender=\"female\" voice=\"susan\">This is a test bxml response</SpeakSentence></Bxml>";

            var updateConferenceBxmlResponse = conferenceApiInstance.UpdateConferenceBxmlWithHttpInfo(accountId, conferenceId, testUpdateBxml);
            Assert.Equal(HttpStatusCode.NoContent, updateConferenceBxmlResponse.StatusCode);

            var updateCall = new UpdateCall(
                state: CallStateEnum.Completed
            );
            // hang up call
            callsApiInstance.UpdateCall(accountId, callId, updateCall);
        }   

        /// <summary>
        /// Test Conference Recordings
        /// Tests a successful flow of creating a call with a recording.
        /// </summary>
        [Fact]
        public void testConferenceRecordings()
        {
            Tuple <string, string> createCoferenceResponse = CreateConferenceTest();
            var testId = createCoferenceResponse.Item1;
            var conferenceId = createCoferenceResponse.Item2;
            var listConferencesResponse = conferenceApiInstance.ListConferencesWithHttpInfo(accountId);
            Assert.Equal(HttpStatusCode.OK, listConferencesResponse.StatusCode);

            testUpdateBxml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Bxml><StartRecording/><SpeakSentence locale=\"en_US\" gender=\"female\" voice=\"susan\">This should be a conference recording.</SpeakSentence><StopRecording/></Bxml>";

            var updateConferenceBxmlResponse = conferenceApiInstance.UpdateConferenceBxmlWithHttpInfo(accountId, conferenceId, testUpdateBxml);
            Assert.Equal(HttpStatusCode.NoContent, updateConferenceBxmlResponse.StatusCode);

            var callStatus = GetTestStatus(testId);
            var retryCounter = 0;
            JObject callStatusJson = JObject.Parse(callStatus);

            while (!(Boolean)callStatusJson["callRecorded"] && retryCounter < 10)
            {
                System.Threading.Thread.Sleep(5000);
                callStatus = GetTestStatus(testId);
                callStatusJson = JObject.Parse(callStatus);
                retryCounter++;
            }
            Assert.True((Boolean)callStatusJson["callRecorded"]);

            var listConferenceRecordingsResponse = conferenceApiInstance.ListConferenceRecordingsWithHttpInfo(accountId, conferenceId);
            Assert.Equal(HttpStatusCode.OK, listConferenceRecordingsResponse.StatusCode);
            Assert.NotEmpty(listConferenceRecordingsResponse.Data);

            ConferenceRecordingMetadata firstRecording = listConferenceRecordingsResponse.Data[0];
            Assert.Equal("complete", firstRecording.Status);
            Assert.Equal(FileFormatEnum.Wav, firstRecording.FileFormat);

            var firstRecordingId = firstRecording.RecordingId;
            var getConferenceRecordingResponse = conferenceApiInstance.GetConferenceRecordingWithHttpInfo(accountId, conferenceId, firstRecordingId);
            Assert.Equal(HttpStatusCode.OK, getConferenceRecordingResponse.StatusCode);
            Assert.Equal(conferenceId, getConferenceRecordingResponse.Data.ConferenceId);
            Assert.Equal(firstRecordingId, getConferenceRecordingResponse.Data.RecordingId);
            Assert.IsType<string>(getConferenceRecordingResponse.Data.Name);
            Assert.Equal("complete", getConferenceRecordingResponse.Data.Status);
            Assert.Equal(FileFormatEnum.Wav, getConferenceRecordingResponse.Data.FileFormat);

            var recordingMediaResponse = conferenceApiInstance.DownloadConferenceRecordingWithHttpInfo(accountId, conferenceId, firstRecordingId);
            Assert.Equal(HttpStatusCode.OK, recordingMediaResponse.StatusCode);
        } 

        /// <summary>
        /// Test List Conferences Unauthorized
        /// </summary>
        [Fact]
        public void ListConferencesUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.ListConferencesWithHttpInfo(accountId));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test List Conferences Forbidden
        /// </summary>
        [Fact]
        public void ListConferenceForbiddenRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.ListConferencesWithHttpInfo(accountId));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conferences Unauthorized
        /// </summary>
        [Fact]
        public void GetConferencesUnauthorizedRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.ListConferencesWithHttpInfo(accountId));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conferences Forbidden
        /// </summary>
        [Fact]
        public void GetConferencesForbiddenRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.GetConferenceWithHttpInfo(accountId, testConferenceId));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conferences Not Found
        /// </summary>
        [Fact]
        public void GetConferencesNotFound()
        {
            ApiException exception = Assert.Throws<ApiException>(() => conferenceApiInstance.GetConferenceWithHttpInfo(accountId, testConferenceId));
            Assert.Equal(404, exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conference Member Unauthorized
        /// </summary>
        [Fact]
        public void GetConferenceMemberUnauthorizedRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.GetConferenceMemberWithHttpInfo(accountId, testConferenceId, testMemberId));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conference Member Forbidden
        /// </summary>
        [Fact]
        public void GetConferenceMemberForbiddenRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.GetConferenceMemberWithHttpInfo(accountId, testConferenceId, testMemberId));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conference Member Not Found
        /// </summary>
        [Fact]
        public void GetConferenceMemberNotFoundRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => conferenceApiInstance.GetConferenceMemberWithHttpInfo(accountId, testConferenceId, testMemberId));
            Assert.Equal(404, exception.ErrorCode);
        }

        /// <summary>
        /// Test List Conference Recordings Unauthorized
        /// </summary>
        [Fact]
        public void ListConferenceRecordingsUnauthorizedRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.ListConferenceRecordingsWithHttpInfo(accountId, testConferenceId));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test List Conference Recordings Forbidden
        /// </summary> 
        [Fact]
        public void ListConferenceRecordingsForbiddenRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.ListConferenceRecordingsWithHttpInfo(accountId, testConferenceId));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conference Recording Unauthorized
        /// </summary>
        [Fact]
        public void GetConferenceRecordingUnauthorizedRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.GetConferenceRecordingWithHttpInfo(accountId, testConferenceId, testRecordingId));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conference Recording Forbidden
        /// </summary>
        [Fact]
        public void GetConferenceRecordingForbiddenRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.GetConferenceRecordingWithHttpInfo(accountId, testConferenceId, testRecordingId));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test Get Conference Recording not found
        /// </summary>
        [Fact(Skip = "Actually throws a 500 error and needs to be fixed by the voice team")]
        public void GetConferenceRecordingNotFound()
        {
            ApiException exception = Assert.Throws<ApiException>(() => conferenceApiInstance.GetConferenceRecordingWithHttpInfo(accountId, testConferenceId, testRecordingId));
            Assert.Equal(404, exception.ErrorCode); 
        }

        /// <summary>
        /// Test Update Conference Unauthorized Request
        /// </summary>
        [Fact]
        public void UpdateConferenceUnauthorizedRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.UpdateConferenceWithHttpInfo(accountId, testConferenceId, updateConferenceBody));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Conference Forbidden Request
        /// </summary>
        [Fact]
        public void UpdateConferenceForbiddenRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.UpdateConferenceWithHttpInfo(accountId, testConferenceId, updateConferenceBody));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Conference Not Found
        /// </summary>
        [Fact]
        public void UpdateConferenceNotFoundRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => conferenceApiInstance.UpdateConferenceWithHttpInfo(accountId, testConferenceId, updateConferenceBody));

            Assert.Equal(404, exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Conference BXML Unauthorized
        /// </summary> 
        [Fact]
        public void UpdateConferenceBxmlUnauthorizedRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.UpdateConferenceBxmlWithHttpInfo(accountId, testConferenceId, testUpdateBxml));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        ///  Test Update Conference BXML Forbidden
        /// </summary>
        [Fact]
        public void UpdateConferenceBxmlForbiddenRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.UpdateConferenceBxmlWithHttpInfo(accountId, testConferenceId, testUpdateBxml));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Conference BXML Not Found
        /// </summary>
        [Fact]
        public void UpdateConferenceBxmlNotFoundRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => conferenceApiInstance.UpdateConferenceBxmlWithHttpInfo(accountId, testConferenceId, testUpdateBxml));
            Assert.Equal(404, exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Conference Member Unauthorized
        /// </summary>
        [Fact]
        public void UpdateConferenceMemberUnauthorizedRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.UpdateConferenceMemberWithHttpInfo(accountId, testConferenceId, testMemberId, updateConferenceMember));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test Update Conference Member Forbidden
        /// </summary>
        [Fact]
        public void UpdateConferenceMemberForbiddenRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.UpdateConferenceMemberWithHttpInfo(accountId, testConferenceId, testMemberId, updateConferenceMember));
            Assert.Equal(403, exception.ErrorCode); // not erroring out
        }

        /// <summary>
        /// Test Update Conference Member Not Found
        /// </summary>
        [Fact]
        public void UpdateConferenceMemberNotFoundRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => conferenceApiInstance.UpdateConferenceMember(accountId, testConferenceId, testMemberId, updateConferenceMember));
            Assert.Equal(404, exception.ErrorCode);
        }
    }
}
