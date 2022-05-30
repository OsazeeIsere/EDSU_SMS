using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDSU_SMS.Models
{
    [Table("Faculties")]
    public class Faculty 
    {
        public int Id { get; set; }

        [StringLength(40)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        
       
    }
}
