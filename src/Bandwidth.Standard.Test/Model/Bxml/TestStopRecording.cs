using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestStopRecording
	{
		[Fact]
		public void StopRecordingTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <StopRecording /></Response>";

			var stopRecording = new StopRecording();

			var response = new Response(stopRecording);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}
