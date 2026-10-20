using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Unit.Model.Bxml
{
	public class TestTransfer
	{
		[Fact]
		public void TransferTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Transfer transferCallerId=\"Anonymous\" transferCallerDisplayName=\"test\" callTimeout=\"30\" transferCompleteUrl=\"http://test.com\" transferCompleteMethod=\"POST\" transferCompleteFallbackUrl=\"http://fallbackTest.com\" transferCompleteFallbackMethod=\"POST\" username=\"username\" password=\"password\" fallbackUsername=\"fallbackUsername\" fallbackPassword=\"fallbackPassword\" tag=\"test\" diversionTreatment=\"none\" diversionReason=\"user-busy\" privacy=\"true\" attestationLevel=\"A\">    <PhoneNumber>+15551234567</PhoneNumber>    <SipUri uui=\"abc123\">sip:1-999-123-4567@voip-provider.example.net</SipUri>  </Transfer></Response>";

			var phoneNumber = new PhoneNumber();
			phoneNumber.Number = "+15551234567";

			var sipUri = new SipUri();
			sipUri.Uri = "sip:1-999-123-4567@voip-provider.example.net";
			sipUri.Uui = "abc123";
			
			var transfer = new Transfer();
			transfer.TransferCallerId = "Anonymous";
			transfer.TransferCallerDisplayName = "test";
			transfer.CallTimeout = 30;
			transfer.TransferCompleteUrl = "http://test.com";
			transfer.TransferCompleteMethod = "POST";
			transfer.TransferCompleteFallbackUrl = "http://fallbackTest.com";
			transfer.TransferCompleteFallbackMethod = "POST";
			transfer.Username = "username";
			transfer.Password = "password";
			transfer.FallbackUsername = "fallbackUsername";
			transfer.FallbackPassword = "fallbackPassword";
			transfer.Tag = "test";
			transfer.DiversionTreatment = "none";
			transfer.DiversionReason = "user-busy";
			transfer.Privacy = true;
			transfer.AttestationLevel = "A";
			transfer.PhoneNumbers = new PhoneNumber[] { phoneNumber };
			transfer.SipUris = new SipUri[] { sipUri };

			var response = new Response(transfer);
			var actual = response.ToBXML();
			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}

		[Fact]
		public void TransferIdentityTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Transfer callTimeout=\"30\" identity=\"abc.def.ghi;info=&lt;https://cert.example.com/cert.pem&gt;;alg=ES256;ppt=&quot;shaken&quot;\">    <PhoneNumber>+15551234567</PhoneNumber>  </Transfer></Response>";

			var phoneNumber = new PhoneNumber();
			phoneNumber.Number = "+15551234567";

			var transfer = new Transfer();
			transfer.Identity = "abc.def.ghi;info=<https://cert.example.com/cert.pem>;alg=ES256;ppt=\"shaken\"";
			transfer.PhoneNumbers = new PhoneNumber[] { phoneNumber };

			var response = new Response(transfer);
			var actual = response.ToBXML();
			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

