using System;

namespace Tee.FamilyApp.Common.Core.Entities
{
    public class BirthDetail : BaseEntity
    {
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Province { get; set; }
        public string Town { get; set; }
        public byte BranchId { get; set; }
    }
}