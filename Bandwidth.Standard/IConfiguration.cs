// <copyright file="IConfiguration.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard
{
    using System;
    using System.Net;
    using Bandwidth.Standard.Authentication;

    /// <summary>
    /// IConfiguration.
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets Current API environment.
        /// </summary>
        Environment Environment { get; }

        /// <summary>
        /// Gets BaseUrl value.
        /// </summary>
        string BaseUrl { get; }

        /// <summary>
        /// Gets the credentials to use with MessagingBasicAuth.
        /// </summary>
        IMessagingBasicAuthCredentials MessagingBasicAuthCredentials { get; }

        /// <summary>
        /// Gets the credentials to use with TwoFactorAuthBasicAuth.
        /// </summary>
        ITwoFactorAuthBasicAuthCredentials TwoFactorAuthBasicAuthCredentials { get; }

        /// <summary>
        /// Gets the credentials to use with VoiceBasicAuth.
        /// </summary>
        IVoiceBasicAuthCredentials VoiceBasicAuthCredentials { get; }

        /// <summary>
        /// Gets the credentials to use with WebRtcBasicAuth.
        /// </summary>
        IWebRtcBasicAuthCredentials WebRtcBasicAuthCredentials { get; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        string GetBaseUri(Server alias = Server.Default);
    }
}