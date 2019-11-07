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
    public class DeleteModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public DeleteModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Office Office { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Office = await _context.Office
                .Include(o => o.Company)
                .Include(o => o.Manager).FirstOrDefaultAsync(m => m.OfficeID == id);

            if (Office == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Office = await _context.Office.FindAsync(id);

            if (Office != null)
            {
                _context.Office.Remove(Office);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
