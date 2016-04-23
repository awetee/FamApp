namespace Tee.FamilyApp.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Tee.FamilyApp.Common.Enums;

    public class Branch : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public virtual ICollection<Link> Links { get; set; }
        public virtual BirthDetail BirthDetail { get; set; }

        //public int Age
        //{
        //    get
        //    {
        //        return this.GetAge();
        //    }
        //}

        //private int GetAge()
        //{
        //    var birthYear = this.BirthDetails.DateOfBirth.Year;
        //    var birthMonth = this.BirthDetails.DateOfBirth.Month;
        //    var today = DateTime.Today;

        //    var age = today.Year - birthYear;

        //    if (birthMonth > today.Month)
        //    {
        //        age--;
        //    }

        //    return age;
        //}
    }
}