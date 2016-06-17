using System.Data.Entity;
using Tee.FamilyApp.IntegrationTests.DAL.Entities;

namespace Tee.FamilyApp.IntegrationTests.DAL
{
    public class BaseIntegrationTest
    {
        private RootTestContext ctx;

        public BaseIntegrationTest()
        {
            ctx = new RootTestContext();

            DeleteBirthDetails();
            DeleteBranches();
            DeleteInvites();
            DeleteLinks();

            ctx.SaveChanges();
        }

        private void DeleteBirthDetails()
        {
            foreach (var entity in ctx.BirthDetails)
            {
                ctx.Entry(entity).State = EntityState.Deleted;
            }
        }

        private void DeleteBranches()
        {
            foreach (var entity in ctx.Branches)
            {
                ctx.Entry(entity).State = EntityState.Deleted;
            }
        }

        private void DeleteInvites()
        {
            foreach (var entity in ctx.Invites)
            {
                ctx.Entry(entity).State = EntityState.Deleted;
            }
        }

        private void DeleteLinks()
        {
            foreach (var entity in ctx.Links)
            {
                ctx.Entry(entity).State = EntityState.Deleted;
            }
        }
    }
}