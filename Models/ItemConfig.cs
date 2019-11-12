using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FACILITIES.Models
{
    public class ItemConfig
    {
        public int ItemConfigID { get; set; }

        public string Items_csv { get; set; }

        public ICollection<Office> Offices { get; set; }


    }
}
