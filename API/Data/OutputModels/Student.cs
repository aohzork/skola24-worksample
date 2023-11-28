namespace API.Data.OutputModels
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
        public IEnumerable<Absence> Absences { get; set; }
    }
}
