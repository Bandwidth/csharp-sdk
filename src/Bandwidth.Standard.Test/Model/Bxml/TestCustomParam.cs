using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestCustomParam
	{
		[Fact]
		public void CustomParamTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <CustomParam name=\"testName\" value=\"testValue\" /></Response>";

			var customParam = new CustomParam();
			customParam.Name = "testName";
			customParam.Value = "testValue";

			var response = new Response(customParam);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

