using System.Collections.Generic;

namespace Tee.FamilyApp.DAL.Repository
{
    using Common.Entities;

    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        int Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}