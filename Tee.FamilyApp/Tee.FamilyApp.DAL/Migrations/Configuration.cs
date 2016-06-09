namespace Tee.FamilyApp.DAL.Migrations
{
    using System.Data.Entity.Migrations;
    using Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<RootContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RootContext context)
        {
        }
    }
}