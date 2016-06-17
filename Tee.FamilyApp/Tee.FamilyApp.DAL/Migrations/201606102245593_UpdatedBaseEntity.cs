namespace Tee.FamilyApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedBaseEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BirthDetail", "DateCreated", c => c.DateTime());
            AddColumn("dbo.BirthDetail", "DateModified", c => c.DateTime());
            AddColumn("dbo.Branch", "DateCreated", c => c.DateTime());
            AddColumn("dbo.Branch", "DateModified", c => c.DateTime());
            AddColumn("dbo.Link", "DateCreated", c => c.DateTime());
            AddColumn("dbo.Link", "DateModified", c => c.DateTime());
            AddColumn("dbo.Invite", "DateCreated", c => c.DateTime());
            AddColumn("dbo.Invite", "DateModified", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Invite", "DateModified");
            DropColumn("dbo.Invite", "DateCreated");
            DropColumn("dbo.Link", "DateModified");
            DropColumn("dbo.Link", "DateCreated");
            DropColumn("dbo.Branch", "DateModified");
            DropColumn("dbo.Branch", "DateCreated");
            DropColumn("dbo.BirthDetail", "DateModified");
            DropColumn("dbo.BirthDetail", "DateCreated");
        }
    }
}
