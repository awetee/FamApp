using Tee.FamilyApp.Common.Enums;

namespace Tee.FamilyApp.Common.Entities
{
    public class Invite : BaseEntity
    {
        public Invite()
        {
            Type = InviteType.Branch;
        }

        public InviteType Type { get; set; }
        public LinkType LinkType { get; set; }
        public InviteStatus Status { get; set; }
        public int InvitedBranchId { get; set; }
        public string EmailAddress { get; set; }
        public int BranchId { get; set; }
    }
}