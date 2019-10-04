using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FACILITIES.Models
{
    public class Manager
    {
        public int ManagerID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public int CompanyID { get; set; }
        public int OfficeID { get; set; }
        public int PermissionID { get; set; }

    }
}
