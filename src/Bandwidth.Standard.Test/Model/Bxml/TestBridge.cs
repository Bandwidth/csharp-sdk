using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestBridge
	{
		[Fact]
		public void BridgeTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Bridge bridgeCompleteUrl=\"https://bridge.url/nextBXMLForSecondCall\" bridgeCompleteMethod=\"POST\" bridgeCompleteFallbackUrl=\"https://fallbackbridge.url/nextBXMLForSecondCall\" bridgeCompleteFallbackMethod=\"POST\" bridgeTargetCompleteUrl=\"https://bridge.url/nextBXMLForFirstCall\" bridgeTargetCompleteMethod=\"POST\" bridgeTargetCompleteFallbackUrl=\"https://fallbackbridge.url/nextBXMLForFirstCall\" bridgeTargetCompleteFallbackMethod=\"POST\" username=\"username\" password=\"password\" fallbackUsername=\"fallbackUsername\" fallbackPassword=\"fallbackPassword\" tag=\"test\">c-1234abcd</Bridge></Response>";

			var bridge = new Bridge();
			bridge.TargetCall = "c-1234abcd";
			bridge.BridgeCompleteUrl = "https://bridge.url/nextBXMLForSecondCall";
			bridge.BridgeCompleteMethod = "POST";
			bridge.BridgeCompleteFallbackUrl = "https://fallbackbridge.url/nextBXMLForSecondCall";
			bridge.BridgeCompleteFallbackMethod = "POST";
			bridge.BridgeTargetCompleteUrl = "https://bridge.url/nextBXMLForFirstCall";
			bridge.BridgeTargetCompleteMethod = "POST";
			bridge.BridgeTargetCompleteFallbackUrl = "https://fallbackbridge.url/nextBXMLForFirstCall";
			bridge.BridgeTargetCompleteFallbackMethod = "POST";
			bridge.Username = "username";
			bridge.Password = "password";
			bridge.FallbackUsername = "fallbackUsername";
			bridge.FallbackPassword = "fallbackPassword";
			bridge.Tag = "test";

            var response = new Response(bridge);
            var actual = response.ToBXML();

            Assert.Equal(expected, actual.Replace("\n", "").Replace("\r", ""));
        }
    }
}

