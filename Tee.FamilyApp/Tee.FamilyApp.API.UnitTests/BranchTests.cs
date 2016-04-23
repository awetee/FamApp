using NSubstitute;
using NUnit.Framework;

namespace Tee.FamilyApp.Tests
{
    [TestFixture]
    public class BranchTest
    {
        private IBranchService branchService;
        private Branch sut;

        [SetUp]
        public void Setup()
        {
            branchService = Substitute.For<IBranchService>();
            sut = new Branch(branchService);
        }

        [Test]
        public void ShouldSendAnInvite()
        {
            sut.SendFamilyInvite();

            branchService.Received().SendInviteNotification(sut.BranchId);
        }

        [Test]
        public void ShouldReturnAllFamilyMembers()
        {
            sut.GetFamilyMembers();
            branchService.Received().GetRelatedBranchs(sut.BranchId);
        }
    }
}