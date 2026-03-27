using Xunit;
using System;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class EndpointsTests
    {
        private Endpoints instance;

        public EndpointsTests()
        {
            DateTime creationTime = new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime expirationTime = new DateTime(2021, 1, 2, 0, 0, 0, DateTimeKind.Utc);

            instance = new Endpoints(
                endpointId: "e-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85",
                type: EndpointTypeEnum.WEBRTC,
                status: EndpointStatusEnum.CONNECTED,
                creationTimestamp: creationTime,
                expirationTimestamp: expirationTime,
                tag: "test-tag"
            );
        }

        [Fact]
        public void EndpointsInstanceTest()
        {
            Assert.IsType<Endpoints>(instance);
        }

        [Fact]
        public void EndpointIdTest()
        {
            Assert.Equal("e-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85", instance.EndpointId);
        }

        [Fact]
        public void TypeTest()
        {
            Assert.Equal(EndpointTypeEnum.WEBRTC, instance.Type);
        }

        [Fact]
        public void StatusTest()
        {
            Assert.Equal(EndpointStatusEnum.CONNECTED, instance.Status);
        }

        [Fact]
        public void CreationTimestampTest()
        {
            Assert.Equal(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc), instance.CreationTimestamp);
        }

        [Fact]
        public void ExpirationTimestampTest()
        {
            Assert.Equal(new DateTime(2021, 1, 2, 0, 0, 0, DateTimeKind.Utc), instance.ExpirationTimestamp);
        }

        [Fact]
        public void TagTest()
        {
            Assert.Equal("test-tag", instance.Tag);
        }

        [Fact]
        public void EndpointIdRequiredTest()
        {
            Assert.Throws<ArgumentNullException>(() => new Endpoints(
                endpointId: null,
                type: EndpointTypeEnum.WEBRTC,
                status: EndpointStatusEnum.CONNECTED,
                creationTimestamp: new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                expirationTimestamp: new DateTime(2021, 1, 2, 0, 0, 0, DateTimeKind.Utc)
            ));
        }

    }
}
