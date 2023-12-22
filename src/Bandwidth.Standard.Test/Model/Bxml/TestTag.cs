using System;
using Bandwidth.Standard.Model;
using Bandwidth.Standard.Model.Bxml;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestTag
	{
		[Fact]
		public void TagTest()
		{
			var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Tag>test</Tag></Response>";

			var tag = new Bandwidth.Standard.Model.Bxml.Verbs.Tag();
			tag.Value = "test";

			var response = new Response(tag);
			var actual = response.ToBXML();
			Assert.Equal(expected, actual.Replace("\n","").Replace("\r",""));
		}
	}
}

