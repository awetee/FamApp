using Tee.FamilyApp.Common.Core.Enums;

namespace Tee.FamilyApp.Common.Core.Entities
{
    public class Link : BaseEntity
    {
        public LinkType LinkType { get; set; }
        public int BranchId { get; set; }
        public int RalatedBranchId { get; set; }
    }
}