namespace Tee.FamilyApp.DAL.Entities
{
    using Tee.FamilyApp.Common.Enums;

    public class Link : BaseEntity
    {
        public int BranchID { get; set; }
        public int LinkBranchID { get; set; }
        public LinkType LinkType { get; set; }
    }
}