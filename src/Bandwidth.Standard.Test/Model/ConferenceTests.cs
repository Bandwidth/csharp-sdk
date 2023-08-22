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
    ///  Class for testing Conference
    /// </summary>
    public class ConferenceTests : IDisposable
    {
        private Conference instance;

        public ConferenceTests()
        {
            instance = new Conference();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Conference
        /// </summary>
        [Fact]
        public void ConferenceInstanceTest()
        {
            Assert.IsType<Conference>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            instance.Id = "conf-123";
            Assert.IsType<string>(instance.Id);
            Assert.Equal("conf-123", instance.Id);
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            instance.Name = "my-conference-name";
            Assert.IsType<string>(instance.Name);
            Assert.Equal("my-conference-name", instance.Name);
        }
        /// <summary>
        /// Test the property 'CreatedTime'
        /// </summary>
        [Fact]
        public void CreatedTimeTest()
        {
            var date = new DateTime(2020, 1, 1);
            instance.CreatedTime = date;
            Assert.IsType<DateTime>(instance.CreatedTime);
            Assert.Equal(date, instance.CreatedTime);
        }
        /// <summary>
        /// Test the property 'CompletedTime'
        /// </summary>
        [Fact]
        public void CompletedTimeTest()
        {
            var date = new DateTime(2020, 1, 1);
            instance.CompletedTime = date;
            Assert.IsType<DateTime>(instance.CompletedTime);
            Assert.Equal(date, instance.CompletedTime);
        }
        /// <summary>
        /// Test the property 'ConferenceEventUrl'
        /// </summary>
        [Fact]
        public void ConferenceEventUrlTest()
        {
            instance.ConferenceEventUrl = "https://test.com";
            Assert.IsType<string>(instance.ConferenceEventUrl);
            Assert.Equal("https://test.com", instance.ConferenceEventUrl);
        }
        /// <summary>
        /// Test the property 'ConferenceEventMethod'
        /// </summary>
        [Fact]
        public void ConferenceEventMethodTest()
        {
            var method = CallbackMethodEnum.POST;
            instance.ConferenceEventMethod = method;
            Assert.IsType<string>(instance.ConferenceEventMethod);
            Assert.Equal(method, instance.ConferenceEventMethod);
        }
        /// <summary>
        /// Test the property 'Tag'
        /// </summary>
        [Fact]
        public void TagTest()
        {
            instance.Tag = "test";
            Assert.IsType<string>(instance.Tag);
            Assert.Equal("test", instance.Tag);
        }
        /// <summary>
        /// Test the property 'ActiveMembers'
        /// </summary>
        [Fact]
        public void ActiveMembersTest()
        {
            var memberList = new List<ConferenceMember>();
            var member = new ConferenceMember();
            memberList.Add(member);
            instance.ActiveMembers = memberList;
            Assert.IsType<List<ConferenceMember>>(instance.ActiveMembers);
            Assert.Equal(memberList, instance.ActiveMembers);
        }
    }
}
