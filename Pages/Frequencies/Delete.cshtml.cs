using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Pages.Frequencies
{
    public class DeleteModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public DeleteModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Frequency Frequency { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Frequency = await _context.Frequency.FirstOrDefaultAsync(m => m.FrequencyID == id);

            if (Frequency == null)
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

            Frequency = await _context.Frequency.FindAsync(id);

            if (Frequency != null)
            {
                _context.Frequency.Remove(Frequency);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
