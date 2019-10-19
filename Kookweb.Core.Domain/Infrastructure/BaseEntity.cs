using System;

namespace Kookweb.Core.Domain.Infrastructure
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public short IsDeleted { get; set; }
        public short IsActive { get; set; }
        public Guid InsertUserId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}