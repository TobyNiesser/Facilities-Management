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

        
        [Display(Name = "Office Name")]
        public string Name { get; set; }

        
        [Display(Name = "Address Line 1")]
        public string Addr1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string Addr2 { get; set; }

        
        public string Town { get; set; }

        
        public string City { get; set; }

        
        public string Postcode { get; set; }

        
        public string Country { get; set; }

        
        public string Telephone { get; set; }

        
        [Display(Name = "Tenant Name")]
        public string LandlordName { get; set; }

        
        [Display(Name = "Landlord Email")]
        public string LandlordEmail { get; set; }

        [Display(Name = "Landlord Telephone")]
        public int LandlordTelephone { get; set; }
        
        [ForeignKey("Company")]
        public int? CompanyID { get; set; }
        public Company Company { get; set; }

        
        [ForeignKey("Manager")]
        public int? ManagerID { get; set; }
        public Manager Manager { get; set; }
        
        
        [ForeignKey("Item")]
        public int? ItemID { get; set; }
        public Item Item { get; set; }
        
        public ICollection<Setting> Settings { get; set; }
        public ICollection<Manager> Managers { get; set; }

        
    }
   
    
}


