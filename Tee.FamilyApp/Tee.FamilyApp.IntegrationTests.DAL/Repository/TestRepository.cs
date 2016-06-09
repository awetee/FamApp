namespace Tee.FamilyApp.IntegrationTests.DAL.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using Entities;
    using FamilyApp.DAL.Repository;
    using BaseEntity = FamilyApp.DAL.Entities.BaseEntity;

    public class TestRepository<T> : IRepository<T>, IDisposable where T : BaseEntity
    {
        private RootTestContext db;
        private DbSet<T> table;

        public TestRepository()
        {
            db = new RootTestContext();
            table = db.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T Get(int id)
        {
            return table.Find(id);
        }

        public int Add(T entity)
        {
            table.Add(entity);
            db.SaveChanges();
            return entity.Id;
        }

        public void Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(T entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}