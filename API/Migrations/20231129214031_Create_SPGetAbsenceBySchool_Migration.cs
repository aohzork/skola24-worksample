using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Create_SPGetAbsenceBySchool_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"
                CREATE PROCEDURE GetAbsenceBySchool @SchoolName NVARCHAR(250)
                AS
                BEGIN
                    SELECT SUM(ab.AbsenceLength) AS TotalAbsence
                    FROM Absences ab
                    JOIN Students st ON ab.StudentId = st.Id
                    JOIN Schools sc ON st.SchoolId = sc.Id
                    WHERE sc.SchoolName = @SchoolName;
                END
            ";

            migrationBuilder.Sql(sql);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sql = "DROP PROCEDURE GetAbsenceBySchool";
            migrationBuilder.Sql(sql);
        }
    }
}
