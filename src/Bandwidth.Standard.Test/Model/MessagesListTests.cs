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
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Model;
using Bandwidth.Standard.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Bandwidth.Standard.Test.Model
{
    /// <summary>
    ///  Class for testing MessagesList
    /// </summary>
    public class MessagesListTests : IDisposable
    {
        private MessagesList instance;

        public MessagesListTests()
        {
            instance = new MessagesList();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MessagesList
        /// </summary>
        [Fact]
        public void MessagesListInstanceTest()
        {
            Assert.IsType<MessagesList>(instance);
        }


        /// <summary>
        /// Test the property 'TotalCount'
        /// </summary>
        [Fact]
        public void TotalCountTest()
        {
            // TODO unit test for the property 'TotalCount'
        }
        /// <summary>
        /// Test the property 'PageInfo'
        /// </summary>
        [Fact]
        public void PageInfoTest()
        {
            // TODO unit test for the property 'PageInfo'
        }
        /// <summary>
        /// Test the property 'Messages'
        /// </summary>
        [Fact]
        public void MessagesTest()
        {
            // TODO unit test for the property 'Messages'
        }

    }

}
