using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestSipUri
	{
		public TestSipUri()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <SipUri uui=\"abc123\" transferAnswerUrl=\"https.://test.url/\" transferAnswerMethod=\"POST\" transferAnswerFallbackUrl=\"https://fallbackTest.url/\" transferAnswerFallbackMethod=\"POST\" transferDisconnectUrl=\"https://disconnectTest.url/\" transferDisconnectMethod=\"POST\" username=\"username\" password=\"password\" fallbackUsername=\"fallbackUsername\" fallbackPassword=\"fallbackPassword\" tag=\"test\">sip:1-999-123-4567@voip-provider.example.net</SipUri><Response>";
		
			var sipUri = new SipUri();
			sipUri.Uri = "sip:1-999-123-4567@voip-provider.example.net";
			sipUri.Uui = "abc123";
			sipUri.TransferAnswerUrl = "https://test.url/";
			sipUri.TransferAnswerMethod = "POST";
			sipUri.TransferAnswerFallbackUrl = "https://fallbackTest.url/";
			sipUri.TransferAnswerFallbackMethod = "POST";
			sipUri.TransferDisconnectUrl = "https://disconnectTest.url/";
			sipUri.TransferDisconnectMethod = "POST";
			sipUri.Username = "username";
			sipUri.Password = "password";
			sipUri.FallbackUsername = "fallbackUsername";
			sipUri.FallbackPassword = "fallbackPassword";
			sipUri.Tag = "test";


			var response = new Response(sipUri);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

