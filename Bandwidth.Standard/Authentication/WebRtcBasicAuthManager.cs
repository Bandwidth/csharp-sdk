// <copyright file="WebRtcBasicAuthManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.Authentication
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Bandwidth.Standard.Http.Request;

    /// <summary>
    /// WebRtcBasicAuthManager Class.
    /// </summary>
    internal class WebRtcBasicAuthManager : IWebRtcBasicAuthCredentials, IAuthManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IrisBasicAuthManager"/> class.
        /// </summary>
        /// <param name="username"> Username.</param>
        /// <param name="password"> Password.</param>
        public WebRtcBasicAuthManager(string username, string password)
        {
            this.BasicAuthUserName = username;
            this.BasicAuthPassword = password;
        }

        /// <summary>
        /// Gets basicAuthUserName.
        /// </summary>
        public string BasicAuthUserName { get; }

        /// <summary>
        /// Gets basicAuthPassword.
        /// </summary>
        public string BasicAuthPassword { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="basicAuthUserName"> BasicAuthUserName.</param>
        /// <param name="basicAuthPassword"> BasicAuthPassword.</param>
        /// <returns> The boolean value.</returns>
        public bool Equals(string basicAuthUserName, string basicAuthPassword)
        {
            return basicAuthUserName.Equals(this.BasicAuthUserName)
                    && basicAuthPassword.Equals(this.BasicAuthPassword);
        }

        /// <summary>
        /// Adds authentication to the given HttpRequest.
        /// </summary>
        /// <param name="httpRequest">Http Request.</param>
        /// <returns>Returns the httpRequest after adding authentication.</returns>
        public HttpRequest Apply(HttpRequest httpRequest)
        {
            string authCredentials = this.BasicAuthUserName + ":" + this.BasicAuthPassword;
            byte[] data = Encoding.ASCII.GetBytes(authCredentials);
            httpRequest.Headers["Authorization"] = "Basic " + Convert.ToBase64String(data);
            return httpRequest;
        }

        /// <summary>
        /// Adds authentication to the given HttpRequest.
        /// </summary>
        /// <param name="httpRequest">Http Request.</param>
        /// <returns>Returns the httpRequest after adding authentication.</returns>
        public Task<HttpRequest> ApplyAsync(HttpRequest httpRequest)
        {
            string authCredentials = this.BasicAuthUserName + ":" + this.BasicAuthPassword;
            byte[] data = Encoding.ASCII.GetBytes(authCredentials);
            httpRequest.Headers["Authorization"] = "Basic " + Convert.ToBase64String(data);
            return Task.FromResult(httpRequest);
        }
    }
}