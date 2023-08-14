using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestStreamParam
	{
		[Fact]
		public void StreamParamTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <StreamParam name=\"testName\" value=\"testValue\" /></Response>";

			var streamParam = new StreamParam();
			streamParam.Name = "testName";
			streamParam.Value = "testValue";

			var response = new Response(streamParam);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

