﻿using System.Data.Entity;

namespace Tee.FamilyApp.DAL.Entities
{
    public class RootContext : DbContext
    {
        public RootContext() : base("RootContext")
        {
        }

        //public DbSet<BirthDetail> BirthDetails { get; set; }
        //public DbSet<Branch> Branches { get; set; }
        //public DbSet<Link> Links { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Entity<Branch>()
            //            .HasRequired(s => s.BirthDetail)
            //            .WithRequiredPrincipal(t => t.Branch);

            //modelBuilder.Entity<Branch>()
            //            .HasMany(b => b.Links)
            //            .WithRequired(l => l.Branch);
        }
    }
}