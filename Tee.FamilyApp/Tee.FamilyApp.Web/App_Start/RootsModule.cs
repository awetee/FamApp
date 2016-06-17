using Ninject.Modules;
using Tee.FamilyApp.Services;

namespace Tee.FamilyApp.Web.App_Start
{
    public class RootsModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IBranchService>().To<BranchService>();
        }
    }
}