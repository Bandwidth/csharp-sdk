using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Unit.Model.Bxml
{
	public class TestStopStream
	{
		[Fact]
		public void StopStreamTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <StopStream name=\"test\" wait=\"true\" /></Response>";

			var stopStream = new StopStream();
			stopStream.Name = "test";
			stopStream.Wait = true;

			var response = new Response(stopStream);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

