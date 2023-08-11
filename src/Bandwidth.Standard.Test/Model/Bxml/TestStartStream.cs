using System;
using System.Collections.Generic;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestStartStream
	{
		[Fact]
		public void StartStreamTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <StartStream name=\"test\" tracks=\"inbound\" destination=\"wss://test.url/\" streamEventUrl=\"https://test.url/\" streamEventMethod=\"POST\" username=\"username\" password=\"password\">    <StreamParam name=\"testName\" value=\"testValue\"/></StartStream><Response>";

			var streamParam = new StreamParam();
			streamParam.Name = "testName";
			streamParam.Value = "testValue";

			var startStream = new StartStream();
			startStream.Name = "test";
			startStream.Tracks = "inbound";
			startStream.Destination = "wss://test.url/";
			startStream.StreamEventUrl = "https://test.url/";
			startStream.StreamEventMethod = "POST";
			startStream.Username = "username";
			startStream.Password = "password";
			startStream.StreamParams = new List<StreamParam> { streamParam };

			var response = new Response(startStream);
			var actual = response.ToBXML();
			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

