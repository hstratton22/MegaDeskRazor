using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SacramentPlanner.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentPlannerContext(serviceProvider.GetRequiredService<DbContextOptions<SacramentPlannerContext>>()))
            {
                if (context.Plan.Any())
                { return;
                }
                context.Plan.AddRange(
                    new Plan
                    {
                        Date = DateTime.Parse("2021-12-4"),
                        Conductor = "Bishop",
                        OpeningSong = 201,
                        OpeningPrayer = "John Doe",
                        SacramentSong = 171,
                        IntermediateSong = 212,
                        ClosingSong = 206,
                        ClosingPrayer = "Jane Doe",
                        SpeakerSubjects = "Christmas",
                        NumberSpeakers = 2

                    }
                    );
                context.SaveChanges();
            }
                }
    }
}
