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
using Moq;
using System.Net;
using System.Data.SqlTypes;
using Bandwidth.Standard.Model;
using System.Security.Authentication;

namespace Bandwidth.Standard.Test.Api
{
    /// <summary>
    ///  Class for testing TranscriptionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TranscriptionsApiTests : IDisposable
    {
        private TranscriptionsApi instance;
        private Mock<ISynchronousClient> mockClient;
        private Mock<IAsynchronousClient> mockAsynchronousClient;
        private Configuration fakeConfiguration;

        public TranscriptionsApiTests()
        {
            mockClient = new Mock<ISynchronousClient>();
            mockAsynchronousClient = new Mock<IAsynchronousClient>();
            fakeConfiguration = new Configuration();
            fakeConfiguration.BasePath = "https://voice.bandwidth.com/api/v2";
            fakeConfiguration.Username = "username";
            fakeConfiguration.Password = "password";
            instance = new TranscriptionsApi(mockClient.Object, mockAsynchronousClient.Object, fakeConfiguration);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TranscriptionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<TranscriptionsApi>(instance);
        }

        /// <summary>
        /// Test DeleteRealTimeTranscription
        /// </summary>
        [Fact]
        public void DeleteRealTimeTranscriptionTest()
        {
            string accountId = "9900000";
            string callId = "c-12345";
            string transcriptionId = "t-12345";

            var apiResponse = new ApiResponse<Object>(HttpStatusCode.NoContent, null);
            mockClient.Setup(x => x.Delete<Object>("/accounts/{accountId}/calls/{callId}/transcriptions/{transcriptionId}", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.DeleteRealTimeTranscriptionWithHttpInfo(accountId, callId, transcriptionId);

            Assert.IsType<ApiResponse<Object>>(response);
            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
        }

        /// <summary>
        /// Test GetRealTimeTranscription
        /// </summary>
        [Fact]
        public void GetRealTimeTranscriptionTest()
        {
            string accountId = "9900000";
            string callId = "c-12345";
            string transcriptionId = "t-12345";

            CallTranscriptionDetectedLanguageEnum detectedLanguage = CallTranscriptionDetectedLanguageEnum.EnUS;
            CallTranscriptionTrackEnum track = CallTranscriptionTrackEnum.Inbound;

            CallTranscription transcription = new CallTranscription(detectedLanguage: detectedLanguage, track: track, transcript: "abc 123 this is a test", confidence: 0.9);

            List<CallTranscription> tracks = new List<CallTranscription> { transcription };

            CallTranscriptionResponse callTranscriptionResponse = new CallTranscriptionResponse(accountId: accountId, callId: callId, transcriptionId: transcriptionId, tracks: tracks);

            var apiResponse = new ApiResponse<CallTranscriptionResponse>(HttpStatusCode.NoContent, callTranscriptionResponse);
            mockClient.Setup(x => x.Get<CallTranscriptionResponse>("/accounts/{accountId}/calls/{callId}/transcriptions/{transcriptionId}", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.GetRealTimeTranscription(accountId, callId, transcriptionId);

            Assert.IsType<CallTranscriptionResponse>(response);
        }

        /// <summary>
        /// Test ListRealTimeTranscriptions
        /// </summary>
        [Fact]
        public void ListRealTimeTranscriptionsTest()
        {
            string accountId = "9900000";
            string callId = "c-12345";

            CallTranscriptionMetadata transcription = new CallTranscriptionMetadata(transcriptionId: "t-12345", transcriptionUrl: "https://voice.bandwidth.com/api/v2/accounts/9900000/calls/c-12345/transcriptions/t-12345");
            List<CallTranscriptionMetadata> callTranscriptions = new List<CallTranscriptionMetadata> { transcription };

            var apiResponse = new ApiResponse<List<CallTranscriptionMetadata>>(HttpStatusCode.NoContent, callTranscriptions);
            mockClient.Setup(x => x.Get<List<CallTranscriptionMetadata>>("/accounts/{accountId}/calls/{callId}/transcriptions", It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.ListRealTimeTranscriptions(accountId, callId);

            Assert.IsType<List<CallTranscriptionMetadata>>(response);
        }
    }
}
