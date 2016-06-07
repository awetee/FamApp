namespace Tee.FamilyApp.DAL.Entities
{
    using System.Collections.Generic;
    using Tee.FamilyApp.Common.Enums;

    public class Branch : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public List<Link> Links { get; set; }
        public BirthDetail BirthDetail { get; set; }
    }
}