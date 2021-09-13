// <copyright file="APIControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using Bandwidth.Standard;
    using Bandwidth.Standard.Exceptions;
    using Bandwidth.Standard.Http.Client;
    using Bandwidth.Standard.Http.Response;
    using Bandwidth.Standard.PhoneNumberLookup.Controllers;
    using Bandwidth.Standard.Utilities;
    using Bandwidth.Tests.Helpers;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;

    /// <summary>
    /// APIControllerTest.
    /// </summary>
    [TestFixture]
    public class APIControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private APIController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.PhoneNumberLookup.APIController;
        }

        /// <summary>
        /// Create a TN Lookup Order..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestLookupRequest()
        {
            // Parameters for the API call
            string accountId = "9998887";
            Standard.PhoneNumberLookup.Models.OrderRequest body = ApiHelper.JsonDeserialize<Standard.PhoneNumberLookup.Models.OrderRequest>("{\"tns\":[\"19196104420\"]}");

            // Perform API call
            ApiResponse<Standard.PhoneNumberLookup.Models.OrderResponse> result = null;
            try
            {
                result = await this.controller.CreateLookupRequestAsync(accountId, body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(202, this.HttpCallBackHandler.Response.StatusCode, "Status should be 202");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    this.HttpCallBackHandler.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"requestId\":\"004223a0-8b17-41b1-bf81-20732adf5590\",\"status\":\"IN_PROGRESS\"}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}