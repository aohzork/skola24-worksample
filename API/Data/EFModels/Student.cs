using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.EFModels
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StudentName { get; set; }
        [ForeignKey(nameof(SchoolId))]
        public int SchoolId { get; set; }
        public School School { get; set; }
        public IEnumerable<Absence> Absences { get; set; }
    }
}