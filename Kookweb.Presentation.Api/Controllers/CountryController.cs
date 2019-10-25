using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Kookweb.Core.Interfaces;
using Kookweb.Presentation.Api.Infrastructure;
using Kookweb.Presentation.Api.Model.Country;
using Microsoft.AspNetCore.Authorization;

namespace Kookweb.Presentation.Api.Controllers
{
    [Authorize]
    public class CountryController : ApiController
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public IActionResult Get()
        {
            CountryOutput result = new CountryOutput();
            result.status = true;
            result.result = _countryService.GetCountries();
            result.message = $"{result.result.Count()} country returned";
            return Ok(result);
        }
    }
}