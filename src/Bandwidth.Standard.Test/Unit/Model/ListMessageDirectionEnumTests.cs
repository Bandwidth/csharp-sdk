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
    ///  Class for testing ListMessageDirectionEnum
    /// </summary>
    public class ListMessageDirectionEnumTests : IDisposable
    {
        private ListMessageDirectionEnum instance;

        public ListMessageDirectionEnumTests()
        {
            instance = new ListMessageDirectionEnum();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ListMessageDirectionEnum
        /// </summary>
        [Fact]
        public void ListMessageDirectionEnumInstanceTest()
        {
            Assert.IsType<ListMessageDirectionEnum>(instance);
        }

    }

}
