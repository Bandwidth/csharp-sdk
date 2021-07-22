namespace Bandwidth.Standard.WebRtc.Utils
{
    public static class WebRtcTransfer {
        private const string SipUri = "sip:sipx.webrtc.bandwidth.com:5060";

        public static string GenerateBxml(string deviceToken, string sipUri = SipUri)
        {
            var bxmlVerb = GenerateBxmlVerb(deviceToken, sipUri);
            return GenerateBxml(bxmlVerb);
        }
        
        public static string GenerateBxmlVoiceCallId(string deviceToken, string voiceCallId, string sipUri = SipUri)
        {
            var bxmlVerb = GenerateBxmlVerbVoiceCallId(deviceToken, voiceCallId, sipUri);
            return GenerateBxml(bxmlVerb);
        }

        public static string GenerateBxmlVerb(string deviceToken, string sipUri = SipUri)
        {
            return $"<Transfer><SipUri uui=\"{deviceToken};encoding=jwt\">{sipUri}</SipUri></Transfer>";
        }

        public static string GenerateBxmlVerbVoiceCallId(string deviceToken, string voiceCallId, string sipUri = SipUri)
        {
            voiceCallId = voiceCallId.Substring(1).Replace("-", "");
            return $"<Transfer><SipUri uui=\"{voiceCallId};encoding=base64,{deviceToken};encoding=jwt\">{sipUri}</SipUri></Transfer>";
        }

        private static string GenerateBxml(string response)
        {
            return $"<?xml version=\"1.0\" encoding=\"UTF-8\" ?><Response>{response}</Response>";
        }
    }
}
