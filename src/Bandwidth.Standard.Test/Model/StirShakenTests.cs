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
    ///  Class for testing StirShaken
    /// </summary>
    public class StirShakenTests : IDisposable
    {
        private StirShaken instance;

        public StirShakenTests()
        {
            instance = new StirShaken();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of StirShaken
        /// </summary>
        [Fact]
        public void StirShakenInstanceTest()
        {
            Assert.IsType<StirShaken>(instance);
        }


        /// <summary>
        /// Test the property 'Verstat'
        /// </summary>
        [Fact]
        public void VerstatTest()
        {
            instance.Verstat = "Tn-Verification-Passed";
            Assert.IsType<string>(instance.Verstat);
            Assert.Equal("Tn-Verification-Passed", instance.Verstat);
        }
        /// <summary>
        /// Test the property 'AttestationIndicator'
        /// </summary>
        [Fact]
        public void AttestationIndicatorTest()
        {
            instance.AttestationIndicator = "A";
            Assert.IsType<string>(instance.AttestationIndicator);
            Assert.Equal("A", instance.AttestationIndicator);
        }
        /// <summary>
        /// Test the property 'OriginatingId'
        /// </summary>
        [Fact]
        public void OriginatingIdTest()
        {
            instance.OriginatingId = "1234567890";
            Assert.IsType<string>(instance.OriginatingId);
            Assert.Equal("1234567890", instance.OriginatingId);
        }

    }

}
