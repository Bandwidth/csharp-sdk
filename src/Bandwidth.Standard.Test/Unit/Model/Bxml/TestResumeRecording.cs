using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Unit.Model.Bxml
{
	public class TestResumeRecording
	{
		[Fact]
		public void ResumeRecordingTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <ResumeRecording /></Response>";

			var resumeRecording = new ResumeRecording();
			
			var response = new Response(resumeRecording);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));

		}
	}
}

