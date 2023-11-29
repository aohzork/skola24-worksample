using API.Data;
using API.Data.EFModels;
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
            var totalAbsence = await _context.Schools
                .Where(sc => sc.SchoolName == schoolName)
                .Join(_context.Students, sc => sc.Id, st => st.SchoolId, (sc, st) => st)
                .Join(_context.Absences, st => st.Id, ab => ab.StudentId, (st, ab) => ab)
                .SumAsync(ab => ab.AbsenceLength);

            return totalAbsence;
        }
    }
}
