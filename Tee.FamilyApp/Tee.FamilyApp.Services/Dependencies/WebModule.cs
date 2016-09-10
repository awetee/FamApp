using Ninject.Modules;

namespace Tee.FamilyApp.Services.Dependencies
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBranchService>().To<BranchService>();
            Bind<IInviteService>().To<InviteService>();
            Bind<IEmailService>().To<EmailService>();
        }
    }
}