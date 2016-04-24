﻿namespace Tee.FamilyApp.DAL.Entities
{
    using System;

    public class BirthDetail : BaseEntity
    {
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Province { get; set; }
        public string Town { get; set; }
        public Branch Branch { get; set; }
    }
}