using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class AnimalRepository : Repository<Models.Animal>, Interfaces.IAnimalRepository
    {
        private readonly DataContext _dataContext;
        public AnimalRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
