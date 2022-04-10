using System;

namespace Infrastructure.Entities
{
    public abstract class GuidIdentifiable
    {
        public Guid Id { get; set; }
    }
}