using Xunit;
using System;
using Bandwidth.Standard.Model.Bxml;

namespace Bandwidth.Standard.Test.Model.Bxml
{
    public class TestBaseClasses
    {
        [Fact]
        public void EmptyBxmlTest()
        {
            var bxml = new BXML();
            Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?><Bxml />", bxml.ToBXML().Replace("\n", "").Replace("\r", ""));
        }
    }
}

