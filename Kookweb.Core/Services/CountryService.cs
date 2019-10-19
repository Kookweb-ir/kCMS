using System.Collections.Generic;
using System.Linq;
using Kookweb.Core.Domain.Entities;
using Kookweb.Core.Interfaces;
using Kookweb.Core.Models;
using Kookweb.DataAccess.Repository.Interface;

namespace Kookweb.Core.Services
{
    public class CountryService : ICountryService
    {
        private readonly IBaseRepository<Country> _countryRepository;
        public CountryService(IBaseRepository<Country> countryRepository)
        {
            _countryRepository = countryRepository;
        }
        public IEnumerable<CountryDto> GetCountries()
        {
            return _countryRepository.List().Select(x => new CountryDto()
            {
                Id = x.Id,
                Name = x.Name
            });
        }
        public CountryDto GetCountry(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}