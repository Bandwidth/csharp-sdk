using System;
using System.Text;
using System.Collections.Generic;
using Bandwidth.Standard.Http.Request;

namespace Bandwidth.Standard.Utilities
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
    }
}