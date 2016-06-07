namespace Tee.FamilyApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DisabledEF : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BirthDetail", "Id", "dbo.Branch");
            DropForeignKey("dbo.Link", "Branch_Id", "dbo.Branch");
            DropIndex("dbo.BirthDetail", new[] { "Id" });
            DropIndex("dbo.Link", new[] { "Branch_Id" });
            DropTable("dbo.BirthDetail");
            DropTable("dbo.Branch");
            DropTable("dbo.Link");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Link",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RalatedBranchId = c.Int(nullable: false),
                        LinkType = c.Int(nullable: false),
                        Branch_Id = c.Int(nullable: false),
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
                    })
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Link", "Branch_Id");
            CreateIndex("dbo.BirthDetail", "Id");
            AddForeignKey("dbo.Link", "Branch_Id", "dbo.Branch", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BirthDetail", "Id", "dbo.Branch", "Id");
        }
    }
}
