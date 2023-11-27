using System.ComponentModel;

namespace API.Data.Enums
{
    public enum AbsenceType
    {
        [Description("Sjukdom")]
        Sickness = 1,
        [Description("Tandläkare")]
        Dentist = 2,
        [Description("Elevråd")]
        StudentCouncil = 3,
        [Description("VAB")]
        Childcare = 4,
    }
}
