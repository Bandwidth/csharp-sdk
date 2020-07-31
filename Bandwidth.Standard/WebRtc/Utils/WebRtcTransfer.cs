using System.ComponentModel;

namespace Bandwidth.Standard.WebRtc.Utils
{
    public static class WebRtcTransfer {
        public static string generateBxml(string deviceToken) {
            return WebRtcTransfer.generateBxml(deviceToken, "sip:sipx.webrtc.bandwidth.com:5060");
        }

        public static string generateBxml(string deviceToken, string sipUri) {
            return "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>\n"
                + "<Transfer>\n"
                + "\t<SipUri uui=\"" + deviceToken + ";encoding=jwt\">" + sipUri + "</SipUri>\n"
                + "</Transfer>\n";
        }
    }
}
