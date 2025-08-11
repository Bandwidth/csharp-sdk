using System;
using System.Collections.Generic;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Unit.Model.Bxml
{
	public class TestStartStream
	{
		[Fact]
		public void StartStreamTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <StartStream name=\"test\" mode=\"unidirectional\" tracks=\"inbound\" destination=\"wss://test.url/\" destinationUsername=\"destinationUsername\" destinationPassword=\"destinationPassword\" streamEventUrl=\"https://test.url/\" streamEventMethod=\"POST\" username=\"username\" password=\"password\">    <StreamParam name=\"testName\" value=\"testValue\" />  </StartStream></Response>";

			var streamParam = new StreamParam();
			streamParam.Name = "testName";
			streamParam.Value = "testValue";

			var startStream = new StartStream();
			startStream.Name = "test";
			startStream.Mode = "unidirectional";
			startStream.Tracks = "inbound";
			startStream.Destination = "wss://test.url/";
			startStream.DestinationUsername = "destinationUsername";
			startStream.DestinationPassword = "destinationPassword";
			startStream.StreamEventUrl = "https://test.url/";
			startStream.StreamEventMethod = "POST";
			startStream.Username = "username";
			startStream.Password = "password";
			startStream.StreamParam = new List<StreamParam> { streamParam };

			var response = new Response(startStream);
			var actual = response.ToBXML();
			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

