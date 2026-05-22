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
}
}
