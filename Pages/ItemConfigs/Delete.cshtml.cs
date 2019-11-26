using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Pages.ItemConfigs
{
    public class DeleteModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public DeleteModel(FACILITIES.Models.FACILITIESContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ItemConfig = await _context.ItemConfig.FindAsync(id);

            if (ItemConfig != null)
            {
                _context.ItemConfig.Remove(ItemConfig);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
