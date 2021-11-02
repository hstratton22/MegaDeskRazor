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
        public string DateSort { get; set; }
        public string NameSort { get; set; }

        public string CurrentFilter { get; set; }


        public async Task OnGetAsync(string sortOrder, string searchString)
        {

            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            CurrentFilter = searchString;

            IQueryable<Deskquote> deskquoteIQ = from d in _context.Deskquote
                                             select d;

            if (!String.IsNullOrEmpty(searchString))
            {
                deskquoteIQ = deskquoteIQ.Where(s => s.CustomerName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    deskquoteIQ = deskquoteIQ.OrderByDescending(s => s.CustomerName);
                    break;
                case "Date":
                    deskquoteIQ = deskquoteIQ.OrderBy(s => s.quoteDate);
                    break;
                case "date_desc":
                    deskquoteIQ = deskquoteIQ.OrderByDescending(s => s.quoteDate);
                    break;
                default:
                    deskquoteIQ = deskquoteIQ.OrderBy(s => s.CustomerName);
                    break;
            }


            Deskquote = await deskquoteIQ.AsNoTracking().ToListAsync();
           
        }
    }
}
