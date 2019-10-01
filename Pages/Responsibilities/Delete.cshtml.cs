using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Pages.Responsibilities
{
    public class DeleteModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public DeleteModel(FACILITIES.Models.FACILITIESContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Responsibility = await _context.Responsibility.FindAsync(id);

            if (Responsibility != null)
            {
                _context.Responsibility.Remove(Responsibility);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
