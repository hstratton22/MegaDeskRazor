using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDesk_Razor.Data;
using MegaDesk_Razor.Model;

namespace MegaDesk_Razor.Pages.DeskQuotes
{
    public class CreateModel : PageModel
    {
        private readonly MegaDesk_Razor.Data.MegaDesk_RazorContext _context;

        public CreateModel(MegaDesk_Razor.Data.MegaDesk_RazorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DeskID"] = new SelectList(_context.Set<Desk>(), "ID", "ID");
            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
