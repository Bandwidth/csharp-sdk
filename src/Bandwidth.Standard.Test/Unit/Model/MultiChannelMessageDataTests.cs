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
using Bandwidth.Standard.Model;
using Bandwidth.Standard.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Bandwidth.Standard.Test.Unit.Model
{
    /// <summary>
    ///  Class for testing MultiChannelMessageData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MultiChannelMessageDataTests : IDisposable
    {
        private MultiChannelMessageData instance;

        public MultiChannelMessageDataTests()
        {
            instance = new MultiChannelMessageData();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MultiChannelMessageData
        /// </summary>
        [Fact]
        public void MultiChannelMessageDataInstanceTest()
        {
            Assert.IsType<MultiChannelMessageData>(instance);
        }

        /// <summary>
        /// Test the property 'MessageId'
        /// </summary>
        [Fact]
        public void MessageIdTest()
        {
            instance.MessageId = "12345";
            Assert.IsType<string>(instance.MessageId);
            Assert.Equal("12345", instance.MessageId);
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            instance.Status = MultiChannelStatusEnum.DELIVERED;
            Assert.IsType<MultiChannelStatusEnum>(instance.Status);
            Assert.Equal(MultiChannelStatusEnum.DELIVERED, instance.Status);
        }

        /// <summary>
        /// Test the property 'Time'
        /// </summary>
        [Fact]
        public void TimeTest()
        {
            instance.Time = new DateTime(2020, 1, 1);
            Assert.IsType<DateTime>(instance.Time);
            Assert.Equal(new DateTime(2020, 1, 1), instance.Time);
        }

        /// <summary>
        /// Test the property 'Direction'
        /// </summary>
        [Fact]
        public void DirectionTest()
        {
            instance.Direction = MultiChannelMessageDirectionEnum.INBOUND;
            Assert.IsType<MultiChannelMessageDirectionEnum>(instance.Direction);
            Assert.Equal(MultiChannelMessageDirectionEnum.INBOUND, instance.Direction);
        }

        /// <summary>
        /// Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            instance.From = "TestFrom";
            Assert.IsType<string>(instance.From);
            Assert.Equal("TestFrom", instance.From);
        }

        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            instance.To = "TestTo";
            Assert.IsType<string>(instance.To);
            Assert.Equal("TestTo", instance.To);
        }

        /// <summary>
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            instance.ApplicationId = "TestApplicationId";
            Assert.IsType<string>(instance.ApplicationId);
            Assert.Equal("TestApplicationId", instance.ApplicationId);
        }

        /// <summary>
        /// Test the property 'Channel'
        /// </summary>
        [Fact]
        public void ChannelTest()
        {
            instance.Channel = MultiChannelMessageChannelEnum.SMS;
            Assert.IsType<MultiChannelMessageChannelEnum>(instance.Channel);
            Assert.Equal(MultiChannelMessageChannelEnum.SMS, instance.Channel);
        }

        /// <summary>
        /// Test the property 'Tag'
        /// </summary>
        [Fact]
        public void TagTest()
        {
            instance.Tag = "TestTag";
            Assert.IsType<string>(instance.Tag);
            Assert.Equal("TestTag", instance.Tag);
        }
    }
}
