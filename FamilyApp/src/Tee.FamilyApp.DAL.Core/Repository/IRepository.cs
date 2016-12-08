using System.Linq;
using Tee.FamilyApp.Common.Core.Entities;

namespace Tee.FamilyApp.DAL.Core.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();

        T Get(int id);

        int Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}