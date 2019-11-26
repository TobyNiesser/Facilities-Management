using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FACILITIES.Models
{
    public class Manager
    {
        public int ManagerID { get; set; }

        [Display(Name = "Manager Name")]
        public string UserName { get; set; }

        [Display(Name = "Manager Email")]
        public string UserEmail { get; set; }

        [ForeignKey("Company")]
        public int? CompanyID { get; set; }
        public Company Company { get; set; }

        [ForeignKey("Permission")]
        public int? PermissionID { get; set; }
        public Permission Permission { get; set; }
        
    }
}
