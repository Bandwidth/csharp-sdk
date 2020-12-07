using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
    /// <summary>
    /// BXML tag to represent a SIP URI for the transfer verb.
    /// <para><seealso href="https://dev.bandwidth.com/voice/bxml/verbs/transfer.html"/></para>
    /// </summary>
    public class SipUri : IXmlSerializable, IVerb
    {
        /// <summary>
        /// A SIP URI to transfer the call to (e.g. sip:user@server.com).
        /// </summary>
        public string Uri { get; set; }

        /// <summary>
        /// (optional) The value of the User-To-User header to send within the initial INVITE.
        /// Must include the encoding parameter as specified in RFC 7433.Only base64 and jwt encoding are currently allowed.
        /// This value, including the encoding specifier, may not exceed 256 characters.
        /// </summary>
        public string Uui { get; set; }

        /// <summary>
        /// (optional) URL, if any, to send the Transfer Answer event to and request BXML to be executed for the called party before the call is bridged.
        /// </summary>
        public string TransferAnswerUrl { get; set; }

        /// <summary>
        /// (optional) The HTTP method to use for the request to transferAnswerUrl.
        /// GET or POST.
        /// Default value is POST.
        /// </summary>
        public string TransferAnswerMethod { get; set; }

        /// <summary>
        /// A fallback url which, if provided, will be used to retry the Transfer Answer callback delivery in case transferAnswerUrl fails to respond.
        /// </summary>
        public string TransferAnswerFallbackUrl { get; set; }

        /// <summary>
        /// The HTTP method to use to deliver the Transfer Answer callback to transferAnswerFallbackUrl.
        /// GET or POST.
        /// Default value is POST.
        /// </summary>
        public string TransferAnswerFallbackMethod { get; set; }

        /// <summary>
        /// URL, if any, to send the Transfer Disconnect event to.
        /// This event will be sent regardless of how the transfer ends and may not be responded to with BXML.
        /// May be a relative URL.
        /// </summary>
        public string TransferDisconnectUrl  { get; set; }

        /// <summary>
        /// The HTTP method to use for the request to transferDisconnectUrl.
        /// GET or POST.
        /// Default value is POST.
        /// </summary>
        public string TransferDisconnectMethod  { get; set; }

        /// <summary>
        /// The username to send in the HTTP request to transferAnswerUrl and transferDisconnectUrl.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The password to send in the HTTP request to transferAnswerUrl and transferDisconnectUrl.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The username to send in the HTTP request to transferAnswerFallbackUrl.
        /// </summary>
        public string FallbackUsername { get; set; }

        /// <summary>
        /// The password to send in the HTTP request to transferAnswerFallbackUrl.
        /// </summary>
        public string FallbackPassword { get; set; }

        /// <summary>
        /// A custom string that will be sent with these and all future callbacks unless overwritten by a future tag attribute or cleared.
        /// May be cleared by setting tag="".
        /// Max length 256 characters.
        /// </summary>
        public string Tag { get; set; }

        XmlSchema IXmlSerializable.GetSchema()
        {
          return null;
        }

        void IXmlSerializable.ReadXml(XmlReader reader)
        {
          throw new NotImplementedException();
        }

        void IXmlSerializable.WriteXml(XmlWriter writer)
        {
            if (!string.IsNullOrEmpty(Uui))
            {
                writer.WriteAttributeString("uui", Uui);
            }

            if (!string.IsNullOrEmpty(TransferAnswerUrl))
            {
                writer.WriteAttributeString("transferAnswerUrl", TransferAnswerUrl);
            }

            if (!string.IsNullOrEmpty(TransferAnswerMethod))
            {
                writer.WriteAttributeString("transferAnswerMethod", TransferAnswerMethod);
            }

            if (!string.IsNullOrEmpty(TransferAnswerFallbackUrl))
            {
                writer.WriteAttributeString("transferAnswerFallbackUrl ", TransferAnswerFallbackUrl );
            }

            if (!string.IsNullOrEmpty(TransferAnswerFallbackMethod))
            {
                writer.WriteAttributeString("transferAnswerFallbackMethod ", TransferAnswerFallbackMethod );
            }

            if (!string.IsNullOrEmpty(TransferDisconnectUrl))
            {
                writer.WriteAttributeString("transferDisconnectUrl", TransferDisconnectUrl);
            }

            if (!string.IsNullOrEmpty(TransferDisconnectMethod))
            {
                writer.WriteAttributeString("transferDisconnectMethod ", TransferDisconnectMethod);
            }

            if (!string.IsNullOrEmpty(Username))
            {
                writer.WriteAttributeString("username", Username);
            }

            if (!string.IsNullOrEmpty(Password))
            {
                writer.WriteAttributeString("password", Password);
            }

            if (!string.IsNullOrEmpty(FallbackUsername))
            {
                writer.WriteAttributeString("fallbackUsername ", FallbackUsername );
            }

            if (!string.IsNullOrEmpty(FallbackPassword))
            {
                writer.WriteAttributeString("fallbackPassword ", FallbackPassword );
            }

            if (!string.IsNullOrEmpty(Tag))
            {
                writer.WriteAttributeString("tag", Tag);
            }

            writer.WriteString(Uri);
        }
    }
}
