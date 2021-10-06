using Shaijus.EFBusiness;
using System.Data.Entity;

namespace Shaijus.EFDAL
{
    public class ShaijusContext:DbContext
    {
        public DbSet<Box> Boxes { get; set; }

        public DbSet<Cylinder> Cylinders { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new CheckAndMigrateDatabaseToLatestVersion());
            modelBuilder.Properties<string>().Configure(x => { x.HasColumnType("nvarchar"); x.IsUnicode(true); });
            base.OnModelCreating(modelBuilder);
        }
    }
}
