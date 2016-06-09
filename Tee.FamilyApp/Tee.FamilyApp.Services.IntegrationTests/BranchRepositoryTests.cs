using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.IntegrationTests.DAL.Repository;

namespace Tee.FamilyApp.Services.UnitTests
{
    [TestClass]
    public class BranchRepositoryTests
    {
        private readonly IBranchService _branchService;

        public BranchRepositoryTests()
        {
            var testRepo = new TestRepository<Branch>();
            this._branchService = new BranchService(testRepo);
        }

        [TestMethod]
        public void GetShouldReturnValidResult()
        {
            var result = _branchService.GetAllBranches();

            result.Should().NotBeNullOrEmpty();
        }

        [TestMethod]
        public void GetBranchByUserNAmeShouldReturnValidResult()
        {
            var result = this._branchService.GetBranchByUserName("awedupe07@gmail.com");

            Assert.AreEqual(1, result.Id);
        }
    }
}