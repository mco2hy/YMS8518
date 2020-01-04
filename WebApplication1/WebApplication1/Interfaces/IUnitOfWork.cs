using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAnimalRepository AnimalRepository { get; set; }
        int complete();
    }
}
