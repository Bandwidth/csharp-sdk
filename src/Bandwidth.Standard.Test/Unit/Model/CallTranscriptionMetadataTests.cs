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

namespace Bandwidth.Standard.Test.Unit.Model
{
    /// <summary>
    ///  Class for testing CallTranscriptionMetadata
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CallTranscriptionMetadataTests : IDisposable
    {
        private CallTranscriptionMetadata instance;

        public CallTranscriptionMetadataTests()
        {
            instance = new CallTranscriptionMetadata();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CallTranscriptionMetadata
        /// </summary>
        [Fact]
        public void CallTranscriptionMetadataInstanceTest()
        {
            Assert.IsType<CallTranscriptionMetadata>(instance);
        }

        /// <summary>
        /// Test the property 'TranscriptionId'
        /// </summary>
        [Fact]
        public void TranscriptionIdTest()
        {
            instance.TranscriptionId = "test";
            Assert.IsType<string>(instance.TranscriptionId);
            Assert.Equal("test", instance.TranscriptionId);
        }

        /// <summary>
        /// Test the property 'TranscriptionUrl'
        /// </summary>
        [Fact]
        public void TranscriptionUrlTest()
        {
            instance.TranscriptionUrl = "test";
            Assert.IsType<string>(instance.TranscriptionUrl);
            Assert.Equal("test", instance.TranscriptionUrl);
        }
    }
}
