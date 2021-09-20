using MySql.Data.EntityFramework;
using Shaijus.EFBusiness;
using System.Data.Entity;

namespace Shaijus.EFDAL
{
    public abstract class ShaijusContext:DbContext
    {
        public DbSet<Box> Boxes { get; set; }

        public DbSet<Cylinder> Cylinders { get; set; }

        public ShaijusContext()
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new CheckAndMigrateDatabaseToLatestVersion());
            base.OnModelCreating(modelBuilder);
        }
    }
}
