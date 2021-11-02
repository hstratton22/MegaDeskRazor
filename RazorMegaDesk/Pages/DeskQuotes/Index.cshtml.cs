using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMegaDesk.Data;
using RazorMegaDesk.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace RazorMegaDesk.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly RazorMegaDesk.Data.RazorMegaDeskContext _context;

        public IndexModel(RazorMegaDesk.Data.RazorMegaDeskContext context)
        {
            _context = context;
        }

        public IList<Deskquote> Deskquote { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }


        public async Task OnGetAsync()
        {

            var deskquotes = from d in _context.Deskquote
                            select d;

            if (!string.IsNullOrEmpty(SearchString))
            {
                deskquotes = deskquotes.Where(s => s.CustomerName.Contains(SearchString));
            }

            Deskquote = await deskquotes.ToListAsync();

       
           
        }
    }
}
