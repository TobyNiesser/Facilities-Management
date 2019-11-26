using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FACILITIES.Models;

namespace FACILITIES.Pages.Offices
{
    public class ItemConfig : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public ItemConfig(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Office Office { get; set; }
        public bool ItemID { get; set; }

        public IActionResult OnGet()
        {
            ViewData["OfficeID"] = new SelectList(_context.Office, "OfficeID", "Name");
            ViewData["ItemID"] = new SelectList(_context.Item, "ItemID", "ItemName");

            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Office.Add(Office);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");

        }



    }
}
