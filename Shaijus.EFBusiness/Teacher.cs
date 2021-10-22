using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaijus.EFBusiness
{
    public class Teacher : EntityBase
    {
        public string Name { get; set; }

        public long TeachesInId { get; set; }

        [ForeignKey("TeachesInId")]
        public StudyClass TeachesIn { get; set; }

        public long GraduatedFromCollegeId { get; set; }

        [ForeignKey("GraduatedFromCollegeId")]
        public College GraduatedFrom { get; set; }
    }
}
