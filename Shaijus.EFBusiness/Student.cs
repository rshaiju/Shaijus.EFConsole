using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaijus.EFBusiness
{
    public class Student : EntityBase
    {
        public string Name { get; set; }
        
        public long StudyClassId { get; set; }

        [ForeignKey("StudyClassId")]
        public StudyClass StudiesIn { get; set; }

    }
}
