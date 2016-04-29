using Tee.FamilyApp.DAL.Entities;

namespace Tee.FamilyApp.DAL
{
    public class RootInitialiser : System.Data.Entity.CreateDatabaseIfNotExists<RootContext>
    {
        protected override void Seed(RootContext context)
        {
            base.Seed(context);
        }
    }
}