#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Verktygsboden.Data;
using Verktygsboden.Models;

namespace Verktygsboden.Pages.Admin.AssetAdmin
{
    public class DetailsModel : PageModel
    {
        private readonly Verktygsboden.Data.VerktygsbodenContext _context;

        public DetailsModel(Verktygsboden.Data.VerktygsbodenContext context)
        {
            _context = context;
        }

        public Asset Asset { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Asset = await _context.Asset.FirstOrDefaultAsync(m => m.Id == id);

            if (Asset == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
