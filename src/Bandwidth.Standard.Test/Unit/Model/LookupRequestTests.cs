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
    ///  Class for testing LookupRequest
    /// </summary>
    public class LookupRequestTests : IDisposable
    {
        private LookupRequest instance;

        public LookupRequestTests()
        {
            instance = new LookupRequest(new List<string> { "+19195551234" });
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LookupRequest
        /// </summary>
        [Fact]
        public void LookupRequestInstanceTest()
        {
            Assert.IsType<LookupRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Tns'
        /// </summary>
        [Fact]
        public void TnsTest()
        {
            instance.Tns = new List<string> { "+15551234567" };
            Assert.IsType<List<string>>(instance.Tns);
            Assert.Equal(new List<string> { "+15551234567" }, instance.Tns);
        }

    }

}