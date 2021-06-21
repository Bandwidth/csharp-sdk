using System.Collections.Generic;
using System.Threading.Tasks;
using Bandwidth.Standard;
using Bandwidth.Standard.PhoneNumberLookup.Models;
using Xunit;

namespace Bandwidth.StandardTests.PhoneNumberLookup
{
    public class LookupTests
    {
        private BandwidthClient _client;

        public LookupTests()
        {
            _client = new BandwidthClient.Builder()
                .Environment(Bandwidth.Standard.Environment.Production)
                .PhoneNumberLookupBasicAuthCredentials(TestConstants.Username, TestConstants.Password)
                .Build();
        }

        [Fact]
        public async Task CreateLookupAsync()
        {
            var accountId = TestConstants.AccountId;
            var number = TestConstants.From;

            var request = new AccountsTnlookupRequest
            {
                Tns = new List<string> { number }
            };

            var response = await _client.PhoneNumberLookup.APIController.CreateTnLookupRequestAsync(accountId, request);

            Assert.NotEmpty(response.Data.RequestId);
            Assert.Equal("IN_PROGRESS", response.Data.Status);
        }
    }
}