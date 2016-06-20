using System.Collections.Generic;
using System.Web.Mvc;
using Tee.FamilyApp.Common.Models;
using Tee.FamilyApp.Services;

namespace Tee.FamilyApp.Web.Controllers
{
    [Authorize]
    public class BranchController : Controller
    {
        private readonly IBranchService BranchService;

        public BranchController(IBranchService branchService)
        {
            BranchService = branchService;
        }

        public BranchController() : this(new BranchService())
        {
        }

        public ActionResult Index()
        {
            var model = GetBranches();

            return View(model);
        }

        public ActionResult ProfilePage(int id)
        {
            var branch = this.BranchService.GetBranch(id);
            BranchViewModel model = MapToViewmodel(branch);
            return View(model);
        }

        private static BranchViewModel MapToViewmodel(DAL.Entities.Branch branch)
        {
            return new BranchViewModel
            {
                Id = branch.Id,
                FirstName = branch.FirstName,
                LastName = branch.LastName
            };
        }

        private List<BranchViewModel> GetBranches()
        {
            var model = new List<BranchViewModel>();

            var branches = BranchService.GetAllBranches();

            foreach (var branch in branches)
            {
                var item = MapToViewmodel(branch);

                model.Add(item);
            }

            return model;
        }
    }
}