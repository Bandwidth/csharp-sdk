/*
 * Bandwidth
 *
 * Bandwidth's Communication APIs
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: letstalk@bandwidth.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Bandwidth.Standard.Model;
using Bandwidth.Standard.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Bandwidth.Standard.Test.Model
{
    /// <summary>
    ///  Class for testing TranscriptionMetadata
    /// </summary>
    public class TranscriptionMetadataTests : IDisposable
    {
        private TranscriptionMetadata instance;

        public TranscriptionMetadataTests()
        {
            instance = new TranscriptionMetadata();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TranscriptionMetadata
        /// </summary>
        [Fact]
        public void TranscriptionMetadataInstanceTest()
        {
            Assert.IsType<TranscriptionMetadata>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            instance.Id = "t-1234";
            Assert.IsType<string>(instance.Id);
            Assert.Equal("t-1234", instance.Id);
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            instance.Status = "completed";
            Assert.IsType<string>(instance.Status);
            Assert.Equal("completed", instance.Status);
        }
        /// <summary>
        /// Test the property 'CompletedTime'
        /// </summary>
        [Fact]
        public void CompletedTimeTest()
        {
            instance.CompletedTime = "2020-03-20T15:16:37Z";
            Assert.IsType<string>(instance.CompletedTime);
            Assert.Equal("2020-03-20T15:16:37Z", instance.CompletedTime);
        }
        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Fact]
        public void UrlTest()
        {
            instance.Url = "https://test.url/";
            Assert.IsType<string>(instance.Url);
            Assert.Equal("https://test.url/", instance.Url);
        }

    }

}
