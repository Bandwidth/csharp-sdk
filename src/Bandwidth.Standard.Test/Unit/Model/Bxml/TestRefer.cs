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
        public void ReferRoundTripTest()
        {
            var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Refer referCompleteUrl=\"https://example.com/handleRefer\" referCompleteMethod=\"POST\" tag=\"refer-tag\">    <SipUri>sip:alice@atlanta.example.com</SipUri>  </Refer></Response>";

            var refer = new Refer()
                .WithSipUri("sip:alice@atlanta.example.com")
                .WithReferCompleteUrl("https://example.com/handleRefer")
                .WithReferCompleteMethod("POST")
                .WithTag("refer-tag");

            var actual = new Response(refer).ToBXML();
            Assert.Equal(expected, actual.Replace("\n", "").Replace("\r", ""));

            const string referOnlyXml = "<Refer referCompleteUrl=\"https://example.com/handleRefer\" referCompleteMethod=\"POST\" tag=\"refer-tag\"><SipUri>sip:alice@atlanta.example.com</SipUri></Refer>";
            var serializer = new XmlSerializer(typeof(Refer), "");
            Refer deserializedRefer;
            using (var reader = new StringReader(referOnlyXml))
            {
                deserializedRefer = (Refer)serializer.Deserialize(reader);
            }

            Assert.Equal("sip:alice@atlanta.example.com", deserializedRefer.SipUriElement.Uri);
            var roundTrip = new Response(deserializedRefer).ToBXML();
            Assert.Equal(expected, roundTrip.Replace("\n", "").Replace("\r", ""));
        }

        [Fact]
        public void ReferSipUriMustStartWithSipScheme()
        {
            var refer = new Refer();
            Assert.Throws<ArgumentException>(() => refer.WithSipUri("tel:+15551234567"));
        }

        [Fact]
        public void ReferInvalidMethodThrows()
        {
            var refer = new Refer();
            Assert.Throws<ArgumentException>(() => refer.WithReferCompleteMethod("DELETE"));
        }

        [Fact]
        public void ReferWithSipUriObjectOverload()
        {
            // Refer reuses the same SipUri type as Transfer - not a distinct Refer-only class.
            var sipUri = new SipUri { Uri = "sip:alice@atlanta.example.com" };
            var refer = new Refer().WithSipUri(sipUri);
            Assert.Equal("sip:alice@atlanta.example.com", refer.SipUriElement.Uri);
        }

        [Fact]
        public void ReferMinimalOnlySipUri()
        {
            var refer = new Refer().WithSipUri("sip:bob@biloxi.example.com");
            var bxml = new Response(refer).ToBXML();
            Assert.Contains("sip:bob@biloxi.example.com", bxml);
            Assert.Contains("referCompleteMethod=\"POST\"", bxml);
        }

        [Fact]
        public void ReferMissingSipUriProducesEmptyElement()
        {
            var refer = new Refer();
            var bxml = new Response(refer).ToBXML();
            // Documents that missing SipUri produces output without a SipUri element
            Assert.DoesNotContain("<SipUri>", bxml);
        }

        [Fact]
        public void ReferSipUriWithNullUriProducesEmptySipUriElement()
        {
            // Documents that a SipUri element with no URI text serializes as an empty element
            var sipUri = new SipUri(); // Uri not set; required content is missing
            var refer = new Refer().WithSipUri(sipUri);
            var bxml = new Response(refer).ToBXML();
            Assert.Contains("<SipUri />", bxml);
        }

        [Theory]
        [InlineData(nameof(SipUri.Uui), "base64:abc")]
        [InlineData(nameof(SipUri.TransferAnswerUrl), "https://example.com/answer")]
        [InlineData(nameof(SipUri.TransferAnswerMethod), "POST")]
        [InlineData(nameof(SipUri.TransferAnswerFallbackUrl), "https://example.com/fallback")]
        [InlineData(nameof(SipUri.TransferAnswerFallbackMethod), "POST")]
        [InlineData(nameof(SipUri.TransferDisconnectUrl), "https://example.com/disconnect")]
        [InlineData(nameof(SipUri.TransferDisconnectMethod), "POST")]
        [InlineData(nameof(SipUri.Username), "user")]
        [InlineData(nameof(SipUri.Password), "pass")]
        [InlineData(nameof(SipUri.FallbackUsername), "fallbackUser")]
        [InlineData(nameof(SipUri.FallbackPassword), "fallbackPass")]
        [InlineData(nameof(SipUri.Tag), "some-tag")]
        public void ReferRejectsTransferOnlySipUriAttributes(string propertyName, string value)
        {
            var sipUri = new SipUri { Uri = "sip:alice@atlanta.example.com" };
            typeof(SipUri).GetProperty(propertyName).SetValue(sipUri, value);

            var ex = Assert.Throws<ArgumentException>(() => new Refer().WithSipUri(sipUri));
            Assert.Contains(propertyName, ex.Message);
        }

        [Fact]
        public void ReferRejectsTransferOnlySipUriAttributesViaPropertyAssignment()
        {
            var sipUri = new SipUri { Uri = "sip:alice@atlanta.example.com", Username = "user" };
            var refer = new Refer();

            Assert.Throws<ArgumentException>(() => refer.SipUriElement = sipUri);
        }

        [Fact]
        public void TransferOnlySipUriStillAllowsFullAttributeSetOutsideRefer()
        {
            // Regression: the validation added for Refer must not affect Transfer's own usage of SipUri.
            var sipUri = new SipUri
            {
                Uri = "sip:alice@atlanta.example.com",
                Username = "user",
                Password = "pass",
                TransferAnswerUrl = "https://example.com/answer"
            };

            Assert.Equal("user", sipUri.Username);
            Assert.Equal("https://example.com/answer", sipUri.TransferAnswerUrl);
        }
    }
}