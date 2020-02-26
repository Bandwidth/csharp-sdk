using Bandwidth.Standard.Http.Request;
using System.Threading.Tasks;

namespace Bandwidth.Standard.Authentication
{
    internal interface IAuthManager
    {
        HttpRequest Apply(HttpRequest httpRequest);

        Task<HttpRequest> ApplyAsync(HttpRequest httpRequest);
    }
}
