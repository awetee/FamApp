namespace Tee.FamilyApp.DAL.Entities
{
    using Tee.FamilyApp.Common.Enums;

    public class Link : BaseEntity
    {
        public int RalatedBranchId { get; set; }
        public LinkType LinkType { get; set; }
        public Branch Branch { get; set; }
    }
}