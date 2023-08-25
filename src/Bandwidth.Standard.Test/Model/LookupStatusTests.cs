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
    ///  Class for testing LookupStatus
    /// </summary>
    public class LookupStatusTests : IDisposable
    {
        private LookupStatus instance;

        public LookupStatusTests()
        {
            instance = new LookupStatus();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LookupStatus
        /// </summary>
        [Fact]
        public void LookupStatusInstanceTest()
        {
            Assert.IsType<LookupStatus>(instance);
        }


        /// <summary>
        /// Test the property 'RequestId'
        /// </summary>
        [Fact]
        public void RequestIdTest()
        {
            instance.RequestId = "1234";
            Assert.IsType<string>(instance.RequestId);
            Assert.Equal("1234", instance.RequestId);
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            instance.Status = LookupStatusEnum.INPROGRESS;
            Assert.IsType<LookupStatusEnum>(instance.Status);
            Assert.Equal(LookupStatusEnum.INPROGRESS, instance.Status);
        }
        /// <summary>
        /// Test the property 'Result'
        /// </summary>
        [Fact]
        public void ResultTest()
        {
            instance.Result = new List<LookupResult>();
            Assert.IsType<List<LookupResult>>(instance.Result);
            Assert.Equal(new List<LookupResult>(), instance.Result);
        }
        /// <summary>
        /// Test the property 'FailedTelephoneNumbers'
        /// </summary>
        [Fact]
        public void FailedTelephoneNumbersTest()
        {
            instance.FailedTelephoneNumbers = new List<string>() { "+15551234567"};
            Assert.IsType<List<string>>(instance.FailedTelephoneNumbers);
            Assert.Equal(new List<string>() { "+15551234567"}, instance.FailedTelephoneNumbers);
        }

    }

}
