using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestStopTranscription
	{
		[Fact]
		public void StopTranscriptionTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <StopTranscription name=\"test\" /></Response>";

			var stopTranscription = new StopTranscription();
			stopTranscription.Name = "test";

			var response = new Response(stopTranscription);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

