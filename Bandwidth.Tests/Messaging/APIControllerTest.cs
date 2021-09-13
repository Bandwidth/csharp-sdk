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
    using Bandwidth.Standard.Messaging.Controllers;
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
            this.controller = this.Client.Messaging.APIController;
        }

        /// <summary>
        /// Gets a list of your media files. No query parameters are supported..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListMedia()
        {
            // Parameters for the API call
            string accountId = "900000";
            string continuationToken = "12345";

            // Perform API call
            ApiResponse<List<Standard.Messaging.Models.Media>> result = null;
            try
            {
                result = await this.controller.ListMediaAsync(accountId, continuationToken);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Continuation-Token", null);
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    this.HttpCallBackHandler.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// Downloads a media file you previously uploaded..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetMedia()
        {
            // Parameters for the API call
            string accountId = "900000";
            string mediaId = "0a610655-ba58";

            // Perform API call
            ApiResponse<Stream> result = null;
            try
            {
                result = await this.controller.GetMediaAsync(accountId, mediaId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/octet-stream");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    this.HttpCallBackHandler.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// Deletes a media file from Bandwidth API server. Make sure you don't have any application scripts still using the media before you delete. If you accidentally delete a media file, you can immediately upload a new file with the same name..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDeleteMedia()
        {
            // Parameters for the API call
            string accountId = "900000";
            string mediaId = "tjdla-4562ld";

            // Perform API call
            try
            {
                await this.controller.DeleteMediaAsync(accountId, mediaId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Gets a list of messages based on query parameters..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetMessages()
        {
            // Parameters for the API call
            string accountId = "900000";
            string messageId = "9e0df4ca-b18d-40d7-a59f-82fcdf5ae8e6";
            string sourceTn = "%2B15554443333";
            string destinationTn = "%2B15554443333";
            string messageStatus = "RECEIVED";
            int? errorCode = 9902;
            string fromDateTime = "2016-09-14T18:20:16.000Z";
            string toDateTime = "2016-09-14T18:20:16.000Z";
            string pageToken = "gdEewhcJLQRB5";
            int? limit = 50;

            // Perform API call
            ApiResponse<Standard.Messaging.Models.BandwidthMessagesList> result = null;
            try
            {
                result = await this.controller.GetMessagesAsync(accountId, messageId, sourceTn, destinationTn, messageStatus, errorCode, fromDateTime, toDateTime, pageToken, limit);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    this.HttpCallBackHandler.Response.Headers),
                    "Headers should match");
        }
    }
}