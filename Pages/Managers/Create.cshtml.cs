using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FACILITIES.Models;

namespace FACILITIES.Pages.Managers
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
        ViewData["CompanyID"] = new SelectList(_context.Company, "CompanyID", "CompanyID");
        ViewData["PermissionID"] = new SelectList(_context.Permission, "PermissionID", "PermissionID");
            return Page();
        }

        [BindProperty]
        public Manager Manager { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Manager.Add(Manager);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}