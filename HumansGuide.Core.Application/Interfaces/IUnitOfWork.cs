using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansGuide.Core.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IHumanRepository HumanRepository { get; }
    }
}
