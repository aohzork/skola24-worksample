using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AddChangeIndex_SchoolName_AbsenceId_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Absences_Id",
                table: "Absences");

            migrationBuilder.AlterColumn<string>(
                name: "SchoolName",
                table: "Schools",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 35.0, new DateTime(2023, 11, 15, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9810), 1, new DateTime(2023, 11, 24, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 19, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9834), 1, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 38.0, new DateTime(2023, 11, 22, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9879), 2, new DateTime(2023, 11, 29, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9879), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 18, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9889), 2, new DateTime(2023, 11, 29, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9890), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 16, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9899), 2, new DateTime(2023, 11, 28, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9899), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 18, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9910), 3, new DateTime(2023, 11, 29, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9910), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 19, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9919), 3, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 39.0, new DateTime(2023, 11, 16, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9929), 5, new DateTime(2023, 11, 24, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 36.0, new DateTime(2023, 11, 16, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9939), 5, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 24.0, new DateTime(2023, 11, 18, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9949), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 20, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9959), 10, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 19, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9968), 10, new DateTime(2023, 11, 29, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9968), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 20, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9977), 10, new DateTime(2023, 11, 29, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9977), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 22, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9986), 10, new DateTime(2023, 11, 26, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9987), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 3.0, new DateTime(2023, 11, 20, 13, 4, 35, 293, DateTimeKind.Utc).AddTicks(9996), 11, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4), 11, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(5), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(14), 11, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(14), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 20.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(24), 12, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(24), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(33), 12, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(33), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(42), 13, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(84), 13, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 20.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(94), 13, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(103), 13, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(104), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(113), 14, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(114), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 25.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(122), 14, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(131), 15, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(132), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(141), 15, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(149), 15, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(150), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(159), 19, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(168), 19, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 17.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(177), 21, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(178), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(186), 21, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 38.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(196), 23, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(196), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 31.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(206), 23 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(215), 25, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 30.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(224), 25, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(233), 26, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(234), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 20.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(243), 27, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 24.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(251), 27, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(252), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(292), 27, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(303), 28, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(312), 28, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(322), 30, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 23.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(331), 30, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 14.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(340), 30 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(349), 31, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(349), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(358), 31, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(367), 34, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(376), 34, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(385), 34, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(386), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(394), 34, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(403), 36, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(404), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(412), 36, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(413), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(421), 36, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(422), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(430), 36, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(439), 38, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "FromDate", "StudentId", "Type" },
                values: new object[] { new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(448), 38, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 19.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(458), 39, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(466), 39, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(467), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 3.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(508), 39, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(518), 39, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(518), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(527), 40, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(536), 40, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(536), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 34.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(545), 40, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(553), 40, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(554), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 5.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(564), 41, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(564), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(574), 42, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(583), 42, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(592), 47, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(602), 50, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(602), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 26.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(611), 52, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 28.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(621), 52, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 22.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(629), 52 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(638), 52, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(638), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(647), 53, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(656), 55, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(656), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(665), 55, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(707), 55, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(716), 55, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(717), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(726), 59, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(727), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 38.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(735), 59, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(744), 61, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 18.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(753), 61, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 39.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(762), 61, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(763), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(772), 64, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(773), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 17.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(780), 64, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(789), 64, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(790), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(798), 64, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(799), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 31.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(807), 65 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 36.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(816), 65, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 28.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(825), 65, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(834), 65, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(834), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 14.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(843), 69, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(852), 69, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(852), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(862), 71, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(862), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(871), 72, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(872), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 38.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(880), 72 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 32.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(922), 72, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(922), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(931), 72, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(932), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(940), 73, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 15.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(949), 73, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(958), 73, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(958), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(967), 76, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(977), 84, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(978), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 32.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(986), 84, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 38.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(995), 85, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(995), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1003), 85, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1004), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1013), 85, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1013), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1022), 85, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1031), 86, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1031), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1040), 88, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1049), 88, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1058), 89, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1058), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 4.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1067), 90, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1076), 90, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1076), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 31.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1085), 90, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1093), 90, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1093), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 24.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1157), 91, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1166), 91, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1176), 91, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1176), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1184), 91, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1194), 92, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1194), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 38.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1203), 92, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1204), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1212), 92, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1221), 96, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1230), 96, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1231), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1239), 96, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1239), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1249), 98, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 5.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1257), 98, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1258), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1268), 98, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1277), 98, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1277), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1287), 99, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1287), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1347), 99, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1357), 101, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1357), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 5.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1366), 104, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1375), 104, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1376), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 1.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1385), 105, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 32.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1393), 105, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1402), 105, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1403), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 26.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1412), 106, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1420), 106, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1421), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1429), 107, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1430), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1438), 107, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1439), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1447), 109, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1448), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1456), 109, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1456), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1465), 109, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1465), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 14.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1474), 109, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1475), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 1.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1483), 111, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1492), 111, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1501), 111, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1510), 113, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1511), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1520), 113, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 14.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1561), 115, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1562), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 5.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1572), 117, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1572), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1581), 117, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 12.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1590), 119 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1599), 119, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1607), 119, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1616), 119, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1617), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1626), 122, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1627), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1635), 122, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1636), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 24.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1644), 123 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 5.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1653), 123, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1654), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "FromDate", "StudentId", "ToDate" },
                values: new object[] { new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1663), 123, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 1.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1672), 124, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1680), 124, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 30.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1689), 124 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1698), 124, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1699), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 19.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1708), 125, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1708), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 15.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1716), 125, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1725), 125, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1725), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1733), 125, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1734), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1776), 126, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1786), 126, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1786), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 1.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1795), 126 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1804), 127, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1813), 128, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1814), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1823), 128, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1823), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1832), 129, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1832), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1841), 129, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1841), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1850), 129, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1850), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 32.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1858), 130, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1868), 130, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1876), 130, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1877), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1885), 130, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 34.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1895), 135 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1904), 138, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1913), 138, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1921), 138, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1930), 138, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 35.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1939), 139, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 19.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1948), 139, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 31.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1990), 141, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 1.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1999), 141, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(1999), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2007), 141, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2008), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2017), 143, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2017), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2025), 143, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 19.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2035), 144, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2036), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2044), 144, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2053), 144, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2054), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2062), 144, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2063), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 8.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2071), 145 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2080), 145, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2081), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2090), 151, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2090), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 38.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2099), 151, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2099), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2108), 153, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2108), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2117), 153, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 32.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2126), 154, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2134), 154, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2135), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2143), 154, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2153), 154, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 30.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2162), 157 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2203), 157, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 1.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2213), 157, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2213), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 17.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2222), 157 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 12.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2231), 158 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2240), 158, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2240), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "FromDate", "StudentId", "Type" },
                values: new object[] { new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2249), 158, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2258), 158, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2258), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2268), 160, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2276), 160, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2285), 163, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2286), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 15.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2294), 163, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2304), 165, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 17.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2312), 165, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2321), 165, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2321), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2330), 166, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2330), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 3.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2339), 167, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 36.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2348), 170, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2357), 170, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2357), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2366), 170, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2366), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2374), 170, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2375), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2416), 172, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2416), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 35.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2426), 172, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 14.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2435), 174, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2435), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2444), 174, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2444), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2453), 174, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 1.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2462), 174, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 25.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2471), 176, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2480), 177, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2481), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2489), 177, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2490), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2498), 179, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 31.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2507), 179, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2516), 180, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2517), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2525), 180, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 20.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2534), 180, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2534), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 39.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2542), 180, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 15.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2551), 181, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 31.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2560), 181, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2561), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 33.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2570), 182, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 36.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2578), 182, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2587), 182, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2588), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 19.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2629), 182, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 24.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2639), 184, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2647), 184, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2656), 184, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 25.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2665), 184, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2680), 186, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2680), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2689), 187, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2698), 187, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2707), 191, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2708), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2717), 191, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2717), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 8.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2779), 191, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 17.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2789), 193 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 36.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2797), 193, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2798), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 17.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2807), 193, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2817), 198, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2817), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2825), 198, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2826), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 21.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2835), 199, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2844), 199, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2844), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2853), 200, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2853), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 33.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2862), 200 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2871), 200, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2880), 202, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2889), 202, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 13.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2898), 203, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 6.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2907), 203, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 20.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2915), 203, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 10.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2924), 204, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 32.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2933), 204, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 14.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2941), 205, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2950), 205, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 28.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2993), 205, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 38.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3003), 207, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 5.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3012), 207, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 12.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3021), 211, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3030), 211, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 24.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3038), 211, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 19.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3047), 211, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3056), 213, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 23.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3064), 213 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3073), 217, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3082), 218, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 33.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3090), 218, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3098), 218, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3099), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 39.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3108), 221, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3117), 223, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 6.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3126), 223, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3135), 223, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3135), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 39.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3144), 223, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3144), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 25.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3153), 224, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 14.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3162), 225, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3204), 225, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3205), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3214), 225, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3214), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 30.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3223), 226 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 25.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3231), 226, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3242), 232, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3242), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3250), 232, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 37.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3258), 232, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3267), 232, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 21.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3277), 238, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3286), 238, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3294), 238, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3295), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3304), 241, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 38.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3312), 241, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 4.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3321), 241, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 1.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3329), 241, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3338), 253, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3347), 253, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3355), 253, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3356), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3364), 254, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 14.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3373), 254, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 21.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3415), 254, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 17.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3424), 254, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3433), 255, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 15.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3442), 256 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3451), 258, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3451), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "FromDate", "StudentId", "Type" },
                values: new object[] { new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3460), 258, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3469), 261, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3478), 262, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3478), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3486), 262, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3495), 263, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3496), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3504), 263, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3512), 263, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3513), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 14.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3521), 263 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 26.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3530), 265, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3538), 265, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3547), 266, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3548), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 25.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3556), 266 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3565), 266, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3565), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 36.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3574), 266, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3582), 269, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3583), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3624), 269, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3624), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3633), 269, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 6.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3641), 269, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3650), 271, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3651), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3659), 271, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3660), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 1.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3668), 271, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3668), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3677), 272, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3685), 272, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3695), 275, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3695), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 5.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3704), 275, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3704), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3713), 277, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3713), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3722), 277, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3722), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3731), 277, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3731), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 31.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3740), 278, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 12.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3749), 278, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3759), 280, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3767), 280, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3768), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3776), 280, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3777), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3785), 280, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3786), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3795), 284, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3836), 284, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3846), 289, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3847), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3855), 289, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3856), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 30.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3864), 289, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 21.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3873), 293, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3882), 293, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3882), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 32.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3891), 293 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 36.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3900), 293, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3900), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 32.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3909), 295, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3919), 297, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 38.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3927), 297, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 38.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3936), 299 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3944), 299, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3953), 300, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3953), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3961), 300, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3970), 302, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3978), 302, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3979), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 39.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3988), 303, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(3996), 305, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4005), 305, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 32.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4047), 306, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4047), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4056), 306, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4057), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 1.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4065), 306, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4066), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 21.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4075), 307, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4084), 307, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4084), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4093), 307, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4093), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4102), 307, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4102), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4111), 309, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4119), 309, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4128), 309, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4136), 309, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4145), 311, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4146), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 33.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4155), 311, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4163), 311, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4172), 313, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 14.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4180), 313, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 30.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4189), 313, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 1.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4197), 313, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4206), 315, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4214), 315, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4214), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4257), 320, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4257), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4266), 320, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4274), 320, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 14.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4283), 320, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4292), 323, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 12.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4301), 323 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4309), 325, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 35.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4318), 325, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 9.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4327), 327, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4335), 327, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4336), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 31.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4344), 327 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4353), 327, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4353), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4362), 329, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4363), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4371), 329, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4380), 332, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4380), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 14.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4389), 332, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4389), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4397), 332, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 36.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4406), 332, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4406), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4415), 335, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4424), 335, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4424), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4485), 336, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4486), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4496), 336, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4504), 336, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 9.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4513), 341, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 33.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4522), 342, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4530), 342, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4531), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4539), 342, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 16.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4548), 345, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4556), 345, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4565), 345, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4565), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4574), 345, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4574), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 30.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4583), 347 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 1.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4592), 347 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 17.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4601), 347, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4601), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 14.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4609), 347, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4619), 351, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4619), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4628), 353, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4637), 358, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4637), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 31.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4646), 358, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4646), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4655), 359, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4655), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4697), 359, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4697), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 39.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4706), 359, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4707), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4715), 360, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4716), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4725), 364, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4733), 364, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4734), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 1.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4742), 364, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4751), 364, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4751), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 28.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4760), 367, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4769), 367, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4769), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4777), 367, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 17.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4786), 368, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4787), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 17.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4795), 370, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4796), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4805), 373, new DateTime(2023, 11, 27, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4805), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4814), 373, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4814), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4823), 375, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4831), 375, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 25.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4840), 377, new DateTime(2023, 11, 25, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "FromDate", "StudentId", "Type" },
                values: new object[] { new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4849), 377, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4857), 377, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 36.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4866), 381, new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 8.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4907), 381 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 16.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4916), 382 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4925), 382, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 2.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4934), 382, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "FromDate", "StudentId" },
                values: new object[] { new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4942), 382 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4951), 383, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4960), 383, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4960), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 31.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4969), 383, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 20.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4978), 387, new DateTime(2023, 11, 24, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 18.0, new DateTime(2023, 11, 22, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4988), 387, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 14.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(4997), 387, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 19, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(5005), 387, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(5014), 396, new DateTime(2023, 11, 26, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(5015), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(5023), 396, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 2.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(5031), 396, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 17, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(5040), 398, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 20.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(5049), 398, new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(5049), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 16, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(5058), 398, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "FromDate", "ToDate", "Type" },
                values: new object[] { new DateTime(2023, 11, 15, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(5066), null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "AbsenceLength", "FromDate", "ToDate", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 18, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(5075), new DateTime(2023, 11, 29, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(5076), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "AbsenceLength", "FromDate", "Type" },
                values: new object[] { 31.0, new DateTime(2023, 11, 20, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(5116), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "AbsenceLength", "FromDate", "ToDate", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 21, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(5126), new DateTime(2023, 11, 28, 13, 4, 35, 294, DateTimeKind.Utc).AddTicks(5126), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 23, "Hanna Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Eva Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Josefin Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "David Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Josefin Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Peter Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Eva Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Gustav Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Martin Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Mikael Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Erik Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Hanna Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Carolina Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Linda Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Mikael Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Sofia Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Peter Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 23, "Erik Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Maria Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Eva Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Daniel Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Erik Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Eva Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Jonas Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Peter Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "David Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Daniel Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Johan Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Johan Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Anders Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Johan Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Erik Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Jonas Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Carolina Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Carolina Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36,
                column: "StudentName",
                value: "Maria Bengtsson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Maria Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Sofia Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Anders Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Carolina Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Anders Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Mikael Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Gustav Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Hanna Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Anders Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Mikael Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Mikael Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Linda Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Johan Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Linda Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Anna Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Jonas Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Eva Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Erik Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Emma Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Johan Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Carolina Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "David Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Gustav Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "David Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Hanna Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Anders Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Peter Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Anna Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Martin Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Daniel Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Daniel Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Eva Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Emma Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Maria Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 71,
                column: "StudentName",
                value: "Linda Svensson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Jonas Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Anna Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Peter Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Carolina Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Peter Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Jessica Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Mikael Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Anna Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Maria Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Erik Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Maria Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Martin Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Linda Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Gustav Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Jonas Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Jonas Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Carolina Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Daniel Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "David Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Josefin Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "David Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Martin Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Mikael Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Martin Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Erik Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Daniel Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Daniel Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Martin Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Gustav Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Sofia Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Martin Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Mikael Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Jonas Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Peter Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Anders Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Gustav Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 108,
                column: "StudentName",
                value: "Peter Svensson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Jessica Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Jessica Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Peter Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Josefin Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Sofia Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 23, "Anders Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Emma Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Mikael Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Peter Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Mikael Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Johan Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Carolina Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Martin Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "David Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Martin Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Josefin Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Anna Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Josefin Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Anna Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Linda Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Emma Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Erik Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Anders Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Jessica Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Jonas Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Josefin Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Peter Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Eva Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "David Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Sofia Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 139,
                column: "StudentName",
                value: "Carolina Nilsson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Anna Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 23, "Martin Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Carolina Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Linda Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Hanna Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Josefin Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Carolina Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Anna Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Daniel Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Anna Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Anders Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Peter Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 152,
                column: "StudentName",
                value: "Hanna Larsson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Mikael Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Martin Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Erik Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Linda Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Anna Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Emma Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Gustav Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Mikael Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Emma Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Erik Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Gustav Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Mikael Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Josefin Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Anna Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Martin Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Johan Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "David Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Johan Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Anders Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Gustav Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Emma Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Jonas Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Jonas Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Martin Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Josefin Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Anders Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Carolina Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Martin Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Emma Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Emma Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Eva Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Sofia Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Josefin Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 186,
                column: "StudentName",
                value: "Josefin Jansson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Carolina Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Erik Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Gustav Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Josefin Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Emma Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Maria Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Josefin Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "David Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Mikael Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Johan Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Daniel Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Carolina Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Jessica Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Anders Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Hanna Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Linda Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Gustav Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Jonas Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Emma Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Sofia Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Jessica Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Jessica Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 23, "Jonas Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Martin Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Mikael Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Anna Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 213,
                column: "StudentName",
                value: "Martin Johansson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Daniel Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Anders Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Martin Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Anders Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Hanna Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Johan Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Peter Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Jonas Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Sofia Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Linda Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Gustav Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Erik Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Eva Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Gustav Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Sofia Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 23, "Gustav Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Jessica Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Erik Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Jonas Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Martin Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Peter Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "David Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Gustav Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Gustav Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Mikael Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Anders Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Daniel Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Jonas Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Anna Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Eva Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Erik Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Gustav Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Anna Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Carolina Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Jonas Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Peter Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "David Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Carolina Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Peter Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Jonas Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Anders Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Jonas Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Erik Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Linda Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Anna Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Sofia Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 260,
                column: "StudentName",
                value: "Maria Nilsson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Anna Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Johan Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Martin Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Anna Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Anders Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Maria Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Johan Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Mikael Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Linda Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Peter Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 271,
                column: "StudentName",
                value: "Anna Jansson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Eva Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Peter Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Gustav Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Emma Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Peter Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Erik Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Hanna Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Emma Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Josefin Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Erik Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Sofia Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Martin Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Maria Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Anders Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Gustav Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Eva Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Hanna Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Jonas Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Sofia Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Anna Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Mikael Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 23, "Peter Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Johan Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Maria Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Jessica Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Martin Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Erik Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Eva Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Anders Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Linda Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "David Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Carolina Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Josefin Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "David Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Josefin Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 23, "Emma Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Linda Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Gustav Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Daniel Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Sofia Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "David Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Anders Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Sofia Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Gustav Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Daniel Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Eva Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Johan Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Anders Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Anders Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Maria Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Anna Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Mikael Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Mikael Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Maria Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Anders Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Jessica Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Josefin Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Johan Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Linda Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Sofia Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Martin Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Peter Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Josefin Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Maria Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Emma Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Mikael Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Jessica Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Hanna Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Daniel Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Maria Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Hanna Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Hanna Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Anna Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Eva Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Daniel Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Jonas Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Mikael Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Peter Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Gustav Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Gustav Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Martin Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Gustav Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Daniel Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Erik Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Hanna Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Eva Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Sofia Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Jonas Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "David Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Emma Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Emma Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "David Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Hanna Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Mikael Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Anna Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Erik Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Emma Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Gustav Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Daniel Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Gustav Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Jessica Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Carolina Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Linda Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Eva Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "David Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Josefin Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Carolina Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Hanna Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Eva Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Daniel Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Johan Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Maria Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Mikael Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Jonas Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Jonas Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "David Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Jessica Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Mikael Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Martin Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Gustav Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Jessica Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Jonas Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Daniel Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Erik Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Anders Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 23, "Anders Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Carolina Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Carolina Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Mikael Bengtsson" });

            migrationBuilder.CreateIndex(
                name: "IX_SchoolName",
                table: "Schools",
                column: "SchoolName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SchoolName",
                table: "Schools");

            migrationBuilder.AlterColumn<string>(
                name: "SchoolName",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 27.0, new DateTime(2023, 11, 18, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9622), 3, new DateTime(2023, 11, 25, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 15, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9677), 5, new DateTime(2023, 11, 23, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9677), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 21, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9699), 5, new DateTime(2023, 11, 25, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9699), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 1.0, new DateTime(2023, 11, 19, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9720), 6, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 21, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9737), 6, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 19, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9762), 6, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 16, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9782), 7, new DateTime(2023, 11, 26, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9783), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 9.0, new DateTime(2023, 11, 17, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9800), 7, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 19.0, new DateTime(2023, 11, 20, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9817), 7, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 12.0, new DateTime(2023, 11, 17, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9837), 7 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 21, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9856), 8, new DateTime(2023, 11, 28, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9857), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 19, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9878), 15, new DateTime(2023, 11, 28, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9878), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 24.0, new DateTime(2023, 11, 19, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9946), 15, new DateTime(2023, 11, 25, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9947), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 32.0, new DateTime(2023, 11, 18, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9968), 15, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 38.0, new DateTime(2023, 11, 21, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9988), 17, new DateTime(2023, 11, 26, 22, 52, 7, 647, DateTimeKind.Utc).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 19.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8), 18, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(26), 21, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(27), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(45), 21, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(45), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(64), 22, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(81), 22, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(96), 22, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(114), 25, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(115), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 32.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(133), 25, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(134), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(330), 26, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(333), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 15.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(395), 26, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(416), 26, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(417), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 1.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(438), 28, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(438), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(468), 28, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(484), 28, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(485), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(503), 31, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 19.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(523), 32, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(616), 32, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 36.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(641), 32, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 4.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(673), 33 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 1.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(688), 33, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(689), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 19.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(705), 33, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(722), 34, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(723), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(739), 34, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(739), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(756), 34, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(756), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(775), 36, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(775), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(797), 36, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(815), 36, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(815), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(831), 38, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(831), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 21.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(849), 38, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 28.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(867), 39 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 14.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(885), 39, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 24.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(902), 39, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(919), 41, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(920), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(938), 42, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(939), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(955), 42, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(955), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 1.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1018), 43, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1019), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1042), 50, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1058), 50, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1059), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 32.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1076), 50, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 5.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1093), 50, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1113), 51, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "FromDate", "StudentId", "Type" },
                values: new object[] { new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1130), 53, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1148), 54, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1148), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1165), 54, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 7.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1182), 54, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1200), 54, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1201), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1218), 57, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1219), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1236), 57, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1237), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 8.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1257), 58, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1274), 58, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1296), 58, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1315), 58, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1316), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1335), 60, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1336), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1400), 60, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1400), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1418), 60, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 23.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1438), 63, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 14.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1455), 63, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 17.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1474), 66 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1492), 66, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1508), 66, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1525), 66, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1526), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1543), 67, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1544), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1561), 69, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1562), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 24.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1578), 69, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 20.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1595), 69, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1611), 70, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1612), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1629), 70, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1629), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 15.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1645), 70, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1662), 71, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1663), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1682), 71, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1683), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 36.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1699), 71, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1700), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1718), 72, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1718), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 19.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1736), 72, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1736), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 35.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1801), 74 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 13.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1819), 74, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 7.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1836), 74, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1854), 74, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 38.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1870), 75, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1889), 75, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1890), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1909), 80, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1910), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1928), 83, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1928), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 33.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1945), 83 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1962), 85, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1963), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1979), 85, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 31.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1995), 86, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(1996), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 4.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2013), 87, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2031), 87, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2031), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2049), 87, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2049), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2066), 88, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2067), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 17.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2084), 88, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2102), 88, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2102), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 5.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2120), 88, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2121), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 14.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2137), 89, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 20.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2199), 89, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2218), 92, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2218), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2237), 95, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2254), 95, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2255), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2272), 95, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2273), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 37.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2289), 95, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2308), 96, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2325), 97, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2342), 99, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2358), 99, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2376), 102, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2377), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2393), 102, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2393), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2409), 102, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2409), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 19.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2426), 102, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2427), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2444), 103, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2445), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2463), 105, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2481), 105, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 38.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2497), 105, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2514), 105, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2531), 106, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2532), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2602), 107, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2603), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 32.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2625), 107, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2625), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2643), 107, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2643), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2660), 107, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2661), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 17.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2679), 110, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2695), 110, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2696), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2713), 113, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2713), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 31.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2730), 113, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2746), 113, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2747), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 30.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2764), 115, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2781), 115, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2781), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 1.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2798), 115, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2816), 118, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2833), 118, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2852), 118, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2852), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2976), 119, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2994), 119, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(2994), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3012), 119, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3012), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3029), 119, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3030), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 32.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3048), 122, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3065), 122, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3082), 122, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3099), 122, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3117), 125, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3134), 125, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 17.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3151), 126, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3168), 126, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3169), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 26.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3186), 126 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 17.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3203), 126, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3221), 132, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3239), 132, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3239), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3256), 132, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3274), 134, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 1.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3290), 134 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3308), 135, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "FromDate", "StudentId", "ToDate" },
                values: new object[] { new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3370), 136, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3388), 136, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3405), 137, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3406), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 8.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3424), 138 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 19.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3441), 138, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3457), 140, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 1.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3474), 141, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3492), 141, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3509), 146, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3510), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3527), 147, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3544), 147, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3544), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 33.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3561), 149 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3578), 149, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3595), 149, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3613), 157, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 39.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3631), 157, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3648), 157, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3649), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3666), 157, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3666), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3683), 158, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3683), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 20.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3699), 158, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3700), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3760), 158, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3778), 158, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 7.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3796), 162 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3812), 162, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3813), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3830), 163, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3847), 168, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3847), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3864), 169, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3864), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 7.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3880), 169, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3898), 174, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3899), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 19.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3916), 174, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3917), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3933), 174, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3934), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3951), 174, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3967), 176, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3983), 176, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(3984), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 36.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4000), 176, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4000), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4017), 176, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4034), 177, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 39.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4051), 182, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 2.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4067), 182 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4084), 184, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4084), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 19.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4147), 184, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4148), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4165), 186, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4165), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4183), 187, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4183), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4199), 187, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4200), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4218), 188, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4219), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4235), 188, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4235), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4253), 188, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4269), 188, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 22.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4286), 193 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4302), 193, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4318), 193, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 36.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4335), 193 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 5.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4357), 194 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 36.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4381), 194, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4382), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "FromDate", "StudentId", "Type" },
                values: new object[] { new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4399), 194, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4416), 194, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4417), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4433), 195, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4448), 195, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4464), 195, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 24.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4480), 197, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 19.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4541), 197, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4542), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 2.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4558), 197, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4575), 198, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4594), 205, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 37.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4610), 205, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 14.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4627), 207, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4644), 207, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4644), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 18.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4661), 207, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4677), 207, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4678), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 32.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4696), 208, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4696), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 34.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4712), 208, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4731), 209, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4732), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4749), 209, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4750), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4766), 209, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 10.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4784), 213, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 31.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4800), 213, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4816), 213, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 38.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4832), 213, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4833), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4850), 215, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4851), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 37.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4867), 215, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4990), 215, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(4991), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5009), 215, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 39.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5026), 219, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5042), 219, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 39.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5059), 219, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5077), 221, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 16.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5093), 221, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5109), 221, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5110), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5126), 222, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 35.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5143), 222, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5161), 226, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5177), 226, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 1.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5195), 228, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5195), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 33.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5212), 229, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5282), 232, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5282), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5299), 232, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5316), 232, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 17.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5332), 232, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5350), 233, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5350), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 39.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5366), 233, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 39.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5384), 236 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5400), 236, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5401), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 11.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5417), 239, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5434), 239, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5451), 241, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5452), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 6.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5468), 241, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5486), 241, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 32.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5501), 241, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 31.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5518), 242 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5535), 245, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5535), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5598), 245, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5599), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 39.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5622), 245, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 37.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5640), 245, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 24.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5657), 246, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5674), 247, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5675), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 38.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5693), 247, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5713), 250, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 22.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5733), 251, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 20.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5751), 251, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 21.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5771), 252, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 12.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5788), 252, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 17.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5805), 252, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 1.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5822), 253, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 32.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5839), 253, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5839), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 8.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5857), 253, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5873), 253, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5893), 255, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 2.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5910), 255 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 15.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5927), 255, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5927), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(5945), 258, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 24.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6015), 258, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 20.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6036), 258, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6037), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6054), 260, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6071), 260, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 5.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6089), 261, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 5.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6108), 261, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6125), 262, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 23.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6141), 262, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6156), 264, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6172), 264, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6191), 265, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6191), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 4.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6208), 265 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 12.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6224), 265, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 20.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6240), 265, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6256), 266, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 25.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6273), 266, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6293), 266, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 11.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6312), 268, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6330), 268, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6346), 268, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6347), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6418), 269, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 32.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6436), 269, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6437), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 19.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6453), 269, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 31.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6471), 270, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6472), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6488), 270, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6488), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6505), 270, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 5.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6520), 270, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6520), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 24.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6537), 272, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6537), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 7.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6554), 273, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 30.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6571), 273, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6589), 278, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6589), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6608), 278, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 10.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6625), 279 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6644), 281, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6644), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "FromDate", "StudentId", "Type" },
                values: new object[] { new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6661), 282, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6682), 291, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6700), 291, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6700), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6718), 292, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6718), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 5.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6734), 296, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6753), 296, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6754), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 17.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6817), 297, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6818), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 5.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6835), 297 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 7.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6852), 297, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6869), 297, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6869), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 24.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6886), 299, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6887), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 31.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6904), 299 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6921), 299, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6922), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6940), 302, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 24.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6957), 302, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6957), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 36.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6976), 302, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(6995), 304, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 16.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7013), 304, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7031), 304, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7031), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7117), 304, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7117), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7138), 308, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7154), 308, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7155), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7171), 308, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7172), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7188), 308, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7189), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7207), 309, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 5.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7226), 310, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7226), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 20.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7301), 311, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7302), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 19.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7321), 311, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7322), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 30.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7339), 311, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 14.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7356), 311, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 32.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7374), 312, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7375), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7392), 312, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 24.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7410), 314, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7410), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7428), 314, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7429), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7446), 315, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7446), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 24.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7463), 315, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7464), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 14.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7480), 316, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7497), 317, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 15.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7514), 317, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 8.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7533), 319, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7550), 319, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7550), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 14.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7567), 319 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7584), 319, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 38.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7602), 322, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7618), 322, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7619), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 39.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7636), 324, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7637), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 16.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7701), 324 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7719), 327, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7736), 327, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7737), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7754), 328, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7771), 329, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 14.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7789), 329, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 24.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7806), 329, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7824), 332, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7842), 333, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7843), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 19.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7859), 333, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7877), 333, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7896), 335, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 32.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7913), 335, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7931), 337, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7932), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7949), 337, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7949), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7967), 337, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 14.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7985), 338, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(7986), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8001), 338, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8020), 338, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8020), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8037), 338, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8160), 339, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8160), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 5.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8180), 339, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8198), 339, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8198), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8219), 339, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8219), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8236), 341, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 13.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8254), 341, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8272), 341, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8272), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8290), 342, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8291), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8307), 342, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8308), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8325), 342, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 27.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8343), 343, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8343), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8360), 343, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 31.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8378), 343, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8397), 343, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 1.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8415), 344 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8431), 344, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 14.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8448), 344, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 4.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8465), 344, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8487), 345, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8487), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 18.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8504), 345 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 28.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8573), 345, null, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8590), 345, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8591), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8609), 347, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8627), 347, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8627), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8646), 348, null, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 20.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8662), 348, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8663), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 22.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8681), 348, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 4.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8697), 349, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8698), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 31.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8716), 352, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8716), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 5.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8734), 354, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8735), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8754), 356, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8754), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8772), 359, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8772), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 19.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8790), 359, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 17.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8811), 359, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 23.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8829), 359, null, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8847), 363, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 15.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8866), 363, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 38.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8885), 366, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8885), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 5.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8904), 366, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8922), 366, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8923), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 35.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(8983), 366 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 18.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9003), 367 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9019), 367, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9020), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 20.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9038), 367, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9038), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 17.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9057), 370, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 34.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9074), 370, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 1.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9090), 370, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9091), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 35.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9109), 370, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9129), 372, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9129), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9151), 372, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9168), 375, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9168), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 7.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9185), 377, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9186), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 21.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9203), 377, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 9.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9220), 378, null, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 38.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9238), 378, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 16.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9255), 378, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 39.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9273), 379, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 12.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9291), 379, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9292), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 10.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9309), 379, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9326), 381, null, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 24.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9394), 381, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9395), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 26.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9416), 386, new DateTime(2023, 11, 23, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9417), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 29.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9433), 386, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9433), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 3.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9451), 387, 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9467), 387, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 18.0, new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9485), 388, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "FromDate", "StudentId", "Type" },
                values: new object[] { new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9502), 388, 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 13.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9518), 388, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 3.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9534), 388, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 35.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9551), 391 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId" },
                values: new object[] { 20.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9568), 392 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 25.0, new DateTime(2023, 11, 19, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9585), 392, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9586), 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 4.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9602), 392, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "FromDate", "StudentId" },
                values: new object[] { new DateTime(2023, 11, 20, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9618), 392 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 37.0, new DateTime(2023, 11, 21, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9635), 393, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9635), 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 17.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9651), 393, new DateTime(2023, 11, 26, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9651), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 36.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9668), 393, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 17.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9684), 393, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 28.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9701), 394, null });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 17, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9718), 394, 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 31.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9779), 394, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 38.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9800), 395, new DateTime(2023, 11, 27, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9800), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 6.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9816), 395, 3 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate" },
                values: new object[] { 7.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9832), 395, new DateTime(2023, 11, 28, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 11.0, new DateTime(2023, 11, 16, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9849), 396, new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9850), 5 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "ToDate", "Type" },
                values: new object[] { 5.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9866), 396, new DateTime(2023, 11, 25, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9866), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "AbsenceLength", "FromDate", "StudentId", "Type" },
                values: new object[] { 2.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9884), 397, 2 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "FromDate", "ToDate", "Type" },
                values: new object[] { new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9901), new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9901), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "AbsenceLength", "FromDate", "ToDate", "Type" },
                values: new object[] { 8.0, new DateTime(2023, 11, 14, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9917), new DateTime(2023, 11, 24, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9918), 4 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "AbsenceLength", "FromDate", "Type" },
                values: new object[] { 33.0, new DateTime(2023, 11, 15, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9933), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "AbsenceLength", "FromDate", "ToDate", "Type" },
                values: new object[] { 30.0, new DateTime(2023, 11, 18, 22, 52, 7, 648, DateTimeKind.Utc).AddTicks(9949), null, 4 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Carolina Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Eva Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Mikael Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Maria Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Maria Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Maria Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "David Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Emma Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Anders Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Johan Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Sofia Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Peter Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Jessica Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Emma Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Linda Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Daniel Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Daniel Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Jonas Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Martin Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Linda Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Eva Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Linda Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Jessica Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Linda Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Carolina Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Eva Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Emma Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Hanna Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Johan Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Emma Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "David Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Erik Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Daniel Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Martin Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Eva Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36,
                column: "StudentName",
                value: "Anna Persson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Peter Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Erik Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Mikael Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Jessica Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Hanna Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Gustav Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Josefin Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Sofia Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Jonas Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Linda Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Peter Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "David Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Maria Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Anna Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Jessica Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Peter Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Peter Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Sofia Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Anna Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Erik Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Sofia Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Carolina Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Carolina Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Erik Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Anna Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Carolina Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Anders Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Sofia Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Carolina Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Eva Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Josefin Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "David Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Jonas Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Martin Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 71,
                column: "StudentName",
                value: "Daniel Söderström");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Anna Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Martin Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Hanna Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Daniel Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Emma Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Jessica Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Daniel Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 23, "Carolina Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Jessica Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Jessica Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Eva Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Johan Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Jessica Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Johan Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Josefin Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Hanna Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Gustav Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Hanna Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Anna Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Anna Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Eva Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Anders Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Mikael Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Josefin Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Eva Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Sofia Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Emma Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Gustav Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Anna Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Peter Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Gustav Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Carolina Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Erik Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Hanna Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Gustav Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Carolina Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 108,
                column: "StudentName",
                value: "David Andersson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Daniel Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Johan Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Eva Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Gustav Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Jonas Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Josefin Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Sofia Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Emma Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Linda Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Gustav Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Johan Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Hanna Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Gustav Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Jonas Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Linda Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "David Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Eva Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Erik Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Mikael Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Mikael Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Martin Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Gustav Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Emma Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "David Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Carolina Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Josefin Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Johan Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Anna Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Daniel Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 23, "Linda Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 139,
                column: "StudentName",
                value: "Jonas Larsson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Sofia Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Peter Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Carolina Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Erik Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Sofia Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Emma Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Martin Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Gustav Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Emma Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Peter Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Peter Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Eva Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 152,
                column: "StudentName",
                value: "Hanna Johansson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 23, "Anders Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Peter Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Peter Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Hanna Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Gustav Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Mikael Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Maria Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Jonas Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Anna Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Maria Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Emma Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Martin Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Emma Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Maria Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Sofia Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Jessica Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Eva Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Anna Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Erik Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Anna Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Josefin Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Daniel Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Mikael Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Erik Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Josefin Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Anders Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Peter Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Anders Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Jonas Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Jonas Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Carolina Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 23, "Hanna Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Peter Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 186,
                column: "StudentName",
                value: "Peter Holm");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "David Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Jessica Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "David Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Linda Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Peter Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Carolina Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Sofia Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Maria Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Daniel Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Carolina Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Gustav Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "David Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Linda Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Sofia Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Emma Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Erik Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "David Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Jessica Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Martin Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Gustav Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Linda Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Jonas Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Maria Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Anders Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Martin Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "David Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 213,
                column: "StudentName",
                value: "Carolina Lindberg");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Peter Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Peter Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Emma Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Jonas Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Jonas Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Sofia Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Anna Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Martin Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Johan Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Martin Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Linda Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Eva Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Jessica Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Eva Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Emma Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Josefin Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Jessica Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Sofia Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Linda Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Sofia Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Maria Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Anders Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Jonas Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Josefin Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Daniel Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Anders Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Anna Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Daniel Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Jessica Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 23, "Josefin Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Maria Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Martin Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Daniel Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Jonas Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Anders Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Jonas Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Jessica Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Jessica Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Martin Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Jessica Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Emma Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Sofia Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Linda Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Hanna Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Jessica Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Jessica Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 260,
                column: "StudentName",
                value: "Johan Olsson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Maria Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Gustav Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Hanna Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Jonas Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Erik Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Erik Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Eva Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Maria Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Maria Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Anders Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 271,
                column: "StudentName",
                value: "Josefin Karlsson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Anna Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Erik Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "David Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Linda Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Peter Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Mikael Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Anna Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Gustav Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Jessica Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Daniel Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Carolina Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Jonas Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Sofia Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Gustav Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Martin Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Daniel Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Mikael Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Hanna Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Daniel Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Johan Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Gustav Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Emma Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Eva Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Maria Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Mikael Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Emma Gustafsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Carolina Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Linda Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Linda Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Johan Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Jonas Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Daniel Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "David Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Sofia Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Peter Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Erik Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Mikael Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Anders Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Gustav Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "David Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Johan Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Josefin Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Jessica Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Jonas Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "David Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Martin Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Anders Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Peter Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 21, "Emma Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Gustav Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 11, "Peter Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "David Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Gustav Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Anders Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 1, "Hanna Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Peter Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Jonas Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Maria Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Anders Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Jonas Nilsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Johan Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Erik Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Jessica Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "David Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Eva Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Peter Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Martin Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Peter Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Maria Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 3, "Mikael Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Mikael Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Josefin Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Anders Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Linda Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Maria Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 27, "Daniel Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 10, "Josefin Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Emma Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 4, "Carolina Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Johan Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 12, "Maria Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 8, "Anders Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Jessica Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Daniel Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 2, "Gustav Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Anna Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Anna Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Carolina Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Emma Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Emma Pettersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Jessica Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Jonas Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Daniel Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Linda Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Martin Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Josefin Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Daniel Holm" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Emma Persson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Mikael Karlsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Anna Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Anna Ek" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Peter Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Jessica Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 28, "Peter Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Hanna Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 9, "Mikael Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Daniel Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 16, "Erik Eriksson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Emma Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Carolina Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Jessica Andersson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 25, "Mikael Jansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 18, "Sofia Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 17, "Anna Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 14, "Johan Lindberg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 20, "Sofia Söderström" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 24, "Martin Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 26, "Emma Johansson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 15, "Hanna Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 22, "Eva Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 19, "Mikael Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 6, "Hanna Olsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 29, "Hanna Larsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Johan Bengtsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 23, "Linda Berg" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Peter Jonsson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 5, "Johan Svensson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 7, "Mikael Lindqvist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "SchoolId", "StudentName" },
                values: new object[] { 13, "Josefin Jansson" });

            migrationBuilder.CreateIndex(
                name: "IX_Absences_Id",
                table: "Absences",
                column: "Id");
        }
    }
}
