using Bandwidth.Standard.Http.Request;

namespace Bandwidth.Standard.Utilities
{
    internal interface IAuthManager
    {
        HttpRequest Apply(HttpRequest httpRequest);
    }
}
