using System;

namespace Bandwidth.Standard.Utilities
{
    public interface IBasicAuthCredentials
    {
        string Username { get; }
        string Password { get; }
    }
}