using System.Collections.Generic;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.DAL.Repository;

namespace Tee.FamilyApp.Services
{
    public interface IBranchService
    {
        IEnumerable<Branch> FindAll();
    }

    public class BranchService : IBranchService
    {
        private readonly IBranchRepository branchRepository;

        public BranchService(IBranchRepository branchRepository)
        {
            this.branchRepository = branchRepository;
        }

        public IEnumerable<Branch> FindAll()
        {
            return this.branchRepository.FindAll();
        }
    }
}