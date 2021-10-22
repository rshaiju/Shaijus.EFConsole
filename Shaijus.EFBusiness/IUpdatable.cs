using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaijus.EFBusiness
{
    public interface IUpdatable
    {
        DateTime? LastModifiedDate { get; set; }

        string LastModifiedBy { get; set; }
    }
}
