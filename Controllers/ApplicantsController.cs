#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EDSU_SMS.Data;
using EDSU_SMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using EDSU_SMS.Views.Applicants;
using EDSU_SMS.Authorization;
using static EDSU_SMS.Models.Enum;

namespace EDSU_SMS.Controllers
{
    public class ApplicantsController : DI_BaseViewModel
    {
        public ApplicantsController(ApplicationDbContext context,
            IAuthorizationService authorizationService,
            UserManager<IdentityUser> userManager) : base(context, authorizationService, userManager)
        {
        }


        [AllowAnonymous]
        // GET: Applicants
        public async Task<IActionResult> Index()
        {
            var applicants = from i in Context.Applicant
                           select i;


            var isManager = User.IsInRole(Constants.ApplicationManagerRole);
            var isAdmin = User.IsInRole(Constants.ApplicationSuperAdminRole);
            //checking if an applicant has applied before
            var currentUser = UserManager.GetUserId(User);

            if (isManager == false && isAdmin == false)
            {
                applicants = applicants.Where(i => i.UserId == currentUser);
            }

            return View(applicants);
        }

        // GET: Applicants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicant = await Context.Applicant
                .FirstOrDefaultAsync(m => m.id == id);
            if (applicant == null)
            {
                return NotFound();
            }

            var applicants = from i in Context.Applicant
                             select i;


            var isManager = User.IsInRole(Constants.ApplicationManagerRole);
            var isAdmin = User.IsInRole(Constants.ApplicationSuperAdminRole);
            //checking if an applicant has applied before
            var currentUser = UserManager.GetUserId(User);

            if (isManager == false && isAdmin == false)
            {
                applicants = applicants.Where(i => i.UserId == currentUser);
            }
            //var isAuthorized = await AuthorizationService.AuthorizeAsync(User, applicant, ApplicationOperations.Read);
            //if (isAuthorized.Succeeded == false)
            //    return Forbid();

            return View(applicant);
        }

        //Post: Applicant/Detail
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(int? id, ApplicationStatus status)
        {
          var  applicant = await Context.Applicant.FindAsync(id);

            if (applicant == null)
                return NotFound();


            var applicationOperation = (status.ToString() == ApplicationOperations.Approved.ToString())
                ? ApplicationOperations.Approved
                : ApplicationOperations.Declined;

            var isAuthorized = await AuthorizationService.AuthorizeAsync(
                User, applicant, applicationOperation);

            if (isAuthorized.Succeeded == false)
                return Forbid();

            applicant.Status = status;
            Context.Applicant.Update(applicant);
            //Context.Students.Add((Student)applicant);

            await Context.SaveChangesAsync();

            return View(applicant);
        }


            // GET: Applicants/Create
            public async Task <IActionResult> Create()
        {
            var isManager = User.IsInRole(Constants.ApplicationManagerRole);
            var isAdmin = User.IsInRole(Constants.ApplicationSuperAdminRole);
            //checking if an applicant has applied before
            var currentUser = UserManager.GetUserId(User);

            if (isManager == true || isAdmin == true)
            {
                return Forbid();
            }

            //checking if an applicant has applied before
            List<Applicant> applicants = await Context.Applicant
                .Where(i=>i.UserId== currentUser).ToListAsync();
            if(applicants.Any())
                return Forbid();

           return View();
        }

        // POST: Applicants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,UserId,Surname,FirstName,OtherName,Sex,DOB,MaritalStatus,PlaceOfBirth,ContactAddress,PermanentHomeAddress,Nationality,StateOfOrigin,LGA,PhoneNumber,Email,PrimarySchool,SecondarySchool,Indigine,ModeOfEntry,PreviousInstitution,PreviousLevel,PreviousGrade,Status,CourseChoseInJamb,UTMESubject1,UTMESubject2,UTMESubject3,UTMESubject4,UTMESubject1Score,UTMESubject2Score,UTMESubject3Score,UTMESubject4Score,FirstChoice,SecondChoice,ThirdChoice,NoOfSittings,Ssce1Type,Ssce1Year,Ssce1Number,Ssce1Subject1,Ssce1Subject2,Ssce1Subject3,Ssce1Subject4,Ssce1Subject5,Ssce1Subject6,Ssce1Subject7,Ssce1Subject8,Ssce1Subject9,Ssce1Subject1Grade,Ssce1Subject2Grade,Ssce1Subject3Grade,Ssce1Subject4Grade,Ssce1Subject5Grade,Ssce1Subject6Grade,Ssce1Subject7Grade,Ssce1Subject8Grade,Ssce1Subject9Grade,Ssce2Type,Ssce2Year,Ssce2Number,Ssce2Subject1,Ssce2Subject2,Ssce2Subject3,Ssce2Subject4,Ssce2Subject5,Ssce2Subject6,Ssce2Subject7,Ssce2Subject8,Ssce2Subject9,Ssce2Subject1Grade,Ssce2Subject2Grade,Ssce2Subject3Grade,Ssce2Subject4Grade,Ssce2Subject5Grade,Ssce2Subject6Grade,Ssce2Subject7Grade,Ssce2Subject8Grade,Ssce2Subject9Grade,ParentFullName,ParentAddress,ParentPhoneNumber,ParentAlternatePhoneNumber,ParentEmail,ParentOccupation,Passport,Jamb,Ssce1,Ssce2,BirthCertificate")] Applicant applicant)
        {
            //checking if an applicant has applied before
            var currentUser = UserManager.GetUserId(User);
            List<Applicant> applicants = await Context.Applicant
                .Where(i => i.UserId == currentUser).ToListAsync();
            if (applicants.Any())
                return Forbid();
            applicant.UserId = currentUser;
            var isAuthorized = await AuthorizationService.AuthorizeAsync(User, applicant, ApplicationOperations.Create);
            if (isAuthorized.Succeeded == false)
                return Forbid();

            Context.Applicant.Add(applicant);
            await Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            
              return View(applicant);
        }

        // GET: Applicants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicants = await Context.Applicant.FindAsync(id);
            if (applicants == null)
            {
                return NotFound();
            }
            var isAuthorized = await AuthorizationService.AuthorizeAsync(User, applicants, ApplicationOperations.Update);
            if (isAuthorized.Succeeded == false)
                return Forbid();

            if (applicants.Status.ToString() != "Pending")
                return Forbid();

            return View(applicants);
        }

        // POST: Applicants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            var applicants = await Context.Applicant.FindAsync(id);

            if (id ==null)
            {
                return NotFound();
            }
            applicants.UserId = UserManager.GetUserId(User);
            try
            {
                var isAuthorized = await AuthorizationService.AuthorizeAsync(User, applicants, ApplicationOperations.Update);
                if (isAuthorized.Succeeded == false)
                    return Forbid();


                var ApplicatantToUpdate = await Context.Applicant
            .FirstOrDefaultAsync(c => c.id == id);

                if (await TryUpdateModelAsync<Applicant>(ApplicatantToUpdate, "", c => c.UTMESubject1, c=>c.UTMESubject1Score, c=>c.UTMESubject2, c=>c.UTMESubject2Score, c=>c.UTMESubject3, c=>c.UTMESubject3Score, c=>c.UTMESubject4, c=>c.UTMESubject4Score, c=>c.FirstChoice, c => c.SecondChoice, c => c.ThirdChoice))
                {
                    try
                    {
                        await Context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {

                        //Log the error (uncomment ex variable name and write a log.)
                        ModelState.AddModelError("", "Unable to save changes. " +
                            "Try again, and if the problem persists, " +
                            "see your system administrator.");
                    }
                    return RedirectToAction(nameof(Index));
                }



                //Context.Update(applicant);
                //await Context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ex.ToString();

            }
            return View();

        }
        // GET: Applicants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicant = await Context.Applicant
                .FirstOrDefaultAsync(m => m.id == id);
            if (applicant == null)
            {
                return NotFound();
            }

            var isAuthorized = await AuthorizationService.AuthorizeAsync(User, applicant, ApplicationOperations.Delete);
            if (isAuthorized.Succeeded == false)
                return Forbid();

            return View(applicant);
        }

        // POST: Applicants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var applicant = await Context.Applicant.FindAsync(id);
            Context.Applicant.Remove(applicant);
            await Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicantExists(int id)
        {
            return Context.Applicant.Any(e => e.id == id);
        }
    }
}
