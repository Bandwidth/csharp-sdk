using System;
using System.Collections.Generic;
using Xunit;

using Bandwidth.Standard.Client;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Model;
using System.Net;

namespace Bandwidth.Standard.Test.Smoke
{
    /// <summary>
    ///  Class for testing PhoneNumberLookupApi
    /// </summary>
    public class PhoneNumberLookupSmokeTests : IDisposable
    {
        private string accountId;
        private string BW_NUMBER;
        private Configuration fakeConfiguration;
        private PhoneNumberLookupApi forbiddenInstance;
        private PhoneNumberLookupApi instance;
        private string testRequestId;
        private PhoneNumberLookupApi unauthorizedInstance;

        public PhoneNumberLookupSmokeTests()
        {
            accountId = Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");
            testRequestId = "test-request-id";
            BW_NUMBER = Environment.GetEnvironmentVariable("BW_NUMBER");

            // Authorized API Client
            fakeConfiguration = new Configuration();
            fakeConfiguration.BasePath = "https://voice.bandwidth.com/api/v2";
            fakeConfiguration.Username = Environment.GetEnvironmentVariable("BW_USERNAME");
            fakeConfiguration.Password = Environment.GetEnvironmentVariable("BW_PASSWORD");
            instance = new PhoneNumberLookupApi(fakeConfiguration);

            // Unauthorized API Client
            fakeConfiguration.Username = "badUsername";
            fakeConfiguration.Password = "badPassword";
            unauthorizedInstance = new PhoneNumberLookupApi(fakeConfiguration);

            // Forbidden API Client
            fakeConfiguration.Username = Environment.GetEnvironmentVariable("BW_USERNAME_FORBIDDEN");
            fakeConfiguration.Password = Environment.GetEnvironmentVariable("BW_PASSWORD_FORBIDDEN");
            forbiddenInstance = new PhoneNumberLookupApi(fakeConfiguration);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PhoneNumberLookupApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<PhoneNumberLookupApi>(instance);
        }

        /// <summary>
        /// Test successful GetLookupStatus request
        /// </summary>
        [Fact]
        public void GetLookupStatusTest()
        {
            LookupRequest lookupRequest = new LookupRequest(new List<string> { BW_NUMBER });
            var response = instance.CreateLookupWithHttpInfo(accountId, lookupRequest);

            var lookupStatus = instance.GetLookupStatus(accountId, response.Data.RequestId);
            Assert.IsType<LookupStatus>(lookupStatus);
            Assert.Equal(response.Data.RequestId, lookupStatus.RequestId);
            Assert.Equal(BW_NUMBER, lookupStatus.Result[0].E164Format);
        }

        /// <summary>
        /// Test GetLookupStatus with an unauthorized client
        /// </summary>
        [Fact]
        public void GetLookupStatusUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.GetLookupStatus(accountId, testRequestId));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test GetLookupStatus with a forbidden client
        /// API throws a 401 rather than the expected 403
        /// </summary>
        [Fact]
        public void GetLookupStatusForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.GetLookupStatus(accountId, testRequestId));
            // Assert.Equal(403, Exception.ErrorCode);
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test successful CreateLookup request
        /// </summary>
        [Fact]
        public void CreateLookupTest()
        {
            LookupRequest lookupRequest = new LookupRequest(new List<string> { BW_NUMBER });
            var response = instance.CreateLookupWithHttpInfo(accountId, lookupRequest);
            Assert.IsType<ApiResponse<CreateLookupResponse>>(response);
            Assert.Equal(LookupStatusEnum.INPROGRESS, response.Data.Status);
            Assert.IsType<string>(response.Data.RequestId);
            Assert.Matches("[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$", response.Data.RequestId);
            Assert.Equal(HttpStatusCode.Accepted, response.StatusCode);

            var lookupStatus = instance.GetLookupStatus(accountId, response.Data.RequestId);
            Assert.IsType<LookupStatus>(lookupStatus);
            Assert.Equal(response.Data.RequestId, lookupStatus.RequestId);
            Assert.Equal(BW_NUMBER, lookupStatus.Result[0].E164Format);

        }

        /// <summary>
        /// Test CreateLookup with a bad request
        /// </summary>
        [Fact]
        public void CreateLookupBadRequest()
        {
            LookupRequest lookupRequest = new LookupRequest(new List<string> { "not a number" });
            ApiException exception = Assert.Throws<ApiException>(() => instance.CreateLookup(accountId, lookupRequest));
            var error = new TnLookupRequestError(exception.Message);
            Assert.IsType<TnLookupRequestError>(error);
            Assert.Equal(400, exception.ErrorCode);

        }

        /// <summary>
        /// Test CreateLookup with a duplicate phone number lookup
        /// </summary>
        [Fact]
        public void CreateLookupDuplicateRequest()
        {
            LookupRequest lookupRequest = new LookupRequest(new List<string> { BW_NUMBER, BW_NUMBER });
            ApiException Exception = Assert.Throws<ApiException>(() => instance.CreateLookup(accountId, lookupRequest));
            Assert.Equal(400, Exception.ErrorCode); 
            Assert.IsType<string>(Exception.Message);
        }  

        /// <summary>
        /// Test CreateLookup with an unauthorized client
        /// </summary>
        [Fact]
        public void CreateLookupUnauthorizedRequest()
        {
            LookupRequest lookupRequest = new LookupRequest(new List<string> { BW_NUMBER });
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.CreateLookup(accountId, lookupRequest));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test CreateLookup with a forbidden client
        /// </summary>
        [Fact]
        public void CreateLookupForbiddenRequest()
        {
            LookupRequest lookupRequest = new LookupRequest(new List<string> { BW_NUMBER });
            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.CreateLookup(accountId, lookupRequest));
            //This API throws a 401 when a user provides valid credentials with the `TN Lookup` role disabled
            // Assert.Equal(403, Exception.ErrorCode);
            Assert.Equal(401, Exception.ErrorCode);
        }
    }
}
