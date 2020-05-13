using System;
using System.Collections.Generic;
using System.Linq;
using Restaurante.Domain.Repository;

namespace Restaurante.Data.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T: class, IEntity
    {
        private readonly Context _context;

        public RepositoryBase(Context context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
