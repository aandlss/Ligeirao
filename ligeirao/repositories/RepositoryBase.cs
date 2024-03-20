using ligeirao.interfaces;
using ligeirao.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligeirao.repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T>, IDisposable where T : class
    {
        protected LigeiraoContext _context;
        public bool _SaveChanges = true;

        public RepositoryBase(bool SaveChanges = true)
        {
            _context = new LigeiraoContext();
            _SaveChanges = SaveChanges;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
        public T Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            if (_SaveChanges)
            {
                SaveChanges();
            }
        }
       

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T Update(T entity)
        {
            _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            if (_SaveChanges)
            {
                SaveChanges();
            }
            return entity;
        }

        public void SaveChanges()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
                Console.WriteLine("Deu ruim");
            }
        }
    }
}