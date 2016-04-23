using System.Collections.Generic;

namespace Tee.FamilyApp.Tests
{
    public class Branch
    {
        private readonly IBranchService _branchService;

        public Branch(IBranchService branchService)
        {
            _branchService = branchService;
        }

        public int BranchId { get; set; }

        public bool SendFamilyInvite()
        {
            return _branchService.SendInviteNotification(BranchId);
        }

        public IEnumerable<Branch> GetFamilyMembers()
        {
            return _branchService.GetRelatedBranchs(BranchId);
        }
    }
}