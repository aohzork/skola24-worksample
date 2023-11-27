using System.ComponentModel.DataAnnotations;

namespace API.Data.EFModels
{
    public class School
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SchoolName { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
