using Tee.FamilyApp.Common.Core.Enums;

namespace Tee.FamilyApp.Common.Core.Models
{
    public class LinkViewModel : BaseViewModel
    {
        public int RalatedBranchId { get; set; }
        public LinkType LinkType { get; set; }
        public BranchViewModel Branch { get; set; }
    }
}