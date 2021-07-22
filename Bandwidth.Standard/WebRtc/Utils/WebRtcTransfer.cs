using System.ComponentModel;

namespace Bandwidth.Standard.WebRtc.Utils
{
    public static class WebRtcTransfer {
        public static string generateBxml(string deviceToken) {
            return WebRtcTransfer.generateBxml(deviceToken, "sip:sipx.webrtc.bandwidth.com:5060");
        }

        public static string generateBxml(string deviceToken, string sipUri) {
            return "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>\n"
                + "<Response><Transfer>\n"
                + "\t<SipUri uui=\"" + deviceToken + ";encoding=jwt\">" + sipUri + "</SipUri>\n"
                + "</Transfer></Response>\n";
        }

        public static string generateBxmlTransferVerb(string deviceToken) {
            return WebRtcTransfer.generateBxmlTransferVerb(deviceToken, "sip:sipx.webrtc.bandwidth.com:5060");
        }

        public static string generateBxmlTransferVerb(string deviceToken, string sipUri) {
            return "<Transfer>\n"
                + "\t<SipUri uui=\"" + deviceToken + ";encoding=jwt\">" + sipUri + "</SipUri>\n"
                + "</Transfer>\n";
        }
    }
}
