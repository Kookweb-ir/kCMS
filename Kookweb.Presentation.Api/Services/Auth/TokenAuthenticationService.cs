using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Kookweb.Presentation.Api.Interfaces.Auth;
using Kookweb.Presentation.Api.Model.Auth;
using Kookweb.Presentation.Api.Model.Auth.Query;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Kookweb.Presentation.Api.Services.Auth
{
    public class TokenAuthenticationService : IAuthenticateService
    {
        private readonly IUserManagementService _userManagementService;
        private readonly TokenManagement _tokenManagement;

        public TokenAuthenticationService(IUserManagementService service, IOptions<TokenManagement> tokenManagement)
        {
            _userManagementService = service;
            _tokenManagement = tokenManagement.Value;
        }
        public string IsAuthenticated(TokenRequest request)
        {

            string token = string.Empty;
            if (!_userManagementService.IsValidUser(request.Username, request.Password)) return string.Empty;

            var claim = new[]
            {
                new Claim(ClaimTypes.Name, request.Username)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenManagement.Secret));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var jwtToken = new JwtSecurityToken(
                _tokenManagement.Issuer,
                _tokenManagement.Audience,
                claim,
                expires: DateTime.Now.AddMinutes(_tokenManagement.AccessExpiration),
                signingCredentials: credentials
            );
            token = new JwtSecurityTokenHandler().WriteToken(jwtToken);
            return token;

        }
    }
}