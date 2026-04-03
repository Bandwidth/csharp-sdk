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
    ///  Class for testing CreateEndpointRequestBase
    /// </summary>
    public class CreateEndpointRequestBaseTests : IDisposable
    {
        private CreateEndpointRequestBase instance;

        public CreateEndpointRequestBaseTests()
        {
            instance = new CreateEndpointRequestBase(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.INBOUND,
                eventCallbackUrl: "https://myapp.com/callback",
                eventFallbackUrl: "https://fallback.myapp.com/callback",
                tag: "test-tag"
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateEndpointRequestBase
        /// </summary>
        [Fact]
        public void CreateEndpointRequestBaseInstanceTest()
        {
            Assert.IsType<CreateEndpointRequestBase>(instance);
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            Assert.IsType<EndpointTypeEnum>(instance.Type);
            Assert.Equal(EndpointTypeEnum.WEBRTC, instance.Type);
        }

        /// <summary>
        /// Test the property 'Direction'
        /// </summary>
        [Fact]
        public void DirectionTest()
        {
            Assert.IsType<EndpointDirectionEnum>(instance.Direction);
            Assert.Equal(EndpointDirectionEnum.INBOUND, instance.Direction);
        }

        /// <summary>
        /// Test the property 'EventCallbackUrl'
        /// </summary>
        [Fact]
        public void EventCallbackUrlTest()
        {
            Assert.IsType<string>(instance.EventCallbackUrl);
            Assert.Equal("https://myapp.com/callback", instance.EventCallbackUrl);
        }

        /// <summary>
        /// Test the property 'EventFallbackUrl'
        /// </summary>
        [Fact]
        public void EventFallbackUrlTest()
        {
            Assert.IsType<string>(instance.EventFallbackUrl);
            Assert.Equal("https://fallback.myapp.com/callback", instance.EventFallbackUrl);
        }

        /// <summary>
        /// Test the property 'Tag'
        /// </summary>
        [Fact]
        public void TagTest()
        {
            Assert.IsType<string>(instance.Tag);
            Assert.Equal("test-tag", instance.Tag);
        }

    }

}
