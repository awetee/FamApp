using System;
using NUnit.Framework;
using Tee.FamilyApp.Api.Controllers;
using Tee.FamilyApp.Common.Enums;
using Tee.FamilyApp.DAL.Entities;

namespace Tee.FamilyApp.Api.IntegrationTests
{
    [TestFixture]
    public class BranchControllerTests
    {
        public BranchController controller;

        public BranchControllerTests()
        {
            controller = new BranchController();

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
            var result = this.controller.Get();
            Assert.That(result, Is.Not.Empty);
        }
    }
}