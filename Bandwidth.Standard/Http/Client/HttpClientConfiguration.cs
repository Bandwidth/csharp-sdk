using System;

namespace Bandwidth.Standard.Http.Client
{
    /// <summary>
    /// Represents the current state of the Http Client
    /// </summary>
    internal class HttpClientConfiguration : IHttpClientConfiguration
    {
        public HttpClientConfiguration()
        {
            Timeout = TimeSpan.FromSeconds(100);
        }

        /// <summary>
        /// Http client timeout
        /// </summary>
        public TimeSpan Timeout { get; internal set; }

        public override string ToString()
        {
            return "HttpClientConfiguration: " +
                $"{Timeout} ";
        }
    }
}
