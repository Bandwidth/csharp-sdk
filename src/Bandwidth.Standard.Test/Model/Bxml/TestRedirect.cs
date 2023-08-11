using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestRedirect
	{
		[Fact]
		public void RedirectTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Redirect redirectUrl=\"https://test.url/\" redirectMethod=\"POST\" redirectFallbackUrl=\"\" redirectFallbackMethod=\"POST\" username=\"username\" password=\"password\" fallbackUsername=\"fallbackUsername\" fallbackPassword=\"fallbackPassword\" tag=\"test\"/><Response>";

			var redirect = new Redirect();
			redirect.RedirectUrl = "https://test.url/";
			redirect.RedirectMethod = "POST";
			redirect.RedirectFallbackUrl = "https://fallbacktest.url/";
			redirect.RedirectFallbackMethod = "POST";
			redirect.Username = "username";
			redirect.Password = "password";
			redirect.FallbackUsername = "fallbackUsername";
			redirect.FallbackPassword = "fallbackPassword";
			redirect.Tag = "test";

			var response = new Response(redirect);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

