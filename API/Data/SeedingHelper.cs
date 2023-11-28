using API.Data.EFModels;
using API.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;

namespace API.Data
{
    public class SeedingHelper
    {
        private static string[] _studentFirstNames =
        { 
            "Erik", "Anna", "Anders", "Maria", "Johan",
            "Emma", "Jonas", "Sofia", "Mikael", "Linda",
            "Gustav", "Hanna", "Martin", "Eva", "David",
            "Josefin", "Daniel", "Carolina", "Peter", "Jessica"
        };
        private static string[] _studentLastNames =
        {
            "Andersson", "Johansson", "Karlsson", "Nilsson", "Eriksson",
            "Larsson", "Olsson", "Svensson", "Pettersson", "Gustafsson",
            "Jonsson", "Persson", "Jansson", "Lindberg", "Berg",
            "Ek", "Holm", "Lindqvist", "Söderström", "Bengtsson"
        };
        private static string[] _schoolNames = 
        {
            "Söderskolan", "Lindeskolan", "Centralgymnasiet", "Östra grundskolan", "Högdalsskolan",
            "Västergårdsskolan", "Sveagymnasiet", "Mölndals högstadieskola", "Nordvästra skolan", "Sturegymnasiet",
            "Eriksdalsskolan", "Sunnegårdsskolan", "Kristianstadsgymnasiet", "Mälarhöjdens skola", "Södertälje gymnasium",
            "Ängelholmsgymnasiet", "Örebrogymnasiet", "Göteborgs högre samskola", "Sjöbergsskolan", "Falkenbergsskolan",
            "Västermalms högstadieskola", "Kungsängsgymnasiet", "Nynäshamnsskolan", "Österänggymnasiet", "Hässelbygårdsskolan",
            "Bromma gymnasium", "Skarpängsskolan", "Malmö Borgarskola", "Hästhagenskolan", "Hudiksvalls högstadieskola"
        };

        private static int _totalNameCombinations = _studentFirstNames.Length * _studentLastNames.Length;

        public static void GenerateSchools(ModelBuilder modelBuilder)
        {
            for(int i = 0; i < _schoolNames.Length; i++)
            {
                modelBuilder.Entity<School>().HasData(
                    new School { Id = i+1, SchoolName = _schoolNames[i] }
                );
            }
        }

        public static void GenerateStudents(ModelBuilder modelBuilder)
        {
            Random random = new();

            for (int i = 0; i < _totalNameCombinations; i++)
            {
                modelBuilder.Entity<Student>().HasData(
                    new Student {
                        Id = i+1,
                        SchoolId = random.Next(1,_schoolNames.Length),
                        StudentName = GenerateRandomStudentName()
                    }
                );
            }
        }

        static string GenerateRandomStudentName()
        {
            Random random = new();

            string firstName = _studentFirstNames[random.Next(_studentFirstNames.Length)];
            string lastName = _studentLastNames[random.Next(_studentLastNames.Length)];

            return $"{firstName} {lastName}";
        }

        public static void GenerateAbsence(ModelBuilder modelBuilder)
        {
            Random random = new();
            int absenceId = 0;

            for (int i = 0; i < _totalNameCombinations; i++)
            {
                var hasAbsence = random.Next(0, 1);

                if (hasAbsence == 1)
                {
                    var amountOfAbsences = random.Next(1, 5);

                    for (int j = 0; j < amountOfAbsences; j++)
                    {
                        absenceId += 1;
                        var absenceLength = random.Next(1, 40);

                        modelBuilder.Entity<Absence>().HasData(
                            new Absence
                            {
                                Id = absenceId,
                                AbsenceLength = absenceLength,
                                Type = GenerateAbsenceType(random),
                                StudentId = i + 1,
                            }
                        );
                    }
                }
            }
        }

        static AbsenceType GenerateAbsenceType(Random rand)
        {
            AbsenceType[] absenceType = { AbsenceType.None, AbsenceType.Sickness, AbsenceType.Dentist, AbsenceType.StudentCouncil, AbsenceType.Vacation };
            var type = absenceType[rand.Next(0, absenceType.Length)];

            return type;
        }
             
    }
}
