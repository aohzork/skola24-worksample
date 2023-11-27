using API.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.EFModels
{
    public class Absence
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(StudentId))]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public double AbsenceLength { get; set; }
        [Required]
        public AbsenceType Type { get; set; }
        [Required]
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}