namespace Tee.FamilyApp.DAL.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(name: "PublicInvite")]
    public class PublicInvite : Invite
    {
        public string EmailAddress { get; set; }
    }
}