using System;
using System.Collections.Generic;

namespace Tee.FamilyApp.DAL.Entities
{
    internal interface IRepository<T> : IDisposable
    {
        IEnumerable<T> GetAll();

        T Get(int Id);

        int Add(T entity);

        bool Delete(int id);

        bool Update(T entity);
    }
}