namespace Tee.FamilyApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BirthDetail",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Country = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Province = c.String(),
                        Town = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Branch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Link",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BranchID = c.Int(nullable: false),
                        LinkBranchID = c.Int(nullable: false),
                        LinkType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.BranchID, cascadeDelete: true)
                .Index(t => t.BranchID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Link", "BranchID", "dbo.Branch");
            DropForeignKey("dbo.BirthDetail", "Id", "dbo.Branch");
            DropIndex("dbo.Link", new[] { "BranchID" });
            DropIndex("dbo.BirthDetail", new[] { "Id" });
            DropTable("dbo.Link");
            DropTable("dbo.Branch");
            DropTable("dbo.BirthDetail");
        }
    }
}
