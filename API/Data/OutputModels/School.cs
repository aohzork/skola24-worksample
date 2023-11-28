namespace API.Data.OutputModels
{
    public class School
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
