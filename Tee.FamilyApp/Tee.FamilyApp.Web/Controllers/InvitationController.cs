using System.Web.Mvc;
using Tee.FamilyApp.Common;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.Services;

namespace Tee.FamilyApp.Web.Controllers
{
    public class InvitationController : Controller
    {
        private readonly IBranchService BranchService;
        private readonly IInviteService InvitationService;

        public InvitationController()
        {
            this.InvitationService = new InviteService();
            this.BranchService = new BranchService();
        }

        [Authorize]
        // GET: Invitations
        public ActionResult SendInvite()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult SendInvite(InviteViewModel model)
        {
            ModelState.Remove("BranchName");

            if (!ModelState.IsValid)
            {
                this.ViewBag.ErrorMessage = "Invalid entries";
                return RedirectToAction("SendInvite", model);
            }

            Invite invite = MapToInvite(model);

            var inviteSent = this.InvitationService.SendInvitation(invite);

            if (inviteSent)
            {
                return RedirectToAction("SendInviteConfirmation");
            }

            this.ViewBag.ErrorMessage = "Unable to send invite";

            return RedirectToAction("SendInvite", model);
        }

        public ActionResult SendInviteConfirmation()
        {
            return View();
        }

        private Invite MapToInvite(InviteViewModel model)
        {
            var branch = this.BranchService.GetBranchByUserName(User.Identity.Name);

            // we probably need an auto mapper here
            var invite = new Invite
            {
                BranchId = branch.Id,
                EmailAddress = model.Email,
                LinkType = model.LinkType,
                Status = InviteStatus.Sent
            };

            return invite;
        }
    }
}