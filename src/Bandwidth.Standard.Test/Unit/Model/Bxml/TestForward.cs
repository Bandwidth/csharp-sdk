using System;
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;
using Xunit;

namespace Bandwidth.Standard.Test.Unit.Model.Bxml
{
	public class TestForward
	{
		[Fact]
		public void ForwardTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Forward to=\"+15551234567\" from=\"+15557654321\" callTimeout=\"10\" diversionTreatment=\"propagate\" diversionReason=\"away\" uui=\"93d6f3c0be5845960b744fa28015d8ede84bd1a4;encoding=base64,asdf;encoding=jwt\" /></Response>";

			var forward = new Forward();
			forward.To = "+15551234567";
			forward.From = "+15557654321";
			forward.CallTimeout = 10;
			forward.DiversionTreatment = "propagate";
			forward.DiversionReason = "away";
			forward.Uui	= "93d6f3c0be5845960b744fa28015d8ede84bd1a4;encoding=base64,asdf;encoding=jwt";

			var response = new Response(forward);
			var actual = response.ToBXML();

			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

