using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition2.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository BookRepository { get; set; }
        IPetRepository PetRepository { get; set; }
        IRoomRepository RoomRepository { get; set; }
        IUserRepository UserRepository { get; set; }

        int Complete();
    }
}
