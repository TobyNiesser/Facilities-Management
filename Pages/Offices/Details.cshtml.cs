using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Pages.Offices
{
    public class DetailsModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public DetailsModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }

        public Office Office { get; set; }

        [BindProperty]
        public Setting Setting { get; set; }

        public IEnumerable<Setting> Settings { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            Office = await _context.Office
                .Include(o => o.Company)
                .Include(o => o.Item)
                .Include(o => o.Manager).FirstOrDefaultAsync(m => m.OfficeID == id);

            if (Office == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
