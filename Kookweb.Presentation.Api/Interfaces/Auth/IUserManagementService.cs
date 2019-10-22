namespace Kookweb.Presentation.Api.Interfaces.Auth
{
    public interface IUserManagementService
    {
        bool IsValidUser(string username, string password);
    }
}