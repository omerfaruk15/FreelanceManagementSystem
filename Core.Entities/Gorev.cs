using System;

namespace Core.Entities
{
    public abstract class Gorev
    {
        public int TaskID { get; set; }
        public int ProjectID { get; set; }
        public int EmployeeID { get; set; }
        public string? TaskTitle { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal WorkedHours { get; set; }
        public string? TaskType { get; set; }

        public abstract decimal HakedisHesapla();
    }
}