using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Pages.ItemConfigs
{
    public class EditModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public EditModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ItemConfig ItemConfig { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ItemConfig = await _context.ItemConfig
                .Include(i => i.Item)
                .Include(i => i.Office).FirstOrDefaultAsync(m => m.ItemConfigID == id);

            if (ItemConfig == null)
            {
                return NotFound();
            }
           ViewData["ItemID"] = new SelectList(_context.Item, "ItemID", "ItemID");
           ViewData["OfficeID"] = new SelectList(_context.Office, "OfficeID", "OfficeID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ItemConfig).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemConfigExists(ItemConfig.ItemConfigID))
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

        private bool ItemConfigExists(int id)
        {
            return _context.ItemConfig.Any(e => e.ItemConfigID == id);
        }
    }
}
