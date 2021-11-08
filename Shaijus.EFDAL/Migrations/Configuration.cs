namespace Shaijus.EFDAL.Migrations
{
    using MySql.Data.EntityFramework;
    using System.Configuration;
    using System.Data.Entity.Migrations;
    using EFBusiness;
    using System.Diagnostics;
    using System.Linq;

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
            var city = new City { Name = "Palakkad" };
            context.Cities.AddOrUpdate(c => c.Name, city);
            context.SaveChanges();

            var studyClass = new StudyClass { Name = "Life" };
            context.StudyClass.AddOrUpdate(x => x.Name, studyClass);
            context.SaveChanges();

            var college = new College { Name = "Victoria" };
            college.IsActive = true;
            college.CityId = context.Cities.Where(c => c.Name == "Palakkad").FirstOrDefault().Id;
            context.Colleges.AddOrUpdate(x => x.Name, college);
            context.SaveChanges();


            var student = new Student {Name = "Shaiju" };
            student.StudyClassId = context.StudyClass.Where(c=>c.Name=="Life").FirstOrDefault().Id;
            context.Students.AddOrUpdate(x => x.Name, student);
            context.SaveChanges();

            var teacher = new Teacher {Name = "Rajan" };
            teacher.TeachesInId = context.StudyClass.Where(c => c.Name == "Life").FirstOrDefault().Id;
            teacher.GraduatedFromCollegeId = context.Colleges.Where(c => c.Name == "Victoria").FirstOrDefault().Id;
            context.Teachers.AddOrUpdate(x => x.Name, teacher);
            context.SaveChanges();
        }
    }
}
