﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Pages.Statuses
{
    public class DetailsModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public DetailsModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }

        public Status Status { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Status = await _context.Status.FirstOrDefaultAsync(m => m.StatusID == id);

            if (Status == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
