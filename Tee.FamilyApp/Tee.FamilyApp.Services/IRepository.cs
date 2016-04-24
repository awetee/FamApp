namespace Tee.FamilyApp.Services
{
    public interface IRepository<TEntity, TKey> where TEntity : class
    {
        TEntity Get(TKey Id);

        int Add(TEntity branch);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}