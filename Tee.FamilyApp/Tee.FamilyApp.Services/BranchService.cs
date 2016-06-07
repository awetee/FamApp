using System.Collections.Generic;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.DAL.Repository;

namespace Tee.FamilyApp.Services
{
    public class BranchService : IBranchService
    {
        private readonly IRepository<Branch> branchRepository;

        public BranchService(IRepository<Branch> brachRepository)
        {
            this.branchRepository = brachRepository;
        }

        public Branch GetBranch(int branchId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Branch> GetAllBranches()
        {
            return this.branchRepository.GetAll();
        }

        public IEnumerable<Branch> GetRelatedBranches(int branchId)
        {
            throw new System.NotImplementedException();
        }

        public bool AddBranch(Branch branch)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBranch(Branch branch)
        {
            throw new System.NotImplementedException();
        }
    }
}