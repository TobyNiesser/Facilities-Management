using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FACILITIES.Models
{
    public class Responsibility
    {
        public int ResponsibilityID { get; set; }
        public string Name { get; set; }

        public ICollection<Setting> Settings { get; set; }

    }
}
