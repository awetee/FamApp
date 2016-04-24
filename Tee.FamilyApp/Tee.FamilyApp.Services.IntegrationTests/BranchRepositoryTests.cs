using System;
using NUnit.Framework;
using Tee.FamilyApp.Common.Enums;
using Tee.FamilyApp.DAL.Entities;

namespace Tee.FamilyApp.Services.IntegrationTests
{
    [TestFixture]
    public class BranchRepositoryTests
    {
        private readonly RootContext context;
        private readonly IBranchRepository repository;

        public BranchRepositoryTests()
        {
            this.context = new RootContext();
            this.repository = new BranchRepository(this.context);

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
            var result = this.repository.Get(1);
            Assert.IsNotNull(result);
        }
    }
}