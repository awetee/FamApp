using System.Data.Entity;
using Ninject.Modules;
using Tee.FamilyApp.DAL.Repository;

namespace Tee.FamilyApp.DAL.Dependencies
{
    public class DalModule : NinjectModule
    {
        public override void Load()
        {
            Bind<DbContext>().To<RootContext>();
            Bind(typeof(IRepository<>)).To(typeof(Repository<>));
        }
    }
}