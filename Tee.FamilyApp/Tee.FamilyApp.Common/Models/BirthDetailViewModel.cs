using System;

namespace Tee.FamilyApp.Common.Models
{
    public class BirthDetailViewModel : BaseViewModel
    {
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Province { get; set; }
        public string Town { get; set; }
        public BranchViewModel Branch { get; set; }
    }
}