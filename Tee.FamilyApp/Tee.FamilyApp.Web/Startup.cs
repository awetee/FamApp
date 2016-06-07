using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tee.FamilyApp.Web.Startup))]
namespace Tee.FamilyApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
