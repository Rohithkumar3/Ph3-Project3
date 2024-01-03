using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int SId { get; set; }
        [Required]
        public string SName { get; set; }
        public string SubName { get; set; }
        public int Marks { get; set; }
    }

}
