using FluentAssertions;
using NUnit.Framework;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.DAL.Repository;

namespace Tee.FamilyApp.Services.UnitTests
{
    [TestFixture]
    public class BranchRepositoryTests
    {
        private BranchService branchService;

        [SetUp]
        public void Setup()
        {
            this.branchService = new BranchService(new Repository<Branch>());
        }

        [Test]
        public void GetShouldReturnValidResult()
        {
            var result = this.branchService.GetAllBranches();

            result.Should().NotBeNullOrEmpty();
        }
    }
}