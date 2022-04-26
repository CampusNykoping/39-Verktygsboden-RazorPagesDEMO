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

namespace Verktygsboden.Pages.Admin.BookingAdmin
{
    public class DetailsModel : PageModel
    {
        private readonly Verktygsboden.Data.VerktygsbodenContext _context;

        public DetailsModel(Verktygsboden.Data.VerktygsbodenContext context)
        {
            _context = context;
        }

        public Booking Booking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Booking = await _context.Booking
                .Include(b => b.Asset)
                .Include(b => b.User).FirstOrDefaultAsync(m => m.Id == id);

            if (Booking == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
