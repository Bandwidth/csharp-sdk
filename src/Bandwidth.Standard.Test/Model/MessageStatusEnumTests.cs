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
    ///  Class for testing MessageStatusEnum
    /// </summary>
    public class MessageStatusEnumTests : IDisposable
    {
        private MessageStatusEnum instance;

        public MessageStatusEnumTests()
        {
            instance = new MessageStatusEnum();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MessageStatusEnum
        /// </summary>
        [Fact]
        public void MessageStatusEnumInstanceTest()
        {
            Assert.IsType<MessageStatusEnum>(instance);
        }

    }

}
