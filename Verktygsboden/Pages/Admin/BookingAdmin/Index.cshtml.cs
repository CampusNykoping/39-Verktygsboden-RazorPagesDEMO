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
    public class IndexModel : PageModel
    {
        private readonly Verktygsboden.Data.VerktygsbodenContext _context;

        public IndexModel(Verktygsboden.Data.VerktygsbodenContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; }

        public async Task OnGetAsync()
        {
            Booking = await _context.Booking
                .Include(b => b.Asset)
                .Include(b => b.User).ToListAsync();
        }
    }
}
