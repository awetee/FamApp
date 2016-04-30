using System;
using System.Collections.Generic;
using Tee.FamilyApp.Common.Enums;

namespace Tee.FamilyApp.Common.Models
{
    public class BranchViewModel : BaseViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public ICollection<LinkViewModel> Links { get; set; }
        public BirthDetailViewModel BirthDetail { get; set; }

        public int Age
        {
            get
            {
                return this.GetAge();
            }
        }

        private int GetAge()
        {
            var birthYear = this.BirthDetail.DateOfBirth.Year;
            var birthMonth = this.BirthDetail.DateOfBirth.Month;
            var today = DateTime.Today;

            var age = today.Year - birthYear;

            if (birthMonth > today.Month)
            {
                age--;
            }

            return age;
        }
    }
}