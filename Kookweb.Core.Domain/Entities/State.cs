using System.Collections.Generic;
using Kookweb.Core.Domain.Infrastructure;

namespace Kookweb.Core.Domain.Entities
{
    public class State : BaseEntity
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}