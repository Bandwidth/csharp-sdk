using System;
using System.Collections.Generic;
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
    ///  Class for testing TranscriptionsApi
    /// </summary>
    public class TranscriptionsIntegrationTests : IDisposable
    {
        private TranscriptionsApi transcriptionsApiInstance;
        private CallsApi callsApiInstance;

        private TranscriptionsApi unauthorizedInstance;
        private TranscriptionsApi forbiddenInstance;
        private Configuration fakeConfiguration;
        private ApiClient restClient;
        private CreateCall mantecaCallBody;
        private string accountId;
        private string testCallId;
        private string testTranscriptionId;
        private string BW_USERNAME;
        private string BW_PASSWORD;
        private string MANTECA_ACTIVE_NUMBER;
        private string MANTECA_IDLE_NUMBER;
        private string MANTECA_APPLICATION_ID;
        private string MANTECA_BASE_URL;
        private string BW_FORBIDDEN_USERNAME;
        private string BW_FORBIDDEN_PASSWORD;

        public TranscriptionsIntegrationTests()
        {
            accountId = Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");
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
            transcriptionsApiInstance = new TranscriptionsApi(fakeConfiguration);
            callsApiInstance = new CallsApi(fakeConfiguration);

            // Unauthorized API Client
            fakeConfiguration.Username = "badUsername";
            fakeConfiguration.Password = "badPassword";
            unauthorizedInstance = new TranscriptionsApi(fakeConfiguration);

            // Forbidden API Client
            fakeConfiguration.Username = BW_FORBIDDEN_USERNAME;
            fakeConfiguration.Password = BW_FORBIDDEN_PASSWORD;
            forbiddenInstance = new TranscriptionsApi(fakeConfiguration);

            restClient = new ApiClient(basePath: "https://voice.bandwidth.com/api/v2");

            mantecaCallBody = new CreateCall(
                to: MANTECA_IDLE_NUMBER,
                from: MANTECA_ACTIVE_NUMBER,
                applicationId: MANTECA_APPLICATION_ID,
                answerUrl: MANTECA_BASE_URL + "/bxml/idle"
            );

            InitializeManteca();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        private void InitializeManteca()
        {
            // set up request options for creating a call
            var jsonBody = JsonSerializer.Serialize(new
            {
                os = Environment.GetEnvironmentVariable("OPERATING_SYSTEM"),
                language = "csharp" + Environment.GetEnvironmentVariable("DOTNET_VERSION"),
                type = "REAL_TIME_TRANSCRIPTION"
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
        }

        /// <summary>
        /// Test an instance of TranscriptionsAPi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<TranscriptionsApi>(transcriptionsApiInstance);
        }

        private void CreateCallTranscription()
        {
            string startTranscriptionBxml = $"<?xml version=\"1.0\" encoding=\"UTF-8\"?><Response><StartTranscription name=\"{mantecaCallBody.Tag}\" tracks=\"inbound\"></StartTranscription><Pause duration=\"6\"/></Response>";
            string stopTranscriptionBxml = $"<?xml version=\"1.0\" encoding=\"UTF-8\"?><Response><StopTranscription name=\"{mantecaCallBody.Tag}\"></StopTranscription></Response>";
            UpdateCall updateCallBody = new UpdateCall(state: CallStateEnum.Completed);

            // Create the call
            CreateCallResponse createCallResponse = callsApiInstance.CreateCall(accountId, mantecaCallBody);
            testCallId = createCallResponse.CallId;

            // Sleep for 3 seconds
            System.Threading.Thread.Sleep(3000);

            // Start the Transcription
            callsApiInstance.UpdateCallBxml(accountId, testCallId, startTranscriptionBxml);

            // Sleep for 3 seconds
            System.Threading.Thread.Sleep(3000);

            // Stop the Transcription
            callsApiInstance.UpdateCallBxml(accountId, testCallId, stopTranscriptionBxml);

            // End the call
            callsApiInstance.UpdateCall(accountId, testCallId, updateCallBody);
        }

        private void ListRealTimeTranscriptions()
        {
            // Sleep for 20 seconds
            System.Threading.Thread.Sleep(40000);

            List<CallTranscriptionMetadata> callTranscriptions = transcriptionsApiInstance.ListRealTimeTranscriptions(accountId, testCallId);
            Assert.NotEmpty(callTranscriptions);

            testTranscriptionId = callTranscriptions[0].TranscriptionId;
        }
        private void GetRealTimeTranscription()
        {
            CallTranscriptionResponse response = transcriptionsApiInstance.GetRealTimeTranscription(accountId, testCallId, testTranscriptionId);
            Assert.Equal(testCallId, response.CallId);
        }

        private void DeleteRealTimeTranscription()
        {
            transcriptionsApiInstance.DeleteRealTimeTranscription(accountId, testCallId, testTranscriptionId);
        }

        // Need these to run in a specific order
        [Fact]
        public void TestTranscriptionsSuccess()
        {
            CreateCallTranscription();
            ListRealTimeTranscriptions();
            GetRealTimeTranscription();
            DeleteRealTimeTranscription();
        }
    }
}
