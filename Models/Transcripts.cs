namespace EDSU_SMS.Models
{
    public class Transcripts
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Surname { get; set; }
        public string? Firstname { get; set; }
        public string? Othername { get; set; }
        public string? MatNo { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public bool Processed { get; set; }

        //Program details
        public string? Programme { get; set; }
        public DateTime GraduationDate { get; set; }
        public bool AppliedBefore { get; set; }
        public DateTime IfYes { get; set; }

        //Destination Details
        public string? DestinationName { get; set; }
        public string? DestinationEmail { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
        public string? TranscriptLabel { get; set; }

        //Supporting Documents
        public string? Receipt { get; set; }
        public string? ReceiptNumber { get; set; }
        public string? NotificationOfResult { get; set; }
        public string? Others { get; set; }
       
    }
}
