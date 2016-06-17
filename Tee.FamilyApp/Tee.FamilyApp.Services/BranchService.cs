using System;
using System.Collections.Generic;
using System.Linq;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.DAL.Repository;

namespace Tee.FamilyApp.Services
{
    public class BranchService : IBranchService
    {
        private readonly IRepository<Branch> branchRepository;

        public BranchService() : this(new Repository<Branch>(new RootContext()))
        {
        }

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
            // get the links having this ID as BranchID using the link service
            // THen you need to get the related branch in each link
            return new List<Branch>();
        }

        public bool AddBranch(Branch branch)
        {
            throw new NotImplementedException();
        }

        public Branch GetBranchByUserName(string userName)
        {
            var branch = new Branch();

            branch = this.branchRepository.GetAll().Where(b => b.Username == userName).Single();

            return branch;
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