﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FACILITIES.Models;

namespace FACILITIES.Pages.Settings
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
        ViewData["FrequencyID"] = new SelectList(_context.Frequency, "FrequencyID", "FrequencyID");
        ViewData["ItemID"] = new SelectList(_context.Item, "ItemID", "ItemID");
        ViewData["OfficeID"] = new SelectList(_context.Office, "OfficeID", "OfficeID");
        ViewData["ResponsibilityID"] = new SelectList(_context.Responsibility, "ResponsibilityID", "ResponsibilityID");
        ViewData["StatusID"] = new SelectList(_context.Status, "StatusID", "StatusID");
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