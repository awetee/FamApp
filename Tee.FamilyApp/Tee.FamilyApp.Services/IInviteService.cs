using Tee.FamilyApp.Common;
using Tee.FamilyApp.DAL.Entities;

namespace Tee.FamilyApp.Services
{
    public interface IInviteService
    {
        OperationResult SendInvitation(Invite invite);
    }
}