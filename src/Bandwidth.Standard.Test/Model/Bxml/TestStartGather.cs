using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestStartGather
	{
		[Fact]
		public void StartGatherTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <StartGather gatherUrl=\"https://test.url/\" gatherMethod=\"POST\" username=\"username\" password=\"password\" tag=\"test\"></StartGather></Response>";

			var startGather = new StartGather();
			startGather.DtmfUrl = "https://test.url/";
			startGather.DtmfMethod = "POST";
			startGather.Username = "username";
			startGather.Password = "password";
			startGather.Tag = "test";

			var response = new Response(startGather);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

