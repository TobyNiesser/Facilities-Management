using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;
using System.Diagnostics;

namespace FACILITIES.Pages.ItemConfigs
{
    public class EditModel : PageModel
    {
        private readonly FACILITIES.Models.FACILITIESContext _context;

        public EditModel(FACILITIES.Models.FACILITIESContext context)
        {
            _context = context;
        }

        [FromRoute]
        public int? Id { get; set; }


        [BindProperty]
        public ItemConfig ItemConfig { get; set; }

        [BindProperty]
        public ItemConfig OfficeID { get; set; }

        public int? page_id;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            page_id = id;

            ItemConfig = await _context.ItemConfig
                .Include(i => i.Item)
                .Include(i => i.Office).FirstOrDefaultAsync(m => m.ItemConfigID == id);

            if (ItemConfig == null)
            {
                return NotFound();
            }

            SelectList list = new SelectList(_context.Item, "ItemID", "ItemName");


            ViewData["ItemID"] = list;

            //if (Items_csv != null)
            //{
            //    string selected_load = ItemConfig.Items_csv;
            //    string[] selectedList = selected_load.Split(',');


            //    foreach (SelectListItem item in list)
            //    {
            //        foreach (var integer in selectedList)
            //        {

            //            if (item.Value == integer)
            //            {
            //                item.Selected = true;
            //                break;
            //            }
            //        }
            //    }

            //}



        ViewData["OfficeID"] = new SelectList(_context.Office, "OfficeID", "Name");
            return Page();



        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string selected = Request.Form["MyItems"].ToString();
            string[] selectedList = selected.Split(',');
            foreach (var temp in selectedList)
            {
                Debug.WriteLine(temp);
            }



            _context.Attach(ItemConfig).State = EntityState.Modified;

            try
            {

                ItemConfig.OfficeID = Convert.ToInt32(Request.Form["select"]);
                ItemConfig.Items_csv = selected;
                        await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemConfigExists(ItemConfig.ItemConfigID))
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

        private bool ItemConfigExists(int id)
        {
            return _context.ItemConfig.Any(e => e.ItemConfigID == id);
        }
    }
}
