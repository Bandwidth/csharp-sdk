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
    ///  Class for testing TfvError
    /// </summary>
    public class TfvErrorTests : IDisposable
    {
        private TfvError instance;
        private Dictionary<string, string> errors;

        public TfvErrorTests()
        {
            errors = new Dictionary<string, string> {
                { "username", "Username is required." },
                { "email", "Invalid email format." }
            };

            instance = new TfvError(
                type: "type",
                description: "description",
                errors: errors
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TfvError
        /// </summary>
        [Fact]
        public void TfvErrorInstanceTest()
        {
            Assert.IsType<TfvError>(instance);
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            Assert.IsType<string>(instance.Type);
            Assert.Equal("type", instance.Type);
        }

        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            Assert.IsType<string>(instance.Type);
            Assert.Equal("description", instance.Description);
        }

        /// <summary>
        /// Test the property 'Errors'
        /// </summary>
        [Fact]
        public void ErrorsTest()
        {
            Assert.IsType<Dictionary<string, string>>(instance.Errors);
            Assert.Equal(errors, instance.Errors);
        }
    }
}
