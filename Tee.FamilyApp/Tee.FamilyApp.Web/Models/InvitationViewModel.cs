using System.ComponentModel.DataAnnotations;
using Tee.FamilyApp.Common.Enums;

namespace Tee.FamilyApp.Web.Controllers
{
    public class InviteViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public LinkType LinkType { get; set; }
    }
}