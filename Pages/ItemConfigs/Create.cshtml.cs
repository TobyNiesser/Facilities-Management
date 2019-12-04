using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FACILITIES.Models;

namespace FACILITIES.Pages.ItemConfigs
{
    public class CreateModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public CreateModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ItemID"] = new SelectList(_context.Item, "ItemID", "ItemName");
        ViewData["OfficeID"] = new SelectList(_context.Office, "OfficeID", "Name");
            return Page();
        }

        [BindProperty]
        public ItemConfig ItemConfig { get; set; }

        [BindProperty]
        public List<Item> Items { get; set; } = new List<Item>();



        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ItemConfig.Add(ItemConfig);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}