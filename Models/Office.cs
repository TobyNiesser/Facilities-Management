using System;
using System.Collections.Generic;
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
        public int CompanyID { get; set; }
        public int ManagerID { get; set; }
    }
}
