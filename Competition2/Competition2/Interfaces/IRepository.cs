using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition2.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        void Delete(int id);
        T Insert(T model);
        IEnumerable<T> GetAll();
        T Update(T model);
        
    }
}
