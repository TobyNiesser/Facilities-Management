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
    public class DetailsModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public DetailsModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }

        public Setting Setting { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Setting = await _context.Setting
                .Include(s => s.Company)
                .Include(s => s.Frequency)
                .Include(s => s.Item)
                .Include(s => s.Office)
                .Include(s => s.Responsibility)
                .Include(s => s.Status).FirstOrDefaultAsync(m => m.SettingID == id);

            if (Setting == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
