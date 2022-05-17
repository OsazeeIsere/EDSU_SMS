
using System.ComponentModel.DataAnnotations;
using static EDSU_SMS.Models.Enum;

namespace EDSU_SMS.Models
{
    
    public class Applicant
    {
       
        public int id { get; set; }
        public string? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? OtherName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        //Application Status
        public ApplicationStatus Status { get; set; }

    }

    
}
