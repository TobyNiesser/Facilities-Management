using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FACILITIES.Models
{
    public class Office
    {
        public int OfficeID { get; set; }
        public string Name { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Telephone { get; set; }
        public string LandlordName { get; set; }
        public string LandlordEmail { get; set; }
        public int LandlordTelephone { get; set; }

        [ForeignKey("Company")]
        public int? CompanyID { get; set; }
        public Company Company { get; set; }

        [ForeignKey("Manager")]
        public int? ManagerID { get; set; }
        public Manager Manager { get; set; }

        //[ForeignKey("ItemConfig")]
        //public int? ItemConfigID { get; set; }
        //public ItemConfig ItemConfig { get; set; }




        public ICollection<Setting> Settings { get; set; }
        public ICollection<Manager> Managers { get; set; }
        //public ICollection<ItemConfig> ItemConfigs { get; set; }

    }
}


