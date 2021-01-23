using System;

namespace docker_webapi
{
    public class Birthday
    {
        public DateTime DateOfBirth { get; set; }

        public long DaysOfLife => (DateTime.Today.Ticks - DateOfBirth.Ticks) / TimeSpan.TicksPerDay;

        public string WeekdayOfBirth => DateOfBirth.DayOfWeek.ToString();

        public string Name { get; set; }


        public long DaysTillBirthday { 
            get {

                DateTime annualBirthday = new DateTime(DateTime.Today.Year, DateOfBirth.Month, DateOfBirth.Day);
                // Birthday next year?
                if (annualBirthday.Ticks < DateTime.Today.Ticks){
                    annualBirthday = annualBirthday.AddYears(1);
                }
                
                return (annualBirthday.Ticks - DateTime.Today.Ticks) / TimeSpan.TicksPerDay;
            }
        }
    }
}
