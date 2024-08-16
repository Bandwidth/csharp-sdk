using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Unit.Model.Bxml
{
	public class TestStartGather
	{
		[Fact]
		public void StartGatherTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <StartGather dtmfUrl=\"https://test.url/\" dtmfMethod=\"POST\" username=\"username\" password=\"password\" tag=\"test\" /></Response>";

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

