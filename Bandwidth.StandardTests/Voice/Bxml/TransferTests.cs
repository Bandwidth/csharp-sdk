using System.Collections.Generic;
using Bandwidth.Standard.Voice.Bxml;
using Xunit;

namespace Bandwidth.StandardTests.Voice.Bxml
{
    public class TransferTests
    {

        [Fact]
        public void SimpleTransferTest()
        {
            var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Transfer callTimeout=\"30\">    <PhoneNumber>+19195551234</PhoneNumber>  </Transfer></Response>";

            var transferNumber = new PhoneNumber { Number = "+19195551234" };
            var transfer = new Transfer
            {
                PhoneNumbers = new[] { transferNumber }
            };

            var response = new Response(transfer);
            var actual = response.ToBXML();

            Assert.Equal(expected, actual.Replace("\n", "").Replace("\r", ""));
        }

        [Fact]
        public void TransferWithPrivacy()
        {
            var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Transfer privacy=\"true\" transferCallerDisplayName=\"Anonymous\" callTimeout=\"30\">    <PhoneNumber>+19195551234</PhoneNumber>  </Transfer></Response>";

            var transferNumber = new PhoneNumber { Number = "+19195551234" };
            var transfer = new Transfer
            {
                Privacy = true,
                TransferCallerDisplayName = Standard.Voice.Models.DisplayNameEnum.Anonymous,
                PhoneNumbers = new[] { transferNumber }
            };

            var response = new Response(transfer);
            var actual = response.ToBXML();

            Assert.Equal(expected, actual.Replace("\n", "").Replace("\r", ""));
        }
    }
}
