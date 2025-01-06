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
    ///  Class for testing Tag
    /// </summary>
    public class TagTests : IDisposable
    {
        private Tag instance;

        public TagTests()
        {
            instance = new Tag();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Tag
        /// </summary>
        [Fact]
        public void TagInstanceTest()
        {
            Assert.IsType<Tag>(instance);
        }


        /// <summary>
        /// Test the property 'Key'
        /// </summary>
        [Fact]
        public void KeyTest()
        {
            instance.Key = "test";
            Assert.IsType<string>(instance.Key);
            Assert.Equal("test", instance.Key);
        }
        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Fact]
        public void ValueTest()
        {
            instance.Value = "test";
            Assert.IsType<string>(instance.Value);
            Assert.Equal("test", instance.Value);
        }

    }

}