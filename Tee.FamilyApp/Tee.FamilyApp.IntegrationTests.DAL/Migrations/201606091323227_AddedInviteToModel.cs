namespace Tee.FamilyApp.IntegrationTests.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInviteToModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invite",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmailAddress = c.String(),
                        BranchId = c.Int(nullable: false),
                        LinkType = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Invite");
        }
    }
}