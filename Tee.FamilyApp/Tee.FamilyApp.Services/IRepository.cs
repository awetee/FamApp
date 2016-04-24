using System;
using System.Collections.Generic;

namespace Tee.FamilyApp.DAL.Entities
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetAll();

        T Get(int Id);

        int Add(T entity);

        bool Delete(int id);

        bool Update(T entity);
    }

    public class Repository<T> : IRepository<T> where T : class
    {
        public int Add(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}