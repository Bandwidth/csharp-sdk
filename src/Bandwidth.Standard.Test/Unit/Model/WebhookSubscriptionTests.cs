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
    ///  Class for testing WebhookSubscription
    /// </summary>
    public class WebhookSubscriptionTests : IDisposable
    {
        private WebhookSubscription instance;

        public WebhookSubscriptionTests()
        {
            instance = new WebhookSubscription(
                id: "id",
                accountId: "accountId",
                callbackUrl: "callbackUrl",
                type: WebhookSubscriptionTypeEnum.TOLLFREEVERIFICATIONSTATUS,
                basicAuthentication: new WebhookSubscriptionBasicAuthentication(
                    username: "username",
                    password: "password"
                ),
                createdDate: DateTime.Parse("2023-10-01T00:00:00Z"),
                modifiedDate: DateTime.Parse("2023-10-01T00:00:00Z")
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebhookSubscription
        /// </summary>
        [Fact]
        public void WebhookSubscriptionInstanceTest()
        {
            Assert.IsType<WebhookSubscription>(instance);
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            Assert.IsType<string>(instance.Id);
            Assert.Equal("id", instance.Id);
        }

        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            Assert.IsType<string>(instance.AccountId);
            Assert.Equal("accountId", instance.AccountId);
        }

        /// <summary>
        /// Test the property 'CallbackUrl'
        /// </summary>
        [Fact]
        public void CallbackUrlTest()
        {
            Assert.IsType<string>(instance.CallbackUrl);
            Assert.Equal("callbackUrl", instance.CallbackUrl);
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            Assert.IsType<WebhookSubscriptionTypeEnum>(instance.Type);
            Assert.Equal(WebhookSubscriptionTypeEnum.TOLLFREEVERIFICATIONSTATUS, instance.Type);
        }

        /// <summary>
        /// Test the property 'BasicAuthentication'
        /// </summary>
        [Fact]
        public void BasicAuthenticationTest()
        {
            Assert.IsType<WebhookSubscriptionBasicAuthentication>(instance.BasicAuthentication);
            Assert.Equal("username", instance.BasicAuthentication.Username);
            Assert.Equal("password", instance.BasicAuthentication.Password);
        }

        /// <summary>
        /// Test the property 'CreatedDate'
        /// </summary>
        [Fact]
        public void CreatedDateTest()
        {
            Assert.IsType<DateTime>(instance.CreatedDate);
            Assert.Equal(DateTime.Parse("2023-10-01T00:00:00Z"), instance.CreatedDate);
        }

        /// <summary>
        /// Test the property 'ModifiedDate'
        /// </summary>
        [Fact]
        public void ModifiedDateTest()
        {
            Assert.IsType<DateTime>(instance.ModifiedDate);
            Assert.Equal(DateTime.Parse("2023-10-01T00:00:00Z"), instance.ModifiedDate);
        }
    }
}
