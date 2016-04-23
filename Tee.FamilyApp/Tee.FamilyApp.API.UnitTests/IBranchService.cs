using System.Collections.Generic;

namespace Tee.FamilyApp.Tests
{
    public interface IBranchService
    {
        IEnumerable<Branch> GetRelatedBranchs(int branchId);

        bool SendInviteNotification(int branchId);
    }
}