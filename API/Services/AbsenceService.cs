using API.Data;
using API.Data.EFModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
            var totalAbsence = await _context.Absences
                .FromSqlRaw("EXEC GetAbscenceBySchool @SchoolName", new SqlParameter("@SchoolName", schoolName))
                .FirstOrDefaultAsync();


            return 0.5;
        }
    }
}
