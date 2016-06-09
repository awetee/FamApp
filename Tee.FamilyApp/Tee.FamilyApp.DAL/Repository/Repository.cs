namespace Tee.FamilyApp.DAL.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using Tee.FamilyApp.DAL.Entities;

    public class Repository<T> : IRepository<T>, IDisposable where T : BaseEntity
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
            return this.table.ToList();
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

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Repository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        #endregion IDisposable Support
    }
}