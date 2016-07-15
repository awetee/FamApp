using System.Collections.Generic;
using System.Web.Mvc;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.Services;

namespace Tee.FamilyApp.Web.Controllers
{
    [Authorize]
    public class InviteController : Controller
    {
        private readonly IInviteService InviteService;

        public InviteController(IInviteService invitationService)
        {
            this.InviteService = invitationService;
        }

        public InviteController() : this(new InviteService())
        {
        }

        public IEnumerable<Invite> GetPendingInvitesForBranch(int branchId)
        {
            return InviteService.GetPendingReceivedInvitesByBranch(branchId);
        }

        public ActionResult SendInvite()
        {
            return View();
        }

        public ActionResult Index()
        {
            var model = this.InviteService.GetPendingInvitesForUser(this.User.Identity.Name);
            return this.View(model);
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

            var result = this.InviteService.SendInvitation(model, User.Identity.Name);

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