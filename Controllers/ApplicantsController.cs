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
        public async Task<IActionResult> Create([Bind("id,UserId,FirstName,LastName,OtherName,Email,Phone,DOB,ContactAddress,PermanentAddress,Sex,MaritalStatus,PrimarySchool,SecondarySchool,Nationality,ModeOfEntry,UtmeNo,State,PlaceOfBirth,LGA,indegine,ParentFullname,ParentAddress,ParentEmail,ParentPhoneNumber,ParentPhoneNumber2,ParentOccupation,CourseChooseInJamb,UtmeSubject1,UtmeSubject2,UtmeSubject3,UtmeSubject4,UtmeSubject1Score,UtmeSubject2Score,UtmeSubject3Score,UtmeSubject4Score,NumberOfSittings,Ssce1Type,Ssce1Number,Ssce1Year,Ssce1Subject1,Ssce1Subject2,Ssce1Subject3,Ssce1Subject4,Ssce1Subject5,Ssce1Subject6,Ssce1Subject7,Ssce1Subject8,Ssce1Subject9,Ssce1Subject1Grade,Ssce1Subject2Grade,Ssce1Subject3Grade,Ssce1Subject4Grade,Ssce1Subject5Grade,Ssce1Subject6Grade,Ssce1Subject7Grade,Ssce1Subject8Grade,Ssce1Subject9Grade,Ssce2Type,Ssce2Number,Ssce2Year,Ssce2Subject1,Ssce2Subject2,Ssce2Subject3,Ssce2Subject4,Ssce2Subject5,Ssce2Subject6,Ssce2Subject7,Ssce2Subject8,Ssce2Subject9,Ssce2Subject1Grade,Ssce2Subject2Grade,Ssce2Subject3Grade,Ssce2Subject4Grade,Ssce2Subject5Grade,Ssce2Subject6Grade,Ssce2Subject7Grade,Ssce2Subject8Grade,Ssce2Subject9Grade,AdmissionYear,PreviousInstitution,PreviousLevel,PreviousGrade,Passport,JambResultUpload,Ssce1ResultUpload,Ssce2ResultUpload,BirthCertUpload,DirectEntryUpload,LgaUpload,CourseChoice1,CourseChoice2,CourseChoice3")] Applicant applicant)
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
        public async Task<IActionResult> Edit(int id, [Bind("id,UserId,LastName,OtherName,Email,Phone")] Applicant applicant)
        {
            if (id != applicant.id)
            {
                return NotFound();
            }
            applicant.UserId = UserManager.GetUserId(User);
            var applicants = await Context.Applicant.FindAsync(id);
            try
            {
                    var isAuthorized = await AuthorizationService.AuthorizeAsync(User, applicant, ApplicationOperations.Update);
                    if (isAuthorized.Succeeded == false)
                        return Forbid();
                    Context.Update(applicant);
                    await Context.SaveChangesAsync();
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
            
            return View(applicant);
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
