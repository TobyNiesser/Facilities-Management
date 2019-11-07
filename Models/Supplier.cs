using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FACILITIES.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public int SupplierOptions { get; set; }
    }
}
