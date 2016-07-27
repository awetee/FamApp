using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Tee.FamilyApp.Common.Entities;
using Tee.FamilyApp.Common.Interfaces;

namespace Tee.FamilyApp.IntegrationTests.DAL.Entities
{
    public class RootTestContext : DbContext, IDbContext
    {
        public RootTestContext() : base("RootTestContext")
        {
        }

        public DbSet<BirthDetail> BirthDetails { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Invite> Invites { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Branch>()
                        .HasRequired(s => s.BirthDetail);

            modelBuilder.Entity<Branch>()
                        .HasMany(b => b.Links);
        }
    }
}