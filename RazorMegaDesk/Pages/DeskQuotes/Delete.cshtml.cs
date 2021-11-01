using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMegaDesk.Data;
using RazorMegaDesk.Models;

namespace RazorMegaDesk.Pages.DeskQuotes
{
    public class DeleteModel : PageModel
    {
        private readonly RazorMegaDesk.Data.RazorMegaDeskContext _context;

        public DeleteModel(RazorMegaDesk.Data.RazorMegaDeskContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Deskquote Deskquote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Deskquote = await _context.Deskquote.FirstOrDefaultAsync(m => m.ID == id);

            if (Deskquote == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Deskquote = await _context.Deskquote.FindAsync(id);

            if (Deskquote != null)
            {
                _context.Deskquote.Remove(Deskquote);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
