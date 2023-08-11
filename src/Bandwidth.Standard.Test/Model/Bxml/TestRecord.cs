using System;
using Bandwidth.Standard.Model.Bxml;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestRecord
	{
		[Fact]
		public void RecordTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Record recordCompleteUrl=\"https://test.url/\" recordCompleteMethod=\"POST\" recordCompleteFallbackUrl=\"https://fallbackTest.url/\" recordCompleteFallbackMethod=\"POST\" recordingAvailableUrl=\"https://recordingTest.url/\" recordAvailableMethod=\"POST\" transcribe=\"true\" detectLanguage=\"true\" transcriptionAvailableUrl=\"https://transcriptionTest.url/\" transcriptionAvailableMethod=\"POST\" username=\"username\" password=\"password\" fallbackUsername=\"fallbackUsername\" fallbackPassword=\"fallbackPassword\" tag=\"test\" terminatingDigits=\"#\" maxDuration=\"60\" silenceTimeout=\"0\" fileFormat=\"wav\"/><Response>";

			var record = new Bandwidth.Standard.Model.Bxml.Verbs.Record();
			record.RecordCompleteUrl = "https://test.url/";
			record.RecordCompleteMethod = "POST";
			record.RecordCompleteFallbackUrl = "https://fallbackTest.url/";
			record.RecordCompleteFallbackMethod = "POST";
			record.RecordingAvailableUrl = "https://recordingTest.url/";
			record.RecordingAvailableMethod = "POST";
			record.Transcribe = true;
			record.DetectLanguage = true;
			record.TranscriptionAvailableUrl = "https://transcriptionTest.url/";
			record.TranscriptionAvailableMethod = "POST";
			record.Username = "username";
			record.Password = "password";
			record.FallbackUsername = "fallbackUsername";
			record.FallbackPassword = "fallbackPassword";
			record.Tag = "test";
			record.TerminatingDigits = "#";
			record.MaxDuration = 60;
			record.SilenceTimeout = 0;
			record.FileFormat = "wav";

			var response = new Response(record);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

