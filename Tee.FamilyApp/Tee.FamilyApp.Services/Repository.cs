using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Tee.FamilyApp.DAL;
using Tee.FamilyApp.DAL.Entities;

namespace Tee.FamilyApp.Services
{
    public interface IBranchRepository : IRepository<Branch, int>
    {
        IEnumerable<Branch> FindAll();
    }

    public class BranchRepository : IBranchRepository
    {
        private RootContext context;

        public BranchRepository(RootContext context)
        {
            this.context = context;
        }

        public Branch Get(int Id)
        {
            return this.context.Branches.Find(Id);
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