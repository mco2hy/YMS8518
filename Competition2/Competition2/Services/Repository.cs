using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition2.Services
{
    public class Repository<T> : Interfaces.IRepository<T> where T : class
    {
        private readonly DataContext _dataContext;
        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Delete(int id)
        {
            T model = Get(id);
            _dataContext.Set<T>().Remove(model);
            
        }

        public T Get(int id)
        {
            return _dataContext.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dataContext.Set<T>().ToList();

        }

        public T Insert(T model)
        {
            _dataContext.Set<T>().Add(model);
            
            return model;
        }

        public T Update(T model)
        {
            _dataContext.Set<T>().Update(model);
            
            return model;
        }
    }
}
