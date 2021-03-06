﻿using System;
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

        [Required]
        [Display(Name = "Office Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Tenant Name")]
        public string LandlordName { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public string Addr1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string Addr2 { get; set; }

        
        public string Town { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Postcode { get; set; }

        [Display(Name = "County")]
        public string Country { get; set; }

        [Display(Name = "Comments")]
        public string Telephone { get; set; }

        
        [Display(Name = "Landlord Email")]
        public string LandlordEmail { get; set; }

        [Display(Name = "Landlord Telephone")]
        public int LandlordTelephone { get; set; }

        [Display(Name = "Office Dimension Sq.ft")]
        public int Sqft { get; set; }

        [Display(Name = "Lease Date Start")]
        [DataType(DataType.Date)]
        public DateTime LeaseDate { get; set; }

        [Display(Name = "Lease End / Review")]
        [DataType(DataType.Date)]
        public DateTime LeaseEndReview { get; set; }

        [Display(Name = "Notice Period")]
        public String NoticePeriod { get; set; }

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


