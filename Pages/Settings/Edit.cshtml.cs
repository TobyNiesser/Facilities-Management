using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Pages.Settings
{
    public class EditModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public EditModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Setting Setting { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Setting = await _context.Setting
                .Include(s => s.Company)
                .Include(s => s.Frequency)
                .Include(s => s.Item)
                .Include(s => s.Office)
                .Include(s => s.Responsibility)
                .Include(s => s.Status).FirstOrDefaultAsync(m => m.SettingID == id);

            if (Setting == null)
            {
                return NotFound();
            }
           ViewData["CompanyID"] = new SelectList(_context.Company, "CompanyID", "CompanyID");
           ViewData["FrequencyID"] = new SelectList(_context.Frequency, "FrequencyID", "FrequencyID");
           ViewData["OfficeID"] = new SelectList(_context.Office, "OfficeID", "OfficeID");
           ViewData["ResponsibilityID"] = new SelectList(_context.Responsibility, "ResponsibilityID", "ResponsibilityID");
           ViewData["StatusID"] = new SelectList(_context.Status, "StatusID", "StatusID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Setting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SettingExists(Setting.SettingID))
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

        private bool SettingExists(int id)
        {
            return _context.Setting.Any(e => e.SettingID == id);
        }
    }
}
