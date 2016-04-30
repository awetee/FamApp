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
        private IRepository<Branch> branchRepository;

        public BranchService(IRepository<Branch> branchRepository)
        {
            this.branchRepository = branchRepository;
        }

        public IEnumerable<Branch> FindAll()
        {
            return this.branchRepository.GetAll();
        }
    }
}