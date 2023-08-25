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
    ///  Class for testing CallStateEnum
    /// </summary>
    public class CallStateEnumTests : IDisposable
    {
        private CallStateEnum instance;

        public CallStateEnumTests()
        {
            instance = new CallStateEnum();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CallStateEnum
        /// </summary>
        [Fact]
        public void CallStateEnumInstanceTest()
        {
            Assert.IsType<CallStateEnum>(instance);
        }

    }

}
