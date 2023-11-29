namespace API.Services
{
    public interface IAbsenceService
    {
        Task<double> GetAbsenceBySchoolAsync(string school);
    }
}