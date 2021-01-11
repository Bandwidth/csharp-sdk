using System;

namespace Bandwidth.Standard.Authentication
{
    public interface IVoiceBasicAuthCredentials
    {
        /// <summary>
        /// Getter for basicAuthUserName
        /// </summary>
        string BasicAuthUserName { get; }

        /// <summary>
        /// Getter for basicAuthPassword
        /// </summary>
        string BasicAuthPassword { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        bool Equals(string basicAuthUserName, string basicAuthPassword);
    }
}