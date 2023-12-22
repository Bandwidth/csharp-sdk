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
    ///  Class for testing PageInfo
    /// </summary>
    public class PageInfoTests : IDisposable
    {
        private PageInfo instance;

        public PageInfoTests()
        {
            instance = new PageInfo();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PageInfo
        /// </summary>
        [Fact]
        public void PageInfoInstanceTest()
        {
            Assert.IsType<PageInfo>(instance);
        }


        /// <summary>
        /// Test the property 'PrevPage'
        /// </summary>
        [Fact]
        public void PrevPageTest()
        {
            instance.PrevPage = "https://test.url/";
            Assert.IsType<string>(instance.PrevPage);
            Assert.Equal("https://test.url/", instance.PrevPage);
        }
        /// <summary>
        /// Test the property 'NextPage'
        /// </summary>
        [Fact]
        public void NextPageTest()
        {
            instance.NextPage = "https://test.url/";
            Assert.IsType<string>(instance.NextPage);
            Assert.Equal("https://test.url/", instance.NextPage);
        }
        /// <summary>
        /// Test the property 'PrevPageToken'
        /// </summary>
        [Fact]
        public void PrevPageTokenTest()
        {
            instance.PrevPageToken = "DLAPE902";
            Assert.IsType<string>(instance.PrevPageToken);
            Assert.Equal("DLAPE902", instance.PrevPageToken);
        }
        /// <summary>
        /// Test the property 'NextPageToken'
        /// </summary>
        [Fact]
        public void NextPageTokenTest()
        {
            instance.NextPageToken = "GL83PD3C";
            Assert.IsType<string>(instance.NextPageToken);
            Assert.Equal("GL83PD3C", instance.NextPageToken);
        }

    }

}
