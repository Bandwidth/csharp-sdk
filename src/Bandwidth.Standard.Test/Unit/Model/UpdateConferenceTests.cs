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
    ///  Class for testing UpdateConference
    /// </summary>
    public class UpdateConferenceTests : IDisposable
    {
        private UpdateConference instance;

        public UpdateConferenceTests()
        {
            instance = new UpdateConference();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UpdateConference
        /// </summary>
        [Fact]
        public void UpdateConferenceInstanceTest()
        {
            Assert.IsType<UpdateConference>(instance);
        }


        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            instance.Status = ConferenceStateEnum.Active;
            Assert.IsType<ConferenceStateEnum>(instance.Status);
            Assert.Equal(ConferenceStateEnum.Active, instance.Status);
        }
        /// <summary>
        /// Test the property 'RedirectUrl'
        /// </summary>
        [Fact]
        public void RedirectUrlTest()
        {
            instance.RedirectUrl = "https://test.url/";
            Assert.IsType<string>(instance.RedirectUrl);
            Assert.Equal("https://test.url/", instance.RedirectUrl);
        }
        /// <summary>
        /// Test the property 'RedirectMethod'
        /// </summary>
        [Fact]
        public void RedirectMethodTest()
        {
            instance.RedirectMethod = RedirectMethodEnum.POST;
            Assert.IsType<RedirectMethodEnum>(instance.RedirectMethod);
            Assert.Equal(RedirectMethodEnum.POST, instance.RedirectMethod);
        }
        /// <summary>
        /// Test the property 'Username'
        /// </summary>
        [Fact]
        public void UsernameTest()
        {
            instance.Username = "username";
            Assert.IsType<string>(instance.Username);
            Assert.Equal("username", instance.Username);
        }
        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Fact]
        public void PasswordTest()
        {
            instance.Password = "password";
            Assert.IsType<string>(instance.Password);
            Assert.Equal("password", instance.Password);
        }
        /// <summary>
        /// Test the property 'RedirectFallbackUrl'
        /// </summary>
        [Fact]
        public void RedirectFallbackUrlTest()
        {
            instance.RedirectFallbackUrl = "https://fallbackTest.url/";
            Assert.IsType<string>(instance.RedirectFallbackUrl);
            Assert.Equal("https://fallbackTest.url/", instance.RedirectFallbackUrl);
        }
        /// <summary>
        /// Test the property 'RedirectFallbackMethod'
        /// </summary>
        [Fact]
        public void RedirectFallbackMethodTest()
        {
            instance.RedirectFallbackMethod = RedirectMethodEnum.POST;
            Assert.IsType<RedirectMethodEnum>(instance.RedirectFallbackMethod);
            Assert.Equal(RedirectMethodEnum.POST, instance.RedirectFallbackMethod);
        }
        /// <summary>
        /// Test the property 'FallbackUsername'
        /// </summary>
        [Fact]
        public void FallbackUsernameTest()
        {
            instance.FallbackUsername = "fallbackUsername";
            Assert.IsType<string>(instance.FallbackUsername);
            Assert.Equal("fallbackUsername", instance.FallbackUsername);
        }
        /// <summary>
        /// Test the property 'FallbackPassword'
        /// </summary>
        [Fact]
        public void FallbackPasswordTest()
        {
            instance.FallbackPassword = "fallbackPassword";
            Assert.IsType<string>(instance.FallbackPassword);
            Assert.Equal("fallbackPassword", instance.FallbackPassword);
        }

    }

}
