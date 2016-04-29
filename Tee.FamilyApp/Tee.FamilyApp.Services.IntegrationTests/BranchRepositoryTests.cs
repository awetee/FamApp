using System;
using NUnit.Framework;
using Tee.FamilyApp.Common.Enums;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.DAL.Repository;

namespace Tee.FamilyApp.Services.IntegrationTests
{
    [TestFixture]
    public class BranchRepositoryTests
    {
        private readonly IBranchService service;

        public BranchRepositoryTests()
        {
            var branchRepository = new BranchRepository();
            this.service = new BranchService(branchRepository);

            var result = this.service.FindAll();

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
            var result = this.service.FindAll();
            Assert.IsNotEmpty(result);
        }
    }
}