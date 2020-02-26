using System;

namespace Bandwidth.Standard.Authentication
{
    public interface IBasicAuthCredentials
    {
        string Username { get; }
        string Password { get; }
    }
}