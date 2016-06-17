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

        public BranchController()
        {
            BranchService = new BranchService();
        }

        // GET: Branch
        public ActionResult Index()
        {
            var model = GetBranches();

            return View(model);
        }

        public ActionResult ProfilePage(int id)
        {
            return View();
        }

        private List<BranchViewModel> GetBranches()
        {
            var model = new List<BranchViewModel>();

            var branches = BranchService.GetAllBranches();

            foreach (var branch in branches)
            {
                var item = new BranchViewModel
                {
                    Id = branch.Id,
                    FirstName = branch.FirstName,
                    LastName = branch.LastName
                };

                model.Add(item);
            }

            return model;
        }
    }
}