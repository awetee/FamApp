using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tee.FamilyApp.Common.Enums;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.IntegrationTests.DAL.Repository;
using Tee.FamilyApp.Services;

namespace Tee.FamilyApp.Web.Controllers.Tests
{
    [TestClass]
    public class InvitationServiceTests
    {
        [TestMethod]
        public void SendInvitationTest()
        {
            // Arrange
            var service = new InviteService(new TestRepository<Invite>());
            var invite = new Invite
            {
                EmailAddress = "Test@email.com",
                LinkType = LinkType.Sibling,
                BranchId = 1,
            };
            var expected = true;

            // Act
            var actual = service.SendInvitation(invite);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}