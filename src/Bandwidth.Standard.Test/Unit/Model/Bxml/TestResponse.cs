using System;
using Bandwidth.Standard.Model.Bxml;
using Xunit;

namespace Bandwidth.Standard.Test.Unit.Model.Bxml
{
	public class TestResponse
	{
        [Fact]
        public void ResponseTest()
        {
            var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response />";
            var response = new Response();
            Assert.Equal(expected, response.ToBXML().Replace("\n", "").Replace("\r", ""));
        }
    }
}

