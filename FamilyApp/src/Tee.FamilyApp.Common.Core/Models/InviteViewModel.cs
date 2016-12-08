using Tee.FamilyApp.Common.Core.Enums;

namespace Tee.FamilyApp.Common.Core.Models
{
    public class InviteViewModel
    {
        public int BranchId { get; set; }

        public int InvitedBranchId { get; set; }
        public string Email { get; set; }
        public LinkType LinkType { get; set; }
    }
}