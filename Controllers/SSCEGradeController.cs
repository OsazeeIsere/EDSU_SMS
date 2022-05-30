using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EDSU_SMS.Data;
using EDSU_SMS.Models;

namespace EDSU_SMS.Controllers
{
    public class SSCEGradeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SSCEGradeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SSCEGrade
        public async Task<IActionResult> Index()
        {
              return _context.SSCEGrade != null ? 
                          View(await _context.SSCEGrade.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.SSCEGrade'  is null.");
        }

        // GET: SSCEGrade/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SSCEGrade == null)
            {
                return NotFound();
            }

            var sSCEGrade = await _context.SSCEGrade
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sSCEGrade == null)
            {
                return NotFound();
            }

            return View(sSCEGrade);
        }

        // GET: SSCEGrade/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SSCEGrade/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Grade")] SSCEGrade sSCEGrade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sSCEGrade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sSCEGrade);
        }

        // GET: SSCEGrade/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SSCEGrade == null)
            {
                return NotFound();
            }

            var sSCEGrade = await _context.SSCEGrade.FindAsync(id);
            if (sSCEGrade == null)
            {
                return NotFound();
            }
            return View(sSCEGrade);
        }

        // POST: SSCEGrade/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Grade")] SSCEGrade sSCEGrade)
        {
            if (id != sSCEGrade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sSCEGrade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SSCEGradeExists(sSCEGrade.Id))
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
            return View(sSCEGrade);
        }

        // GET: SSCEGrade/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SSCEGrade == null)
            {
                return NotFound();
            }

            var sSCEGrade = await _context.SSCEGrade
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sSCEGrade == null)
            {
                return NotFound();
            }

            return View(sSCEGrade);
        }

        // POST: SSCEGrade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SSCEGrade == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SSCEGrade'  is null.");
            }
            var sSCEGrade = await _context.SSCEGrade.FindAsync(id);
            if (sSCEGrade != null)
            {
                _context.SSCEGrade.Remove(sSCEGrade);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SSCEGradeExists(int id)
        {
          return (_context.SSCEGrade?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
