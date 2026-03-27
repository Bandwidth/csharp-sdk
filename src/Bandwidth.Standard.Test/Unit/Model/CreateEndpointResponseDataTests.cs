using Xunit;
using System;
using System.Collections.Generic;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class CreateEndpointResponseDataTests
    {
        private CreateEndpointResponseData instance;

        public CreateEndpointResponseDataTests()
        {
            DateTime creationTime = new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime expirationTime = new DateTime(2021, 1, 2, 0, 0, 0, DateTimeKind.Utc);

            Device device = new Device(
                deviceId: "d-abc123",
                deviceName: "Test Device",
                status: DeviceStatusEnum.CONNECTED,
                creationTimestamp: creationTime
            );

            instance = new CreateEndpointResponseData(
                endpointId: "e-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85",
                type: EndpointTypeEnum.WEBRTC,
                status: EndpointStatusEnum.CONNECTED,
                creationTimestamp: creationTime,
                expirationTimestamp: expirationTime,
                tag: "test-tag",
                devices: new List<Device> { device },
                token: "test-token-abc123"
            );
        }

        [Fact]
        public void CreateEndpointResponseDataInstanceTest()
        {
            Assert.IsType<CreateEndpointResponseData>(instance);
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
        public void DevicesTest()
        {
            Assert.NotNull(instance.Devices);
            Assert.Single(instance.Devices);
            Assert.Equal("d-abc123", instance.Devices[0].DeviceId);
            Assert.Equal("Test Device", instance.Devices[0].DeviceName);
            Assert.Equal(DeviceStatusEnum.CONNECTED, instance.Devices[0].Status);
        }

        [Fact]
        public void TokenTest()
        {
            Assert.Equal("test-token-abc123", instance.Token);
        }

        [Fact]
        public void EndpointIdRequiredTest()
        {
            Assert.Throws<ArgumentNullException>(() => new CreateEndpointResponseData(
                endpointId: null,
                type: EndpointTypeEnum.WEBRTC,
                status: EndpointStatusEnum.CONNECTED,
                creationTimestamp: new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                expirationTimestamp: new DateTime(2021, 1, 2, 0, 0, 0, DateTimeKind.Utc),
                token: "token"
            ));
        }

        [Fact]
        public void TokenRequiredTest()
        {
            Assert.Throws<ArgumentNullException>(() => new CreateEndpointResponseData(
                endpointId: "e-abc123",
                type: EndpointTypeEnum.WEBRTC,
                status: EndpointStatusEnum.CONNECTED,
                creationTimestamp: new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                expirationTimestamp: new DateTime(2021, 1, 2, 0, 0, 0, DateTimeKind.Utc),
                token: null
            ));
        }

    }
}
