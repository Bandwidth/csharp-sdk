using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Unit.Model.Bxml
{
	public class TestEndpoint
	{
		[Fact]
		public void EndpointTest()
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
