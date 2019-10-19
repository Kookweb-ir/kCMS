using System.Collections.Generic;
using Kookweb.Core.Models;

namespace Kookweb.Core.Interfaces
{
    public interface ICountryService
    {
         CountryDto GetCountry (int Id);
         IEnumerable<CountryDto> GetCountries ();
    }
}