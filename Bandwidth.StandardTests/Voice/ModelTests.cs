using Bandwidth.Standard.Voice.Models;
using Newtonsoft.Json;
using Xunit;

namespace Bandwidth.StandardTests.Voice
{
    public class ModelTests
    {
        [Fact]
        public void PopulateMachineDetectionConfiguration()
        {
            var machineDetectionConfiguration = new MachineDetectionConfiguration
            {
                Mode = ModeEnum.Async,
                DetectionTimeout = 3.2,
                SilenceTimeout = 5.6,
                SpeechThreshold = 1.2,
                SpeechEndThreshold = 7.6,
                DelayResult = false,
                CallbackUrl = "https://www.example.com/",
                CallbackMethod = CallbackMethodEnum.GET,
                FallbackUrl = "https://www.example-fallback.com/",
                FallbackMethod = FallbackMethodEnum.GET,
                Username = "neato-username",
                Password = "neato-password",
                FallbackUsername = "neato-username-fallback",
                FallbackPassword = "neato-password-fallback",
                MachineSpeechEndThreshold = 3.4
            };

            Assert.Equal(ModeEnum.Async, machineDetectionConfiguration.Mode);
            Assert.Equal(3.2, machineDetectionConfiguration.DetectionTimeout);
            Assert.Equal(5.6, machineDetectionConfiguration.SilenceTimeout);
            Assert.Equal(1.2, machineDetectionConfiguration.SpeechThreshold);
            Assert.Equal(7.6, machineDetectionConfiguration.SpeechEndThreshold);
            Assert.False(machineDetectionConfiguration.DelayResult);
            Assert.Equal("https://www.example.com/", machineDetectionConfiguration.CallbackUrl);
            Assert.Equal(CallbackMethodEnum.GET, machineDetectionConfiguration.CallbackMethod);
            Assert.Equal("https://www.example-fallback.com/", machineDetectionConfiguration.FallbackUrl);
            Assert.Equal(FallbackMethodEnum.GET, machineDetectionConfiguration.FallbackMethod);
            Assert.Equal("neato-username", machineDetectionConfiguration.Username);
            Assert.Equal("neato-password", machineDetectionConfiguration.Password);
            Assert.Equal("neato-username-fallback", machineDetectionConfiguration.FallbackUsername);
            Assert.Equal("neato-password-fallback", machineDetectionConfiguration.FallbackPassword);
            Assert.Equal(3.4, machineDetectionConfiguration.MachineSpeechEndThreshold);
        }

        [Fact]
        public void SerializeMachineDetectionConfiguration()
        {
            var machineDetectionConfiguration = new MachineDetectionConfiguration
            {
                Mode = ModeEnum.Async,
                DetectionTimeout = 3.2,
                SilenceTimeout = 5.6,
                SpeechThreshold = 1.2,
                SpeechEndThreshold = 7.6,
                DelayResult = false,
                CallbackUrl = "https://www.example.com/",
                CallbackMethod = CallbackMethodEnum.GET,
                FallbackUrl = "https://www.example-fallback.com/",
                FallbackMethod = FallbackMethodEnum.GET,
                Username = "neato-username",
                Password = "neato-password",
                FallbackUsername = "neato-username-fallback",
                FallbackPassword = "neato-password-fallback",
                MachineSpeechEndThreshold = 3.4
            };

            var json = JsonConvert.SerializeObject(machineDetectionConfiguration);
            Assert.Equal("{\"machineSpeechEndThreshold\":3.4,\"mode\":\"async\",\"detectionTimeout\":3.2,\"silenceTimeout\":5.6,\"speechThreshold\":1.2,\"speechEndThreshold\":7.6,\"delayResult\":false,\"callbackUrl\":\"https://www.example.com/\",\"callbackMethod\":\"GET\",\"fallbackUrl\":\"https://www.example-fallback.com/\",\"fallbackMethod\":\"GET\",\"username\":\"neato-username\",\"password\":\"neato-password\",\"fallbackUsername\":\"neato-username-fallback\",\"fallbackPassword\":\"neato-password-fallback\"}", json);
        }

        [Fact]
        public void SerializeMachineDetectionConfigurationUnsetMachineSpeechEndThreshold()
        {
            var machineDetectionConfiguration = new MachineDetectionConfiguration
            {
                Mode = ModeEnum.Async,
                DetectionTimeout = 3.2,
                SilenceTimeout = 5.6,
                SpeechThreshold = 1.2,
                SpeechEndThreshold = 7.6,
                DelayResult = false,
                CallbackUrl = "https://www.example.com/",
                CallbackMethod = CallbackMethodEnum.GET,
                FallbackUrl = "https://www.example-fallback.com/",
                FallbackMethod = FallbackMethodEnum.GET,
                Username = "neato-username",
                Password = "neato-password",
                FallbackUsername = "neato-username-fallback",
                FallbackPassword = "neato-password-fallback"
            };

            var json = JsonConvert.SerializeObject(machineDetectionConfiguration);
            Assert.Equal("{\"mode\":\"async\",\"detectionTimeout\":3.2,\"silenceTimeout\":5.6,\"speechThreshold\":1.2,\"speechEndThreshold\":7.6,\"delayResult\":false,\"callbackUrl\":\"https://www.example.com/\",\"callbackMethod\":\"GET\",\"fallbackUrl\":\"https://www.example-fallback.com/\",\"fallbackMethod\":\"GET\",\"username\":\"neato-username\",\"password\":\"neato-password\",\"fallbackUsername\":\"neato-username-fallback\",\"fallbackPassword\":\"neato-password-fallback\"}", json);
        }

        [Fact]
        public void CheckModifyCallRequestCallStateStatus()
        {
            var modifyCallRequest = new ModifyCallRequest
            {
                RedirectUrl = "http://www.myServer.com/fake/callback/url"
            };

            Assert.Equal(StateEnum.Active,  modifyCallRequest.State);
        } 
    }
}
