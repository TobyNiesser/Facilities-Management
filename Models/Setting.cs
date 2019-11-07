using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FACILITIES.Models
{
    public class Setting
    {
        public int SettingID { get; set; }

        [ForeignKey("Office")]
        public int OfficeID { get; set; }
        public Office Office { get; set; }

        [ForeignKey("Item")]
        public int ItemID { get; set; }
        public Item Item { get; set; }
    
        public DateTime DueDate { get; set; }
        [DataType(DataType.Date)]

        public DateTime NextDate { get; set; }
        [DataType(DataType.Date)]

        [ForeignKey("Frequency")]
        public int FrequencyID { get; set; }
        public Frequency Frequency { get; set; }

        [ForeignKey("Company")]
        public int CompanyID { get; set; }
        public Company Company { get; set; }

        [ForeignKey("Responsibility")]
        public int ResponsibilityID { get; set; }
        public Responsibility Responsibility { get; set; }

        [ForeignKey("Status")]
        public int StatusID { get; set; }
        public Status Status { get; set; }

        public string Comment { get; set; }
    }
}
