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
    ///  Class for testing CallTranscriptionResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CallTranscriptionResponseTests : IDisposable
    {
        private CallTranscriptionResponse instance;

        public CallTranscriptionResponseTests()
        {
            instance = new CallTranscriptionResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CallTranscriptionResponse
        /// </summary>
        [Fact]
        public void CallTranscriptionResponseInstanceTest()
        {
            Assert.IsType<CallTranscriptionResponse>(instance);
        }

        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            instance.AccountId = "12345";
            Assert.IsType<string>(instance.AccountId);
            Assert.Equal("12345", instance.AccountId);
        }

        /// <summary>
        /// Test the property 'CallId'
        /// </summary>
        [Fact]
        public void CallIdTest()
        {
            instance.CallId = "12345";
            Assert.IsType<string>(instance.CallId);
            Assert.Equal("12345", instance.CallId);
        }

        /// <summary>
        /// Test the property 'TranscriptionId'
        /// </summary>
        [Fact]
        public void TranscriptionIdTest()
        {
            instance.TranscriptionId = "12345";
            Assert.IsType<string>(instance.TranscriptionId);
            Assert.Equal("12345", instance.TranscriptionId);
        }

        /// <summary>
        /// Test the property 'Tracks'
        /// </summary>
        [Fact]
        public void TracksTest()
        {
            instance.Tracks = new List<CallTranscription>();
            Assert.IsType<List<CallTranscription>>(instance.Tracks);
        }
    }
}
