using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDesk_Razor.Model;

namespace MegaDesk_Razor.Data
{
    public class MegaDesk_RazorContext : DbContext
    {
        public MegaDesk_RazorContext (DbContextOptions<MegaDesk_RazorContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk_Razor.Model.DeskQuote> DeskQuote { get; set; }
    }
}
