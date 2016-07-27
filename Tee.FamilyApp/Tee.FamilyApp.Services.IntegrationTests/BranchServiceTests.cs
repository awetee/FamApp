using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Tee.FamilyApp.Common.Entities;
using Tee.FamilyApp.Common.Interfaces;
using Tee.FamilyApp.DAL.Repository;

namespace Tee.FamilyApp.Services.UnitTests
{
    [TestClass]
    public class BranchServiceTests
    {
        private readonly IBranchService _branchService;
        private readonly IRepository<Branch> branchRepository;

        public BranchServiceTests()
        {
            var ctx = Substitute.For<IDbContext>();
            this.branchRepository = Substitute.For<IRepository<Branch>>();

            this._branchService = new BranchService(branchRepository);
        }

        [TestMethod]
        public void GetShouldReturnValidResult()
        {
            // Arrange
            this.branchRepository.GetAll().Returns(new List<Branch>());

            // Act
            var result = _branchService.GetAllBranches();

            // Assert
            result.Should().NotBeNull();
        }

        [TestMethod]
        public void GetBranchByUserNAmeShouldReturnValidResult()
        {
            // Arrange
            var userName = "test@gmail.com";

            var expected = new Branch
            {
                Username = userName,
            };

            this.branchRepository.GetAll().Returns(new List<Branch>
            {
                expected
            });

            // Act
            var result = this._branchService.GetBranchByUserName(userName);

            // Assert
            Assert.AreEqual(expected.Username, result.Username);
        }
    }
}