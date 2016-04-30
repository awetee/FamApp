using System.Collections.Generic;
using Tee.FamilyApp.DAL.Entities;

namespace Tee.FamilyApp.Services
{
    public interface IBranchService
    {
        IEnumerable<Branch> GetAllBranches();
    }
}