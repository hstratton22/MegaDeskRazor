using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorMegaDesk.Data;

namespace RazorMegaDesk.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorMegaDeskContext(serviceProvider.GetRequiredService<DbContextOptions<RazorMegaDeskContext>>()))
                    {
                if (context.Deskquote.Any())
                { return;
                }
                context.Deskquote.AddRange(
                    new Deskquote
                    {
                        CustomerName = "Harry Potter",
                        Width = 45,
                        Depth = 14,
                        QuoteDate = DateTime.Parse("2021-11-1"),
                        DrawerCount = 1,
                        DesktopMaterial = DesktopMaterial.Pine,
                        RushDays = 3
                        

                    }, 
                    new Deskquote
                    {
                        CustomerName = "Ron Weasley",
                        Width = 30,
                        Depth = 20,
                        QuoteDate = DateTime.Parse("2021-11-2"),
                        DrawerCount = 4,
                        DesktopMaterial = DesktopMaterial.Oak,
                        RushDays = 5
                    },
                    new Deskquote
                    {
                        CustomerName = "Hermione Granger",
                        Width = 96,
                        Depth = 48,
                        QuoteDate = DateTime.Parse("2021-11-3"),
                        DrawerCount = 7,
                        DesktopMaterial = DesktopMaterial.Rosewood,
                        RushDays = 0
                    });
                context.SaveChanges();
            }
                }
    }
}
