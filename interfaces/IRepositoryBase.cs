using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligeirao.interfaces
{
    public interface IRepositoryBase <T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        T Create(T entity);
        T Update(T entity);
        void Delete(T entity);
        void SaveChanges();
    }
}