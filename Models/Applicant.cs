
using System.ComponentModel.DataAnnotations;
using static EDSU_SMS.Models.Enum;

namespace EDSU_SMS.Models
{
    
    public class Applicant
    {
        public int id { get; set; }
        public string? UserId { get; set; }
        public string? Surname { get; set; }
        public string? FirstName { get; set; }
        public string? OtherName { get; set; }
        public string? Sex { get; set; }
        public DateTime DOB { get; set; }
        public string? MaritalStatus { get; set; }
        public string? PlaceOfBirth { get; set; }
        public string? ContactAddress { get; set; }
        public string? PermanentHomeAddress { get; set; }
        public string? Nationality { get; set; }
        public string? StateOfOrigin { get; set; }
        public string? LGA { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? PrimarySchool { get; set; }
        public string? SecondarySchool { get; set; }
        public bool Indigine { get; set; }
        public string? ModeOfEntry { get; set; }
        public string? PreviousInstitution { get; set; }
        public string? PreviousLevel { get; set; }
        public string? PreviousGrade { get; set; }
        
        public ApplicationStatus Status { get; set; }
        //Second Page
        /// <summary>
        //UTME Subjects and Scores
        /// </summary>
        public string? CourseChoseInJamb { get; set; }
        public string? UTMESubject1 { get; set; }
        public string? UTMESubject2 { get; set; }
        public string? UTMESubject3 { get; set; }
        public string? UTMESubject4 { get; set; }
        public int UTMESubject1Score { get; set; }
        public int UTMESubject2Score { get; set; }
        public int UTMESubject3Score { get; set; }
        public int UTMESubject4Score { get; set; }
        public int UTEMTotal { get; set; }

        /// <summary>
        /// //Choice of course of study
        /// </summary>

        public string? FirstChoice { get; set; }
        public string? SecondChoice { get; set; }
        public string? ThirdChoice { get; set; }

        //Third Page
        /// <summary>
        /// //SSCE Details
        /// </summary>
        public int NoOfSittings { get; set; }
        public string? Ssce1Type { get; set; }
        public string? Ssce1Year { get; set; }
        public string? Ssce1Number { get; set; }
        public string? Ssce1Subject1 { get; set; }
        public string? Ssce1Subject2 { get; set; }
        public string? Ssce1Subject3 { get; set; }
        public string? Ssce1Subject4 { get; set; }
        public string? Ssce1Subject5 { get; set; }
        public string? Ssce1Subject6 { get; set; }
        public string? Ssce1Subject7 { get; set; }
        public string? Ssce1Subject8 { get; set; }
        public string? Ssce1Subject9 { get; set; }

        //ssce 1 grade
        public int Ssce1Subject1Grade { get; set; }
        public int Ssce1Subject2Grade { get; set; }
        public int Ssce1Subject3Grade { get; set; }
        public int Ssce1Subject4Grade { get; set; }
        public int Ssce1Subject5Grade { get; set; }
        public int Ssce1Subject6Grade { get; set; }
        public int Ssce1Subject7Grade { get; set; }
        public int Ssce1Subject8Grade { get; set; }
        public int Ssce1Subject9Grade { get; set; }

        public string? Ssce2Type { get; set; }
        public string? Ssce2Year { get; set; }
        public string? Ssce2Number { get; set; }
        public string? Ssce2Subject1 { get; set; }
        public string? Ssce2Subject2 { get; set; }
        public string? Ssce2Subject3 { get; set; }
        public string? Ssce2Subject4 { get; set; }
        public string? Ssce2Subject5 { get; set; }
        public string? Ssce2Subject6 { get; set; }
        public string? Ssce2Subject7 { get; set; }
        public string? Ssce2Subject8 { get; set; }
        public string? Ssce2Subject9 { get; set; }

        //ssce 1 grade
        public int Ssce2Subject1Grade { get; set; }
        public int Ssce2Subject2Grade { get; set; }
        public int Ssce2Subject3Grade { get; set; }
        public int Ssce2Subject4Grade { get; set; }
        public int Ssce2Subject5Grade { get; set; }
        public int Ssce2Subject6Grade { get; set; }
        public int Ssce2Subject7Grade { get; set; }
        public int Ssce2Subject8Grade { get; set; }
        public int Ssce2Subject9Grade { get; set; }

        //Fourth Page
        /// <summary>
        /// Parent/Guardian Info
        /// </summary>
        public string? ParentFullName { get; set; }
        public string? ParentAddress { get; set; }
        public string? ParentPhoneNumber { get; set; }
        public string? ParentAlternatePhoneNumber { get; set; }
        public string? ParentEmail { get; set; }
        public string? ParentOccupation { get; set; }

        //Fifth Page
        /// <summary>
        /// File Uploads
        /// </summary>
        public string? Passport { get; set; }
        public string? Jamb { get; set; }
        public string? Ssce1 { get; set; }
        public string? Ssce2 { get; set; }
        public string? BirthCertificate { get; set; }
        public string? DirectEntryUpload { get; set; }
        public string? LGAUpload { get; set; }

    }

    
}
