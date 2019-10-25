using Kookweb.Presentation.Api.Model.Auth.Query;

namespace Kookweb.Presentation.Api.Interfaces.Auth
{
    public interface IAuthenticateService
    {
        string IsAuthenticated(TokenRequest request);
    }
}