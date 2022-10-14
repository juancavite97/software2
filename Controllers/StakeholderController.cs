using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SoftwareII.Data;
using SoftwareII.Models;

namespace SoftwareII.Controllers
{
    public class StakeholderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StakeholderController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Stakeholder
        public async Task<IActionResult> Index()
        {
              return View(await _context.Stakeholder.ToListAsync());
        }

        // GET: Stakeholder/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Stakeholder == null)
            {
                return NotFound();
            }

            var stakeholder = await _context.Stakeholder
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stakeholder == null)
            {
                return NotFound();
            }

            return View(stakeholder);
        }

        // GET: Stakeholder/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stakeholder/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,LastName,Company,Code,Email")] Stakeholder stakeholder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stakeholder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stakeholder);
        }

        // GET: Stakeholder/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Stakeholder == null)
            {
                return NotFound();
            }

            var stakeholder = await _context.Stakeholder.FindAsync(id);
            if (stakeholder == null)
            {
                return NotFound();
            }
            return View(stakeholder);
        }

        // POST: Stakeholder/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,LastName,Company,Code,Email")] Stakeholder stakeholder)
        {
            if (id != stakeholder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stakeholder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StakeholderExists(stakeholder.Id))
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
            return View(stakeholder);
        }

        // GET: Stakeholder/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Stakeholder == null)
            {
                return NotFound();
            }

            var stakeholder = await _context.Stakeholder
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stakeholder == null)
            {
                return NotFound();
            }

            return View(stakeholder);
        }

        // POST: Stakeholder/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Stakeholder == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Stakeholder'  is null.");
            }
            var stakeholder = await _context.Stakeholder.FindAsync(id);
            if (stakeholder != null)
            {
                _context.Stakeholder.Remove(stakeholder);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StakeholderExists(int id)
        {
          return _context.Stakeholder.Any(e => e.Id == id);
        }
    }
}
