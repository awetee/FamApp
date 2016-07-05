using System.Collections.Generic;
using Tee.FamilyApp.Common;
using Tee.FamilyApp.Common.Models;
using Tee.FamilyApp.DAL.Entities;

namespace Tee.FamilyApp.Services
{
    public interface IInviteService
    {
        OperationResult SendInvitation(InviteViewModel invite, string userName);

        IEnumerable<InviteViewModel> GetPendingInvitesForUser(string username);

        IEnumerable<Invite> GetPendingReceivedInvitesByBranch(int branchId);
    }
}