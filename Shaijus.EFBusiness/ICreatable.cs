﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaijus.EFBusiness
{
    public interface ICreatable
    {
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
    }
}
