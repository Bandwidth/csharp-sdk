using System;
using System.Net;

namespace Bandwidth.Standard
{
    public interface IConfiguration
    {
        /// <summary>
        /// Http client timeout
        /// </summary>
        TimeSpan Timeout { get; }

        /// <summary>
        /// Current API environment
        /// </summary>
        Environment Environment { get; }

        /// <summary>
        /// BaseUrl value
        /// </summary>
        string BaseUrl { get; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:DEFAULT</param>
        /// <return>Returns the baseurl</return>
        string GetBaseUri(Server alias = Server.Default);
    }
}