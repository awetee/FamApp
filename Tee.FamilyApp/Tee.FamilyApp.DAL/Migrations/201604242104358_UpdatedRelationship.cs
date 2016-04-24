namespace Tee.FamilyApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedRelationship : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Link", name: "BranchID", newName: "Branch_Id");
            RenameIndex(table: "dbo.Link", name: "IX_BranchID", newName: "IX_Branch_Id");
            AddColumn("dbo.Link", "RalatedBranchId", c => c.Int(nullable: false));
            DropColumn("dbo.Link", "LinkBranchID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Link", "LinkBranchID", c => c.Int(nullable: false));
            DropColumn("dbo.Link", "RalatedBranchId");
            RenameIndex(table: "dbo.Link", name: "IX_Branch_Id", newName: "IX_BranchID");
            RenameColumn(table: "dbo.Link", name: "Branch_Id", newName: "BranchID");
        }
    }
}
