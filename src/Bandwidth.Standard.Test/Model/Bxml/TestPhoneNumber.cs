using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestPhoneNumber
	{
		[Fact]
		public void PhoneNumberTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <PhoneNumber transferAnswerUrl=\"https://test.url/\" transferAnswerMethod=\"POST\" transferAnswerFallbackUrl=\"https://fallbackTest.url/\" transferAnswerFallbackMethod=\"POST\" transferDisconnectUrl=\"https://disconnectTest.url/\" transferDisconnectMethod=\"POST\" username=\"username\" password=\"password\" fallbackUsername=\"fallbackUsername\" fallbackPassword=\"fallbackPassword\" tag=\"test\">+15551234567</PhoneNumber><Response>";

			var phoneNumber = new PhoneNumber();
			phoneNumber.Number = "+15551234567";
			phoneNumber.TransferAnswerUrl = "https://test.url/";
			phoneNumber.TransferAnswerMethod = "POST";
			phoneNumber.TransferAnswerFallbackUrl = "https://fallbackTest.url/";
			phoneNumber.TransferAnswerFallbackMethod = "POST";
			phoneNumber.TransferDisconnectUrl = "https://disconnectTest.url/";
			phoneNumber.TransferDisconnectMethod = "POST";
			phoneNumber.Username = "username";
			phoneNumber.Password = "password";
			phoneNumber.FallbackUsername = "fallbackUsername";
			phoneNumber.FallbackPassword = "fallbackPassword";
			phoneNumber.Tag = "test";

			var response = new Response(phoneNumber);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

