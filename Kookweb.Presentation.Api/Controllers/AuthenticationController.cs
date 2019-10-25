using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Kookweb.Core.Interfaces;
using Kookweb.Presentation.Api.Infrastructure;
using Kookweb.Presentation.Api.Model.Country;
using Microsoft.AspNetCore.Authorization;
using Kookweb.Presentation.Api.Model.Auth.Query;
using Kookweb.Presentation.Api.Interfaces.Auth;
using Kookweb.Presentation.Api.Model.Auth;
using System;

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
        public IActionResult RequestToken(TokenRequest request)
        {
            TokenOutput output = new TokenOutput();

            if (!ModelState.IsValid)
            {
                output.status = false;
                output.ValidationErrors = ModelState.FetchErrors();
                return BadRequest(ModelState);
            }

            string token = _authService.IsAuthenticated(request);
            if (!string.IsNullOrEmpty(token))
            {
                output.status = true;
                output.result = token;
            }
            else
            {
                output.result = "invalid username and/or password";
                output.status = false;
            }

            return Ok(output);
        }
    }
}