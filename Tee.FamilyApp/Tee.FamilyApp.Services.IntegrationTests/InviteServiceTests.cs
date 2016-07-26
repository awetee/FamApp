using NSubstitute;
using NUnit.Framework;
using Tee.FamilyApp.Common.Enums;
using Tee.FamilyApp.Common.Interfaces;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.DAL.Repository;
using Tee.FamilyApp.Services;

namespace Tee.FamilyApp.Web.Controllers.Tests
{
    [TestFixture]
    public class InvitationServiceTests
    {
        private IRepository<Invite> inviteRepository;
        private InviteService _inviteService;

        [SetUp]
        public void Setup()
        {
            var ctx = Substitute.For<IDbContext>();
            this.inviteRepository = Substitute.For<IRepository<Invite>>();

            this._inviteService = new InviteService(inviteRepository);
        }

        [Test]
        public void SendInvitationTest()
        {
            // Arrange
            var invite = new Invite
            {
                EmailAddress = "Test@email.com",
                LinkType = LinkType.Sibling,
                BranchId = 1,
            };

            //var expected = true;

            this.inviteRepository.Add(invite).Returns(1);

            // Act
            //var actual = this._inviteService.SendInvitation(invite);

            // Assert
            //actual.Succeded.ShouldBeEquivalentTo(expected);
        }
    }
}