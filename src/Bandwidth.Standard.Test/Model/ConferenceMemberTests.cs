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
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Model;
using Bandwidth.Standard.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Bandwidth.Standard.Test.Model
{
    /// <summary>
    ///  Class for testing ConferenceMember
    /// </summary>
    public class ConferenceMemberTests : IDisposable
    {
        private ConferenceMember instance;

        public ConferenceMemberTests()
        {
            instance = new ConferenceMember();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConferenceMember
        /// </summary>
        [Fact]
        public void ConferenceMemberInstanceTest()
        {
            Assert.IsType<ConferenceMember>(instance);
        }


        /// <summary>
        /// Test the property 'CallId'
        /// </summary>
        [Fact]
        public void CallIdTest()
        {
            instance.CallId = "c-1234";
            Assert.IsType<string>(instance.CallId);
            Assert.Equal("c-1234", instance.CallId);
        }
        /// <summary>
        /// Test the property 'ConferenceId'
        /// </summary>
        [Fact]
        public void ConferenceIdTest()
        {
            instance.ConferenceId = "conf-123";
            Assert.IsType<string>(instance.ConferenceId);
            Assert.Equal("conf-123", instance.ConferenceId);
        }
        /// <summary>
        /// Test the property 'MemberUrl'
        /// </summary>
        [Fact]
        public void MemberUrlTest()
        {
            instance.MemberUrl = "http://test.com";
            Assert.IsType<string>(instance.MemberUrl);
            Assert.Equal("http://test.com", instance.MemberUrl);
        }
        /// <summary>
        /// Test the property 'Mute'
        /// </summary>
        [Fact]
        public void MuteTest()
        {
            instance.Mute = false;
            Assert.IsType<bool>(instance.Mute);
            Assert.False(instance.Mute);
        }
        /// <summary>
        /// Test the property 'Hold'
        /// </summary>
        [Fact]
        public void HoldTest()
        {
            instance.Hold = false;
            Assert.IsType<bool>(instance.Hold);
            Assert.False(instance.Hold);
        }
        /// <summary>
        /// Test the property 'CallIdsToCoach'
        /// </summary>
        [Fact]
        public void CallIdsToCoachTest()
        {
            instance.CallIdsToCoach = new List<string> { "c-1234" };
            Assert.IsType<List<string>>(instance.CallIdsToCoach);
            Assert.Equal(new List<string> { "c-1234" }, instance.CallIdsToCoach);
        }
    }
}
