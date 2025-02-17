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
    ///  Class for testing TfvStatus
    /// </summary>
    public class TfvStatusTests : IDisposable
    {
        private TfvStatus instance;
        private Guid internalTicketNumber = Guid.NewGuid();
        private TfvSubmissionInfo submission = new TfvSubmissionInfo();

        public TfvStatusTests()
        {
            instance = new TfvStatus(
                phoneNumber: "phoneNumber",
                status: TfvStatusEnum.PENDING,
                internalTicketNumber: internalTicketNumber,
                declineReasonDescription: "declineReasonDescription",
                resubmitAllowed: true,
                createdDateTime: DateTime.Parse("2023-10-01T00:00:00Z"),
                modifiedDateTime: DateTime.Parse("2023-10-01T00:00:00Z"),
                submission: submission
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TfvStatus
        /// </summary>
        [Fact]
        public void TfvStatusInstanceTest()
        {
            Assert.IsType<TfvStatus>(instance);
        }

        /// <summary>
        /// Test the property 'PhoneNumber'
        /// </summary>
        [Fact]
        public void PhoneNumberTest()
        {
            Assert.IsType<string>(instance.PhoneNumber);
            Assert.Equal("phoneNumber", instance.PhoneNumber);
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            Assert.IsType<TfvStatusEnum>(instance.Status);
            Assert.Equal(TfvStatusEnum.PENDING, instance.Status);
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
        /// Test the property 'DeclineReasonDescription'
        /// </summary>
        [Fact]
        public void DeclineReasonDescriptionTest()
        {
            Assert.IsType<string>(instance.DeclineReasonDescription);
            Assert.Equal("declineReasonDescription", instance.DeclineReasonDescription);
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
        /// Test the property 'CreatedDateTime'
        /// </summary>
        [Fact]
        public void CreatedDateTimeTest()
        {
            Assert.IsType<DateTime>(instance.CreatedDateTime);
            Assert.Equal(DateTime.Parse("2023-10-01T00:00:00Z"), instance.CreatedDateTime);
        }

        /// <summary>
        /// Test the property 'ModifiedDateTime'
        /// </summary>
        [Fact]
        public void ModifiedDateTimeTest()
        {
            Assert.IsType<DateTime>(instance.ModifiedDateTime);
            Assert.Equal(DateTime.Parse("2023-10-01T00:00:00Z"), instance.ModifiedDateTime);
        }

        /// <summary>
        /// Test the property 'Submission'
        /// </summary>
        [Fact]
        public void SubmissionTest()
        {
            Assert.IsType<TfvSubmissionInfo>(instance.Submission);
            Assert.Equal(submission, instance.Submission);
        }
    }
}
