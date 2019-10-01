using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Pages.Responsibilities
{
    public class EditModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public EditModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Responsibility Responsibility { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Responsibility = await _context.Responsibility.FirstOrDefaultAsync(m => m.ResponsibilityID == id);

            if (Responsibility == null)
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

            _context.Attach(Responsibility).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResponsibilityExists(Responsibility.ResponsibilityID))
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

        private bool ResponsibilityExists(int id)
        {
            return _context.Responsibility.Any(e => e.ResponsibilityID == id);
        }
    }
}
