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
// uncomment below to import models
//using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Api
{
    /// <summary>
    ///  Class for testing ConferencesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ConferencesApiTests : IDisposable
    {
        private ConferencesApi instance;

        public ConferencesApiTests()
        {
            instance = new ConferencesApi();
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
            // TODO uncomment below to test 'IsType' ConferencesApi
            //Assert.IsType<ConferencesApi>(instance);
        }

        /// <summary>
        /// Test DownloadConferenceRecording
        /// </summary>
        [Fact]
        public void DownloadConferenceRecordingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string conferenceId = null;
            //string recordingId = null;
            //var response = instance.DownloadConferenceRecording(accountId, conferenceId, recordingId);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GetConference
        /// </summary>
        [Fact]
        public void GetConferenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string conferenceId = null;
            //var response = instance.GetConference(accountId, conferenceId);
            //Assert.IsType<Conference>(response);
        }

        /// <summary>
        /// Test GetConferenceMember
        /// </summary>
        [Fact]
        public void GetConferenceMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string conferenceId = null;
            //string memberId = null;
            //var response = instance.GetConferenceMember(accountId, conferenceId, memberId);
            //Assert.IsType<ConferenceMember>(response);
        }

        /// <summary>
        /// Test GetConferenceRecording
        /// </summary>
        [Fact]
        public void GetConferenceRecordingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string conferenceId = null;
            //string recordingId = null;
            //var response = instance.GetConferenceRecording(accountId, conferenceId, recordingId);
            //Assert.IsType<ConferenceRecordingMetadata>(response);
        }

        /// <summary>
        /// Test ListConferenceRecordings
        /// </summary>
        [Fact]
        public void ListConferenceRecordingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string conferenceId = null;
            //var response = instance.ListConferenceRecordings(accountId, conferenceId);
            //Assert.IsType<List<ConferenceRecordingMetadata>>(response);
        }

        /// <summary>
        /// Test ListConferences
        /// </summary>
        [Fact]
        public void ListConferencesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string name = null;
            //string minCreatedTime = null;
            //string maxCreatedTime = null;
            //int? pageSize = null;
            //string pageToken = null;
            //var response = instance.ListConferences(accountId, name, minCreatedTime, maxCreatedTime, pageSize, pageToken);
            //Assert.IsType<List<Conference>>(response);
        }

        /// <summary>
        /// Test UpdateConference
        /// </summary>
        [Fact]
        public void UpdateConferenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string conferenceId = null;
            //UpdateConference updateConference = null;
            //instance.UpdateConference(accountId, conferenceId, updateConference);
        }

        /// <summary>
        /// Test UpdateConferenceBxml
        /// </summary>
        [Fact]
        public void UpdateConferenceBxmlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string conferenceId = null;
            //string body = null;
            //instance.UpdateConferenceBxml(accountId, conferenceId, body);
        }

        /// <summary>
        /// Test UpdateConferenceMember
        /// </summary>
        [Fact]
        public void UpdateConferenceMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string conferenceId = null;
            //string memberId = null;
            //UpdateConferenceMember updateConferenceMember = null;
            //instance.UpdateConferenceMember(accountId, conferenceId, memberId, updateConferenceMember);
        }
    }
}