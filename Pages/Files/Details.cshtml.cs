﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Pages.Files
{
    public class DetailsModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public DetailsModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }

        public new File File { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            File = await _context.File.FirstOrDefaultAsync(m => m.FileID == id);

            if (File == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
