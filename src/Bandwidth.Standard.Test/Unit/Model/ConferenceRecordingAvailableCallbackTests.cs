/*
 * Bandwidth
 *
 * Bandwidth's Communication APIs
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: letstalk@bandwidth.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Bandwidth.Standard.Model;
using Bandwidth.Standard.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Bandwidth.Standard.Test.Unit.Model
{
    /// <summary>
    ///  Class for testing ConferenceRecordingAvailableCallback
    /// </summary>
    public class ConferenceRecordingAvailableCallbackTests : IDisposable
    {
        private ConferenceRecordingAvailableCallback instance;

        public ConferenceRecordingAvailableCallbackTests()
        {
            instance = new ConferenceRecordingAvailableCallback();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConferenceRecordingAvailableCallback
        /// </summary>
        [Fact]
        public void ConferenceRecordingAvailableCallbackInstanceTest()
        {
            Assert.IsType<ConferenceRecordingAvailableCallback>(instance);
        }


        /// <summary>
        /// Test the property 'EventType'
        /// </summary>
        [Fact]
        public void EventTypeTest()
        {
            instance.EventType = "conferenceMemberRecordingAvailable";
            Assert.IsType<string>(instance.EventType);
            Assert.Equal("conferenceMemberRecordingAvailable", instance.EventType);
        }
        /// <summary>
        /// Test the property 'EventTime'
        /// </summary>
        [Fact]
        public void EventTimeTest()
        {
            instance.EventTime = new DateTime(2020, 1, 1);
            Assert.IsType<DateTime>(instance.EventTime);
            Assert.Equal(new DateTime(2020, 1, 1), instance.EventTime);
        }
        /// <summary>
        /// Test the property 'ConferenceId'
        /// </summary>
        [Fact]
        public void ConferenceIdTest()
        {
            instance.ConferenceId = "conf-123";
            Assert.IsType<string>(instance.ConferenceId);
            Assert.Equal("conf-123", instance.ConferenceId);
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            instance.Name = "my-conference-name";
            Assert.IsType<string>(instance.Name);
            Assert.Equal("my-conference-name", instance.Name);
        }
        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            instance.AccountId = "123-456-abcd";
            Assert.IsType<string>(instance.AccountId);
            Assert.Equal("123-456-abcd", instance.AccountId);
        }
        /// <summary>
        /// Test the property 'RecordingId'
        /// </summary>
        [Fact]
        public void RecordingIdTest()
        {
            instance.RecordingId = "r-123";
            Assert.IsType<string>(instance.RecordingId);
            Assert.Equal("r-123", instance.RecordingId);
        }
        /// <summary>
        /// Test the property 'Channels'
        /// </summary>
        [Fact]
        public void ChannelsTest()
        {
            instance.Channels = 1;
            Assert.IsType<int>(instance.Channels);
            Assert.Equal(1, instance.Channels);
        }
        /// <summary>
        /// Test the property 'StartTime'
        /// </summary>
        [Fact]
        public void StartTimeTest()
        {
            instance.StartTime = new DateTime(2020, 1, 1);
            Assert.IsType<DateTime>(instance.StartTime);
            Assert.Equal(new DateTime(2020, 1, 1), instance.StartTime);
        }
        /// <summary>
        /// Test the property 'EndTime'
        /// </summary>
        [Fact]
        public void EndTimeTest()
        {
            instance.EndTime = new DateTime(2020, 1, 1);
            Assert.IsType<DateTime>(instance.EndTime);
            Assert.Equal(new DateTime(2020, 1, 1), instance.EndTime);
        }
        /// <summary>
        /// Test the property 'Duration'
        /// </summary>
        [Fact]
        public void DurationTest()
        {
            instance.Duration = "PT13.67S";
            Assert.IsType<string>(instance.Duration);
            Assert.Equal("PT13.67S", instance.Duration);
        }
        /// <summary>
        /// Test the property 'FileFormat'
        /// </summary>
        [Fact]
        public void FileFormatTest()
        {
            instance.FileFormat = FileFormatEnum.Mp3;
            Assert.IsType<FileFormatEnum>(instance.FileFormat);
            Assert.Equal(FileFormatEnum.Mp3, instance.FileFormat);
        }
        /// <summary>
        /// Test the property 'MediaUrl'
        /// </summary>
        [Fact]
        public void MediaUrlTest()
        {
            instance.MediaUrl = "http://test.com";
            Assert.IsType<string>(instance.MediaUrl);
            Assert.Equal("http://test.com", instance.MediaUrl);
        }
        /// <summary>
        /// Test the property 'Tag'
        /// </summary>
        [Fact]
        public void TagTest()
        {
            instance.Tag = "test";
            Assert.IsType<string>(instance.Tag);
            Assert.Equal("test", instance.Tag);
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            instance.Status = "completed";
            Assert.IsType<string>(instance.Status);
            Assert.Equal("completed", instance.Status);
        }

    }

}