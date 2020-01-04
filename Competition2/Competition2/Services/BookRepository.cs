using Competition2.Interfaces;
using Competition2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition2.Services
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(DataContext dataContext) : base(dataContext)
        {

        }

    }
}
