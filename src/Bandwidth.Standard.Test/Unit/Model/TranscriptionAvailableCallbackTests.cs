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
    ///  Class for testing TranscriptionAvailableCallback
    /// </summary>
    public class TranscriptionAvailableCallbackTests : IDisposable
    {
        private TranscriptionAvailableCallback instance;

        public TranscriptionAvailableCallbackTests()
        {
            instance = new TranscriptionAvailableCallback();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TranscriptionAvailableCallback
        /// </summary>
        [Fact]
        public void TranscriptionAvailableCallbackInstanceTest()
        {
            Assert.IsType<TranscriptionAvailableCallback>(instance);
        }


        /// <summary>
        /// Test the property 'EventType'
        /// </summary>
        [Fact]
        public void EventTypeTest()
        {
            instance.EventType = "transcriptionAvailable";
            Assert.IsType<String>(instance.EventType);
            Assert.Equal("transcriptionAvailable", instance.EventType);
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
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            instance.AccountId = "920000";
            Assert.IsType<String>(instance.AccountId);
            Assert.Equal("920000", instance.AccountId);
        }
        /// <summary>
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            instance.ApplicationId = "123-456-abcd";
            Assert.IsType<String>(instance.ApplicationId);
            Assert.Equal("123-456-abcd", instance.ApplicationId);
        }
        /// <summary>
        /// Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            instance.From = "+15551234567";
            Assert.IsType<string>(instance.From);
            Assert.Equal("+15551234567", instance.From);
        }
        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            instance.To = "+15557654321";
            Assert.IsType<string>(instance.To);
            Assert.Equal("+15557654321", instance.To);
        }
        /// <summary>
        /// Test the property 'Direction'
        /// </summary>
        [Fact]
        public void DirectionTest()
        {
            instance.Direction = CallDirectionEnum.Inbound;
            Assert.IsType<CallDirectionEnum>(instance.Direction);
            Assert.Equal(CallDirectionEnum.Inbound, instance.Direction);
        }
        /// <summary>
        /// Test the property 'CallId'
        /// </summary>
        [Fact]
        public void CallIdTest()
        {
            instance.CallId = "c-1234";
            Assert.IsType<String>(instance.CallId);
            Assert.Equal("c-1234", instance.CallId);
        }
        /// <summary>
        /// Test the property 'CallUrl'
        /// </summary>
        [Fact]
        public void CallUrlTest()
        {
            instance.CallUrl = "https://test.url/";
            Assert.IsType<String>(instance.CallUrl);
            Assert.Equal("https://test.url/", instance.CallUrl);
        }
        /// <summary>
        /// Test the property 'MediaUrl'
        /// </summary>
        [Fact]
        public void MediaUrlTest()
        {
            instance.MediaUrl = "https://mediaTest.url/";
            Assert.IsType<String>(instance.MediaUrl);
            Assert.Equal("https://mediaTest.url/", instance.MediaUrl);
        }
        /// <summary>
        /// Test the property 'ParentCallId'
        /// </summary>
        [Fact]
        public void ParentCallIdTest()
        {
            instance.ParentCallId = "c-1234";
            Assert.IsType<String>(instance.ParentCallId);
            Assert.Equal("c-1234", instance.ParentCallId);
        }
        /// <summary>
        /// Test the property 'RecordingId'
        /// </summary>
        [Fact]
        public void RecordingIdTest()
        {
            instance.RecordingId = "r-1234";
            Assert.IsType<String>(instance.RecordingId);
            Assert.Equal("r-1234", instance.RecordingId);
        }
        /// <summary>
        /// Test the property 'EnqueuedTime'
        /// </summary>
        [Fact]
        public void EnqueuedTimeTest()
        {
            instance.EnqueuedTime = new DateTime(2020, 1, 1);
            Assert.IsType<DateTime>(instance.EnqueuedTime);
            Assert.Equal(new DateTime(2020, 1, 1), instance.EnqueuedTime);
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
            Assert.IsType<String>(instance.Duration);
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
        /// Test the property 'Tag'
        /// </summary>
        [Fact]
        public void TagTest()
        {
            instance.Tag = "test";
            Assert.IsType<String>(instance.Tag);
            Assert.Equal("test", instance.Tag);
        }
        /// <summary>
        /// Test the property 'Transcription'
        /// </summary>
        [Fact]
        public void TranscriptionTest()
        {
            instance.Transcription = new Transcription();
            Assert.IsType<Transcription>(instance.Transcription);
        }
        /// <summary>
        /// Test the property 'TransferCallerId'
        /// </summary>
        [Fact]
        public void TransferCallerIdTest()
        {
            instance.TransferCallerId = "+15551234567";
            Assert.IsType<string>(instance.TransferCallerId);
            Assert.Equal("+15551234567", instance.TransferCallerId);
        }
        /// <summary>
        /// Test the property 'TransferTo'
        /// </summary>
        [Fact]
        public void TransferToTest()
        {
            instance.TransferTo = "+15557654321";
            Assert.IsType<string>(instance.TransferTo);
            Assert.Equal("+15557654321", instance.TransferTo);
        }

    }

}
