using System;
using System.IO;
using System.Xml.Serialization;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Unit.Model.Bxml
{
    public class TestRefer
    {
        [Fact]
        public void ReferTest()
        {
            var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Refer referCompleteUrl=\"https://example.com/handleRefer\" referCompleteMethod=\"POST\" tag=\"refer-tag\">    <SipUri>sip:alice@atlanta.example.com</SipUri>  </Refer></Response>";

            var sipUri = new SipUri { Uri = "sip:alice@atlanta.example.com" };

            var refer = new Refer
            {
                SipUri = sipUri,
                ReferCompleteUrl = "https://example.com/handleRefer",
                ReferCompleteMethod = "POST",
                Tag = "refer-tag"
            };

            var actual = new Response(refer).ToBXML();
            Assert.Equal(expected, actual.Replace("\n", "").Replace("\r", ""));
        }
    }
}
