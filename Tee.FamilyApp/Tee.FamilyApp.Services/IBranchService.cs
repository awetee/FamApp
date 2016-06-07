using System.Collections.Generic;
using Tee.FamilyApp.DAL.Entities;

namespace Tee.FamilyApp.Services
{
    public interface IBranchService
    {
        Branch GetBranch(int branchId);

        IEnumerable<Branch> GetAllBranches();

        IEnumerable<Branch> GetRelatedBranches(int branchId);

        bool AddBranch(Branch branch);

        void Remove(int id);

        void UpdateBranch(Branch branch);
    }
}