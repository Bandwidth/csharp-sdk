using Xunit;
using System;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    /// <summary>
    ///  Class for testing EndpointEvent
    /// </summary>
    public class EndpointEventTests
    {
        private EndpointEvent instance;

        public EndpointEventTests()
        {
            DateTime creationTime = new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime expirationTime = new DateTime(2021, 1, 2, 0, 0, 0, DateTimeKind.Utc);
            DateTime eventTime = new DateTime(2021, 1, 1, 12, 0, 0, DateTimeKind.Utc);

            Device device = new Device(
                deviceId: "d-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85",
                deviceName: "Test Device",
                status: DeviceStatusEnum.CONNECTED,
                creationTimestamp: creationTime
            );

            instance = new EndpointEvent(
                endpointId: "e-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85",
                type: EndpointTypeEnum.WEBRTC,
                status: EndpointStatusEnum.CONNECTED,
                creationTimestamp: creationTime,
                expirationTimestamp: expirationTime,
                tag: "test-tag",
                eventTime: eventTime,
                eventType: EndpointEventTypeEnum.CONNECTED,
                device: device
            );
        }

        /// <summary>
        /// Test an instance of EndpointEvent and all its properties
        /// </summary>
        [Fact]
        public void EndpointEventFieldsTest()
        {
            Assert.IsType<EndpointEvent>(instance);

            Assert.IsType<string>(instance.EndpointId);
            Assert.Equal("e-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85", instance.EndpointId);

            Assert.IsType<EndpointTypeEnum>(instance.Type);
            Assert.Equal(EndpointTypeEnum.WEBRTC, instance.Type);

            Assert.IsType<EndpointStatusEnum>(instance.Status);
            Assert.Equal(EndpointStatusEnum.CONNECTED, instance.Status);

            Assert.IsType<DateTime>(instance.CreationTimestamp);
            Assert.Equal(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc), instance.CreationTimestamp);

            Assert.IsType<DateTime>(instance.ExpirationTimestamp);
            Assert.Equal(new DateTime(2021, 1, 2, 0, 0, 0, DateTimeKind.Utc), instance.ExpirationTimestamp);

            Assert.IsType<string>(instance.Tag);
            Assert.Equal("test-tag", instance.Tag);

            Assert.IsType<DateTime>(instance.EventTime);
            Assert.Equal(new DateTime(2021, 1, 1, 12, 0, 0, DateTimeKind.Utc), instance.EventTime);

            Assert.IsType<EndpointEventTypeEnum>(instance.EventType);
            Assert.Equal(EndpointEventTypeEnum.CONNECTED, instance.EventType);

            Assert.IsType<Device>(instance.Device);
            Assert.NotNull(instance.Device);
            Assert.Equal("d-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85", instance.Device.DeviceId);
        }

        /// <summary>
        /// Test that EndpointId is required
        /// </summary>
        [Fact]
        public void EndpointIdRequiredTest()
        {
            DateTime creationTime = new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime expirationTime = new DateTime(2021, 1, 2, 0, 0, 0, DateTimeKind.Utc);
            DateTime eventTime = new DateTime(2021, 1, 1, 12, 0, 0, DateTimeKind.Utc);

            Assert.Throws<ArgumentNullException>(() => new EndpointEvent(
                endpointId: null,
                type: EndpointTypeEnum.WEBRTC,
                status: EndpointStatusEnum.CONNECTED,
                creationTimestamp: creationTime,
                expirationTimestamp: expirationTime,
                eventTime: eventTime,
                eventType: EndpointEventTypeEnum.CONNECTED
            ));
        }

    }
}
