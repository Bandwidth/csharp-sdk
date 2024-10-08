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

namespace Bandwidth.Standard.Test.Unit.Api
{
    /// <summary>
    ///  Class for testing ConferencesApi
    /// </summary>
    public class ConferencesApiTests : IDisposable
    {
        private ConferencesApi instance;
        private Mock<ISynchronousClient> mockClient;
        private Mock<IAsynchronousClient> mockAsynchronousClient;
        private Configuration fakeConfiguration;

        public ConferencesApiTests()
        {
            mockClient = new Mock<ISynchronousClient>();
            mockAsynchronousClient = new Mock<IAsynchronousClient>();
            fakeConfiguration = new Configuration();
            fakeConfiguration.BasePath = "https://voice.bandwidth.com/api/v2";
            fakeConfiguration.Username = "username";
            fakeConfiguration.Password = "password";
            instance = new ConferencesApi(mockClient.Object, mockAsynchronousClient.Object, fakeConfiguration);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConferencesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<ConferencesApi>(instance);
        }

        /// <summary>
        /// Test DownloadConferenceRecording
        /// </summary>
        [Fact]
        public void DownloadConferenceRecordingTest()
        {
            string accountId = "9900000";
            string conferenceId = "conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9";
            string recordingId = "r-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85";

            var apiResponse = new ApiResponse<System.IO.Stream>(HttpStatusCode.OK, null);
            mockClient.Setup(x => x.Get<System.IO.Stream>("/accounts/{accountId}/conferences/{conferenceId}/recordings/{recordingId}/media",It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.DownloadConferenceRecordingWithHttpInfo(accountId, conferenceId, recordingId);

            Assert.IsAssignableFrom<ApiResponse<System.IO.Stream>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test GetConference
        /// </summary>
        [Fact]
        public void GetConferenceTest()
        {
            string accountId = "9900000";
            string conferenceId = "conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9";
            var conference = new Conference(
                id: "conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9",
                name: "my-conference-name",
                createdTime: new DateTime(2022, 06, 17, 22, 20, 00),
                completedTime: new DateTime(2022, 06, 17, 22, 20, 00),
                conferenceEventUrl: "https://myServer.example/bandwidth/webhooks/conferenceEvent",
                conferenceEventMethod: CallbackMethodEnum.POST,
                tag: "my custom tag"
            );

            var apiResponse = new ApiResponse<Conference>(HttpStatusCode.OK, conference);
            mockClient.Setup(x => x.Get<Conference>("/accounts/{accountId}/conferences/{conferenceId}",It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.GetConferenceWithHttpInfo(accountId, conferenceId);

            Assert.IsType<ApiResponse<Conference>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test GetConferenceMember
        /// </summary>
        [Fact]
        public void GetConferenceMemberTest()
        {
            string accountId = "9900000";
            string conferenceId = "conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9";
            string memberId = "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85";
            ConferenceMember conferenceMember = new ConferenceMember(
                callId: "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85",
                conferenceId: "conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9",
                memberUrl: "https://voice.bandwidth.com/api/v2/accounts/9900000/conferences/conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9/members/c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85",
                mute: false,
                hold: false,
                callIdsToCoach: new List<string> { "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85" }
            );

            var apiResponse = new ApiResponse<ConferenceMember>(HttpStatusCode.OK, conferenceMember);
            mockClient.Setup(x => x.Get<ConferenceMember>("/accounts/{accountId}/conferences/{conferenceId}/members/{memberId}",It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.GetConferenceMemberWithHttpInfo(accountId, conferenceId, memberId);

            Assert.IsType<ApiResponse<ConferenceMember>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test GetConferenceRecording
        /// </summary>
        [Fact]
        public void GetConferenceRecordingTest()
        {
            string accountId = "9900000";
            string conferenceId = "conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9";
            string recordingId = "r-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85";
            ConferenceRecordingMetadata conferenceRecordingMetadata = new ConferenceRecordingMetadata(
                accountId: "920012",
                conferenceId: "conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9",
                name: "my-conference-name",
                recordingId: "r-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85",
                duration: "PT13.67S",
                channels: 1,
                startTime: new DateTime(2022, 06, 17, 22, 20, 00),
                endTime: new DateTime(2022, 06, 17, 22, 20, 00),
                fileFormat: FileFormatEnum.Wav,
                status: "complete",
                mediaUrl:"https://voice.bandwidth.com/api/v2/accounts/9900000/conferences/conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9/recordings/r-fbe05094-9fd2afe9-bf5b-4c68-820a-41a01c1c5833/media"
            );

            var apiResponse = new ApiResponse<ConferenceRecordingMetadata>(HttpStatusCode.OK, conferenceRecordingMetadata);
            mockClient.Setup(x => x.Get<ConferenceRecordingMetadata>("/accounts/{accountId}/conferences/{conferenceId}/recordings/{recordingId}",It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.GetConferenceRecordingWithHttpInfo(accountId, conferenceId, recordingId);

            Assert.IsType<ApiResponse<ConferenceRecordingMetadata>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test ListConferenceRecordings
        /// </summary>
        [Fact]
        public void ListConferenceRecordingsTest()
        {
            string accountId = "9900000";
            string conferenceId = "conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9";
            ConferenceRecordingMetadata conferenceRecordingMetadata = new ConferenceRecordingMetadata(
                accountId: "920012",
                conferenceId: "conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9",
                name: "my-conference-name",
                recordingId: "r-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85",
                duration: "PT13.67S",
                channels: 1,
                startTime: new DateTime(2022, 06, 17, 22, 20, 00),
                endTime: new DateTime(2022, 06, 17, 22, 20, 00),
                fileFormat: FileFormatEnum.Wav,
                status: "complete",
                mediaUrl:"https://voice.bandwidth.com/api/v2/accounts/9900000/conferences/conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9/recordings/r-fbe05094-9fd2afe9-bf5b-4c68-820a-41a01c1c5833/media"
            );

            var apiResponse = new ApiResponse<List<ConferenceRecordingMetadata>>(HttpStatusCode.OK, new List<ConferenceRecordingMetadata>() { conferenceRecordingMetadata });
            mockClient.Setup(x => x.Get<List<ConferenceRecordingMetadata>>("/accounts/{accountId}/conferences/{conferenceId}/recordings",It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.ListConferenceRecordingsWithHttpInfo(accountId, conferenceId);

            Assert.IsType<ApiResponse<List<ConferenceRecordingMetadata>>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test ListConferences
        /// </summary>
        [Fact]
        public void ListConferencesTest()
        {
            string accountId = "9900000";
            string name = "my-custom-name";
            string minCreatedTime = "2022-06-21T19:13:21Z";
            string maxCreatedTime = "2022-06-21T19:13:21Z";
            int? pageSize = 500;
            var conference = new Conference(
                id: "conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9",
                name: "my-conference-name",
                createdTime: new DateTime(2022, 06, 17, 22, 20, 00),
                completedTime: new DateTime(2022, 06, 17, 22, 20, 00),
                conferenceEventUrl: "https://myServer.example/bandwidth/webhooks/conferenceEvent",
                conferenceEventMethod: CallbackMethodEnum.POST,
                tag: "my custom tag"
            );

            var apiResponse = new ApiResponse<List<Conference>>(HttpStatusCode.OK, new List<Conference>() { conference });
            mockClient.Setup(x => x.Get<List<Conference>>("/accounts/{accountId}/conferences",It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.ListConferencesWithHttpInfo(accountId, name, minCreatedTime, maxCreatedTime, pageSize);

            Assert.IsType<ApiResponse<List<Conference>>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test UpdateConference
        /// </summary>
        [Fact]
        public void UpdateConferenceTest()
        {
            string accountId = "9900000";
            string conferenceId = "conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9";
            var conference = new Conference(
                id: "conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9",
                name: "my-conference-name",
                createdTime: new DateTime(2022, 06, 17, 22, 20, 00),
                completedTime: new DateTime(2022, 06, 17, 22, 20, 00),
                conferenceEventUrl: "https://myServer.example/bandwidth/webhooks/conferenceEvent",
                conferenceEventMethod: CallbackMethodEnum.POST,
                tag: "my custom tag"
            );
            UpdateConference updateConference = new UpdateConference(
                status: ConferenceStateEnum.Completed,
                redirectUrl: "https://myServer.example/bandwidth/webhooks/conferenceRedirect",
                redirectMethod: RedirectMethodEnum.POST,
                username: "username",
                password: "password",
                redirectFallbackUrl: "https://myFallbackServer.example/bandwidth/webhooks/conferenceRedirect",
                redirectFallbackMethod: RedirectMethodEnum.POST,
                fallbackUsername: "fallbackUsername",
                fallbackPassword: "fallbackPassword"
            );

            var apiResponse = new ApiResponse<Object>(HttpStatusCode.OK, conference);
            mockClient.Setup(x => x.Post<Object>("/accounts/{accountId}/conferences/{conferenceId}",It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.UpdateConferenceWithHttpInfo(accountId, conferenceId, updateConference);
            
            Assert.IsType<ApiResponse<Object>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test UpdateConferenceBxml
        /// </summary>
        [Fact]
        public void UpdateConferenceBxmlTest()
        {
            string accountId = "9900000";
            string conferenceId = "conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9";
            string body = "<Bxml>  <StopRecording/></Bxml>";
            var conference = new Conference(
                id: "conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9",
                name: "my-conference-name",
                createdTime: new DateTime(2022, 06, 17, 22, 20, 00),
                completedTime: new DateTime(2022, 06, 17, 22, 20, 00),
                conferenceEventUrl: "https://myServer.example/bandwidth/webhooks/conferenceEvent",
                conferenceEventMethod: CallbackMethodEnum.POST,
                tag: "my custom tag"
            );


            var apiResponse = new ApiResponse<Object>(HttpStatusCode.OK, conference);
            mockClient.Setup(x => x.Put<Object>("/accounts/{accountId}/conferences/{conferenceId}/bxml",It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.UpdateConferenceBxmlWithHttpInfo(accountId, conferenceId, body);
            
            Assert.IsType<ApiResponse<Object>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test UpdateConferenceMember
        /// </summary>
        [Fact]
        public void UpdateConferenceMemberTest()
        {
            string accountId = "9900000";
            string conferenceId = "conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9";
            string memberId = "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85";
            UpdateConferenceMember updateConferenceMember = new UpdateConferenceMember(
                mute: false,
                hold: false,
                callIdsToCoach: new List<string> { "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85" }
            );
            ConferenceMember conferenceMember = new ConferenceMember(
                callId: "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85",
                conferenceId: "conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9",
                mute: false,
                hold: false,
                callIdsToCoach: new List<string> { "c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85" }
            );

            var apiResponse = new ApiResponse<Object>(HttpStatusCode.OK, conferenceMember);
            mockClient.Setup(x => x.Put<Object>("/accounts/{accountId}/conferences/{conferenceId}/members/{memberId}",It.IsAny<RequestOptions>(), fakeConfiguration)).Returns(apiResponse);
            var response = instance.UpdateConferenceMemberWithHttpInfo(accountId, conferenceId, memberId, updateConferenceMember);
        
            Assert.IsType<ApiResponse<Object>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
