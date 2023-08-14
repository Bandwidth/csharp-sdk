using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestPauseRecording
	{
		[Fact]
		public void PauseRecordingTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <PauseRecording/></Response>";

			var pauseRecording = new PauseRecording();

			var response = new Response(pauseRecording);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

