using System;
namespace GenericRepository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; set; }
        IBookRepository BookRepository { get; set; }
        IPetRepository PetRepository { get; set; }
        int Complete();
    }
}
