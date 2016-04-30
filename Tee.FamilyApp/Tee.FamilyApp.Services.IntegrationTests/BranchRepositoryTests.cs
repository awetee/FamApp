using System;
using System.Linq;
using NUnit.Framework;
using Tee.FamilyApp.Common.Enums;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.DAL.Repository;

namespace Tee.FamilyApp.Services.IntegrationTests
{
    [TestFixture]
    public class BranchRepositoryTests
    {
        private IRepository<Branch> repository;

        public BranchRepositoryTests()
        {
            this.repository = new Repository<Branch>();

            var branch = new Branch
            {
                FirstName = "James",
                LastName = "Brown",
                Gender = Gender.Male
            };

            var birthDetail = new BirthDetail
            {
                Country = "America",
                DateOfBirth = new DateTime(1950, 1, 2),
                Province = "Unknown",
                Town = "Unknown"
            };

            var link = new Link
            {
                LinkType = LinkType.Child
            };
        }

        [Test]
        public void GetShouldReturnValidResult()
        {
            var result = this.repository.GetAll().ToList();
            Assert.IsNotEmpty(result);
        }
    }
}