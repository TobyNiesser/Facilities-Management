using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Pages.Responsibilities
{
    public class IndexModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public IndexModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }

        public IList<Responsibility> Responsibility { get;set; }

        public async Task OnGetAsync()
        {
            Responsibility = await _context.Responsibility.ToListAsync();
        }
    }
}
