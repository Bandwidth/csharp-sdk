using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestSpeakSentence
	{
		[Fact]
		public void SpeakSentenceTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <SpeakSentence voice=\"kate\" gender=\"female\" locale=\"en_US\">test</SpeakSentence></Response>";

			var speakSentence = new SpeakSentence();
			speakSentence.Text = "test";
			speakSentence.Voice = "kate";
			speakSentence.Gender = "female";
			speakSentence.Locale = "en_US";

			var response = new Response(speakSentence);
			var actual = response.ToBXML();
			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

