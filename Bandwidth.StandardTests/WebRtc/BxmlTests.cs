using Bandwidth.Standard.WebRtc.Utils;
using Xunit;

namespace Bandwidth.StandardTests.WebRtc
{
    public class BxmlTests
    {
        [Fact]
        public void GenerateBxml()
        {
            const string deviceToken = "test-device-token";
            var bxml = WebRtcTransfer.GenerateBxml(deviceToken);

            const string expected = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><Response><Transfer><SipUri uui=\"test-device-token;encoding=jwt\">sip:sipx.webrtc.bandwidth.com:5060</SipUri></Transfer></Response>";

            Assert.Equal(expected, bxml);
        }

        [Fact]
        public void GenerateBxmlWithCustomSipUri()
        {
            const string deviceToken = "test-device-token";
            const string sipUri = "sip:sipx.acme.com:6112";
            var bxml = WebRtcTransfer.GenerateBxml(deviceToken, sipUri);

            const string expected = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><Response><Transfer><SipUri uui=\"test-device-token;encoding=jwt\">sip:sipx.acme.com:6112</SipUri></Transfer></Response>";

            Assert.Equal(expected, bxml);
        }

        [Fact]
        public void GenerateBxmlVoiceCallId()
        {
            const string deviceToken = "test-device-token";
            const string voiceCallId = "c-93d6f3c0-be584596-0b74-4fa2-8015-d8ede84bd1a4";
            var bxml = WebRtcTransfer.GenerateBxmlVoiceCallId(deviceToken, voiceCallId);

            const string expected = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><Response><Transfer><SipUri uui=\"93d6f3c0be5845960b744fa28015d8ede84bd1a4;encoding=base64,test-device-token;encoding=jwt\">sip:sipx.webrtc.bandwidth.com:5060</SipUri></Transfer></Response>";

            Assert.Equal(expected, bxml);
        }

        [Fact]
        public void GenerateBxmlVoiceCallIdWithCustomSipUri()
        {
            var deviceToken = "test-device-token";
            var voiceCallId = "c-93d6f3c0-be584596-0b74-4fa2-8015-d8ede84bd1a4";
            var sipUri = "sip:sipx.acme.com:6112";
            var bxml = WebRtcTransfer.GenerateBxmlVoiceCallId(deviceToken, voiceCallId, sipUri);

            const string expected = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><Response><Transfer><SipUri uui=\"93d6f3c0be5845960b744fa28015d8ede84bd1a4;encoding=base64,test-device-token;encoding=jwt\">sip:sipx.acme.com:6112</SipUri></Transfer></Response>";

            Assert.Equal(expected, bxml);
        }
    }
}
