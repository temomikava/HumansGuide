using HumansGuide.Core.Domain.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansGuide.Core.Domain.Entities
{
    public class City:AuditableEntity
    {
        public string Name { get; set; }
        public List<Human> Humans { get; set; }
    }
}
