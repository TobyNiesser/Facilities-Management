using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FACILITIES.Models
{
    public class Setting
    {
        public int SettingID { get; set; }
        public int OfficeID { get; set; }
        public int ItemID { get; set; }
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime NextDate { get; set; }
        public int FrequencyID { get; set; }
        public int CompanyID { get; set; }
        public int ResponsibilityID { get; set; }
        public int StatusID { get; set; }
        public string Comment { get; set; }
    }
}
