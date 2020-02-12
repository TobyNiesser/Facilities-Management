using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES
{
    public class DashboardMenuModel : PageModel
    {

        private readonly FACILITIES.Models.FACILITIESContext _context;

        public DashboardMenuModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }
        //public void OnGet()
        //{

        //}

        public IActionResult OnGet()
        {
            ViewData["CompanyID"] = new SelectList(_context.Company, "CompanyID", "Name");
            ViewData["FrequencyID"] = new SelectList(_context.Frequency, "FrequencyID", "FrequencyAmount");
            ViewData["ItemID"] = new SelectList(_context.Item, "ItemID", "ItemName");
            ViewData["OfficeID"] = new SelectList(_context.Office, "OfficeID", "Name");
            ViewData["ResponsibilityID"] = new SelectList(_context.Responsibility, "ResponsibilityID", "Name");
            ViewData["StatusID"] = new SelectList(_context.Status, "StatusID", "StatusIndicator");
            return Page();
        }


        [BindProperty]
        public Setting Setting { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Setting.Add(Setting);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }


}