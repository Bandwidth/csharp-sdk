/*
 * Bandwidth
 *
 * Bandwidth's Communication APIs
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: letstalk@bandwidth.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Bandwidth.Standard.Client;
using Bandwidth.Standard.Api;
// uncomment below to import models
//using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Api
{
    /// <summary>
    ///  Class for testing MediaApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MediaApiTests : IDisposable
    {
        private MediaApi instance;

        public MediaApiTests()
        {
            instance = new MediaApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MediaApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MediaApi
            //Assert.IsType<MediaApi>(instance);
        }

        /// <summary>
        /// Test DeleteMedia
        /// </summary>
        [Fact]
        public void DeleteMediaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string mediaId = null;
            //instance.DeleteMedia(accountId, mediaId);
        }

        /// <summary>
        /// Test GetMedia
        /// </summary>
        [Fact]
        public void GetMediaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string mediaId = null;
            //var response = instance.GetMedia(accountId, mediaId);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test ListMedia
        /// </summary>
        [Fact]
        public void ListMediaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string continuationToken = null;
            //var response = instance.ListMedia(accountId, continuationToken);
            //Assert.IsType<List<Media>>(response);
        }

        /// <summary>
        /// Test UploadMedia
        /// </summary>
        [Fact]
        public void UploadMediaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string mediaId = null;
            //System.IO.Stream body = null;
            //string contentType = null;
            //string cacheControl = null;
            //instance.UploadMedia(accountId, mediaId, body, contentType, cacheControl);
        }
    }
}
