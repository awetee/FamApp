using System.Collections.Generic;
using Tee.FamilyApp.Common.Enums;
using Tee.FamilyApp.DAL.Entities;

namespace Tee.FamilyApp.DAL
{
    internal class RootInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<RootContext>
    {
        protected override void Seed(RootContext context)
        {
            base.Seed(context);
        }
    }
}