namespace Tee.FamilyApp.DAL.Migrations
{
    using System.Data.Entity.Migrations;
    using Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<RootContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RootContext context)
        {
            //context.Branches.AddOrUpdate(
            //  new Branch
            //  {
            //      Id = 1,
            //      FirstName = "James",
            //      LastName = "Brown",
            //      Gender = Gender.Male,
            //      BirthDetail = new BirthDetail
            //      {
            //          Country = "England",
            //          DateOfBirth = DateTime.Parse("1989/05/21"),
            //          Province = "",
            //          Town = ""
            //      },
            //      Links = new List<Link>
            //        {
            //            new Link
            //            {
            //                Id = 1,
            //                RalatedBranchId = 2,
            //                LinkType = LinkType.Parent
            //            },
            //                            new Link
            //            {
            //                Id = 2,
            //                RalatedBranchId = 3,
            //                LinkType = LinkType.Sibling
            //            }
            //        }
            //  },
            //  new Branch
            //  {
            //      Id = 2,
            //      FirstName = "Bruce",
            //      LastName = "Brown",
            //      Gender = Gender.Male,
            //      BirthDetail = new BirthDetail
            //      {
            //          Country = "England",
            //          DateOfBirth = DateTime.Parse("1940/07/01"),
            //          Province = "",
            //          Town = ""
            //      },
            //      Links = new List<Link>
            //        {
            //            new Link
            //            {
            //                Id = 3,
            //                RalatedBranchId = 1,
            //                LinkType = LinkType.Child
            //            }
            //        }
            //  },
            //  new Branch
            //  {
            //      Id = 3,
            //      FirstName = "Jane",
            //      LastName = "Brown",
            //      Gender = Gender.Female,
            //      BirthDetail = new BirthDetail
            //      {
            //          Country = "England",
            //          DateOfBirth = DateTime.Parse("1980/08/27"),
            //          Province = "",
            //          Town = ""
            //      },
            //      Links = new List<Link>
            //        {
            //            new Link
            //            {
            //                Id = 4,
            //                RalatedBranchId = 1,
            //                LinkType = LinkType.Sibling
            //            },
            //            new Link
            //            {
            //                Id = 5,
            //                RalatedBranchId = 2,
            //                LinkType = LinkType.Parent
            //            }
            //        },
            //  }

            //);
        }
    }
}