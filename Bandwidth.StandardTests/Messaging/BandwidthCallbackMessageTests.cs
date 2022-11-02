using Bandwidth.Standard.Messaging.Models;
using Xunit;

namespace Bandwidth.StandardTests.Messaging
{
    public class BandwidthCallbackMessageTests
    {
        [Fact]
        public void InitializeMessagingCallbackModel()
        {
            BandwidthMessage testMessage = new BandwidthMessage();

            BandwidthCallbackMessage testCallback = new BandwidthCallbackMessage(
                time: "2016-09-14T18:20:16Z",
                type: "message-failed",
                to: "+52345678903",
                errorCode: 4432,
                description: "forbidden to country",
                message: testMessage
            );

            Assert.Equal("BandwidthCallbackMessage : (this.Time = 2016-09-14T18:20:16Z, this.Type = message-failed, this.To = +52345678903, this.ErrorCode = 4432, this.Description = forbidden to country, this.Message = BandwidthMessage : (this.Id = null, this.Owner = null, this.ApplicationId = null, this.Time = null, this.SegmentCount = null, this.Direction = null, this.To = null, this.From = null, this.Media = null, this.Text = null, this.Tag = null, this.Priority = null))", testCallback.ToString());
            Assert.IsType<int>(testCallback.ErrorCode);
        }
    }
}
