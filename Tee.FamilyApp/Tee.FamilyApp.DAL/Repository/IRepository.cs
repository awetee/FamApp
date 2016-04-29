namespace Tee.FamilyApp.DAL.Repository
{
    public interface IRepository<TEntity, TKey> where TEntity : class
    {
        TEntity Get(TKey id);

        int Add(TEntity branch);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}