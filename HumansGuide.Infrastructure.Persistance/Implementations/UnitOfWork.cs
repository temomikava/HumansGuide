using HumansGuide.Core.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansGuide.Infrastructure.Persistance.Implementations
{
    public class UnitOfWork:IUnitOfWork
    {
        private IHumanRepository humanRepository;

        private readonly DataContext context;
        public UnitOfWork(DataContext context) => this.context = context;

        //public IHumanRepository HumanRepository => humanRepository ??= new HumanRepository(context);
        public IHumanRepository HumanRepository
        {
            get
            {
                return humanRepository ??= new HumanRepository(context);
            }
        }
    }
}
