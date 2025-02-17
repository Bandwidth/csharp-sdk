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
    ///  Class for testing VerificationDenialWebhook
    /// </summary>
    public class VerificationDenialWebhookTests : IDisposable
    {
        private VerificationDenialWebhook instance;
        private AdditionalDenialReason additionalDenialReason;
        private Guid internalTicketNumber = Guid.NewGuid();

        public VerificationDenialWebhookTests()
        {
            additionalDenialReason = new AdditionalDenialReason(
                statusCode: 512,
                reason: "Reason A",
                resubmitAllowed: true
            );

            instance = new VerificationDenialWebhook(
                accountId: "accountId",
                additionalDenialReasons: new List<AdditionalDenialReason> { additionalDenialReason },
                declineReasonDescription: "declineReasonDescription",
                denialStatusCode: 511,
                internalTicketNumber: internalTicketNumber,
                phoneNumber: "+18005551234",
                resubmitAllowed: true,
                status: "status"
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VerificationDenialWebhook
        /// </summary>
        [Fact]
        public void VerificationDenialWebhookInstanceTest()
        {
            Assert.IsType<VerificationDenialWebhook>(instance);
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
        /// Test the property 'AdditionalDenialReasons'
        /// </summary>
        [Fact]
        public void AdditionalDenialReasonsTest()
        {
            Assert.IsType<List<AdditionalDenialReason>>(instance.AdditionalDenialReasons);
            Assert.Equal(additionalDenialReason, instance.AdditionalDenialReasons.First());
        }

        /// <summary>
        /// Test the property 'DeclineReasonDescription'
        /// </summary>
        [Fact]
        public void DeclineReasonDescriptionTest()
        {
            Assert.IsType<string>(instance.DeclineReasonDescription);
            Assert.Equal("declineReasonDescription", instance.DeclineReasonDescription);
        }

        /// <summary>
        /// Test the property 'DenialStatusCode'
        /// </summary>
        [Fact]
        public void DenialStatusCodeTest()
        {
            Assert.IsType<int>(instance.DenialStatusCode);
            Assert.Equal(511, instance.DenialStatusCode);
        }

        /// <summary>
        /// Test the property 'InternalTicketNumber'
        /// </summary>
        [Fact]
        public void InternalTicketNumberTest()
        {
            Assert.IsType<Guid>(instance.InternalTicketNumber);
            Assert.Equal(internalTicketNumber, instance.InternalTicketNumber);
        }

        /// <summary>
        /// Test the property 'PhoneNumber'
        /// </summary>
        [Fact]
        public void PhoneNumberTest()
        {
            Assert.IsType<string>(instance.PhoneNumber);
            Assert.Equal("+18005551234", instance.PhoneNumber);
        }

        /// <summary>
        /// Test the property 'ResubmitAllowed'
        /// </summary>
        [Fact]
        public void ResubmitAllowedTest()
        {
            Assert.IsType<bool>(instance.ResubmitAllowed);
            Assert.Equal(true, instance.ResubmitAllowed);
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            Assert.IsType<string>(instance.Status);
            Assert.Equal("status", instance.Status);
        }
    }
}
