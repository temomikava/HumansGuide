using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansGuide.Core.Domain.Basics
{
    public abstract class AuditableEntity:BaseEntity
    {
        public virtual DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public virtual string CreatedBy { get; set; }
        public virtual DateTime? DateUpdated { get; set; }
        public virtual string UpdatedBy { get; set; }
        public virtual DateTime? DateDeleted { get; set; }
        public virtual string DeletedBy { get; set; }
    }
}
