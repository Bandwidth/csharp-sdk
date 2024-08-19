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
    ///  Class for testing CallTranscriptionDetectedLanguageEnum
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CallTranscriptionDetectedLanguageEnumTests : IDisposable
    {
        private CallTranscriptionDetectedLanguageEnum instance;

        public CallTranscriptionDetectedLanguageEnumTests()
        {
            instance = new CallTranscriptionDetectedLanguageEnum();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CallTranscriptionDetectedLanguageEnum
        /// </summary>
        [Fact]
        public void CallTranscriptionDetectedLanguageEnumInstanceTest()
        {
            Assert.IsType<CallTranscriptionDetectedLanguageEnum>(instance);
        }
    }
}
