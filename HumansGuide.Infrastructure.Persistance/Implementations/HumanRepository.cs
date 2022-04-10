using HumansGuide.Core.Application.Interfaces;
using HumansGuide.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansGuide.Infrastructure.Persistance.Implementations
{
    public class HumanRepository : Repository<Human>, IHumanRepository
    {
        public HumanRepository(DataContext context) : base(context)
        {
        }
    }
}
