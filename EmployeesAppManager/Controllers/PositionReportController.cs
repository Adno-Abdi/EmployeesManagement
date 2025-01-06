using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeesAppManager.Data;
using EmployeesAppManager.Models;

namespace EmployeesAppManager.Controllers
{
    public class PositionReportController : Controller
    {
        private readonly WebDbContext _context;

        public PositionReportController(WebDbContext context)
        {
            _context = context;
        }

        // GET: PositionReport
        public async Task<IActionResult> Index()
        {
            return View(await _context.Position.ToListAsync());
        }

        // GET: PositionReport/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var positions = await _context.Position
                .FirstOrDefaultAsync(m => m.Id == id);
            if (positions == null)
            {
                return NotFound();
            }

            return View(positions);
        }

        // GET: PositionReport/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PositionReport/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title")] Positions positions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(positions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(positions);
        }

        // GET: PositionReport/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var positions = await _context.Position.FindAsync(id);
            if (positions == null)
            {
                return NotFound();
            }
            return View(positions);
        }

        // POST: PositionReport/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title")] Positions positions)
        {
            if (id != positions.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(positions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PositionsExists(positions.Id))
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
            return View(positions);
        }

        // GET: PositionReport/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var positions = await _context.Position
                .FirstOrDefaultAsync(m => m.Id == id);
            if (positions == null)
            {
                return NotFound();
            }

            return View(positions);
        }

        // POST: PositionReport/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var positions = await _context.Position.FindAsync(id);
            if (positions != null)
            {
                _context.Position.Remove(positions);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PositionsExists(int id)
        {
            return _context.Position.Any(e => e.Id == id);
        }
    }
}
