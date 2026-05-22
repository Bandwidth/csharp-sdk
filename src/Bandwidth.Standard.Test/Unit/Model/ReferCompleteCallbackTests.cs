using Bandwidth.Standard.Model;
using Newtonsoft.Json;
using Xunit;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class ReferCompleteCallbackTests
    {
        [Fact]
        public void ReferCompleteSuccessTest()
        {
            var callback = Deserialize("{\"eventType\":\"referComplete\",\"eventTime\":\"2024-01-01T00:00:00.000Z\",\"accountId\":\"9900000\",\"applicationId\":\"04e88489-df02-4e34-a0ee-27a91849555f\",\"from\":\"+15555550100\",\"to\":\"+15555550101\",\"direction\":\"inbound\",\"callId\":\"c-123\",\"callUrl\":\"https://voice.bandwidth.com/api/v2/accounts/9900000/calls/c-123\",\"startTime\":\"2024-01-01T00:00:00.000Z\",\"answerTime\":\"2024-01-01T00:00:01.000Z\",\"referCallStatus\":\"success\"}");

            Assert.Equal(ReferCallStatusEnum.Success, callback.ReferCallStatus);
            Assert.Null(callback.ReferSipResponseCode);
            Assert.Null(callback.NotifySipResponseCode);
        }

        [Fact]
        public void ReferCompleteReferRejectedTest()
        {
            var callback = Deserialize("{\"eventType\":\"referComplete\",\"eventTime\":\"2024-01-01T00:00:00.000Z\",\"accountId\":\"9900000\",\"applicationId\":\"04e88489-df02-4e34-a0ee-27a91849555f\",\"from\":\"+15555550100\",\"to\":\"+15555550101\",\"direction\":\"inbound\",\"callId\":\"c-123\",\"callUrl\":\"https://voice.bandwidth.com/api/v2/accounts/9900000/calls/c-123\",\"startTime\":\"2024-01-01T00:00:00.000Z\",\"answerTime\":\"2024-01-01T00:00:01.000Z\",\"referCallStatus\":\"failure\",\"referSipResponseCode\":405}");

            Assert.Equal(ReferCallStatusEnum.Failure, callback.ReferCallStatus);
            Assert.Equal(405, callback.ReferSipResponseCode);
            Assert.Null(callback.NotifySipResponseCode);
        }

        [Fact]
        public void ReferCompleteDestinationUnreachableTest()
        {
            var callback = Deserialize("{\"eventType\":\"referComplete\",\"eventTime\":\"2024-01-01T00:00:00.000Z\",\"accountId\":\"9900000\",\"applicationId\":\"04e88489-df02-4e34-a0ee-27a91849555f\",\"from\":\"+15555550100\",\"to\":\"+15555550101\",\"direction\":\"inbound\",\"callId\":\"c-123\",\"callUrl\":\"https://voice.bandwidth.com/api/v2/accounts/9900000/calls/c-123\",\"startTime\":\"2024-01-01T00:00:00.000Z\",\"answerTime\":\"2024-01-01T00:00:01.000Z\",\"referCallStatus\":\"failure\",\"referSipResponseCode\":202,\"notifySipResponseCode\":486}");

            Assert.Equal(ReferCallStatusEnum.Failure, callback.ReferCallStatus);
            Assert.Equal(202, callback.ReferSipResponseCode);
            Assert.Equal(486, callback.NotifySipResponseCode);
        }

        [Fact]
        public void ReferCompleteNotifyTimeoutTest()
        {
            var callback = Deserialize("{\"eventType\":\"referComplete\",\"eventTime\":\"2024-01-01T00:00:00.000Z\",\"accountId\":\"9900000\",\"applicationId\":\"04e88489-df02-4e34-a0ee-27a91849555f\",\"from\":\"+15555550100\",\"to\":\"+15555550101\",\"direction\":\"inbound\",\"callId\":\"c-123\",\"callUrl\":\"https://voice.bandwidth.com/api/v2/accounts/9900000/calls/c-123\",\"startTime\":\"2024-01-01T00:00:00.000Z\",\"answerTime\":\"2024-01-01T00:00:01.000Z\",\"referCallStatus\":\"failure\",\"referSipResponseCode\":202}");

            Assert.Equal(ReferCallStatusEnum.Failure, callback.ReferCallStatus);
            Assert.Equal(202, callback.ReferSipResponseCode);
            Assert.Null(callback.NotifySipResponseCode);
        }

        private static ReferCompleteCallback Deserialize(string json)
        {
            var callback = JsonConvert.DeserializeObject<ReferCompleteCallback>(json);
            Assert.NotNull(callback);
            Assert.Equal("referComplete", callback.EventType);
            Assert.Equal(CallDirectionEnum.Inbound, callback.Direction);
            return callback;
        }
    }
}
