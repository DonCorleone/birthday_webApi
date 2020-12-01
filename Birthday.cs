using System;

namespace docker_webapi
{
    public class Birthday
    {
        public DateTime DateOfBirth { get; set; }

        public long DaysOfLife => (DateTime.Today.Ticks - DateOfBirth.Ticks) / TimeSpan.TicksPerDay;

        public string WeekdayOfBirth => DateOfBirth.DayOfWeek.ToString();

        public string Name { get; set; }
    }
}
