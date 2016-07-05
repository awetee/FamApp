using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Tee.FamilyApp.Common.Interfaces;

namespace Tee.FamilyApp.DAL.Entities
{
    public class RootContext : DbContext, IDbContext
    {
        public RootContext() : base("RootContext")
        {
        }

        public DbSet<BirthDetail> BirthDetails { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<PublicInvite> PublicInvites { get; set; }
        public DbSet<RootsInvite> RootsInvites { get; set; }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).DateCreated = DateTime.Now;
                }

                ((BaseEntity)entity.Entity).DateModified = DateTime.Now;
            }

            return base.SaveChanges();
        }

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