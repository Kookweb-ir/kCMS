using Kookweb.Presentation.Api.Interfaces.Auth;

namespace Kookweb.Presentation.Api.Services.Auth
{
    public class UserManagementService : IUserManagementService
    {
        public bool IsValidUser(string userName, string password)
        {
            return true;
        }
    }
}