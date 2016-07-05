using Tee.FamilyApp.Common;
using Tee.FamilyApp.Common.Enums;

namespace Tee.FamilyApp.DAL.Entities
{
    public class Invite : BaseEntity
    {
        public int BranchId { get; set; }
        public LinkType LinkType { get; set; }
        public InviteStatus Status { get; set; }
    }
}