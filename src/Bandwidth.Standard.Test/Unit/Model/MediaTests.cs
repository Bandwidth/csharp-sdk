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
    ///  Class for testing Media
    /// </summary>
    public class MediaTests : IDisposable
    {
        private Media instance;

        public MediaTests()
        {
            instance = new Media();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Media
        /// </summary>
        [Fact]
        public void MediaInstanceTest()
        {
            Assert.IsType<Media>(instance);
        }


        /// <summary>
        /// Test the property 'Content'
        /// </summary>
        [Fact]
        public void ContentTest()
        {
            instance.Content = "test";
            Assert.IsType<string>(instance.Content);
            Assert.Equal("test", instance.Content);
        }
        /// <summary>
        /// Test the property 'ContentLength'
        /// </summary>
        [Fact]
        public void ContentLengthTest()
        {
            instance.ContentLength = 500;
            Assert.IsType<int>(instance.ContentLength);
            Assert.Equal(500, instance.ContentLength);
        }
        /// <summary>
        /// Test the property 'MediaName'
        /// </summary>
        [Fact]
        public void MediaNameTest()
        {
            instance.MediaName = "test";
            Assert.IsType<string>(instance.MediaName);
            Assert.Equal("test", instance.MediaName);
        }

    }

}