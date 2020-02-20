using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FACILITIES.Models
{
    public class Company
    {
        public int CompanyID { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        public string Name { get; set; }

        public string Description { get; set; }

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

        [Required]
        public string County { get; set; }

        public string Telephone { get; set; }


        [Display(Name = "VAT No.")]
        public string VatNumber { get; set; }


        public string Website { get; set; }

        [Required]
        [Display(Name = "Approved Supplier?")]
        public bool ApprovedSupplier { get; set; }

        [ForeignKey("Office")]
        public int? OfficeID { get; set; }
        public Office Office { get; set; }

        public ICollection<Setting> Settings { get; set; }


    }
}
