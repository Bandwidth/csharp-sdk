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
    ///  Class for testing CodeRequest
    /// </summary>
    public class CodeRequestTests : IDisposable
    {
        private CodeRequest instance;

        public CodeRequestTests()
        {
            instance = new CodeRequest(to:"+19195551234", from:"+19195554321", applicationId:"66fd98ae-ac8d-a00f-7fcd-ba3280aeb9b1", message: "Your temporary {NAME} {SCOPE} code is {CODE}");
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CodeRequest
        /// </summary>
        [Fact]
        public void CodeRequestInstanceTest()
        {
            Assert.IsType<CodeRequest>(instance);
        }


        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            Assert.IsType<string>(instance.To);
            Assert.Equal("+19195551234", instance.To);
        }
        /// <summary>
        /// Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            Assert.IsType<string>(instance.From);
            Assert.Equal("+19195554321", instance.From);
        }
        /// <summary>
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            instance.ApplicationId = "66fd98ae-ac8d-a00f-7fcd-ba3280aeb9b1";
            Assert.IsType<string>(instance.ApplicationId);
            Assert.Equal("66fd98ae-ac8d-a00f-7fcd-ba3280aeb9b1", instance.ApplicationId);
        }
        /// <summary>
        /// Test the property 'Scope'
        /// </summary>
        [Fact]
        public void ScopeTest()
        {
            instance.Scope = "2FA";
            Assert.IsType<string>(instance.Scope);
            Assert.Equal("2FA", instance.Scope);
        }
        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            instance.Message = "Your temporary {NAME} {SCOPE} code is {CODE}";
            Assert.IsType<string>(instance.Message);
            Assert.Equal("Your temporary {NAME} {SCOPE} code is {CODE}", instance.Message);
        }
        /// <summary>
        /// Test the property 'Digits'
        /// </summary>
        [Fact]
        public void DigitsTest()
        {
            instance.Digits = 6;
            Assert.IsType<int>(instance.Digits);
            Assert.Equal(6, instance.Digits);
        }

    }

}
