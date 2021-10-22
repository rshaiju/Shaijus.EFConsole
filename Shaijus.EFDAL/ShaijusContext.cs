using Shaijus.EFBusiness;
using System;
using System.Data.Entity;

namespace Shaijus.EFDAL
{
    public class ShaijusContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<StudyClass> StudyClass { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<College> Colleges { get; set; }

        public DbSet<City> Cities { get; set; }


        public ShaijusContext()
        {
            //Database.Log = Console.WriteLine;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new CheckAndMigrateDatabaseToLatestVersion());
            modelBuilder.Properties<string>().Configure(x => { x.HasColumnType("nvarchar"); x.IsUnicode(true); });

            base.OnModelCreating(modelBuilder);
        }
    }
}
