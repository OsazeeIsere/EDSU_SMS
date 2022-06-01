using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDSU_SMS.Models
{
    [Table("Departments")]

    public class Department
    {
        public int Id { get; set; }

        [ForeignKey("Faculties")]
        public int FacultyId { get; set; }

        [StringLength(40)]
        [Column(TypeName = "varchar")]
        public string? Name { get; set; }

        public bool Active { get; set; }
        public Faculty? Faculties { get; set; }
    }
}
