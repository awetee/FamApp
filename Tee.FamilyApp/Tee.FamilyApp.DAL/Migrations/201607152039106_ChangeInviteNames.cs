namespace Tee.FamilyApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeInviteNames : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.PublicInvite", newName: "EmailInvite");
            CreateTable(
                "dbo.BranchInvite",
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
            
            DropTable("dbo.RootsInvite");
        }
        
        public override void Down()
        {
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
            
            DropTable("dbo.BranchInvite");
            RenameTable(name: "dbo.EmailInvite", newName: "PublicInvite");
        }
    }
}
