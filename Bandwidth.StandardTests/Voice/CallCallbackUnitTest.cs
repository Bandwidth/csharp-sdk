using System;
using System.Threading.Tasks;
using Bandwidth.Standard;
using Bandwidth.Standard.Voice.Exceptions;
using Bandwidth.Standard.Voice.Models;
using Xunit;

namespace Bandwidth.StandardTests.Voice
{
    public class CallCallbackUnitTest
    { 
        [Fact]
        public void InitiateEvent()
        {
            var initiateEvent = new CallCallback() {
                EventType = "initiate",
                EventTime = "2019-06-20T15:56:11.554Z",
                AccountId = "55555555",
                ApplicationId = "7fc9698a-b04a-468b-9e8f-91238c0d0086",
                From = "+15551112222",
                To = "+15553334444",
                Direction = "inbound",
                CallId = "c-95ac8d6e-1a31c52e-b38f-4198-93c1-51633ec68f8d",
                CallUrl = "https://voice.bandwidth.com/api/v2/accounts/55555555/calls/c-95ac8d6e-1a31c52e-b38f-4198-93c1-51633ec68f8d",
                StartTime = "2019-06-20T15:54:22.234Z"
            };

            Assert.Equal("initiate", initiateEvent.EventType);
            Assert.Equal("2019-06-20T15:56:11.554Z", initiateEvent.EventTime);
            Assert.Equal("55555555", initiateEvent.AccountId);
            Assert.Equal("7fc9698a-b04a-468b-9e8f-91238c0d0086", initiateEvent.ApplicationId);
            Assert.Equal("+15551112222", initiateEvent.From);
            Assert.Equal("+15553334444", initiateEvent.To);
            Assert.Equal("inbound", initiateEvent.Direction);
            Assert.Equal("c-95ac8d6e-1a31c52e-b38f-4198-93c1-51633ec68f8d", initiateEvent.CallId);
            Assert.Equal("https://voice.bandwidth.com/api/v2/accounts/55555555/calls/c-95ac8d6e-1a31c52e-b38f-4198-93c1-51633ec68f8d", initiateEvent.CallUrl);
            Assert.Equal("2019-06-20T15:54:22.234Z", initiateEvent.StartTime);
        }
        
        [Fact]
        public void MachineDetectionCompleteEvent()
        {
            var machineDetectionCompleteEvent = new CallCallback() {
                EventType = "machineDetectionComplete",
                EventTime = "2019-06-20T15:56:11.554Z",
                AccountId = "55555555",
                ApplicationId = "7fc9698a-b04a-468b-9e8f-91238c0d0086",
                From = "+15551112222",
                To = "+15553334444",
                Direction = "inbound",
                CallId = "c-6a0d8e3e-1c71aa98-fb05-46ca-acf8-f735db20fa28",
                CallUrl = "https://voice.bandwidth.com/api/v2/accounts/55555555/calls/c-6a0d8e3e-1c71aa98-fb05-46ca-acf8-f735db20fa28",
                AnswerTime = "2019-06-20T15:54:22.234Z",
                MachineDetectionResult = new MachineDetectionResult() {Value = "answering-machine", Duration = "PT4.9891287S"}
            };

            Assert.Equal("machineDetectionComplete", machineDetectionCompleteEvent.EventType);
            Assert.Equal("2019-06-20T15:56:11.554Z", machineDetectionCompleteEvent.EventTime);
            Assert.Equal("55555555", machineDetectionCompleteEvent.AccountId);
            Assert.Equal("7fc9698a-b04a-468b-9e8f-91238c0d0086", machineDetectionCompleteEvent.ApplicationId);
            Assert.Equal("+15551112222", machineDetectionCompleteEvent.From);
            Assert.Equal("+15553334444", machineDetectionCompleteEvent.To);
            Assert.Equal("inbound", machineDetectionCompleteEvent.Direction);
            Assert.Equal("c-6a0d8e3e-1c71aa98-fb05-46ca-acf8-f735db20fa28", machineDetectionCompleteEvent.CallId);
            Assert.Equal("https://voice.bandwidth.com/api/v2/accounts/55555555/calls/c-6a0d8e3e-1c71aa98-fb05-46ca-acf8-f735db20fa28", machineDetectionCompleteEvent.CallUrl);
            Assert.Equal("2019-06-20T15:54:22.234Z", machineDetectionCompleteEvent.AnswerTime);
            Assert.Equal("answering-machine", machineDetectionCompleteEvent.MachineDetectionResult.Value);
            Assert.Equal("PT4.9891287S", machineDetectionCompleteEvent.MachineDetectionResult.Duration);
        }
    }

}
