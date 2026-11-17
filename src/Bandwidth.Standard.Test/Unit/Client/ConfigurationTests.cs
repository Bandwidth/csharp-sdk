using System;
using System.Reflection;
using Xunit;
using Bandwidth.Standard.Client;

namespace Bandwidth.Standard.Test.Unit.Client
{
    /// <summary>
    ///  Class for testing Configuration
    /// </summary>
    public class ConfigurationTests
    {
        /// <summary>
        /// Basic auth credentials should fail to compile with a message pointing to OAuth
        /// </summary>
        [Theory]
        [InlineData(typeof(Configuration), "Username")]
        [InlineData(typeof(Configuration), "Password")]
        [InlineData(typeof(IReadableConfiguration), "Username")]
        [InlineData(typeof(IReadableConfiguration), "Password")]
        public void BasicAuthPropertiesAreObsoleteErrors(Type type, string propertyName)
        {
            PropertyInfo property = type.GetProperty(propertyName);
            Assert.NotNull(property);

            ObsoleteAttribute obsolete = property.GetCustomAttribute<ObsoleteAttribute>();
            Assert.NotNull(obsolete);
            Assert.True(obsolete.IsError);
            Assert.Contains("OAuthClientId", obsolete.Message);
            Assert.Contains("OAuthClientSecret", obsolete.Message);
        }
    }
}
