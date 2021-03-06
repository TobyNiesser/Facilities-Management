﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Pages.Offices
{
    public class IndexModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public IndexModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }

        public IList<Office> Office { get;set; }

        public async Task OnGetAsync()
        {
            Office = await _context.Office
                .Include(o => o.Company)
                .Include(o => o.Item)
                .Include(o => o.Manager).ToListAsync();
        }
    }
}
