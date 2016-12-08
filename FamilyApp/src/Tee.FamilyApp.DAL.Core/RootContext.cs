using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Tee.FamilyApp.Common.Core.Entities;
using Tee.FamilyApp.Common.Core.Interfaces;

namespace Tee.FamilyApp.DAL.Core
{
    public class RootContext : DbContext, IDbContext
    {
        public RootContext(DbContextOptions<RootContext> options) : base(options)
        {
        }

        public RootContext()
        {
        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<BirthDetail> BirthDetails { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Invite> Invites { get; set; }

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
    }
}