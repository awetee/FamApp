namespace Tee.FamilyApp.DAL.Entities
{
    using Common.Enums;

    public class Link : BaseEntity
    {
        public LinkType LinkType { get; set; }
        public int BranchId { get; set; }
        public int RalatedBranchId { get; set; }
    }
}