using Competition2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition2.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public UnitOfWork(DataContext dataContext) 
        {
            _dataContext = dataContext;
            BookRepository = new BookRepository(_dataContext);
            PetRepository = new PetRepository(_dataContext);
            RoomRepository = new RoomRepository(_dataContext);
            UserRepository = new UserRepository(_dataContext);
        }

        public IBookRepository BookRepository { get; set; }
        public IPetRepository PetRepository { get; set; }
        public IRoomRepository RoomRepository { get; set; }
        public IUserRepository UserRepository { get; set; }

        public int Complete()
        {
            return _dataContext.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
