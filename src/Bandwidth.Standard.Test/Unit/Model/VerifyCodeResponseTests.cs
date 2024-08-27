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
    ///  Class for testing VerifyCodeResponse
    /// </summary>
    public class VerifyCodeResponseTests : IDisposable
    {
        private VerifyCodeResponse instance;

        public VerifyCodeResponseTests()
        {
            instance = new VerifyCodeResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VerifyCodeResponse
        /// </summary>
        [Fact]
        public void VerifyCodeResponseInstanceTest()
        {
            Assert.IsType<VerifyCodeResponse>(instance);
        }


        /// <summary>
        /// Test the property 'Valid'
        /// </summary>
        [Fact]
        public void ValidTest()
        {
            instance.Valid = true;
            Assert.IsType<bool>(instance.Valid);
            Assert.True(instance.Valid);
        }

    }

}