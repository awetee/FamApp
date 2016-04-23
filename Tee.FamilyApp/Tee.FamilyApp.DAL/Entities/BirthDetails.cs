namespace Tee.FamilyApp.DAL.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class BirthDetail : BaseEntity
    {
        //public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }

        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Province { get; set; }
        public string Town { get; set; }
    }
}