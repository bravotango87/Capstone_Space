using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Space.Data;
using Space.Models;

namespace Space.Controllers
{
    public class ItinerariesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItinerariesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Itineraries

        public async Task<IActionResult> Index()
        {
            var itineraries = _context.Itineraries.Include(c => c.IdentityUser);
            return View(await itineraries.ToListAsync());
        }

        // GET: Itineraries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itinerary = await _context.Itineraries
                .Include(i => i.IdentityUser)
                .FirstOrDefaultAsync(m => m.ItineraryId == id);
            if (itinerary == null)
            {
                return NotFound();
            }

            return View(itinerary);
        }

        // GET: Itineraries/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Itineraries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItineraryId,RequiredForms,Destination,WhatToBring,Depature,ThreeWeeksPrior,DayOfLaunch,Arrival,WhatToDo,FlyingBack,IdentityUserId")] Itinerary itinerary)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itinerary);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View(itinerary);
        }

        // GET: Itineraries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itinerary = await _context.Itineraries.FindAsync(id);
            if (itinerary == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View(itinerary);
        }

        // POST: Itineraries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItineraryId,RequiredForms,Destination,WhatToBring,Depature,ThreeWeeksPrior,DayOfLaunch,Arrival,WhatToDo,FlyingBack,IdentityUserId")] Itinerary itinerary)
        {
            if (id != itinerary.ItineraryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itinerary);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItineraryExists(itinerary.ItineraryId))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View(itinerary);
        }

        // GET: Itineraries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itinerary = await _context.Itineraries
                .Include(i => i.IdentityUser)
                .FirstOrDefaultAsync(m => m.ItineraryId == id);
            if (itinerary == null)
            {
                return NotFound();
            }

            return View(itinerary);
        }

        // POST: Itineraries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itinerary = await _context.Itineraries.FindAsync(id);
            _context.Itineraries.Remove(itinerary);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItineraryExists(int id)
        {
            return _context.Itineraries.Any(e => e.ItineraryId == id);
        }


        public ActionResult Select(int id)
        {
            var itinerary
                = _context.Customers.Where(c => c.CustomerId == id).FirstOrDefault();
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


    }
}
