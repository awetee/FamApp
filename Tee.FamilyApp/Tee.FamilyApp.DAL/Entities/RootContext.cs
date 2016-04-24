using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Tee.FamilyApp.DAL.Entities
{
    public class RootContext : DbContext
    {
        public RootContext() : base("FamilyAppModel")
        {
        }

        public DbSet<BirthDetail> BirthDetails { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Link> Links { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Branch>()
                        .HasRequired(s => s.BirthDetail)
                        .WithRequiredPrincipal(t => t.Branch);
        }
    }
}