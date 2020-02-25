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

        [BindProperty]
        public Office Office { get; set; }

        public List<string> Events { get; set; }

        public JsonResult OnGetEvents(DateTime start, DateTime end)
        {

            var settingsevents = _context.Setting.Include(s => s.Item).Include(s => s.Office).Where(s => s.NextDate >= start && s.NextDate <= end).Select(m => new
            {
                title = m.Item.ItemName,
                start = m.NextDate,
                allDay = true,
                description = m.Item.ItemName + " @ " + m.Office.Name + " Due"
            }).ToList();

            var officesevents = _context.Office.Where(s => s.LeaseEndReview >= start && s.LeaseEndReview <= end).Select(m => new
            {
                title = m.Name + " Lease Due",
                start = m.LeaseEndReview,
                allDay = true,
                description = m.Name + " Lease Due - Contact Landlord: " + m.LandlordName + " (" + m.LandlordTelephone + ", " + m.LandlordEmail + ")"
            }).ToList();


            var events = settingsevents.Concat(officesevents).ToList();
                                 
            return new JsonResult(events);
        }




        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Setting.Add(Setting);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Dashboard/DashboardMenu");
        }


        public class OfficesModal
        {
            public List<Office> Offices { get; set; }
        }
    }


}