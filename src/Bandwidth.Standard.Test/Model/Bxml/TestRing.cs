using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestRing
	{
		[Fact]
		public void RingTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Ring duration=\"5\" answerCall=\"true\" /></Response>";

			var ring = new Ring();
			ring.Duration = 5;
			ring.AnswerCall = true;

			var response = new Response(ring);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

