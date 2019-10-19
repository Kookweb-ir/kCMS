using Kookweb.Core.Domain.Infrastructure;

namespace Kookweb.Core.Domain.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }

    }
}