using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Bandwidth.Standard.Http.Request;

namespace Bandwidth.Standard.Authentication
{
    internal class VoiceBasicAuthManager : IVoiceBasicAuthCredentials, IAuthManager
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public VoiceBasicAuthManager(string username, string password)
        {
            BasicAuthUserName = username;
            BasicAuthPassword = password;
        }

        /// <summary>
        /// Getter for basicAuthUserName
        /// </summary>
        public string BasicAuthUserName { get; }

        /// <summary>
        /// Getter for basicAuthPassword
        /// </summary>
        public string BasicAuthPassword { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        public bool Equals(string basicAuthUserName, string basicAuthPassword) {
            return basicAuthUserName.Equals(BasicAuthUserName)
                    && basicAuthPassword.Equals(BasicAuthPassword);
        }

        /// <summary>
        /// Adds authentication to the given HttpRequest
        /// </summary>
        /// <param name="httpRequest">Http Request</param>
        /// <return>Returns the httpRequest after adding authentication</return>
        public HttpRequest Apply(HttpRequest httpRequest)
        {
            string authCredentials = BasicAuthUserName + ":" + BasicAuthPassword;
            byte[] data = Encoding.ASCII.GetBytes(authCredentials);
            httpRequest.Headers["Authorization"] = "Basic " + Convert.ToBase64String(data);
            return httpRequest;
        }

        /// <summary>
        /// Adds authentication to the given HttpRequest
        /// </summary>
        /// <param name="httpRequest">Http Request</param>
        /// <return>Returns the httpRequest after adding authentication</return>
        public Task<HttpRequest> ApplyAsync(HttpRequest httpRequest)
        {
            string authCredentials = BasicAuthUserName + ":" + BasicAuthPassword;
            byte[] data = Encoding.ASCII.GetBytes(authCredentials);
            httpRequest.Headers["Authorization"] = "Basic " + Convert.ToBase64String(data);
            return Task.FromResult(httpRequest);
        }
    }
}