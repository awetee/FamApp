using System.Collections.Generic;
using Tee.FamilyApp.DAL.Entities;

namespace Tee.FamilyApp.DAL.Repository
{
    public interface IBranchRepository : IRepository<Branch, int>
    {
        IEnumerable<Branch> FindAll();
    }
}