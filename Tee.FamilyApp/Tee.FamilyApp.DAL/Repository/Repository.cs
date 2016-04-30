using System.Collections.Generic;
using System.Data.Entity;
using Tee.FamilyApp.DAL.Entities;

namespace Tee.FamilyApp.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private RootContext db;
        private DbSet<T> table;

        public Repository()
        {
            this.db = new RootContext();
            this.table = this.db.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return this.table;
        }

        public T Get(int id)
        {
            return this.table.Find(id);
        }

        public int Add(T entity)
        {
            this.table.Add(entity);
            this.db.SaveChanges();
            return entity.Id;
        }

        public void Update(T entity)
        {
            this.db.Entry(entity).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(T entity)
        {
            this.db.Entry(entity).State = EntityState.Deleted;
            this.db.SaveChanges();
        }
    }
}