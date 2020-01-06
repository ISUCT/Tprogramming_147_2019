using System;

namespace CourseApp
{
    public class Birthday
    {
        private DateTime birthday;

        public Birthday(DateTime birthday)
        {
            this.birthday = birthday;
        }

        public int CalculateCountYear()
        {
            int years = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.Month < birthday.Month)
            {
                years--;
            }
            years = years < 0 ? 0 : years;
            return years;
        }

        public int CalculateCountMonth()
        {
            if (birthday > DateTime.Now || (birthday.Year == DateTime.Now.Year && birthday.Month == DateTime.Now.Month && birthday.Day == DateTime.Now.Day))
            {
                return 0;
            }
            int monthes = (DateTime.Now.Year - birthday.Year - 1) * 12;
            monthes += 12 - birthday.Month - 1;
            monthes += DateTime.Now.Month;
            return monthes;
        }

        public int CalculateCountDays()
        {
            int days = DateTime.Now.Subtract(birthday).Days;
            return days > 0 ? days : 0;
        }

        public string CalculateFullCountYearsAndMonth()
        {
            var currentYear = CalculateCountYear();
            var currentMonth = CalculateCountMonth() - CalculateCountYear() * 12;
            var currentDays = DateTime.Now.Day;
            return "Years " + currentYear + ", month " + currentMonth + ", days " + currentDays;
        }

        public override string ToString()
        {
            return "Years " + CalculateCountYear() + ", month " + CalculateCountMonth() + ", days " + CalculateCountDays();
        }
    }
}