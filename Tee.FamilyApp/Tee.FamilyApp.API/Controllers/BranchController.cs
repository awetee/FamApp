using System.Collections.Generic;
using System.Web.Http;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.DAL.Repository;

namespace Tee.FamilyApp.API.Controllers
{
    public class BranchController : ApiController
    {
        private Repository<Branch> repository;

        public BranchController()
        {
            this.repository = new Repository<Branch>();
        }

        // GET: api/Branch
        public IEnumerable<Branch> Get()
        {
            return this.repository.GetAll();
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