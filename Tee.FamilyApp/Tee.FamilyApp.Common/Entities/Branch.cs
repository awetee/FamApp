namespace Tee.FamilyApp.Common.Entities
{
    using System.Collections.Generic;
    using Tee.FamilyApp.Common.Enums;

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