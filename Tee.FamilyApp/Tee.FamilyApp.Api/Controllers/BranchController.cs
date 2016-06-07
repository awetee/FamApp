using System.Collections.Generic;
using System.Web.Http;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.Services;

namespace Tee.FamilyApp.Api.Controllers
{
    public class BranchController : ApiController
    {
        private readonly IBranchService branchService;

        public BranchController(IBranchService branchService)
        {
            this.branchService = branchService;
        }

        // GET: api/Branch
        public IEnumerable<Branch> Get()
        {
            return this.branchService.GetAllBranches();
        }

        // GET: api/Branch/5
        public Branch Get(int id)
        {
            return this.branchService.GetBranch(id);
        }

        // POST: api/Branch
        public bool Post(Branch branch)
        {
            return this.branchService.AddBranch(branch);
        }

        // PUT: api/Branch/5
        public void Put(Branch branch)
        {
            this.branchService.UpdateBranch(branch);
        }

        // DELETE: api/Branch/5
        public void Delete(int id)
        {
            this.branchService.Remove(id);
        }
    }
}