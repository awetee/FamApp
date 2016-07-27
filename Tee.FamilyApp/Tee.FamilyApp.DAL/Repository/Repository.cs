namespace Tee.FamilyApp.DAL.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using Entities;

    public class Repository<T> : IRepository<T>, IDisposable where T : BaseEntity
    {
        private DbContext context;
        private DbSet<T> dbSet;

        public Repository(DbContext ctx)
        {
            this.context = ctx;
            this.dbSet = this.context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return this.dbSet.ToList();
        }

        public T Get(int id)
        {
            return this.dbSet.Find(id);
        }

        public int Add(T entity)
        {
            this.dbSet.Add(entity);
            this.context.SaveChanges();
            return entity.Id;
        }

        public void Update(T entity)
        {
            this.context.Entry(entity).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(T entity)
        {
            this.context.Entry(entity).State = EntityState.Deleted;
            this.context.SaveChanges();
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