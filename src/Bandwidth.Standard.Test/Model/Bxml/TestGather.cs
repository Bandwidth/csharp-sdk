using System;
using System.Collections.Generic;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestGather
	{
		[Fact]
		public void GatherTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Gather gatherUrl=\"https://test.url/\" gatherMethod=\"POST\" gatherFallbackUrl=\"https://fallbackTest.url/\" gatherFallbackMethod=\"POST\" username=\"username\" password=\"password\" fallbackUsername=\"fallbackUsername\" fallbackPassword=\"fallbackPassword\" tag=\"test\" terminatingDigits=\"#\" maxDigits=\"50\" interDigitTimeout=\"5\" firstDigitTimeout=\"5\" repeatCount=\"1\">    <SpeakSentence>test</SpeakSentence>    <PlayAudio>https://test.url/test.mp3</PlayAudio>  </Gather></Response>";

			var speakSentence = new SpeakSentence();
			speakSentence.Text = "test";

			var playAudio = new PlayAudio();
			playAudio.AudioUri = "https://test.url/test.mp3";

			var gather = new Gather();
			gather.GatherUrl = "https://test.url/";
			gather.GatherMethod = "POST";
			gather.GatherFallbackUrl = "https://fallbackTest.url/";
			gather.GatherFallbackMethod = "POST";
			gather.Username = "username";
			gather.Password = "password";
			gather.FallbackUsername = "fallbackUsername";
			gather.FallbackPassword = "fallbackPassword";
			gather.Tag = "test";
			gather.TerminatingDigits = "#";
			gather.MaxDigits = 50;
			gather.InterDigitTimeout = 5;
			gather.FirstDigitTimeout = 5;
			gather.RepeatCount = 1;
			gather.SpeakSentence = new List<SpeakSentence> { speakSentence };
			gather.PlayAudio = new List<PlayAudio> { playAudio };

			var response = new Response(gather);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

