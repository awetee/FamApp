namespace Tee.FamilyApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InviteModelUpdate : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Invite", newName: "PublicInvite");
            CreateTable(
                "dbo.RootsInvite",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvitedBranchId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        LinkType = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RootsInvite");
            RenameTable(name: "dbo.PublicInvite", newName: "Invite");
        }
    }
}
