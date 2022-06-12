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
    public class TranscriptsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TranscriptsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Transcripts
        public async Task<IActionResult> Index()
        {
              return _context.Transcripts != null ? 
                          View(await _context.Transcripts.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Transcripts'  is null.");
        }

        // GET: Transcripts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Transcripts == null)
            {
                return NotFound();
            }

            var transcripts = await _context.Transcripts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transcripts == null)
            {
                return NotFound();
            }

            return View(transcripts);
        }

        // GET: Transcripts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transcripts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Surname,Firstname,Othername,MatNo,Email,PhoneNumber,Processed,Programme,GraduationDate,AppliedBefore,IfYes,DestinationName,DestinationEmail,Address1,Address2,City,ZipCode,Country,TranscriptLabel,Receipt,ReceiptNumber,NotificationOfResult,Others")] Transcripts transcripts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transcripts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transcripts);
        }

        // GET: Transcripts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Transcripts == null)
            {
                return NotFound();
            }

            var transcripts = await _context.Transcripts.FindAsync(id);
            if (transcripts == null)
            {
                return NotFound();
            }
            return View(transcripts);
        }

        // POST: Transcripts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Surname,Firstname,Othername,MatNo,Email,PhoneNumber,Processed,Programme,GraduationDate,AppliedBefore,IfYes,DestinationName,DestinationEmail,Address1,Address2,City,ZipCode,Country,TranscriptLabel,Receipt,ReceiptNumber,NotificationOfResult,Others")] Transcripts transcripts)
        {
            if (id != transcripts.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transcripts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TranscriptsExists(transcripts.Id))
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
            return View(transcripts);
        }

        // GET: Transcripts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Transcripts == null)
            {
                return NotFound();
            }

            var transcripts = await _context.Transcripts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transcripts == null)
            {
                return NotFound();
            }

            return View(transcripts);
        }

        // POST: Transcripts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Transcripts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Transcripts'  is null.");
            }
            var transcripts = await _context.Transcripts.FindAsync(id);
            if (transcripts != null)
            {
                _context.Transcripts.Remove(transcripts);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TranscriptsExists(int id)
        {
          return (_context.Transcripts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
