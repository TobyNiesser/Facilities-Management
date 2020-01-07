using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Pages.Offices
{
    public class EditModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public EditModel(FACILITIES.Models.FACILITIESContext context)
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
                .Include(o => o.Item)
                .Include(o => o.Manager).FirstOrDefaultAsync(m => m.OfficeID == id);

            if (Office == null)
            {
                return NotFound();
            }
           ViewData["CompanyID"] = new SelectList(_context.Company, "CompanyID", "Name");
           ViewData["ItemID"] = new SelectList(_context.Item, "ItemID", "ItemName");
           ViewData["ManagerID"] = new SelectList(_context.Manager, "ManagerID", "UserName");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Office).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfficeExists(Office.OfficeID))
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

        private bool OfficeExists(int id)
        {
            return _context.Office.Any(e => e.OfficeID == id);
        }
    }
}
