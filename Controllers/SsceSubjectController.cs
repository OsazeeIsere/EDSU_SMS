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
    public class SsceSubjectController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SsceSubjectController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SsceSubject
        public async Task<IActionResult> Index()
        {
              return _context.SsceSubjects != null ? 
                          View(await _context.SsceSubjects.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.SsceSubjects'  is null.");
        }

        // GET: SsceSubject/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SsceSubjects == null)
            {
                return NotFound();
            }

            var ssceSubjects = await _context.SsceSubjects
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ssceSubjects == null)
            {
                return NotFound();
            }

            return View(ssceSubjects);
        }

        // GET: SsceSubject/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SsceSubject/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SubjectName")] SsceSubjects ssceSubjects)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ssceSubjects);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ssceSubjects);
        }

        // GET: SsceSubject/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SsceSubjects == null)
            {
                return NotFound();
            }

            var ssceSubjects = await _context.SsceSubjects.FindAsync(id);
            if (ssceSubjects == null)
            {
                return NotFound();
            }
            return View(ssceSubjects);
        }

        // POST: SsceSubject/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SubjectName")] SsceSubjects ssceSubjects)
        {
            if (id != ssceSubjects.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ssceSubjects);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SsceSubjectsExists(ssceSubjects.Id))
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
            return View(ssceSubjects);
        }

        // GET: SsceSubject/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SsceSubjects == null)
            {
                return NotFound();
            }

            var ssceSubjects = await _context.SsceSubjects
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ssceSubjects == null)
            {
                return NotFound();
            }

            return View(ssceSubjects);
        }

        // POST: SsceSubject/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SsceSubjects == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SsceSubjects'  is null.");
            }
            var ssceSubjects = await _context.SsceSubjects.FindAsync(id);
            if (ssceSubjects != null)
            {
                _context.SsceSubjects.Remove(ssceSubjects);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SsceSubjectsExists(int id)
        {
          return (_context.SsceSubjects?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
