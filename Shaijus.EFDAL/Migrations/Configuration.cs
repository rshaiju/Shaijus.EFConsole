namespace Shaijus.EFDAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Shaijus.EFDAL.ShaijusContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Shaijus.EFDAL.ShaijusContext context)
        {
            context.Boxes.AddOrUpdate(new EFBusiness.Box { Id = 1, Length = 10, Width = 10, Height = 10 });
            context.Cylinders.AddOrUpdate(new EFBusiness.Cylinder { Id = 1, Height = 20, Radius = 30 });
            context.SaveChanges();
        }
    }
}
