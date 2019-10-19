using System.Collections.Generic;
using Kookweb.Core.Domain.Infrastructure;

namespace Kookweb.Core.Domain.Entities
{     
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<State> States { get; set; }
    }
}