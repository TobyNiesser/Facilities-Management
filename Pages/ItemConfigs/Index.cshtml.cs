using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Pages.ItemConfigs
{
    public class IndexModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public IndexModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }



        public IList<ItemConfig> ItemConfig { get;set; }

        public async Task OnGetAsync()
        {
            ItemConfig = await _context.ItemConfig
                .Include(i => i.Item)
                .Include(i => i.Office).ToListAsync();
        }


        

    }

    
}
