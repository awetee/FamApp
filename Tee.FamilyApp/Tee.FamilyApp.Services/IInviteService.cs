using Tee.FamilyApp.DAL.Entities;

namespace Tee.FamilyApp.Web.Controllers
{
    public interface IInviteService
    {
        bool SendInvitation(Invite invite);
    }
}