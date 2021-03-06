using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Data;
using SacramentPlanner.Models;

namespace SacramentPlanner.Controllers
{
    public class PlansController : Controller
    {
        private readonly SacramentPlannerContext _context;

        public PlansController(SacramentPlannerContext context)
        {
            _context = context;
        }

        // GET: Plans
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CurrentFilter"] = searchString;

            var plans = from p in _context.Plan
                         select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                plans = plans.Where(s => s.SpeakerSubjects!.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "Date":
                    plans = plans.OrderByDescending(p => p.Date);
                    break;
                case "date_desc":
                    plans =  plans.OrderBy(p => p.Date);
                    break;
                default:
                    plans = plans.OrderBy(p => p.Date);
                    break;
            }

            return View(await plans.Include(p => p.Speakers).AsNoTracking().ToListAsync());
        }

        // GET: Plans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan = await _context.Plan
                .Include(p => p.Speakers)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plan == null)
            {
                return NotFound();
            }

            return View(plan);
        }
        // GET: Plans/Details/5
        public async Task<IActionResult> Print(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan = await _context.Plan
                .Include(p => p.Speakers)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plan == null)
            {
                return NotFound();
            }

            return View(plan);
        }

        // GET: Plans/Create
        public IActionResult Create()
        {
            PopulateHymnDropDownList();
            return View();
        }

        // POST: Plans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,Conductor,OpeningSong,OpeningPrayer,SacramentSong,IntermediateSong,ClosingSong,ClosingPrayer,SpeakerSubjects,NumberSpeakers")] Plan plan)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(plan);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }

            return View(plan);
        }

        // GET: Plans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan = await _context.Plan.FindAsync(id);
            if (plan == null)
            {
                return NotFound();
            }
            PopulateHymnDropDownList();
            return View(plan);
        }

        // POST: Plans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Conductor,OpeningSong,OpeningPrayer,SacramentSong,IntermediateSong,ClosingSong,ClosingPrayer,SpeakerSubjects,NumberSpeakers")] Plan plan)
        {
            if (id != plan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanExists(plan.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(plan);
        }

        public void PopulateHymnDropDownList( object selectedHymn = null)
        {

            var hymnsQuery =
                _context.Hymns.OrderBy(s=>s.Num)
                .Select(s => new
                {
                    HymnID = s.Id,
                    Description = s.Num + " - " + s.Name
                })
                .ToList();

            ViewBag.hymns = new SelectList(hymnsQuery, "Description" ,"Description", selectedHymn);
        }

        // GET: Plans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan = await _context.Plan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plan == null)
            {
                return NotFound();
            }

            return View(plan);
        }

        // POST: Plans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plan = await _context.Plan.FindAsync(id);
            _context.Plan.Remove(plan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanExists(int id)
        {
            return _context.Plan.Any(e => e.Id == id);
        }
    }
}
