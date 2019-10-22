using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Kookweb.Core.Interfaces;
using Kookweb.Presentation.Api.Infrastructure;
using Kookweb.Presentation.Api.Model.Country;
using Microsoft.AspNetCore.Authorization;
using Kookweb.Presentation.Api.Model.Auth.Query;
using Kookweb.Presentation.Api.Interfaces.Auth;

namespace Kookweb.Presentation.Api.Controllers
{
    public class AuthenticationController : ApiController
    {
        private readonly IAuthenticateService _authService;
        public AuthenticationController(IAuthenticateService authService)
        {
            _authService = authService;
        }


        [AllowAnonymous]
        [HttpPost, Route("request")]
        public IActionResult RequestToken([FromBody] TokenRequest request)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            string token;
            if (_authService.IsAuthenticated(request, out token))
            {
                return Ok(token);
            }

            return BadRequest("Invalid Request");
        }
    }
}