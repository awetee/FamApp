namespace Tee.FamilyApp.DAL.Entities
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
        public virtual ICollection<Link> Links { get; internal set; }
        public virtual ICollection<Invite> Invites { get; internal set; }
    }
}