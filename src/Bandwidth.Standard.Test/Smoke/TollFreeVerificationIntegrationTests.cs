using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Bandwidth.Standard.Client;
using Bandwidth.Standard.Api;
// uncomment below to import models
//using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Smoke
{
    /// <summary>
    ///  Class for testing TollFreeVerificationApi
    /// </summary>
    public class TollFreeVerificationSmokeTests : IDisposable
    {
        private TollFreeVerificationApi instance;
        private string accountId;
        private Configuration configuration;
        

        public TollFreeVerificationSmokeTests()
        {
            accountId = Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");

            // Authorized API Client
            configuration = new Configuration();
            configuration.Username = Environment.GetEnvironmentVariable("BW_USERNAME");
            configuration.Password = Environment.GetEnvironmentVariable("BW_PASSWORD");
            instance = new TollFreeVerificationApi(configuration);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TollFreeVerificationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<TollFreeVerificationApi>(instance);
        }

        /// <summary>
        /// Test CreateWebhookSubscription
        /// </summary>
        [Fact]
        public void CreateWebhookSubscriptionTest()
        {
            //string accountId = null;
            //WebhookSubscriptionRequestSchema webhookSubscriptionRequestSchema = null;
            //var response = instance.CreateWebhookSubscription(accountId, webhookSubscriptionRequestSchema);
            //Assert.IsType<WebhookSubscription>(response);
        }

        /// <summary>
        /// Test DeleteWebhookSubscription
        /// </summary>
        [Fact]
        public void DeleteWebhookSubscriptionTest()
        {
            //string accountId = null;
            //string id = null;
            //instance.DeleteWebhookSubscription(accountId, id);
        }

        /// <summary>
        /// Test GetTollFreeVerificationStatus
        /// </summary>
        [Fact]
        public void GetTollFreeVerificationStatusTest()
        {
            //string accountId = null;
            //string phoneNumber = null;
            //var response = instance.GetTollFreeVerificationStatus(accountId, phoneNumber);
            //Assert.IsType<TfvStatus>(response);
        }

        /// <summary>
        /// Test ListTollFreeUseCases
        /// </summary>
        [Fact]
        public void ListTollFreeUseCasesTest()
        {
            var response = instance.ListTollFreeUseCases();
            Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test ListWebhookSubscriptions
        /// </summary>
        [Fact]
        public void ListWebhookSubscriptionsTest()
        {
            //string accountId = null;
            //var response = instance.ListWebhookSubscriptions(accountId);
            //Assert.IsType<WebhookSubscriptionsListBody>(response);
        }

        /// <summary>
        /// Test RequestTollFreeVerification
        /// </summary>
        [Fact]
        public void RequestTollFreeVerificationTest()
        {
            //string accountId = null;
            //VerificationRequest verificationRequest = null;
            //instance.RequestTollFreeVerification(accountId, verificationRequest);
        }

        /// <summary>
        /// Test UpdateTollFreeVerificationRequest
        /// </summary>
        [Fact]
        public void UpdateTollFreeVerificationRequestTest()
        {
            //string accountId = null;
            //string phoneNumber = null;
            //TfvSubmissionWrapper tfvSubmissionWrapper = null;
            //instance.UpdateTollFreeVerificationRequest(accountId, phoneNumber, tfvSubmissionWrapper);
        }

        /// <summary>
        /// Test UpdateWebhookSubscription
        /// </summary>
        [Fact]
        public void UpdateWebhookSubscriptionTest()
        {
            //string accountId = null;
            //string id = null;
            //WebhookSubscriptionRequestSchema webhookSubscriptionRequestSchema = null;
            //var response = instance.UpdateWebhookSubscription(accountId, id, webhookSubscriptionRequestSchema);
            //Assert.IsType<WebhookSubscription>(response);
        }
    }
}
