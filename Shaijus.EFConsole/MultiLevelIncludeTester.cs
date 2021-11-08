using Shaijus.EFDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Shaijus.EFConsole
{
    static class MultiLevelIncludeTester
    {
        public static void Test()
        {
            using (ShaijusContext context = new ShaijusContext())
            {
                var student = context.Students
                    .Include(s => s.StudiesIn)
                    .Include(s => s.StudiesIn.Teachers)
                    .Include(s => s.StudiesIn.Teachers.Select(t => t.GraduatedFrom))
                    //.Include(s => s.StudiesIn.Teachers.Select(t => t.GraduatedFrom.LocatedInCity))
                    .FirstOrDefault();


                //Console.WriteLine(student.StudiesIn.Teachers.FirstOrDefault().GraduatedFrom.LocatedInCity.Name);
            }
        }
    }
}
