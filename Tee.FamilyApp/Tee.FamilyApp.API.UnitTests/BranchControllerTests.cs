using System.Collections.Generic;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using Tee.FamilyApp.Api.Controllers;
using Tee.FamilyApp.Common.Entities;
using Tee.FamilyApp.Services;

namespace Tee.FamilyApp.Api.UnitTests
{
    [TestFixture]
    public class BranchControllerTests
    {
        public BranchController controller;
        private IBranchService branchService;

        [SetUp]
        public void Setup()
        {
            branchService = Substitute.For<IBranchService>();
            controller = new BranchController(branchService);
        }

        [Test]
        public void GivenThat_GetIsCalledWithoutParameters_GetShouldReturnAListOfBranches()
        {
            // Arrange
            var expected = new List<Branch>
            {
                new Branch()
            };

            this.branchService.GetAllBranches().Returns(expected);

            // Act
            var actual = this.controller.Get();

            // Assert
            actual.ShouldBeEquivalentTo(expected);
        }

        [Test]
        public void GivenThat_GetIsCalledWithAnId_GetShouldReturnABranch()
        {
            // Arrange
            var expected = new Branch();
            this.branchService.GetBranch(1).Returns(expected);

            // Act
            var actual = this.controller.Get(1);

            // Assert
            actual.ShouldBeEquivalentTo(expected);
        }

        [Test]
        public void GivenAValidBranch_PostShouldReturnTrue()
        {
            // Arrange
            var newBranch = new Branch { Id = 1 };
            this.branchService.AddBranch(newBranch).Returns(true);

            // Act
            var actual = this.controller.Post(newBranch);

            // Assert
            actual.Should().BeTrue();
        }

        [Test]
        public void GivenAnInValidBranch_PostShouldReturnFalse()
        {
            // Arrange
            Branch newBranch = null;
            this.branchService.AddBranch(newBranch).Returns(false);

            // Act
            var actual = this.controller.Post(newBranch);

            // Assert
            actual.Should().BeFalse();
        }
    }
}