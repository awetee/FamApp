namespace Tee.FamilyApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BirthDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Province = c.String(),
                        Town = c.String(),
                        BranchId = c.Byte(nullable: false),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Branch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.Int(nullable: false),
                        Username = c.String(),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                        BirthDetail_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BirthDetail", t => t.BirthDetail_Id)
                .Index(t => t.BirthDetail_Id);
            
            CreateTable(
                "dbo.Invite",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        LinkType = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        InvitedBranchId = c.Int(nullable: false),
                        EmailAddress = c.String(),
                        BranchId = c.Int(nullable: false),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.BranchId, cascadeDelete: true)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.Link",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LinkType = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        RalatedBranchId = c.Int(nullable: false),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.BranchId, cascadeDelete: true)
                .Index(t => t.BranchId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Link", "BranchId", "dbo.Branch");
            DropForeignKey("dbo.Invite", "BranchId", "dbo.Branch");
            DropForeignKey("dbo.Branch", "BirthDetail_Id", "dbo.BirthDetail");
            DropIndex("dbo.Link", new[] { "BranchId" });
            DropIndex("dbo.Invite", new[] { "BranchId" });
            DropIndex("dbo.Branch", new[] { "BirthDetail_Id" });
            DropTable("dbo.Link");
            DropTable("dbo.Invite");
            DropTable("dbo.Branch");
            DropTable("dbo.BirthDetail");
        }
    }
}
