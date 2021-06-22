using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Bandwidth.Standard;
using Bandwidth.Standard.Http.Response;
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
        public async Task CreateTnLookupRequestAsync()
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

        [Fact]
        public async Task GetTnLookupResultAsync()
        {
            var accountId = TestConstants.AccountId;
            var number = TestConstants.From;

            var request = new AccountsTnlookupRequest
            {
                Tns = new List<string> { number }
            };

            var requestResponse = await _client.PhoneNumberLookup.APIController.CreateTnLookupRequestAsync(accountId, request);

            ApiResponse<AccountsTnlookupResponse1> resultResponse;
            do {
                resultResponse = await _client.PhoneNumberLookup.APIController.GetTnLookupResultAsync(accountId, requestResponse.Data.RequestId);
                
                // We hit the rate limit very quickly while checking the status.
                Thread.Sleep(3000);
            } while (resultResponse.Data.Status == "IN_PROGRESS");

            Assert.NotEmpty(resultResponse.Data.RequestId);
            Assert.Equal(requestResponse.Data.RequestId, resultResponse.Data.RequestId);

            Assert.Null(resultResponse.Data.FailedTelephoneNumbers);
            


            

            Assert.Equal("US", resultResponse.Data.Result.First().Country);

            Assert.Equal("COMPLETE", requestResponse.Data.Status);
        }
    }
}