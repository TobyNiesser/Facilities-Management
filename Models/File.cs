using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FACILITIES.Models
{
    public class File
    {
        public int FileID { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public string Extension { get; set; }
        public string FileSize { get; set; }
        public string StoreLocation { get; set; }
    }
}
