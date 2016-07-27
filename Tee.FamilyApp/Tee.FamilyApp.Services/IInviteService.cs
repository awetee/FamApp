using System.Collections.Generic;
using Tee.FamilyApp.Common;
using Tee.FamilyApp.Common.Entities;

namespace Tee.FamilyApp.Services
{
    public interface IInviteService
    {
        OperationResult SendInvitation(Invite invite, string userName);

        IEnumerable<Invite> GetPendingInvitesForUser(string username);

        IEnumerable<Invite> GetPendingReceivedInvitesByBranch(int branchId);
    }
}