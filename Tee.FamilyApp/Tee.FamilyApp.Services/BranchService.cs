using System.Collections.Generic;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.DAL.Repository;

namespace Tee.FamilyApp.Services
{
    public class BranchService : IBranchService
    {
        private IRepository<Branch> branchRepository;

        public BranchService()
        {
            this.branchRepository = new Repository<Branch>();
        }

        public IEnumerable<Branch> GetAllBranches()
        {
            return this.branchRepository.GetAll();
        }
    }
}