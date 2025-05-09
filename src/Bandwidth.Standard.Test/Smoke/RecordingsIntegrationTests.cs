using System;
using System.Collections.Generic;
using Xunit;

using Bandwidth.Standard.Client;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Model;
using System.Net;
using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace Bandwidth.Standard.Test.Smoke
{
    /// <summary>
    ///  Class for testing RecordingsApi
    /// </summary>
    public class RecordingsSmokeTests : IDisposable
    {
        private RecordingsApi recordingApiInstance;
        private CallsApi callsApiInstance;
        private RecordingsApi unauthorizedInstance;
        private RecordingsApi forbiddenInstance;
        private Configuration fakeConfiguration;
        private ApiClient restClient;
        private CreateCall mantecaCallBody;
        private TranscribeRecording testTranscribeRecording;
        private string accountId;
        private string testCallId;
        private string testRecordingId;
        private string BW_USERNAME;
        private string BW_PASSWORD;
        private string MANTECA_ACTIVE_NUMBER;
        private string MANTECA_IDLE_NUMBER;
        private string MANTECA_APPLICATION_ID;
        private string MANTECA_BASE_URL;
        private string BW_FORBIDDEN_USERNAME;
        private string BW_FORBIDDEN_PASSWORD;

        public RecordingsSmokeTests()
        {
            accountId = Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");
            testCallId = "callId";
            testRecordingId = "recordingId";
            BW_USERNAME = Environment.GetEnvironmentVariable("BW_USERNAME");
            BW_PASSWORD = Environment.GetEnvironmentVariable("BW_PASSWORD");
            MANTECA_ACTIVE_NUMBER = Environment.GetEnvironmentVariable("MANTECA_ACTIVE_NUMBER");
            MANTECA_IDLE_NUMBER = Environment.GetEnvironmentVariable("MANTECA_IDLE_NUMBER");
            MANTECA_APPLICATION_ID = Environment.GetEnvironmentVariable("MANTECA_APPLICATION_ID");
            MANTECA_BASE_URL = Environment.GetEnvironmentVariable("MANTECA_BASE_URL");
            BW_FORBIDDEN_USERNAME = Environment.GetEnvironmentVariable("BW_USERNAME_FORBIDDEN");
            BW_FORBIDDEN_PASSWORD = Environment.GetEnvironmentVariable("BW_PASSWORD_FORBIDDEN");

            //API Client
            fakeConfiguration = new Configuration();
            fakeConfiguration.BasePath = "https://voice.bandwidth.com/api/v2";
            fakeConfiguration.Username = BW_USERNAME;
            fakeConfiguration.Password = BW_PASSWORD;
            recordingApiInstance = new RecordingsApi(fakeConfiguration);
            callsApiInstance = new CallsApi(fakeConfiguration);

            // Unauthorized API Client
            fakeConfiguration.Username = "badUsername";
            fakeConfiguration.Password = "badPassword";
            unauthorizedInstance = new RecordingsApi(fakeConfiguration);

            // Forbidden API Client
            fakeConfiguration.Username = BW_FORBIDDEN_USERNAME;
            fakeConfiguration.Password = BW_FORBIDDEN_PASSWORD;
            forbiddenInstance = new RecordingsApi(fakeConfiguration);

            restClient = new ApiClient(basePath: "https://voice.bandwidth.com/api/v2");

            mantecaCallBody = new CreateCall(
                to: MANTECA_IDLE_NUMBER,
                from: MANTECA_ACTIVE_NUMBER,
                applicationId: MANTECA_APPLICATION_ID,
                answerUrl: MANTECA_BASE_URL + "/bxml/joinConferencePause"
            );

            testTranscribeRecording = new TranscribeRecording(
                callbackUrl: MANTECA_BASE_URL + "/transcriptions",
                tag: "test"
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RecordingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<RecordingsApi>(recordingApiInstance);
        }

        /// <summary>
        /// Create and validate a call between two bandwidth numbers. Initializes the call with the Manteca system.
        /// </summary>
        /// <returns>
        /// A tuple containing the test id created in Manteca to track this call, as well as the call id for the created call.
        /// </returns>
        [Fact]
        public Tuple<string, string> CreateAndValidateCall()
        {
            var jsonBody = JsonSerializer.Serialize(new
            {
                os = Environment.GetEnvironmentVariable("OPERATING_SYSTEM"),
                language = "csharp" + Environment.GetEnvironmentVariable("DOTNET_VERSION"),
                type = "CALL"
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

            var createCallResponse = callsApiInstance.CreateCallWithHttpInfo(accountId, mantecaCallBody);
            Assert.Equal(47, createCallResponse.Data.CallId.Length);
            Assert.Equal(accountId, createCallResponse.Data.AccountId);
            Assert.Equal(MANTECA_APPLICATION_ID, createCallResponse.Data.ApplicationId);
            Assert.Equal(MANTECA_IDLE_NUMBER, createCallResponse.Data.To);
            Assert.Equal(MANTECA_ACTIVE_NUMBER, createCallResponse.Data.From);
            Assert.Equal("https://voice.bandwidth.com/api/v2/accounts/" + accountId + "/calls/" + createCallResponse.Data.CallId, createCallResponse.Data.CallUrl);

            return new Tuple<string, string>(testId, createCallResponse.Data.CallId);
        }

        /// <summary>
        /// Creates and completes an entire recorded call lifecycle.  A call should be completed and fully recorded.
        /// </summary>
        /// <returns>
        /// A tuple containing the test id to track this call in the Manteca system and the call id associated with the call in Bandwidth services.
        /// </returns>
        public Tuple<string, string> CompleteRecordedCall()
        {
            mantecaCallBody.AnswerUrl = MANTECA_BASE_URL + "/bxml/startRecording";
            Tuple<string, string> createCallResponse = CreateAndValidateCall();
            var testId = createCallResponse.Item1;
            var callId = createCallResponse.Item2;

            System.Threading.Thread.Sleep(12000);
            var callStatus = GetTestStatus(testId);
            JObject callStatusJson = JObject.Parse(callStatus);
            var retryCounter = 0;

            while (!(Boolean)callStatusJson["callRecorded"] && retryCounter < 40)
            {
                System.Threading.Thread.Sleep(5000);
                callStatus = GetTestStatus(testId);
                callStatusJson = JObject.Parse(callStatus);
                retryCounter++;
            }

            Assert.True((Boolean)callStatusJson["callRecorded"]);

            return (new Tuple<string, string>(testId, callId));

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
        /// Tests a successful flow of creating a call with a recording.
        /// </summary>
        [Fact]
        public void TestSuccessfulCallRecording()
        {
            Tuple<string, string> recordedCallResponse = CompleteRecordedCall();
            var testId = recordedCallResponse.Item1;
            var callId = recordedCallResponse.Item2;

            var listCallResponse = recordingApiInstance.ListCallRecordingsWithHttpInfo(accountId, callId);
            Assert.Equal(HttpStatusCode.OK, listCallResponse.StatusCode);

            List<CallRecordingMetadata> callRecording = listCallResponse.Data;
            Assert.Single(callRecording);

            var firstRecording = callRecording[0];
            Assert.Equal(accountId, firstRecording.AccountId);
            Assert.Equal(callId, firstRecording.CallId);
            Assert.Equal(MANTECA_APPLICATION_ID, firstRecording.ApplicationId);
            Assert.Equal("complete", firstRecording.Status);
            Assert.Equal(FileFormatEnum.Wav, firstRecording.FileFormat);

            var firstRecordingId = firstRecording.RecordingId;

            var getCallRecordingResponse = recordingApiInstance.GetCallRecordingWithHttpInfo(accountId, callId, firstRecordingId);
            Assert.Equal(HttpStatusCode.OK, getCallRecordingResponse.StatusCode);

            var recording = getCallRecordingResponse.Data;
            Assert.Equal(firstRecordingId, recording.RecordingId);
            Assert.Equal(accountId, recording.AccountId);
            Assert.Equal(callId, recording.CallId);
            Assert.Equal(MANTECA_APPLICATION_ID, recording.ApplicationId);
            Assert.Equal("complete", recording.Status);
            Assert.Equal(FileFormatEnum.Wav, recording.FileFormat);

            var downloadCallRecordingResponse = recordingApiInstance.DownloadCallRecordingWithHttpInfo(accountId, callId, firstRecordingId);
            var transcribeRecordingRequest = new TranscribeRecording(
                callbackUrl: MANTECA_BASE_URL + "/transcriptions",
                tag: testId
            );
            var transcribeCallRecording = recordingApiInstance.TranscribeCallRecordingWithHttpInfo(accountId, callId, firstRecordingId, transcribeRecordingRequest);
            Assert.Equal(HttpStatusCode.NoContent, transcribeCallRecording.StatusCode);

            var callStatus = GetTestStatus(testId);
            var retries = 0;
            JObject callStatusJson = JObject.Parse(callStatus);
            while (!(Boolean)callStatusJson["callTranscribed"] && retries < 40)
            {
                System.Threading.Thread.Sleep(5000);
                callStatus = GetTestStatus(testId);
                callStatusJson = JObject.Parse(callStatus);
                retries++;
            }
            Assert.True((Boolean)callStatusJson["callTranscribed"]);
            var transcriptionResponse = recordingApiInstance.GetRecordingTranscriptionWithHttpInfo(accountId, callId, firstRecordingId);
            Assert.Equal(HttpStatusCode.OK, transcriptionResponse.StatusCode);

            var transcription = transcriptionResponse.Data;
            Assert.Single(transcription.Transcripts);

            var firstTranscript = transcription.Transcripts[0];
            Assert.IsType<Transcription>(firstTranscript);
            Assert.IsType<string>(firstTranscript.Text);
            Assert.IsType<double>(firstTranscript.Confidence);

            // delete transcription
            var deleteTranscriptionResponse = recordingApiInstance.DeleteRecordingTranscriptionWithHttpInfo(accountId, callId, firstRecordingId);
            Assert.Equal(HttpStatusCode.NoContent, deleteTranscriptionResponse.StatusCode);

            // making sure transcription is deleted
            ApiException exception = Assert.Throws<ApiException>(() => recordingApiInstance.GetRecordingTranscription(accountId, callId, firstRecordingId));
            Assert.Equal(404, exception.ErrorCode);

            var deleteRecordingMediaResponse = recordingApiInstance.DeleteRecordingMediaWithHttpInfo(accountId, callId, firstRecordingId);
            Assert.Equal(HttpStatusCode.NoContent, deleteRecordingMediaResponse.StatusCode);

            // Delete recording
            var deleteRecordingResponse = recordingApiInstance.DeleteRecordingWithHttpInfo(accountId, callId, firstRecordingId);
            Assert.Equal(HttpStatusCode.NoContent, deleteRecordingResponse.StatusCode);
            var callRecordings = recordingApiInstance.ListCallRecordings(accountId, callId);
            Assert.Empty(callRecordings);
        }

        /// <summary>
        /// Tests a successful UpdateCallRecordingState request
        /// </summary>
        [Fact]
        public void TestSuccessfulUpdateActiveRecording()
        {
            mantecaCallBody.AnswerUrl = MANTECA_BASE_URL + "/bxml/startLongRecording";
            Tuple<string, string> createCallResponse = CreateAndValidateCall();
            var testId = createCallResponse.Item1;
            var callId = createCallResponse.Item2;


            var callStatus = GetTestStatus(testId);
            JObject callStatusJson = JObject.Parse(callStatus);
            var retryCounter = 0;

            while ((string)callStatusJson["status"] == "DEAD" && retryCounter < 40)
            {
                System.Threading.Thread.Sleep(5000);
                callStatus = GetTestStatus(testId);
                callStatusJson = JObject.Parse(callStatus);
                retryCounter++;
            }

            Assert.Equal("ALIVE", (string)callStatusJson["status"]);

            System.Threading.Thread.Sleep(5000);

            var updateCallRecording = new UpdateCallRecording(state: RecordingStateEnum.Paused);
            var updateCallRecordingResponse = recordingApiInstance.UpdateCallRecordingStateWithHttpInfo(accountId, callId, updateCallRecording);
            Assert.Equal(HttpStatusCode.OK, updateCallRecordingResponse.StatusCode);

            // Update the call to resume the recording
            updateCallRecording.State = RecordingStateEnum.Recording;
            updateCallRecordingResponse = recordingApiInstance.UpdateCallRecordingStateWithHttpInfo(accountId, callId, updateCallRecording);
            Assert.Equal(HttpStatusCode.OK, updateCallRecordingResponse.StatusCode);

            // End the call
            var updateCallBody = new UpdateCall(state: CallStateEnum.Completed);
            callsApiInstance.UpdateCall(accountId, callId, updateCallBody);
        }

        /// <summary>
        /// Test ListCallRecordings with an unauthorized client
        /// </summary>
        [Fact]
        public void ListCallRecordingsUnauthorizedRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.ListCallRecordingsWithHttpInfo(accountId, testCallId));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        ///  Test ListCallRecordings with a forbidden client
        /// </summary>
        [Fact]
        public void ListCallRecordingsForbiddenRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.ListCallRecordingsWithHttpInfo(accountId, testCallId));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test ListCallRecordings with a nonexistent call id
        /// The API returns an empty list rather than a 404
        /// </summary>
        [Fact]
        public void listCallRecordingsNotFound()
        {
            // exception = Assert.Throws<ApiException>(() => recordingApiInstance.ListCallRecordingsWithHttpInfo(accountId, "not-a-call-id"));
            // Assert.Equal(404, exception.ErrorCode);
            var callRecordings = recordingApiInstance.ListCallRecordings(accountId, "not-a-call-id");
            Assert.Empty(callRecordings);
        }

        /// <summary>
        /// Test GetCallRecording with an unauthorized client
        /// </summary>
        [Fact]
        public void GetCallRecordingUnauthorizedRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.GetCallRecordingWithHttpInfo(accountId, testCallId, testRecordingId));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test GetCallRecording with a forbidden client
        /// </summary>
        [Fact]
        public void GetCallRecordingForbiddenRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.GetCallRecordingWithHttpInfo(accountId, testCallId, testRecordingId));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test GetCallRecording with a nonexistent call id
        /// </summary>
        [Fact]
        public void GetCallRecordingNotFound()
        {
            ApiException exception = Assert.Throws<ApiException>(() => recordingApiInstance.GetCallRecordingWithHttpInfo(accountId, testCallId, "not-a-recording-id"));
            Assert.Equal(404, exception.ErrorCode);
        }

        /// <summary>
        /// Test DownloadCallRecording with an unauthorized client
        /// </summary>
        [Fact]
        public void DownloadCallRecordingUnauthorizedRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.DownloadCallRecordingWithHttpInfo(accountId, testCallId, testRecordingId));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test DownloadCallRecording with a forbidden client
        /// </summary>
        [Fact]
        public void DownloadCallRecordingForbiddenRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.DownloadCallRecordingWithHttpInfo(accountId, testCallId, testRecordingId));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test DownloadCallRecording with a nonexistent recording id
        /// </summary>
        [Fact]
        public void DownloadCallRecordingNotFound()
        {
            ApiException exception = Assert.Throws<ApiException>(() => recordingApiInstance.DownloadCallRecordingWithHttpInfo(accountId, testCallId, "not-a-recording-id"));
            Assert.Equal(404, exception.ErrorCode);
        }

        /// <summary>
        /// Test TranscribeCallRecording with an unauthorized client
        /// </summary>
        [Fact]
        public void TranscribeCallRecordingUnauthorizedRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.TranscribeCallRecordingWithHttpInfo(accountId, testCallId, testRecordingId, testTranscribeRecording));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test TranscribeCallRecording with a forbidden client
        /// </summary>
        [Fact]
        public void TranscribeCallRecordingForbiddenRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.TranscribeCallRecordingWithHttpInfo(accountId, testCallId, testRecordingId, testTranscribeRecording));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test TranscribeCallRecording with a nonexistent recording id
        /// The API returns a 500 error rather than a 404
        /// </summary>
        [Fact(Skip = "This test returns a 500 error rather than a 404")]
        public void TranscribeCallRecordingNotFound()
        {
            ApiException exception = Assert.Throws<ApiException>(() => recordingApiInstance.TranscribeCallRecordingWithHttpInfo(accountId, testCallId, "not-a-recording-id", testTranscribeRecording));
            Assert.Equal(404, exception.ErrorCode);
        }

        /// <summary>
        /// Test GetRecordingTranscription with an unauthorized client
        /// </summary>
        [Fact]
        public void GetRecordingTranscriptionUnauthorizedRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.GetRecordingTranscriptionWithHttpInfo(accountId, testCallId, testRecordingId));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test GetRecordingTranscription with a forbidden client
        /// </summary>
        [Fact]
        public void GetRecordingTranscriptionForbiddenRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.GetRecordingTranscriptionWithHttpInfo(accountId, testCallId, testRecordingId));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test GetRecordingTranscription with a nonexistent recording id
        /// </summary>
        [Fact]
        public void GetRecordingTranscriptionNotFound()
        {
            ApiException exception = Assert.Throws<ApiException>(() => recordingApiInstance.GetRecordingTranscriptionWithHttpInfo(accountId, testCallId, "not-a-recording-id"));
            Assert.Equal(404, exception.ErrorCode);
        }

        /// <summary>
        /// Test DeleteRecordingTranscription with an unauthorized client
        /// </summary>
        [Fact]
        public void DeleteRecordingTranscriptionUnauthorizedRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.DeleteRecordingTranscriptionWithHttpInfo(accountId, testCallId, testRecordingId));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test DeleteRecordingTranscription with a forbidden client
        /// </summary>
        [Fact]
        public void DeleteRecordingTranscriptionForbiddenRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.DeleteRecordingTranscriptionWithHttpInfo(accountId, testCallId, testRecordingId));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test DeleteRecordingTranscription with a nonexistent recording id
        /// </summary>
        [Fact]
        public void DeleteRecordingTranscriptionNotFound()
        {
            ApiException exception = Assert.Throws<ApiException>(() => recordingApiInstance.DeleteRecordingTranscriptionWithHttpInfo(accountId, testCallId, "not-a-recording-id"));
            Assert.Equal(404, exception.ErrorCode);
        }

        /// <summary>
        /// Test DeleteRecordingMedia with an unauthorized client
        /// </summary>
        [Fact]
        public void DeleteRecordingMediaUnauthorizedRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.DeleteRecordingMediaWithHttpInfo(accountId, testCallId, testRecordingId));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test DeleteRecordingMedia with a forbidden client
        /// </summary>
        [Fact]
        public void DeleteRecordingMediaForbiddenRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.DeleteRecordingMediaWithHttpInfo(accountId, testCallId, testRecordingId));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test DeleteRecordingMedia with a nonexistent recording id
        /// </summary>
        [Fact]
        public void DeleteRecordingMediaNotFound()
        {
            ApiException exception = Assert.Throws<ApiException>(() => recordingApiInstance.DeleteRecordingMediaWithHttpInfo(accountId, testCallId, "not-a-recording-id"));
            Assert.Equal(404, exception.ErrorCode);
        }

        /// <summary>
        /// Test DeleteRecording with an unauthorized client
        /// </summary>
        [Fact]
        public void DeleteRecordingUnauthorizedRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.DeleteRecordingWithHttpInfo(accountId, testCallId, testRecordingId));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test DeleteRecording with a forbidden client
        /// </summary>
        [Fact]
        public void DeleteRecordingForbiddenRequest()
        {
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.DeleteRecordingWithHttpInfo(accountId, testCallId, testRecordingId));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test DeleteRecording with a nonexistent recording id
        /// </summary>
        [Fact]
        public void DeleteRecordingNotFound()
        {
            ApiException exception = Assert.Throws<ApiException>(() => recordingApiInstance.DeleteRecordingWithHttpInfo(accountId, testCallId, "not-a-recording-id"));
            Assert.Equal(404, exception.ErrorCode);
        }

        /// <summary>
        /// Test UpdateCallRecordingState with an unauthorized client
        /// </summary>
        [Fact]
        public void UpdateCallRecordingStateUnauthorizedRequest()
        {
            var updateCallRecording = new UpdateCallRecording(state: RecordingStateEnum.Paused);
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.UpdateCallRecordingStateWithHttpInfo(accountId, testCallId, updateCallRecording));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test UpdateCallRecordingState with a forbidden client
        /// </summary>
        [Fact]
        public void UpdateCallRecordingStateForbiddenRequest()
        {
            var updateCallRecording = new UpdateCallRecording(state: RecordingStateEnum.Paused);
            ApiException exception = Assert.Throws<ApiException>(() => forbiddenInstance.UpdateCallRecordingStateWithHttpInfo(accountId, testCallId, updateCallRecording));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test UpdateCallRecordingState with a nonexistent call id
        /// </summary>
        [Fact (Skip = "PV Issue")]
        public void UpdateCallRecordingStateNotFound()
        {
            var updateCallRecording = new UpdateCallRecording(state: RecordingStateEnum.Paused);
            ApiException exception = Assert.Throws<ApiException>(() => recordingApiInstance.UpdateCallRecordingStateWithHttpInfo(accountId, "not-a-call-id", updateCallRecording));
            Assert.Equal(404, exception.ErrorCode);
        }
    }
}
