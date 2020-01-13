using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FACILITIES.Models
{
    public class File
    {
        public int FileID { get; set; }

        [Display(Name = "File Name")]
        public string FileName { get; set; }

        [Display(Name = "Mime Type")]
        public string MimeType { get; set; }

        public string Extension { get; set; }

        [Display(Name = "File Size")]
        public string FileSize { get; set; }

        [Display(Name = "Store Location")]
        public string StoreLocation { get; set; }

        public string TestColumn { get; set; }
    }
}
