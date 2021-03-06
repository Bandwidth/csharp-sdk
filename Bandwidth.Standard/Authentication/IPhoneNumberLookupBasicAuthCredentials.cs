// <copyright file="IPhoneNumberLookupBasicAuthCredentials.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.Authentication
{
using System;

public interface IPhoneNumberLookupBasicAuthCredentials
    {
        /// <summary>
        /// Gets basicAuthUserName.
        /// </summary>
        string BasicAuthUserName { get; }

        /// <summary>
        /// Gets basicAuthPassword.
        /// </summary>
        string BasicAuthPassword { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        bool Equals(string basicAuthUserName, string basicAuthPassword);
    }
}