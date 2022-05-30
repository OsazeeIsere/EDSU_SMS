using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EDSU_SMS.Models;

namespace EDSU_SMS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<EDSU_SMS.Models.Applicant> Applicant { get; set; }
        public DbSet<EDSU_SMS.Models.Faculty> Faculties { get; set; }
        public DbSet<EDSU_SMS.Models.Department> Departments{ get; set; }
        public DbSet<EDSU_SMS.Models.Course> Courses { get; set; }
        public DbSet<EDSU_SMS.Models.SsceSubjects>? SsceSubjects { get; set; }
        public DbSet<EDSU_SMS.Models.SSCEGrade>? SSCEGrade { get; set; }

    }
}