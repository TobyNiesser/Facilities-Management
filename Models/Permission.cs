using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FACILITIES.Models
{
    public class Permission
    {
        public int PermissionID { get; set; }
        public string Name { get; set; }
        public string AccountType { get; set; }

        public ICollection<Manager> Managers { get; set; }

    }
}
