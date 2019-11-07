using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Pages.Settings
{
    public class IndexModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public IndexModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }

        public IList<Setting> Setting { get;set; }

        public async Task OnGetAsync()
        {
            Setting = await _context.Setting
                .Include(s => s.Company)
                .Include(s => s.Frequency)
                .Include(s => s.Item)
                .Include(s => s.Office)
                .Include(s => s.Responsibility)
                .Include(s => s.Status).ToListAsync();
        }
    }
}
