#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Verktygsboden.Data;
using Verktygsboden.Models;

namespace Verktygsboden.Pages.Admin.BookingAdmin
{
    public class CreateModel : PageModel
    {
        private readonly Verktygsboden.Data.VerktygsbodenContext _context;

        public CreateModel(Verktygsboden.Data.VerktygsbodenContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AssetId"] = new SelectList(_context.Asset, "Id", "Id");
        ViewData["UserId"] = new SelectList(_context.User, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Booking Booking { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Booking.Add(Booking);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
