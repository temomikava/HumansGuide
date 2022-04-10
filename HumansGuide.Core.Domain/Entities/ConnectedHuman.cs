using HumansGuide.Core.Domain.Basics;
using HumansGuide.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansGuide.Core.Domain.Entities
{
    public class ConnectedHuman:AuditableEntity
    {
        public HumanConnectionType ConnectionType { get; set; }

        public int BaseConnectedHumanId { get; set; }
        public Human BaseConnectedHuman { get; set; }

        public int HumanId { get; set; }
        public Human Human { get; set; }
    }
}
