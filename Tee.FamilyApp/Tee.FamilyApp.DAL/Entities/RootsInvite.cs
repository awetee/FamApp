namespace Tee.FamilyApp.DAL.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(name: "RootsInvite")]
    public class RootsInvite : Invite
    {
        public int InvitedBranchId { get; set; }
    }
}