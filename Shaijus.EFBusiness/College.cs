using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaijus.EFBusiness
{
    public class College : EntityBase
    {
        public string Name { get; set; }

        public long CityId { get; set; }

        [ForeignKey("CityId")]
        public City LocatedInCity { get; set; }
    }
}
