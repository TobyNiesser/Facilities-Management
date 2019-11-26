using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace FACILITIES.Models
{
    public class Permission
    {
        public int PermissionID { get; set; }

        public string Name { get; set; }

        [Display(Name = "Account Type")]
        public string AccountType { get; set; }

        public ICollection<Manager> Managers { get; set; }

    }
}
