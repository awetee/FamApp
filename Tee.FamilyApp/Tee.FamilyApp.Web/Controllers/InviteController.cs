using System.Collections.Generic;
using System.Web.Mvc;
using Tee.FamilyApp.Common.Entities;
using Tee.FamilyApp.Services;

namespace Tee.FamilyApp.Web.Controllers
{
    [Authorize]
    public class InviteController : Controller
    {
        private readonly IInviteService _inviteService;

        public InviteController(IInviteService invitationService)
        {
            this._inviteService = invitationService;
        }

        [HttpGet]
        public IEnumerable<Invite> GetPendingInvitesForBranch(int branchId)
        {
            return _inviteService.GetPendingReceivedInvitesByBranch(branchId);
        }

        [HttpGet]
        public ActionResult SendInvite()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendInvite(Invite model)
        {
            ModelState.Remove("BranchName");

            if (!ModelState.IsValid)
            {
                this.ViewBag.ErrorMessage = "Invalid entries";
                return RedirectToAction("SendInvite", model);
            }

            var result = this._inviteService.SendInvitation(model, User.Identity.Name);

            if (result.Succeded)
            {
                return RedirectToAction("SendInviteConfirmation");
            }

            this.ModelState.AddModelError("model", result.Messages[0]);

            return RedirectToAction("SendInvite", model);
        }

        public ActionResult SendInviteConfirmation()
        {
            return View();
        }
    }
}