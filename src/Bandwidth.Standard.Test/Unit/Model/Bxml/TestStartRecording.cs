using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Unit.Model.Bxml
{
	public class TestStartRecording
	{
		[Fact]
		public void StartRecordingTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <StartRecording recordingAvailableUrl=\"https://test.url/\" recordingAvailableMethod=\"POST\" transcribe=\"true\" detectLanguage=\"true\" transcriptionAvailableUrl=\"https://transcriptionTest.url/\" transcriptionAvailableMethod=\"POST\" username=\"username\" password=\"password\" tag=\"test\" fileFormat=\"mp3\" multiChannel=\"true\" /></Response>";

			var startRecording = new StartRecording();
			startRecording.RecordingAvailableUrl = "https://test.url/";
			startRecording.RecordingAvailableMethod = "POST";
			startRecording.Transcribe = true;
			startRecording.DetectLanguage = true;
			startRecording.TranscriptionAvailableUrl = "https://transcriptionTest.url/";
			startRecording.TranscriptionAvailableMethod = "POST";
			startRecording.Username = "username";
			startRecording.Password = "password";
			startRecording.Tag = "test";
			startRecording.FileFormat = "mp3";
			startRecording.MultiChannel = true;

			var response = new Response(startRecording);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

