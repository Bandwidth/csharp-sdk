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
    ///  Class for testing MachineDetectionResult
    /// </summary>
    public class MachineDetectionResultTests : IDisposable
    {
        private MachineDetectionResult instance;

        public MachineDetectionResultTests()
        {
            instance = new MachineDetectionResult();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MachineDetectionResult
        /// </summary>
        [Fact]
        public void MachineDetectionResultInstanceTest()
        {
            Assert.IsType<MachineDetectionResult>(instance);
        }


        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Fact]
        public void ValueTest()
        {
            instance.Value = "value";
            Assert.IsType<string>(instance.Value);
            Assert.Equal("value", instance.Value);
        }
        /// <summary>
        /// Test the property 'Duration'
        /// </summary>
        [Fact]
        public void DurationTest()
        {
            instance.Duration = "PT4.9891287S";
            Assert.IsType<string>(instance.Duration);
            Assert.Equal("PT4.9891287S", instance.Duration);
        }

    }

}
