using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FACILITIES.Models;

namespace FACILITIES.Pages.Responsibilities
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
            return Page();
        }

        [BindProperty]
        public Responsibility Responsibility { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Responsibility.Add(Responsibility);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}