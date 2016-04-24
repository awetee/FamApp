using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Tee.FamilyApp.DAL.Entities;

namespace Tee.FamilyApp.Services
{
    public class BranchRepository : IBranchRepository
    {
        private readonly RootContext context;

        public BranchRepository(RootContext context)
        {
            this.context = context;
        }

        public Branch Get(int id)
        {
            var branches = this.context.Branches.ToList();

            var result = this.context.Branches.SingleOrDefault(b => b.Id == id);
            return result;
        }

        public int Add(Branch branch)
        {
            context.Entry(branch).State = EntityState.Deleted;
            return context.SaveChanges();
        }

        public void Update(Branch branch)
        {
            this.context.Entry(branch).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(Branch branch)
        {
            this.context.Entry(branch).State = EntityState.Deleted;
            this.context.SaveChanges();
        }

        public IEnumerable<Branch> FindAll()
        {
            return this.context.Branches.ToList();
        }
    }
}