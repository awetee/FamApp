using System.Collections.Generic;
using Tee.FamilyApp.DAL.Entities;

namespace Tee.FamilyApp.Services
{
    public interface IBranchRepository : IRepository<Branch, int>
    {
        IEnumerable<Branch> FindAll();
    }
}