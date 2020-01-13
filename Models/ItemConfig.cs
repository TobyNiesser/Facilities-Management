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

        [Display(Name = "Selected Items")]
        public string Items_csv { get; set; }
        
        [ForeignKey("Office")]
        public int? OfficeID { get; set; }
        public Office Office { get; set; }

        [ForeignKey("Item")]
        public int? ItemID { get; set; }
        public Item Item { get; set; }
        
        public class Items
        {
            public ICollection<string> MyItems { get; set; }
        }
        
        public class IsSelected
        {
            public bool ItemID { get; set; }
        }
    }
    
    public class ItemList
    {
        public List<Item> Items { get; set; }
    }

}
