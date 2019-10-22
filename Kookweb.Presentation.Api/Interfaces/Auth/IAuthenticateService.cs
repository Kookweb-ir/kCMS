using Kookweb.Presentation.Api.Model.Auth.Query;

namespace Kookweb.Presentation.Api.Interfaces.Auth
{
    public interface IAuthenticateService
    {
        bool IsAuthenticated(TokenRequest request, out string token);
    }
}