using System.Collections.Generic;
using Tee.FamilyApp.Common.Core;
using Tee.FamilyApp.Common.Core.Entities;

namespace Tee.FamilyApp.Services.Core
{
    public interface IInviteService
    {
        OperationResult SendInvitation(Invite invites);

        IEnumerable<Invite> GetPendingInvitesForUser(string username);

        IEnumerable<Invite> GetPendingReceivedInvitesByBranch(int branchId);
    }
}