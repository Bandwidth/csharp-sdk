using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestSendDtmf
	{
		[Fact]
		public void SendDtmfTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <SendDtmf toneDuration=\"200\" toneInterval=\"400\">12w34</SendDtmf></Response>";

			var sendDtmf = new SendDtmf();
			sendDtmf.Digits = "12w34";
			sendDtmf.ToneDuration = 200;
			sendDtmf.ToneInterval = 400;

			var response = new Response(sendDtmf);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

