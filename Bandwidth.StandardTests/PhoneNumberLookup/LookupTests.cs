using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

            var request = new OrderRequest
            {
                Tns = new List<string> { number }
            };

            // Sleep to avoid rate limiting from other tests.
            Thread.Sleep(5000);

            var response = await _client.PhoneNumberLookup.APIController.CreateLookupRequestAsync(accountId, request);

            Assert.NotEmpty(response.Data.RequestId);
            Assert.Equal("IN_PROGRESS", response.Data.Status);
        }

        [Fact]
        public async Task GetTnLookupResultAsync()
        {
            var accountId = TestConstants.AccountId;
            var number = TestConstants.From;

            var request = new OrderRequest
            {
                Tns = new List<string> { number }
            };

            // Sleep to avoid rate limiting from other tests.
            Thread.Sleep(5000);

            var requestResponse = await _client.PhoneNumberLookup.APIController.CreateLookupRequestAsync(accountId, request);

            ApiResponse<OrderStatus> resultResponse;
            do {
                // We hit the rate limit very quickly while checking the status. Sleep before the initial request to avoid hitting rate limit from other tests.
                Thread.Sleep(5000);

                resultResponse = await _client.PhoneNumberLookup.APIController.GetLookupRequestStatusAsync(accountId, requestResponse.Data.RequestId);
            } while (resultResponse.Data.Status == "IN_PROGRESS");

            Assert.NotEmpty(resultResponse.Data.RequestId);
            Assert.Equal(requestResponse.Data.RequestId, resultResponse.Data.RequestId);
            
            Assert.Equal("COMPLETE", resultResponse.Data.Status);

            Assert.Null(resultResponse.Data.FailedTelephoneNumbers);
            
            Assert.Single(resultResponse.Data.Result);
            
            Assert.Equal(0, resultResponse.Data.Result.First().ResponseCode);
            Assert.Equal("NOERROR", resultResponse.Data.Result.First().Message);
            Assert.Equal(number, resultResponse.Data.Result.First().E164Format);

            Assert.Equal("not-a-number", resultResponse.Data.Result.First().E164Format);

            var formatPattern = @"^\+\d(\d{3})(\d{3})(\d{4})$";
            foreach (Match match in Regex.Matches(number, formatPattern))
            {   
                var formattedNumber = $"({match.Groups[1].Value}) {match.Groups[2].Value}-{match.Groups[3].Value}";
                Assert.Equal(formattedNumber, resultResponse.Data.Result.First().Formatted);
            }

            Assert.Equal(0, resultResponse.Data.Result.First().ResponseCode);
            Assert.Equal("US", resultResponse.Data.Result.First().Country);
            Assert.Equal("Mobile", resultResponse.Data.Result.First().LineType);
            Assert.Equal("Bandwidth", resultResponse.Data.Result.First().LineProvider);
            Assert.Null(resultResponse.Data.Result.First().MobileCountryCode);
            Assert.Null(resultResponse.Data.Result.First().MobileNetworkCode);
        }
    }
}