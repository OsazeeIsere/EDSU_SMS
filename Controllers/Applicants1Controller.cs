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
    public class Applicants1Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Applicants1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Applicants1
        public async Task<IActionResult> Index()
        {
              return _context.Applicant != null ? 
                          View(await _context.Applicant.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Applicant'  is null.");
        }

        // GET: Applicants1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Applicant == null)
            {
                return NotFound();
            }

            var applicant = await _context.Applicant
                .FirstOrDefaultAsync(m => m.id == id);
            if (applicant == null)
            {
                return NotFound();
            }

            return View(applicant);
        }

        // GET: Applicants1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Applicants1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,UserId,Surname,FirstName,OtherName,Sex,DOB,MaritalStatus,PlaceOfBirth,ContactAddress,PermanentHomeAddress,Nationality,StateOfOrigin,LGA,PhoneNumber,Email,PrimarySchool,SecondarySchool,Indigine,ModeOfEntry,PreviousInstitution,PreviousLevel,PreviousGrade,Status,CourseChoseInJamb,UTMESubject1,UTMESubject2,UTMESubject3,UTMESubject4,UTMESubject1Score,UTMESubject2Score,UTMESubject3Score,UTMESubject4Score,FirstChoice,SecondChoice,ThirdChoice,NoOfSittings,Ssce1Type,Ssce1Year,Ssce1Number,Ssce1Subject1,Ssce1Subject2,Ssce1Subject3,Ssce1Subject4,Ssce1Subject5,Ssce1Subject6,Ssce1Subject7,Ssce1Subject8,Ssce1Subject9,Ssce1Subject1Grade,Ssce1Subject2Grade,Ssce1Subject3Grade,Ssce1Subject4Grade,Ssce1Subject5Grade,Ssce1Subject6Grade,Ssce1Subject7Grade,Ssce1Subject8Grade,Ssce1Subject9Grade,Ssce2Type,Ssce2Year,Ssce2Number,Ssce2Subject1,Ssce2Subject2,Ssce2Subject3,Ssce2Subject4,Ssce2Subject5,Ssce2Subject6,Ssce2Subject7,Ssce2Subject8,Ssce2Subject9,Ssce2Subject1Grade,Ssce2Subject2Grade,Ssce2Subject3Grade,Ssce2Subject4Grade,Ssce2Subject5Grade,Ssce2Subject6Grade,Ssce2Subject7Grade,Ssce2Subject8Grade,Ssce2Subject9Grade,ParentFullName,ParentAddress,ParentPhoneNumber,ParentAlternatePhoneNumber,ParentEmail,ParentOccupation,Passport,Jamb,Ssce1,Ssce2,BirthCertificate")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(applicant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(applicant);
        }

        // GET: Applicants1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Applicant == null)
            {
                return NotFound();
            }

            var applicant = await _context.Applicant.FindAsync(id);
            if (applicant == null)
            {
                return NotFound();
            }
            return View(applicant);
        }

        // POST: Applicants1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,UserId,Surname,FirstName,OtherName,Sex,DOB,MaritalStatus,PlaceOfBirth,ContactAddress,PermanentHomeAddress,Nationality,StateOfOrigin,LGA,PhoneNumber,Email,PrimarySchool,SecondarySchool,Indigine,ModeOfEntry,PreviousInstitution,PreviousLevel,PreviousGrade,Status,CourseChoseInJamb,UTMESubject1,UTMESubject2,UTMESubject3,UTMESubject4,UTMESubject1Score,UTMESubject2Score,UTMESubject3Score,UTMESubject4Score,FirstChoice,SecondChoice,ThirdChoice,NoOfSittings,Ssce1Type,Ssce1Year,Ssce1Number,Ssce1Subject1,Ssce1Subject2,Ssce1Subject3,Ssce1Subject4,Ssce1Subject5,Ssce1Subject6,Ssce1Subject7,Ssce1Subject8,Ssce1Subject9,Ssce1Subject1Grade,Ssce1Subject2Grade,Ssce1Subject3Grade,Ssce1Subject4Grade,Ssce1Subject5Grade,Ssce1Subject6Grade,Ssce1Subject7Grade,Ssce1Subject8Grade,Ssce1Subject9Grade,Ssce2Type,Ssce2Year,Ssce2Number,Ssce2Subject1,Ssce2Subject2,Ssce2Subject3,Ssce2Subject4,Ssce2Subject5,Ssce2Subject6,Ssce2Subject7,Ssce2Subject8,Ssce2Subject9,Ssce2Subject1Grade,Ssce2Subject2Grade,Ssce2Subject3Grade,Ssce2Subject4Grade,Ssce2Subject5Grade,Ssce2Subject6Grade,Ssce2Subject7Grade,Ssce2Subject8Grade,Ssce2Subject9Grade,ParentFullName,ParentAddress,ParentPhoneNumber,ParentAlternatePhoneNumber,ParentEmail,ParentOccupation,Passport,Jamb,Ssce1,Ssce2,BirthCertificate")] Applicant applicant)
        {
            if (id != applicant.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(applicant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicantExists(applicant.id))
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
            return View(applicant);
        }

        // GET: Applicants1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Applicant == null)
            {
                return NotFound();
            }

            var applicant = await _context.Applicant
                .FirstOrDefaultAsync(m => m.id == id);
            if (applicant == null)
            {
                return NotFound();
            }

            return View(applicant);
        }

        // POST: Applicants1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Applicant == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Applicant'  is null.");
            }
            var applicant = await _context.Applicant.FindAsync(id);
            if (applicant != null)
            {
                _context.Applicant.Remove(applicant);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicantExists(int id)
        {
          return (_context.Applicant?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
