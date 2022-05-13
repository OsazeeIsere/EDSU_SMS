
using static SMS_PROJECT.Models.Enum;

namespace SMS_PROJECT.Models
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
