using System;
using System.Collections.Generic;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestStartTranscription
	{
		[Fact]
		public void StartTranscriptionTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <StartTranscription name=\"test\" tracks=\"inbound\" transcriptionEventUrl=\"https://test.url/\" transcriptionEventMethod=\"POST\" username=\"username\" password=\"password\" destination=\"wss://test.url/\" stabilized=\"true\">    <CustomParam name=\"testName\" value=\"testValue\" />  </StartTranscription></Response>";
			
			var customParam = new CustomParam();
			customParam.Name = "testName";
			customParam.Value = "testValue";


			var startTranscription = new StartTranscription();
			startTranscription.Name = "test";
			startTranscription.Tracks = "inbound";
			startTranscription.TranscriptionEventUrl = "https://test.url/";
			startTranscription.TranscriptionEventMethod = "POST";
			startTranscription.Username = "username";
			startTranscription.Password = "password";
			startTranscription.Destination = "wss://test.url/";
			startTranscription.Stabilized = true;
			startTranscription.CustomParams = new List<CustomParam> { customParam };

			var response = new Response(startTranscription);
			var actual = response.ToBXML();
			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

