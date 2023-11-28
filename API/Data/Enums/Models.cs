using System.ComponentModel;

namespace API.Data.Enums
{
    public enum AbsenceType
    {
        [Description("Ej angivit")]
        None = 1,
        [Description("Sjukdom")]
        Sickness = 2,
        [Description("Tandläkare")]
        Dentist = 3,
        [Description("Elevråd")]
        StudentCouncil = 4,
        [Description("Semester")]
        Vacation = 5,
    }
}
