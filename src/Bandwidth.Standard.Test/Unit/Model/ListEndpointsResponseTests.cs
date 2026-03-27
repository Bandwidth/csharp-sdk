using Xunit;
using System;
using System.Collections.Generic;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class ListEndpointsResponseTests
    {
        private ListEndpointsResponse instance;

        public ListEndpointsResponseTests()
        {
            DateTime creationTime = new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime expirationTime = new DateTime(2021, 1, 2, 0, 0, 0, DateTimeKind.Utc);

            var endpoint1 = new Endpoints(
                endpointId: "e-abc123",
                type: EndpointTypeEnum.WEBRTC,
                status: EndpointStatusEnum.CONNECTED,
                creationTimestamp: creationTime,
                expirationTimestamp: expirationTime,
                tag: "endpoint-1"
            );

            var endpoint2 = new Endpoints(
                endpointId: "e-def456",
                type: EndpointTypeEnum.WEBRTC,
                status: EndpointStatusEnum.DISCONNECTED,
                creationTimestamp: creationTime,
                expirationTimestamp: expirationTime,
                tag: "endpoint-2"
            );

            var selfLink = new Link(rel: "self", href: "/accounts/123/endpoints");
            var page = new Page(pageSize: 10, totalElements: 2, totalPages: 1, pageNumber: 0);

            instance = new ListEndpointsResponse(
                links: new List<Link> { selfLink },
                page: page,
                data: new List<Endpoints> { endpoint1, endpoint2 },
                errors: new List<Error>()
            );
        }

        [Fact]
        public void ListEndpointsResponseInstanceTest()
        {
            Assert.IsType<ListEndpointsResponse>(instance);
        }

        [Fact]
        public void LinksTest()
        {
            Assert.NotNull(instance.Links);
            Assert.Single(instance.Links);
            Assert.Equal("self", instance.Links[0].Rel);
            Assert.Equal("/accounts/123/endpoints", instance.Links[0].Href);
        }

        [Fact]
        public void PageTest()
        {
            Assert.NotNull(instance.Page);
            Assert.Equal(10, instance.Page.PageSize);
            Assert.Equal(2, instance.Page.TotalElements);
            Assert.Equal(1, instance.Page.TotalPages);
            Assert.Equal(0, instance.Page.PageNumber);
        }

        [Fact]
        public void DataTest()
        {
            Assert.NotNull(instance.Data);
            Assert.Equal(2, instance.Data.Count);

            Assert.Equal("e-abc123", instance.Data[0].EndpointId);
            Assert.Equal(EndpointTypeEnum.WEBRTC, instance.Data[0].Type);
            Assert.Equal(EndpointStatusEnum.CONNECTED, instance.Data[0].Status);
            Assert.Equal("endpoint-1", instance.Data[0].Tag);

            Assert.Equal("e-def456", instance.Data[1].EndpointId);
            Assert.Equal(EndpointTypeEnum.WEBRTC, instance.Data[1].Type);
            Assert.Equal(EndpointStatusEnum.DISCONNECTED, instance.Data[1].Status);
            Assert.Equal("endpoint-2", instance.Data[1].Tag);
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
            Assert.Throws<ArgumentNullException>(() => new ListEndpointsResponse(
                links: null,
                data: new List<Endpoints>(),
                errors: new List<Error>()
            ));
        }

        [Fact]
        public void DataRequiredTest()
        {
            Assert.Throws<ArgumentNullException>(() => new ListEndpointsResponse(
                links: new List<Link>(),
                data: null,
                errors: new List<Error>()
            ));
        }

        [Fact]
        public void ErrorsRequiredTest()
        {
            Assert.Throws<ArgumentNullException>(() => new ListEndpointsResponse(
                links: new List<Link>(),
                data: new List<Endpoints>(),
                errors: null
            ));
        }

    }
}
