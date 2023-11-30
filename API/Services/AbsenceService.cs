using API.Data;
using API.Data.EFModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
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
    }
}
