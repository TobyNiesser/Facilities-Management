using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Pages.Frequencies
{
    public class EditModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public EditModel(FACILITIES.Models.FACILITIESContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Frequency).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FrequencyExists(Frequency.FrequencyID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FrequencyExists(int id)
        {
            return _context.Frequency.Any(e => e.FrequencyID == id);
        }
    }
}
