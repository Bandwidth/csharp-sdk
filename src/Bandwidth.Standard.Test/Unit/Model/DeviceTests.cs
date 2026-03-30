using Xunit;
using System;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class DeviceTests
    {
        private Device instance;

        public DeviceTests()
        {
            DateTime creationTime = new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            instance = new Device(
                deviceId: "d-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85",
                deviceName: "Test Device",
                status: DeviceStatusEnum.CONNECTED,
                creationTimestamp: creationTime
            );
        }

        [Fact]
        public void DeviceFieldsTest()
        {
            Assert.IsType<Device>(instance);
            Assert.Equal("d-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85", instance.DeviceId);
            Assert.Equal("Test Device", instance.DeviceName);
            Assert.Equal(DeviceStatusEnum.CONNECTED, instance.Status);
            Assert.Equal(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc), instance.CreationTimestamp);
        }

        [Fact]
        public void DeviceIdRequiredTest()
        {
            Assert.Throws<ArgumentNullException>(() => new Device(
                deviceId: null,
                status: DeviceStatusEnum.CONNECTED,
                creationTimestamp: new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            ));
        }

    }
}
