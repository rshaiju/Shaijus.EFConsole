namespace Shaijus.EFDAL.Migrations
{
    using MySql.Data.EntityFramework;
    using System.Configuration;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<Shaijus.EFDAL.ShaijusContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            
            switch (ConfigurationManager.ConnectionStrings["ShaijusContext"]?.ProviderName)
            {
                case "MySql.Data.MySqlClient":
                    SetSqlGenerator("MySql.Data.MySqlClient", new MySqlMigrationSqlGenerator());
                    break;
            }
        }

        protected override void Seed(Shaijus.EFDAL.ShaijusContext context)
        {
            context.Boxes.AddOrUpdate(new EFBusiness.Box { Id = 1, Length = 10, Width = 10, Height = 10 });
            context.Cylinders.AddOrUpdate(new EFBusiness.Cylinder { Id = 1, Height = 20, Radius = 30 });
            context.SaveChanges();
        }
    }
}
