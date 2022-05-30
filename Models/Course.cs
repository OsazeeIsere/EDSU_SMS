using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDSU_SMS.Models
{
    [Table("Courses")]

    public class Course
    {

        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Title { get; set; }

        [Key]

        public string Code { get; set; }


        public int Id { get; set; }

        [ForeignKey("Departments")]
        public int DepartmentId { get; set; }   

        [StringLength(2000)]
        [Column(TypeName = "varchar")]
        public string Description { get; set; }

        public int CreditUnit { get; set; }

        public string Status { get; set; }

        public Department Departments { get; set; }


    }
}
