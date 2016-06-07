using System.Collections.Generic;
using Tee.FamilyApp.Common.Enums;

namespace Tee.FamilyApp.Common.Models
{
    public class BranchViewModel : BaseViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public List<LinkViewModel> Links { get; set; }
        public BirthDetailViewModel BirthDetail { get; set; }
    }
}