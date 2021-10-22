﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaijus.EFBusiness
{
    public  class StudyClass : EntityBase
    {
        public string Name { get; set; }

        public IList<Teacher> Teachers { get; set; }

        public IList<Student> Students { get; set; }
    }
}
