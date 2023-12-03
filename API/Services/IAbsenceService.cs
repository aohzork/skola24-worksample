using API.Data.OutputModels;

namespace API.Services
{
    public interface IAbsenceService
    {
        Task<double> GetAbsenceBySchoolAsync(string schoolName);
        Task<List<StudentsAbsences>> GetStudentsAbsenceBySchool(string schoolName);
    }
}