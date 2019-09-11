using System;

namespace ALMaster.Domain.Models
{
    public class Entity : IEntity
    {
        public Guid Id { get; protected set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        public bool Deleted { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public virtual void Delete()
        {
            Deleted = true;
        }
    }
}
