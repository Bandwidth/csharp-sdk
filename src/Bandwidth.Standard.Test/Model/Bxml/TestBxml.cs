using System;
using Bandwidth.Standard.Model.Bxml;
using Xunit;

namespace Bandwidth.Standard.Test.Model.Bxml
{
	public class TestBxml
	{
        [Fact]
        public void BxmlTest()
        {
            var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Bxml />";
            var bxml = new BXML();
            Assert.Equal(expected, bxml.ToBXML().Replace("\n", "").Replace("\r", ""));
        }
    }
}

