using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FACILITIES.Models
{
    public class Frequency
    {
        public int FrequencyID { get; set; }
        public string FrequencyAmount { get; set; }

        public ICollection<Setting> Settings { get; set; }


    }
}
