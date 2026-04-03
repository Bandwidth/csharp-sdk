/*
 * Bandwidth
 *
 * Bandwidth's Communication APIs
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: letstalk@bandwidth.com
 * Author: Sudhanshu Moghe
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
    ///  Class for testing EndpointDirectionEnum
    /// </summary>
    public class EndpointDirectionEnumTests : IDisposable
    {
        private EndpointDirectionEnum instance;

        public EndpointDirectionEnumTests()
        {
            instance = new EndpointDirectionEnum();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EndpointDirectionEnum
        /// </summary>
        [Fact]
        public void EndpointDirectionEnumInstanceTest()
        {
            Assert.IsType<EndpointDirectionEnum>(instance);
        }

        [Fact]
        public void EndpointDirectionEnumSerializationTest()
        {
            Assert.Equal("\"INBOUND\"", JsonConvert.SerializeObject(EndpointDirectionEnum.INBOUND));
            Assert.Equal("\"OUTBOUND\"", JsonConvert.SerializeObject(EndpointDirectionEnum.OUTBOUND));
            Assert.Equal("\"BIDIRECTIONAL\"", JsonConvert.SerializeObject(EndpointDirectionEnum.BIDIRECTIONAL));

            Assert.Equal(EndpointDirectionEnum.INBOUND, JsonConvert.DeserializeObject<EndpointDirectionEnum>("\"INBOUND\""));
            Assert.Equal(EndpointDirectionEnum.OUTBOUND, JsonConvert.DeserializeObject<EndpointDirectionEnum>("\"OUTBOUND\""));
            Assert.Equal(EndpointDirectionEnum.BIDIRECTIONAL, JsonConvert.DeserializeObject<EndpointDirectionEnum>("\"BIDIRECTIONAL\""));
        }
    }
}
