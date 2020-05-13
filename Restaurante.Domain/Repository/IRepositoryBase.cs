using System;
using System.Collections.Generic;

namespace Restaurante.Domain.Repository
{
    public interface IRepositoryBase<T> : IDisposable where T : class, IEntity
    {
        void Insert(T entity);

        void Update(T entity);

        T GetById(int id);

        void Delete(int id);

        List<T> GetAll();
    }
}
