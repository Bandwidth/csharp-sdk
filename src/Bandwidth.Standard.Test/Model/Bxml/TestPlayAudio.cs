using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestPlayAudio
	{
		[Fact]
		public void PlayAudioTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <PlayAudio username=\"username\" password=\"password\">https://test.url/test.mp3</PlayAudio><Response>";

			var playAudio = new PlayAudio();
			playAudio.AudioUri = "https://test.url/test.mp3";
			playAudio.Username = "username";
			playAudio.Password = "password";

			var response = new Response(playAudio);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

