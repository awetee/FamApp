using System.Collections.Generic;
using Tee.FamilyApp.Common.Core.Entities;

namespace Tee.FamilyApp.Services.Core
{
    public interface IBranchService
    {
        Branch GetBranch(int branchId);

        IEnumerable<Branch> GetAllBranches();

        Branch GetBranchByUserName(string userName);

        IEnumerable<Branch> GetRelatedBranches(int branchId);

        bool AddBranch(Branch branch);

        void Remove(int id);

        void UpdateBranch(Branch branch);
    }
}