using Tee.FamilyApp.Common.Enums;

namespace Tee.FamilyApp.Common.Models
{
    public class LinkViewModel : BaseViewModel
    {
        public int RalatedBranchId { get; set; }
        public LinkType LinkType { get; set; }
        public BranchViewModel Branch { get; set; }
    }
}