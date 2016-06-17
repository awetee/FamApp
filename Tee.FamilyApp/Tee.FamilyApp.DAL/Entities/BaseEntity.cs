using System;

namespace Tee.FamilyApp.DAL.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; internal set; }
        public DateTime? DateModified { get; internal set; }
    }
}