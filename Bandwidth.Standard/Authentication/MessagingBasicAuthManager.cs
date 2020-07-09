using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Bandwidth.Standard.Http.Request;

namespace Bandwidth.Standard.Authentication
{
    internal class MessagingBasicAuthManager : IBasicAuthCredentials, IAuthManager
    {
        public string Username { get; }
        public string Password { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        public MessagingBasicAuthManager(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// Adds authentication to the given HttpRequest
        /// </summary>
        /// <param name="httpRequest">Http Request</param>
        /// <return>Returns the httpRequest after adding authentication</return>
        public HttpRequest Apply(HttpRequest httpRequest)
        {
            string authCredentials = Username + ":" + Password;
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
            string authCredentials = Username + ":" + Password;
            byte[] data = Encoding.ASCII.GetBytes(authCredentials);
            httpRequest.Headers["Authorization"] = "Basic " + Convert.ToBase64String(data);
            return Task.FromResult(httpRequest);
        }
    }
}