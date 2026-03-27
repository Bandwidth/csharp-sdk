using Xunit;
using System;
using System.Collections.Generic;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class EndpointResponseTests
    {
        private EndpointResponse instance;

        public EndpointResponseTests()
        {
            DateTime creationTime = new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime expirationTime = new DateTime(2021, 1, 2, 0, 0, 0, DateTimeKind.Utc);

            var endpointData = new Endpoint(
                endpointId: "e-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85",
                type: EndpointTypeEnum.WEBRTC,
                status: EndpointStatusEnum.CONNECTED,
                creationTimestamp: creationTime,
                expirationTimestamp: expirationTime,
                tag: "test-tag"
            );

            var link = new Link(rel: "self", href: "/accounts/123/endpoints/e-15ac29a2");

            instance = new EndpointResponse(
                links: new List<Link> { link },
                data: endpointData,
                errors: new List<Error>()
            );
        }

        [Fact]
        public void EndpointResponseInstanceTest()
        {
            Assert.IsType<EndpointResponse>(instance);
        }

        [Fact]
        public void LinksTest()
        {
            Assert.NotNull(instance.Links);
            Assert.Single(instance.Links);
            Assert.Equal("self", instance.Links[0].Rel);
            Assert.Equal("/accounts/123/endpoints/e-15ac29a2", instance.Links[0].Href);
        }

        [Fact]
        public void DataTest()
        {
            Assert.NotNull(instance.Data);
            Assert.Equal("e-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85", instance.Data.EndpointId);
            Assert.Equal(EndpointTypeEnum.WEBRTC, instance.Data.Type);
            Assert.Equal(EndpointStatusEnum.CONNECTED, instance.Data.Status);
            Assert.Equal("test-tag", instance.Data.Tag);
        }

        [Fact]
        public void ErrorsTest()
        {
            Assert.NotNull(instance.Errors);
            Assert.Empty(instance.Errors);
        }

        [Fact]
        public void LinksRequiredTest()
        {
            Assert.Throws<ArgumentNullException>(() => new EndpointResponse(
                links: null,
                data: instance.Data,
                errors: new List<Error>()
            ));
        }

        [Fact]
        public void DataRequiredTest()
        {
            Assert.Throws<ArgumentNullException>(() => new EndpointResponse(
                links: new List<Link>(),
                data: null,
                errors: new List<Error>()
            ));
        }

        [Fact]
        public void ErrorsRequiredTest()
        {
            Assert.Throws<ArgumentNullException>(() => new EndpointResponse(
                links: new List<Link>(),
                data: instance.Data,
                errors: null
            ));
        }

    }
}
