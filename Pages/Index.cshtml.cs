using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FACILITIES.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FACILITIES.Pages
{
    public class IndexModel : PageModel
    {



        private readonly FACILITIESContext fACILITIES;

        public IndexModel(FACILITIESContext databasecontext)
        {
            fACILITIES = databasecontext;
        }

      

    }


}

