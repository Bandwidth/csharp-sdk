using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Bandwidth.Standard;
using Bandwidth.Standard.Exceptions;
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
            // Rate limit response code.
            const int tooManyRequests = 429;

            var accountId = TestConstants.AccountId;
            var number = TestConstants.From;

            var request = new OrderRequest
            {
                Tns = new List<string> { number }
            };

            int responseCode = -1;
            do
            {
                try
                {
                    var response = await _client.PhoneNumberLookup.APIController.CreateLookupRequestAsync(accountId, request);
                    
                    Assert.NotEmpty(response.Data.RequestId);
                    Assert.Equal("IN_PROGRESS", response.Data.Status);
                }
                catch (ApiException ex)
                {
                    responseCode = ex.ResponseCode;
                }
            } while (responseCode == tooManyRequests);
        }

        [Fact]
        public async Task GetTnLookupResultAsync()
        {
            // Rate limit response code.
            const int tooManyRequests = 429;

            var accountId = TestConstants.AccountId;
            var number = TestConstants.From;

            var request = new OrderRequest
            {
                Tns = new List<string> { number }
            };

            ApiResponse<OrderResponse> requestResponse;
            int responseCode = -1;
            do {
                try
                {
                    requestResponse = await _client.PhoneNumberLookup.APIController.CreateLookupRequestAsync(accountId, request);

                    ApiResponse<OrderStatus> requestStatusResponse = null;
                    int resultResponseCode = -1;
                    do
                    {
                        try
                        {
                            requestStatusResponse = await _client.PhoneNumberLookup.APIController.GetLookupRequestStatusAsync(accountId, requestResponse.Data.RequestId);
                        }
                        catch (ApiException ex)
                        {
                            if (ex.ResponseCode != tooManyRequests) throw ex;

                            resultResponseCode = ex.ResponseCode;
                        }
                    } while (resultResponseCode == tooManyRequests || requestStatusResponse.Data.Status == "IN_PROGRESS");

                    Assert.NotEmpty(requestStatusResponse.Data.RequestId);
                    Assert.Equal(requestResponse.Data.RequestId, requestStatusResponse.Data.RequestId);
                    
                    Assert.Equal("COMPLETE", requestStatusResponse.Data.Status);

                    Assert.Null(requestStatusResponse.Data.FailedTelephoneNumbers);
                    
                    Assert.Single(requestStatusResponse.Data.Result);
                    
                    Assert.Equal(0, requestStatusResponse.Data.Result.First().ResponseCode);
                    Assert.Equal("NOERROR", requestStatusResponse.Data.Result.First().Message);
                    Assert.Equal(number, requestStatusResponse.Data.Result.First().E164Format);

                    var formatPattern = @"^\+\d(\d{3})(\d{3})(\d{4})$";
                    foreach (Match match in Regex.Matches(number, formatPattern))
                    {   
                        var formattedNumber = $"({match.Groups[1].Value}) {match.Groups[2].Value}-{match.Groups[3].Value}";
                        Assert.Equal(formattedNumber, requestStatusResponse.Data.Result.First().Formatted);
                    }

                    Assert.Equal(0, requestStatusResponse.Data.Result.First().ResponseCode);
                    Assert.Equal("US", requestStatusResponse.Data.Result.First().Country);
                    Assert.Equal("Mobile", requestStatusResponse.Data.Result.First().LineType);
                    Assert.Equal("Bandwidth", requestStatusResponse.Data.Result.First().LineProvider);
                    Assert.Null(requestStatusResponse.Data.Result.First().MobileCountryCode);
                    Assert.Null(requestStatusResponse.Data.Result.First().MobileNetworkCode);
                }
                catch (ApiException ex)
                {
                    if (ex.ResponseCode != tooManyRequests) throw ex;

                    responseCode = ex.ResponseCode;
                }
            } while (responseCode == tooManyRequests);
        }
    }
}