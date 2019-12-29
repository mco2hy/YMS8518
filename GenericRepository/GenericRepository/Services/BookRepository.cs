using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericRepository.Models;

namespace GenericRepository.Services
{
    public class BookRepository : Repository<Models.Book>, Interfaces.IBookRepository
    {
        private readonly DataContext _dataContext;
        public BookRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public Book GetTheBestSeller()
        {
            return _dataContext.Books.LastOrDefault(a => a.Name == "x");
        }
    }
}
