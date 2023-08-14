using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestConference
	{
		[Fact]
		public void ConferenceTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Conference mute=\"true\" hold=\"true\" callIdsToCoach=\"c-1234abcd,c-9876zyxwv\" conferenceEventUrl=\"https://test.url/\" conferenceEventMethod=\"POST\" conferenceEventFallbackUrl=\"https://fallbackTest.url/\" conferenceEventFallbackMethod=\"POST\" username=\"username\" password=\"password\" fallbackUsername=\"fallbackUsername\" fallbackPassword=\"fallbackPassword\" tag=\"test\" callbackTimeout=\"10\">test</Conference></Response>";

			var conference = new Conference();

			conference.Name = "test";
			conference.Mute = true;
			conference.Hold = true;
			conference.CallIdsToCoach = "c-1234abcd,c-9876zyxwv";
			conference.ConferenceEventUrl = "https://test.url/";
			conference.ConferenceEventMethod = "POST";
			conference.ConferenceEventFallbackUrl = "https://fallbackTest.url/";
			conference.ConferenceEventFallbackMethod = "POST";
			conference.Username = "username";
			conference.Password = "password";
			conference.FallbackUsername = "fallbackUsername";
			conference.FallbackPassword = "fallbackPassword";
			conference.Tag = "test";
			conference.CallbackTimeout = 10;

			var response = new Response(conference);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

