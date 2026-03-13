using Xunit;
using System;
using System.Collections.Generic;
using Bandwidth.Standard.Model;
using Newtonsoft.Json;

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
        public void DeviceInstanceTest()
        {
            Assert.IsType<Device>(instance);
        }

        [Fact]
        public void DeviceIdTest()
        {
            Assert.Equal("d-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85", instance.DeviceId);
        }

        [Fact]
        public void DeviceNameTest()
        {
            Assert.Equal("Test Device", instance.DeviceName);
        }

        [Fact]
        public void StatusTest()
        {
            Assert.Equal(DeviceStatusEnum.CONNECTED, instance.Status);
        }

        [Fact]
        public void CreationTimestampTest()
        {
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

        [Fact]
        public void SerializationTest()
        {
            string json = instance.ToJson();
            Assert.Contains("\"deviceId\"", json);
            Assert.Contains("\"deviceName\"", json);
            Assert.Contains("\"status\"", json);
            Assert.Contains("\"creationTimestamp\"", json);
            Assert.Contains("d-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85", json);
            Assert.Contains("Test Device", json);
        }

        [Fact]
        public void DeserializationTest()
        {
            string json = @"{
                ""deviceId"": ""d-abc123"",
                ""deviceName"": ""My Phone"",
                ""status"": ""DISCONNECTED"",
                ""creationTimestamp"": ""2021-01-01T00:00:00Z""
            }";

            Device deserialized = JsonConvert.DeserializeObject<Device>(json);

            Assert.NotNull(deserialized);
            Assert.Equal("d-abc123", deserialized.DeviceId);
            Assert.Equal("My Phone", deserialized.DeviceName);
            Assert.Equal(DeviceStatusEnum.DISCONNECTED, deserialized.Status);
            Assert.Equal(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc), deserialized.CreationTimestamp);
        }
    }
}
