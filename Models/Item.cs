using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FACILITIES.Models
{
    public class Item
    {
        public int ItemID { get; set; }

        [Display(Name = "Item Name")]
        public string ItemName { get; set; }

        public ICollection<Setting> Settings { get; set; }
        public ICollection<ItemConfig> ItemConfigs { get; set; }
        public ICollection<Office> Offices { get; set; }


    }
}
