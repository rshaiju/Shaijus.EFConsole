using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaijus.EFBusiness
{
    public class Teacher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int TeachesInId { get; set; }

        [ForeignKey("TeachesInId")]
        public StudyClass TeachesIn { get; set; }

        public int GraduatedFromCollegeId { get; set; }

        [ForeignKey("GraduatedFromCollegeId")]
        public College GraduatedFrom { get; set; }
    }
}
