using API.Data.Enums;

namespace API.Data.OutputModels
{
    public class Absence
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public double AbsenceLength { get; set; }
        public AbsenceType Type { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
