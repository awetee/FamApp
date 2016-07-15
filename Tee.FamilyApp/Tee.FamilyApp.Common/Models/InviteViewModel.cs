using System.ComponentModel.DataAnnotations;
using Tee.FamilyApp.Common.Enums;

namespace Tee.FamilyApp.Common.Models
{
    public class InviteViewModel
    {
        public int BranchId { get; set; }

        public int InvitedBranchId { get; set; }

        public int MyProperty { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public LinkType LinkType { get; set; }
    }
}