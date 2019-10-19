using Microsoft.AspNetCore.Mvc;
using Kookweb.Presentation.Api.Infrastructure;
using Kookweb.Presentation.Api.Model.Echo;

namespace Kookweb.Presentation.Api.Controllers
{
    public class EchoController : ApiController
    {
        [Route("/api/[controller]/{input?}")]
        public IActionResult Get(string input)
        {
            EchoOutput result = new EchoOutput()
            {
                status = true,
                message = string.Empty,
                result = $"You said: {input ?? "nothing!"}"
            };
            return Ok(result);
        }
    }
}