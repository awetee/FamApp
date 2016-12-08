using System.Collections.Generic;
using Tee.FamilyApp.Common.Core.Enums;

namespace Tee.FamilyApp.Common.Core.Entities
{
    public class Branch : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Username { get; set; }
        public virtual BirthDetail BirthDetail { get; set; }
        public virtual ICollection<Link> Links { get; set; }
        public virtual ICollection<Invite> Invites { get; set; }
    }
}