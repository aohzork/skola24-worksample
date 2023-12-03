using API.Data;
using EFModels = API.Data.EFModels;
using API.Data.OutputModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using API.Data.EFModels;

namespace API.Services
{
    public class AbsenceService : IAbsenceService
    {
        private Skola24Context _context;

        public AbsenceService(Skola24Context context)
        {
            _context = context;
        }

        public async Task<double> GetAbsenceBySchoolAsync(string schoolName)
        {
            var schoolNameParam = new SqlParameter("@SchoolName", schoolName);
            var totalAbsenceParam = new SqlParameter
            {
                ParameterName = "@TotalAbsence",
                SqlDbType = SqlDbType.Decimal,
                Direction = ParameterDirection.Output,
            };

            await _context.Database
            .ExecuteSqlRawAsync("EXEC GetAbsenceBySchool @SchoolName, @TotalAbsence OUTPUT",
                schoolNameParam, totalAbsenceParam);

            var totalAbsence = Decimal.ToDouble((decimal)totalAbsenceParam.Value);

            return totalAbsence;
        }

        public async Task<List<StudentsAbsences>> GetStudentsAbsenceBySchool(string schoolName)
        {
            var students = await _context.Set<EFModels.School>()
                        .Where(sc => sc.SchoolName == schoolName)
                        .Include(s => s.Students)
                        .ThenInclude(a => a.Absences).SelectMany(s => s.Students)
                        .Select(student => new StudentsAbsences
                        {
                            Id = student.Id,
                            Name = student.StudentName,
                            TotalAbsence = student.Absences.Sum(a => a.AbsenceLength)
                        }).ToListAsync();

            return students;
        }
    }
}
