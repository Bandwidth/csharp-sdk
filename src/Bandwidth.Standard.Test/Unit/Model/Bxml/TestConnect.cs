using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Unit.Model.Bxml
{
	public class TestConnect
	{
		[Fact]
		public void ConnectTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Connect eventCallbackUrl=\"https://example.com/callback\">    <Endpoint>e-abc123</Endpoint>  </Connect></Response>";

			var endpoint = new Endpoint();
			endpoint.EndpointId = "e-abc123";

			var connect = new Connect();
			connect.EventCallbackUrl = "https://example.com/callback";
			connect.Destination = endpoint;

			var response = new Response(connect);
			var actual = response.ToBXML();
			Assert.Equal(expected, actual.Replace("\n", "").Replace("\r", ""));
		}

		[Fact]
		public void ConnectWithoutCallbackTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Connect>    <Endpoint>e-abc123</Endpoint>  </Connect></Response>";

			var endpoint = new Endpoint();
			endpoint.EndpointId = "e-abc123";

			var connect = new Connect();
			connect.Destination = endpoint;

			var response = new Response(connect);
			var actual = response.ToBXML();
			Assert.Equal(expected, actual.Replace("\n", "").Replace("\r", ""));
		}
	}
}
