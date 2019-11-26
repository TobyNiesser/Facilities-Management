using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace FACILITIES.Models
{
    public class Status
    {
        public int StatusID { get; set; }

        [Display(Name = "Status Indicator")]
        public string StatusIndicator { get; set; }

        public ICollection<Setting> Settings { get; set; }

    }


}
