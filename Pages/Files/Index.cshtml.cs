using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Pages.Files
{
    public class IndexModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public IndexModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }

        
        public new IList<File> File { get;set; }

        public async Task OnGetAsync()
        {
            File = await _context.File.ToListAsync();
        }
    }
}
