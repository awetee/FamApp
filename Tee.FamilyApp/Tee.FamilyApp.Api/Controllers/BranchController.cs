using System.Collections.Generic;
using System.Web.Http;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.Services;

namespace Tee.FamilyApp.Api.Controllers
{
    public class BranchController : ApiController
    {
        private BranchService branchService;

        public BranchController()
        {
            this.branchService = new BranchService();
        }

        // GET: api/Branch
        public IEnumerable<Branch> Get()
        {
            return this.branchService.GetAllBranches();
        }

        // GET: api/Branch/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Branch
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Branch/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Branch/5
        public void Delete(int id)
        {
        }
    }
}